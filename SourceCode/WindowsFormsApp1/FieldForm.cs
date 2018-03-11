using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FieldForm : Form
    {
        WareHouse wh = new WareHouse();
        Bitmap bm;
        Panel pn;
        bool check = new bool();
        int FirstX = new int();
        int FirstY = new int();
        int FirstField = new int();
        PackageForm f;
        int _x, _y, _size;
        double _rotate;
        WareHouse wh_backup;
        WarehouseForm f1;
        public FieldForm(ref WareHouse p, int index, WarehouseForm _f1)
        {
            InitializeComponent();
            f1 = _f1;
            wh_backup = p;
            _x = p.lf[index].x_coord;
            _y = p.lf[index].y_coord;
            _rotate = p.lf[index].rotate;
            p.lf[index].x_coord = 0;
            p.lf[index].y_coord = 0;
            p.lf[index].rotate = 0;
            _size = Package.SIZE;
            wh.add(p.lf[index]);
            timer1.Enabled = true;
            timer1.Interval = 200;
            pn = new Panel();
            pn.MouseMove += Pn_MouseMove;
            pn.MouseDown += Pn_MouseDown;
            pn.MouseUp += Pn_MouseUp;
            panel.Controls.Add(pn);
            draw();
        }
        
        static KeyValuePair<int, int> preCoordNate = new KeyValuePair<int, int>(-1, -1);
        int preField;
        
        private bool compareCoordNate(KeyValuePair<int, int> p, int field)
        {
            return (field == preField) && (p.Key == preCoordNate.Key) && (p.Value == preCoordNate.Value);
        }

        private void Field_add_Click(object sender, EventArgs e)
        {
            Package p = Package.Get(int.Parse(type.Text));
            int n = 0;
            int x = int.Parse(px.Text);
            int y = int.Parse(py.Text);
            p.set(txtID.Text, x, y, n, int.Parse(txtPrice.Text), txtDate.Text);
            wh.add(n, x, y, p);
            draw();
            px.Text = "";
            py.Text = "";
            type.Text = "";
            txtID.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
        }

        private void change_Click(object sender, EventArgs e)
        {
            int z = int.Parse(zoom.Text);
            Package.SIZE = z * 20 / 100;
            draw();
        }

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
            }

            preCoordNate = tmp;
            preField = temp.Value;

        }

        private void Pn_MouseDown(object sender, MouseEventArgs e)
        {
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
                        FirstX = tmp.Key;
                        FirstY = tmp.Value;
                        FirstField = k;
                    }
                    break;
                case MouseButtons.Right:
                    break;
            }
        }

        private void Pn_MouseUp(object sender, MouseEventArgs e)
        {
            check = false;
            KeyValuePair<KeyValuePair<int, int>, int> temp = wh.convert((double)e.X, (double)e.Y);
            switch (e.Button)
            {

                case MouseButtons.Left:
                    KeyValuePair<int, int> p1 = new KeyValuePair<int, int>(FirstY, FirstX);

                    KeyValuePair<int, int> p2 = new KeyValuePair<int, int>(temp.Key.Value, temp.Key.Key);
                    wh.MovePackage(p1, FirstField, p2, temp.Value);
                    draw();
                    break;
                case MouseButtons.Right:
                    break;
            }
            draw();
        }

        void draw()
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

        private void label5_Click(object sender, EventArgs e)
        {

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
            type.Text = "";
            txtID.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
        }

        private void btnMovePackage_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, int> p1 = new KeyValuePair<int, int>(int.Parse(txtFromY.Text), int.Parse(txtFromX.Text));
            KeyValuePair<int, int> p2 = new KeyValuePair<int, int>(int.Parse(txtToY.Text), int.Parse(txtToX.Text));
            int field1 = 0;
            int field2 = 0;
            wh.MovePackage(p1, field1, p2, field2);
            draw();
            txtFromX.Text = "";
            txtFromY.Text = "";
            txtToX.Text = "";
            txtToY.Text = "";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (wh.isEmpty()) return;
            pn.CreateGraphics().DrawImage(bm, new Point(0, 0));
        }

        private void Field_add_Click_1(object sender, EventArgs e)
        {
            Package p = Package.Get(int.Parse(type.Text));
            int x = int.Parse(px.Text);
            int y = int.Parse(py.Text);
            p.set(txtID.Text, x, y, 0, int.Parse(txtPrice.Text), txtDate.Text);
            wh.add(0, x, y, p);
            draw();
            px.Text = "";
            py.Text = "";
            type.Text = "";
            txtID.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
        }

        private void btnRemovePackage_Click_1(object sender, EventArgs e)
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
            type.Text = "";
            txtID.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
        }

        private void btnMovePackage_Click_1(object sender, EventArgs e)
        {
            KeyValuePair<int, int> p1 = new KeyValuePair<int, int>(int.Parse(txtFromY.Text), int.Parse(txtFromX.Text));
            KeyValuePair<int, int> p2 = new KeyValuePair<int, int>(int.Parse(txtToY.Text), int.Parse(txtToX.Text));
            wh.MovePackage(p1, 0, p2, 0);
            draw();
            txtFromX.Text = "";
            txtFromY.Text = "";
            txtToX.Text = "";
            txtToY.Text = "";
        }

        private void change_Click_1(object sender, EventArgs e)
        {
            int z = int.Parse(zoom.Text);
            Package.SIZE = z * 20 / 100;
            draw();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            wh.lf[0].x_coord = _x;
            wh.lf[0].y_coord = _y;
            wh.lf[0].rotate = _rotate;
            Package.SIZE = _size;
            f1.draw();
            f1.send();
        }
    }
}
