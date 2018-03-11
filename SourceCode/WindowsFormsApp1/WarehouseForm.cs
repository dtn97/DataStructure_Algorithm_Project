using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class WarehouseForm : Form
    {
        public Server server;
        public Client client;

        public delegate void UpdateTextCallback(string text);
        private delegate void ReconnectCallback();

        WareHouse wh = new WareHouse();
        Bitmap bm;
        Panel pn;
        bool check = new bool();
        bool _check = new bool();
        int FirstX = new int();
        int FirstY = new int();
        int FirstField = new int();
        PackageForm f;
        FieldForm _f;
        static KeyValuePair<int, int> preCoordNate = new KeyValuePair<int, int>(-1, -1);
        int preField;
        HashSet<int> listField;
        string fileName;
        public WarehouseForm()
        {
            InitializeComponent();
            Text += " " + Constant.SOFTWAREVERSION;

            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            for (int i = 0; i < IPHost.AddressList.Length; i++)
            {
                textBox1.AppendText("My IP address is: " + IPHost.AddressList[i].ToString() + "\r\n");
            }
            string ipText = IPHost.AddressList[IPHost.AddressList.Length - 1].ToString();
            string[] IPs = ipText.Split(new char[] { '.' });
            textBox3.Text = IPs[0];
            check = false;
            preField = new int();
            preField = -1;
            f = null;
            _check = false;
            this.Width = 1030;
            this.Height = 620;
            TreeView tv = new TreeView();
        }
        public WarehouseForm(ref WareHouse p)
        {
            InitializeComponent();
            check = false;
            preField = new int();
            preField = -1;
            f = null;
            _check = false;
            wh = p;
            draw();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;
            pn = new Panel();
            pn.MouseMove += Pn_MouseMove;
            pn.MouseDown += Pn_MouseDown;
            pn.MouseUp += Pn_MouseUp;
            panel.Controls.Add(pn);
            draw();
        }
        private bool compareCoordNate(KeyValuePair<int, int> p, int field)
        {
            return (field == preField) && (p.Key == preCoordNate.Key) && (p.Value == preCoordNate.Value);
        }
        #region Action
        private void btnAddField_Click(object sender, EventArgs e)
        {
            string rt = "";
            for (int i = 0; i < rotate.Text.Length; ++i)
                rt += rotate.Text[i] == '.' ? ',' : rotate.Text[i];
            wh.add(int.Parse(wpx.Text), int.Parse(wpy.Text), int.Parse(height.Text), int.Parse(width.Text), double.Parse(rt));
            draw();
            wpx.Text = "";
            wpy.Text = "";
            height.Text = "";
            width.Text = "";
            rotate.Text = "0";
            send();
        }

        private void Field_add_Click(object sender, EventArgs e)
        {
            Package p = Package.Get(int.Parse(type.Text));
            int n = int.Parse(no.Text);
            int x = int.Parse(py.Text);
            int y = int.Parse(px.Text);
            p.set(txtID.Text, x, y, n, int.Parse(txtPrice.Text), txtDate.Text);
            wh.add(n, x, y, p);
            draw();
            px.Text = "";
            py.Text = "";
            no.Text = "";
            type.Text = "";
            txtID.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
            send();
        }

        private void change_Click(object sender, EventArgs e)
        {
            int z = int.Parse(zoom.Text);
            Package.SIZE = z * 20 / 100;
            draw();
        }
#endregion

        #region Subpanel
        private void Pn_MouseMove(object sender, MouseEventArgs e)
        {
            double x = (double)e.X;
            double y = (double)e.Y;
            KeyValuePair<KeyValuePair<int, int>, int> temp = wh.convert(x, y);
            int k = temp.Value;
            KeyValuePair<int, int> tmp = temp.Key;
            if (k < 0 || tmp.Key < 0 || tmp.Value < 0)
            {
                txtCurNo.Text = "";
                txtCurX.Text = "";
                txtCurY.Text = "";
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
            }
            else
            {
                txtCurNo.Text = k.ToString();
                txtCurX.Text = tmp.Key.ToString();
                txtCurY.Text = tmp.Value.ToString();
                if (!check)
                {
                     if (!compareCoordNate(tmp, temp.Value))
                     {
                        if (f != null)
                        {
                            f.Close();
                            f = null;
                        }
                        Package pa = wh.lf[temp.Value].getPackage(new KeyValuePair<int, int>(tmp.Value, tmp.Key));
                        
                        if (pa != null)
                        {
                            if (pa.getType() == 0)
                                pa = wh.lf[temp.Value].getPackage(new KeyValuePair<int, int>(tmp.Value, tmp.Key - 1));
                            f = new PackageForm(pa);
                            f.Location = new Point(e.X, e.Y + f.Height);
                            f.StartPosition = FormStartPosition.Manual;
                            f.Show();
                        }
                    }
                }
                else
                {
                    if (_check)
                    {
                        listField.Add(k);
                    }
                }
            }
            
            preCoordNate = tmp;
            preField = temp.Value;

        }

        private void Pn_MouseDown(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                f.Close();
                f = null;
            }
            check = true;
            double x = (double)e.X;
            double y = (double)e.Y;
            KeyValuePair<KeyValuePair<int, int>, int> temp = wh.convert(x, y);
            int k = temp.Value;
            KeyValuePair<int, int> tmp = temp.Key;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (k >= 0 && tmp.Key >= 0 && tmp.Value >= 0)
                    {
                        check = true;
                        FirstX = tmp.Key;
                        FirstY = tmp.Value;
                        FirstField = k;
                    }
                    break;
                case MouseButtons.Right:
                    listField = new HashSet<int>();
                    if (k >= 0 && tmp.Key >= 0 && tmp.Value >= 0)
                        listField.Add(k);
                    _check = true;
                    break;
            }
        }

        private void Pn_MouseUp(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                f.Close();
                f = null;
            }
            check = false;
            KeyValuePair<KeyValuePair<int, int>, int> temp = wh.convert((double)e.X, (double)e.Y);
            switch (e.Button)
            {

                case MouseButtons.Left:
                    KeyValuePair<int, int> p1 = new KeyValuePair<int, int>(FirstY, FirstX);
                    
                    KeyValuePair<int, int> p2 = new KeyValuePair<int, int>(temp.Key.Value, temp.Key.Key);
                    wh.MovePackage(p1, FirstField, p2, temp.Value);
                    draw();
                    send();
                    break;
                case MouseButtons.Right:
                    _check = false;
                    if (temp.Key.Key >= 0 && temp.Key.Value >= 0)
                        listField.Add(temp.Value);
                    if (listField.Count > 0)
                    {
                        _f = new FieldForm(ref wh, wh.top_left(listField), this);
                        _f.Show();
                    }
                    break;
            }
        }
#endregion
        public void draw()
        {
            if (wh.isEmpty()) return;
            bm = new Bitmap((int)(wh.xMax * Package.SIZE) + 2, (int)(wh.yMax * Package.SIZE) + 2);
            pn.Width = bm.Width;
            pn.Height = bm.Height;
            Graphics gp = Graphics.FromImage(bm);
            gp.Clear(Color.White);
            wh.draw(gp);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wh.isEmpty()) return;
            pn.CreateGraphics().DrawImage(bm, new Point(0, 0));
        }

        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            int x = int.Parse(py.Text);
            int y = int.Parse(px.Text);
            Field tmp = wh.isExist(x, y);
            if (tmp != null)
            {
                tmp.del(new KeyValuePair<int, int>(x, y));
            }
            draw();
            px.Text = "";
            py.Text = "";
            no.Text = "";
            type.Text = "";
            txtID.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
            send();
        }

        private void btnMovePackage_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, int> p1 = new KeyValuePair<int, int>(int.Parse(txtFromY.Text), int.Parse(txtFromX.Text));
            KeyValuePair<int, int> p2 = new KeyValuePair<int, int>(int.Parse(txtToY.Text), int.Parse(txtToX.Text));
            int field1 = int.Parse(txtFromNo.Text);
            int field2 = int.Parse(txtToNo.Text);
            wh.MovePackage(p1, field1, p2, field2);
            draw();
            txtFromNo.Text = "";
            txtFromX.Text = "";
            txtFromY.Text = "";
            txtToNo.Text = "";
            txtToX.Text = "";
            txtToY.Text = "";
            send();
        }

        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            wh.removeField(int.Parse(txtFieldRemove.Text));
            draw();
            txtFieldRemove.Text = "";
            send();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            wh = new WareHouse();
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                fileName = fbd.FileName;
            if (fileName != null)
            {
                wh.inputProcess(wh.inputInfo(fileName));
                draw();
                send();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            wh.outputInfo(fileName);
        }
        #region Syns
       
        #endregion
        #region Helper Methods

        public void UpdateText(string text)//Update the text on textBox1
        {
            if (this.textBox1.InvokeRequired)
            {
                UpdateTextCallback temp = new UpdateTextCallback(UpdateText);
                this.Invoke(temp, new object[] { text });
            }
            else if (wh.setCons(text)) draw();
            else
            {
                string str = "";
                if (radioButton1.Checked == true) str = "\r\nClient said: (@" + DateTime.Now.ToString() + ")\r\n" + text;
                else if (radioButton2.Checked == true) str = "\r\nServer said: (@" + DateTime.Now.ToString() + ")\r\n" + text;
                textBox1.AppendText(str);
            }
        }
        private bool IsValidIPAddress(string ipaddr)//Validate the input IP address
        {
            try
            {
                IPAddress.Parse(ipaddr);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "IsValidIPAddress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void Reconnect()//Reconnect the Ethernet
        {
            try
            {
                if (button4.InvokeRequired)
                {
                    ReconnectCallback r = new ReconnectCallback(Reconnect);
                    this.Invoke(r, new object[] { });
                }
                else
                {
                    button4_Click(null, null);//Reconnect
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Reconnect failed.  Please restart.\r\n" + e.Message, "Reconnect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (radioButton1.Checked == true)//Server Mode
                {
                    try
                    {
                        if (server != null)
                        {
                            byte[] bytes = Encoding.GetEncoding(Constant.SimplifiedChineseCode).GetBytes(textBox2.Text);
                            server.Send(bytes);
                            string str = "";
                            str = "\r\nServer said: (@" + DateTime.Now.ToString() + ")\r\n" + textBox2.Text;
                            textBox1.AppendText(str + "\r\n");
                            textBox2.Clear();
                        }
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("Server send error!\r\n" + se.Message);
                    }
                }
                else if (radioButton2.Checked == true)//Client Mode
                {
                    try
                    {
                        if (client != null)
                        {
                            byte[] bytes = Encoding.GetEncoding(Constant.SimplifiedChineseCode).GetBytes(textBox2.Text);
                            client.Send(bytes);
                            string str = "";
                            str = "\r\nClient said: (@" + DateTime.Now.ToString() + ")\r\n" + textBox2.Text;
                            textBox1.AppendText(str + "\r\n");
                            textBox2.Clear();
                        }
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("Client send error!\r\n" + se.Message);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)//Connect
        {
            string ipAddr = textBox3.Text + "." + textBox4.Text + "." + textBox5.Text + "." + textBox6.Text;
            string port = textBox7.Text;
            if (IsValidIPAddress(ipAddr) == true)
            {
                if (radioButton1.Checked == true)//Server Mode
                {
                    try
                    {
                        if (server == null)
                            server = new Server(this);

                        server.Connect(ipAddr, port);

                        button2.Enabled = false;
                        button3.Enabled = true;
                        textBox2.Focus();
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("Server Connect Error.\r\n" + se.ToString());
                    }
                }
                else if (radioButton2.Checked == true)//Client Mode
                {
                    try
                    {
                        if (client == null)
                            client = new Client(this);

                        client.Connect(ipAddr, port);

                        string data = "Hello, I'm a Client";
                        client.Send(Encoding.GetEncoding(Constant.SimplifiedChineseCode).GetBytes(data));
                        textBox1.AppendText("\r\nClient said: (@" + DateTime.Now.ToString() + ")\r\n" + data + "\r\n");
                        button2.Enabled = false;
                        button3.Enabled = true;
                        textBox2.Focus();
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("Client Connect Error.\r\n" + se.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid IP address input.");
            }
        }
        private void button3_Click(object sender, EventArgs e)//Disconnect
        {
            if (radioButton1.Checked == true)//Server Mode
            {
                server.Disconnect();
                if (button2.Enabled == false)
                {
                    button2.Enabled = true;
                    button3.Enabled = false;
                }
            }
            else if (radioButton2.Checked == true)//Client Mode
            {
                client.Disconnect();
                if (button2.Enabled == false)
                {
                    button2.Enabled = true;
                    button3.Enabled = false;
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)//Reconnect
        {
            if (button3.Enabled == true)
                button3_Click(sender, e);//Disconnect
            Thread.Sleep(200);
            button2_Click(sender, e);//Connect
        }
        private void button5_Click(object sender, EventArgs e)//Clear
        {
            textBox1.Clear();
        }
        public void send()
        {
            textBox2.Text = wh.toText();
            if (radioButton1.Checked == true)//Server Mode
            {   
                try
                {
                    if (server != null)
                    {
                        byte[] bytes = Encoding.GetEncoding(Constant.SimplifiedChineseCode).GetBytes(textBox2.Text);
                        server.Send(bytes);
                        string str = "";
                        str = "\r\nServer said: (@" + DateTime.Now.ToString() + ")\r\n" + textBox2.Text;
                        textBox1.AppendText(str + "\r\n");
                        textBox2.Clear();
                    }
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Server send error!\r\n" + se.Message);
                }
            }
            else if (radioButton2.Checked == true)//Client Mode
            {
                try
                {
                    if (client != null)
                    {
                        byte[] bytes = Encoding.GetEncoding(Constant.SimplifiedChineseCode).GetBytes(textBox2.Text);
                        client.Send(bytes);
                        string str = "";
                        str = "\r\nClient said: (@" + DateTime.Now.ToString() + ")\r\n" + textBox2.Text;
                        textBox1.AppendText(str + "\r\n");
                        textBox2.Clear();
                    }
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Client send error!\r\n" + se.Message);
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileName != null)
            {
                wh.outputInfo(fileName);
            }
        }
    }
}