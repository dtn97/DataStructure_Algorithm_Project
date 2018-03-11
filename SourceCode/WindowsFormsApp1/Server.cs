﻿/* ********************************
 * Copyright (C) Hantou
 *
 * SimpleMessenger is free software: you can redistribute it and/or modify 
 * it under the terms of the CPOL License as published by the Code Project.
 * www.codeproject.com
 * 
 * SimpleMessenger is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * 
 * Contact :
 *   hantou.studio@gmail.com
 *   http://www.codeproject.com/KB/miscctrl/SimpleMessenger.aspx
 *   
 * &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
*/
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Server
    {
        private Socket server;
        private Socket tempSocket;
        private AsyncCallback asyncCallBack;

        private WarehouseForm form1;

        public Server(WarehouseForm f)
        {
            form1 = f;
        }


        public void Send(byte[] data)
        {
            if (tempSocket != null)
            {
                tempSocket.Send(data);
            }
            else
            {
                MessageBox.Show("There is no client connected.\r\nOr server is not connected.", "Server Send", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Connect(string ipAddr, string port)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));

            server.Bind(ipLocal);//bind to the local IP Address...
            server.Listen(5);//start listening...

            // create the call back for any client connections...
            server.BeginAccept(new AsyncCallback(OnClientConnect), null);
        }
        public void Disconnect()
        {
            server.Close();
            server = null;
            tempSocket = null;
        }

        public void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                if (server != null)
                {
                    tempSocket = server.EndAccept(asyn);

                    WaitForData(tempSocket);

                    server.BeginAccept(new AsyncCallback(OnClientConnect), null);
                }
            }
            catch (ObjectDisposedException)
            {
                Debugger.Log(0, "1", "OnClientConnect: Socket has been closed.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "OnClientConnect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void WaitForData(Socket soc)
        {
            try
            {
                if (asyncCallBack == null)
                    asyncCallBack = new AsyncCallback(OnDataReceived);

                KeyValuePair aKeyValuePair = new KeyValuePair();
                aKeyValuePair.socket = soc;

                // now start to listen for incoming data...
                aKeyValuePair.dataBuffer = new byte[soc.ReceiveBufferSize];

                soc.BeginReceive(aKeyValuePair.dataBuffer, 0, aKeyValuePair.dataBuffer.Length, SocketFlags.None, asyncCallBack, aKeyValuePair);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message, "WaitForData Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnDataReceived(IAsyncResult asyn)//For Server Mode
        {
            try
            {
                if (tempSocket != null)
                {
                    KeyValuePair aKeyValuePair = (KeyValuePair)asyn.AsyncState;
                    //end receive...
                    int iRx = 0;
                    iRx = aKeyValuePair.socket.EndReceive(asyn);
                    if (iRx != 0)
                    {
                        char[] chars = new char[iRx];
                        int charLength = Encoding.GetEncoding(Constant.SimplifiedChineseCode).GetDecoder().GetChars(aKeyValuePair.dataBuffer, 0, iRx, chars, 0);
                        String text = new String(chars);
                        Send(aKeyValuePair.dataBuffer);
                        form1.UpdateText(text + "\r\n");
                        WaitForData(tempSocket);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException e)
            {
                if (e.ErrorCode == 10054)//Connection reset, http://msdn.microsoft.com/en-us/library/ms740668(VS.85).aspx
                {
                    string text = "Client Disconnected \r\n";
                    form1.UpdateText(text + "\r\n");
                    tempSocket = null;
                }

            }
        }  
    }
}
