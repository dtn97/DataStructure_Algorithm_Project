using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public class KeyValuePair
    {
        public Socket socket;
        public byte[] dataBuffer = new byte[1];
    }
    #region Package
    public class Package
    {
        public static int SIZE = 20;
        public string id; 
        public int xCoord;
        public int yCoord;
        public int Price;
        public string Date;
        public int field;
        public Package()
        {
            id = "";
            Date = "";
            field = -1;
            xCoord = 0;
            yCoord = 0;
            Price = 0;
        }
        public void update(int x, int y, int no)
        {
            xCoord = x;
            yCoord = y;
            field = no;
        }
        public void set(string ID, int x, int y, int no, int price, string date)
        {
            xCoord = x;
            yCoord = y;
            field = no;
            Price = price;
            Date = date.ToString();
            id = ID.ToString();
        }
        public virtual void draw(int x, int y, Graphics gp)
        {
        }
        public virtual int getType()
        {
            return 0;
        }
        public static Package Get(int i)
        {
            if (i == 0) return new Package();
            if (i == 1) return new Package1();
            if (i == 2) return new Package2();
            return null;
        }
    }
    public class Package1 : Package
    {
        public override void draw(int x, int y, Graphics gp)
        {
            Rectangle rect = new Rectangle(x * SIZE, y * SIZE, SIZE, SIZE);
            gp.FillRectangle(new SolidBrush(Color.Yellow), rect);
            gp.DrawRectangle(Pens.Blue, rect);
        }
        public override int getType()
        {
            return 1;
        }
    }
    public class Package2 : Package
    {
        public override void draw(int x, int y, Graphics gp)
        {
            Rectangle rect = new Rectangle(x * SIZE, y * SIZE, 2 * SIZE, SIZE);
            gp.FillRectangle(new SolidBrush(Color.Orange), rect);
            gp.DrawRectangle(Pens.Blue, rect);
        }
        public override int getType()
        {
            return 2;
        }
    }
#endregion

    #region Field
    public class Field
    {
        public int x_coord, y_coord;
        public int height, width;
        public double rotate;
        public Dictionary<KeyValuePair<int, int>, Package> field;
        public Field(int x, int y, int h, int w, double r)
        {
            x_coord = x;
            y_coord = y;
            height = h;
            width = w;
            rotate = r;
            field = new Dictionary<KeyValuePair<int, int>, Package>();
        }
        public bool isExist(KeyValuePair<int, int> p)
        {
            return field.ContainsKey(p);
        }

        public Package getPackage(KeyValuePair<int, int> p)
        {
            Package res = null;
            if (field.TryGetValue(p, out res))
            {
                return res;  
            }
            return null;
        }
        public bool add(KeyValuePair<int, int> pos, Package p)
        {
            if (p == null) return false;
            if (pos.Key < 0 || pos.Key >= height || pos.Value < 0 || pos.Value >= width) return false;
            if (field.ContainsKey(pos)) return false;
            if (p.getType() == 2)
                if (!add(new KeyValuePair<int, int>(pos.Key, pos.Value + 1), new Package())) return false;
            field.Add(pos, p);
            return true;
        }
        public bool del(KeyValuePair<int, int> pos)
        {
            if (!field.ContainsKey(pos)) return false;
            Package p = this.getPackage(new KeyValuePair<int, int>(pos.Key, pos.Value));
            if (p.getType() == 1)
            {
                field.Remove(pos);
            }
            else
            {
                if (p.getType() == 2)
                {
                    field.Remove(new KeyValuePair<int, int>(pos.Key, pos.Value));
                    field.Remove(new KeyValuePair<int, int>(pos.Key, pos.Value + 1));
                }
                else
                {
                    if (p.getType() == 0)
                    {
                        field.Remove(new KeyValuePair<int, int>(pos.Key, pos.Value));
                        field.Remove(new KeyValuePair<int, int>(pos.Key, pos.Value - 1));
                    }
                }

            }
            return true;
        }
        public bool isTrueCoordnate(KeyValuePair<int, int> p)
        {
            return (p.Key >= 0 && p.Key < height) && (p.Value >= 0 && p.Value < width);
        }
        public double getH()
        {
            double tmp = Math.Sqrt(width * width + height * height);
            double angle = Math.Atan((double)height / width) + rotate;
            tmp = tmp * Math.Sin(angle);
            tmp = (double)y_coord + (height + tmp) / 2;
            return Math.Abs(tmp);
        }
        public double getW()
        {
            double tmp = Math.Sqrt(width * width + height * height);
            double angle = Math.Atan((double)width / height) + rotate;
            tmp = tmp * Math.Sin(angle);
            tmp = (double)x_coord + (tmp + width) / 2;
            return Math.Abs(tmp);
        }
        public void draw(Graphics gp)
        {
            int x = x_coord * Package.SIZE;
            int y = y_coord * Package.SIZE;
            int w = width * Package.SIZE;
            int h = height * Package.SIZE;
            if (rotate != 0)
            {
                double ox = (double)w / 2 + x;
                double oy = (double)h / 2 + y;
                gp.TranslateTransform((float)ox, (float)oy);
                gp.RotateTransform((float)(rotate * 180 / Math.PI));
                gp.TranslateTransform((float)-ox, (float)-oy);
            }
            gp.DrawRectangle(Pens.Blue, new Rectangle(x, y, w, h));
            SolidBrush sb = new SolidBrush(Color.Blue);
            for (int i = x + Package.SIZE; i < w + x; i += Package.SIZE)
                for (int j = y + Package.SIZE; j < h + y; j += Package.SIZE)
                    gp.FillEllipse(sb, new Rectangle(i - 1, j - 1, 2, 2));
            foreach (KeyValuePair<KeyValuePair<int, int>, Package> cur in field)
                cur.Value.draw(x_coord + cur.Key.Value, y_coord + cur.Key.Key, gp);
            gp.ResetTransform();
        }
        public static void ftranslate(ref double x, ref double y, double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        public static void frotate(ref double x, ref double y, double a)
        {
            double cos = Math.Cos(a);
            double sin = Math.Sin(a);
            double tmp = x;
            x = x * cos - y * sin;
            y = tmp * sin + y * cos;
        }
        public KeyValuePair<int, int> convert(double x, double y)
        {
            double ox = (double)width / 2 + x_coord;
            double oy = (double)height / 2 + y_coord;
            ftranslate(ref x, ref y, -ox, -oy);
            frotate(ref x, ref y, -rotate);
            ftranslate(ref x, ref y, ox, oy);
            x -= x_coord;
            y -= y_coord;
            int ix = (int)x;
            int iy = (int)y;
            if (ix < width && iy < height) return new KeyValuePair<int, int>(ix, iy);
            else return new KeyValuePair<int, int>(-1, -1);
        }
    }
#endregion

    #region WareHouse
    public class WareHouse
    {
        public double xMax, yMax;
        public List<Field> lf;
        public WareHouse()
        {
            lf = new List<Field>();
            xMax = 0;
            yMax = 0;
        }
        public bool isEmpty()
        {
            return lf.Count < 1;
        }
        void updateXY()
        {
            double xx = lf[lf.Count - 1].getW();
            double yy = lf[lf.Count - 1].getH();
            if (xMax < xx) xMax = xx;
            if (yMax < yy) yMax = yy;
        }
        public void add(Field a)
        {
            lf.Add(a);
            updateXY();
        }
        public bool add(int x, int y, int w, int h, double r)
        {
            if (h < 1 || w < 1 || x < 0 || y < 0) return false;
            lf.Add(new Field(x, y, w, h, r));
            updateXY();
            return true;
        }
        public bool add(int n, int x, int y, Package p)
        {
            if (n >= lf.Count || n < 0) return false;
            else return lf[n].add(new KeyValuePair<int, int>(x, y), p);
        }
        public void draw(Graphics gp)
        {
            for (int i = 0; i < lf.Count; ++i)
                lf[i].draw(gp);
        }

        public Field isExist(int x, int y)
        {
            foreach(Field cur in lf)
            {
                if (cur.isExist(new KeyValuePair<int, int>(x, y)))
                    return cur;
            }
            return null;
        }

        public bool MovePackage(KeyValuePair<int, int> p1, int field1, KeyValuePair<int, int> p2, int field2)
        {
            if (!lf[field1].isExist(p1))
                return false;
            Package tmp = lf[field1].getPackage(p1);
            if (tmp.getType() == 0)
            {
                KeyValuePair<int, int> p = new KeyValuePair<int, int>(p1.Key, p1.Value - 1);
                tmp = lf[field1].getPackage(p);
            }
            lf[field1].del(p1);
            if (tmp.getType() == 2)
            {
                KeyValuePair<int, int> p = new KeyValuePair<int, int>(p2.Key, p2.Value + 1);
                if (lf[field2].isExist(p) || !lf[field2].isTrueCoordnate(p))
                {
                    lf[field1].add(p1, tmp);
                    return false;
                }
            }
            tmp.update(p2.Key, p2.Value, field2);
            lf[field2].add(p2, tmp);
            return true;
        }

        public KeyValuePair<KeyValuePair<int, int>, int> convert(double x, double y)
        {
            KeyValuePair<int, int> res = new KeyValuePair<int, int>();
            for (int k = 0; k < lf.Count; ++k)
            {
                double _x = x / Package.SIZE;
                double _y = y / Package.SIZE;
                res = lf[k].convert(_x, _y);
                if (res.Key >= 0 || res.Value >= 0)
                {
                    return new KeyValuePair<KeyValuePair<int, int>, int>(res, k);
                }
            }
            return new KeyValuePair<KeyValuePair<int, int>, int>(res, -1);
        }
        public int top_left(HashSet<int> set)
        {
            if (set.Count == 0) return -1;
            int[] arr = new int [set.Count];
            set.CopyTo(arr);
            int res = arr[0];
            for (int i = 1; i < set.Count; ++i)
            {
                if (lf[res].y_coord < lf[arr[i]].y_coord) continue;
                if (lf[res].y_coord > lf[arr[i]].y_coord) res = arr[i];
                if (lf[res].x_coord < lf[arr[i]].x_coord) continue;
                res = arr[i];
            }
            return res;
        }

        public void inputProcess(string str)
        {
            string[] input = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Queue<string> q = new Queue<string>();
            foreach (string cur in input)
            {
                q.Enqueue(cur);
            }
            int numOfFields = int.Parse(q.Peek());
            q.Dequeue();
            for (int i = 0; i < numOfFields; ++i)
            {
                string line = q.Peek();
                q.Dequeue();
                string[] tmp = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Field f = new Field(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[4]), int.Parse(tmp[3]), double.Parse(tmp[2]));
                int numOfPackages = int.Parse(tmp[5]);
                for (int j = 0; j < numOfPackages; ++j)
                {
                    line = q.Peek();
                    q.Dequeue();
                    tmp = (line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    int packageType = int.Parse(tmp[2]);
                    Package p;
                    if (packageType == 1)
                        p = new Package1();
                    else
                        p = new Package2();
                    p.xCoord = int.Parse(tmp[0]);
                    p.yCoord = int.Parse(tmp[1]);
                    p.id = tmp[3];
                    p.Price = int.Parse(tmp[4]);
                    p.field = i;
                    p.Date = tmp[5];
                    f.add(new KeyValuePair<int, int>(p.xCoord, p.yCoord), p);
                }
                q.Dequeue();
                this.add(f);
            }
        }

        public string inputInfo(string fileName)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            string ret = file.ReadToEnd();
            file.Close();
            ret += "\r\n ";
            return ret;
        }

        public string outputProcess()
        {
            Queue<string> ret = new Queue<string>();
            ret.Enqueue(lf.Count().ToString());
            foreach (Field f in lf)
            {
                int numOfdummyPackages = 0;
                foreach (KeyValuePair<KeyValuePair<int, int>, Package> cur in f.field)
                {
                    Package p = cur.Value;
                    if (p.getType() == 0) ++numOfdummyPackages;
                }
                ret.Enqueue(f.x_coord.ToString() + " " + f.y_coord.ToString() + " " + f.rotate.ToString() + " "
                    + f.width.ToString() + " " + f.height.ToString() + " " + (f.field.Count - numOfdummyPackages).ToString());
                foreach (KeyValuePair<KeyValuePair<int, int>, Package> cur in f.field)
                {
                    Package p = cur.Value;
                    if (p.getType() == 0) continue;
                    ret.Enqueue(p.xCoord.ToString() + " " + p.yCoord.ToString()
                        + " " + p.getType().ToString() + " " + p.id + " " + p.Price.ToString() + " " + p.Date);
                }
                ret.Enqueue("");
            }
            string res = "";
            foreach (string cur in ret)
                res += (cur + " \r\n");
            return res;
        }

        public void outputInfo(string fileName)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            file.WriteLine(this.outputProcess());
            file.Close();
        }
        public string toText()
        {
            string res = lf.Count.ToString() + "x";
            foreach (Field f in lf)
            {
                int numOfdummyPackages = 0;
                foreach (KeyValuePair<KeyValuePair<int, int>, Package> cur in f.field)
                {
                    Package p = cur.Value;
                    if (p.getType() == 0) ++numOfdummyPackages;
                }
                res += f.x_coord.ToString() + " " + f.y_coord.ToString() + " " + f.rotate.ToString() + " "
                    + f.width.ToString() + " " + f.height.ToString() + " " + (f.field.Count - numOfdummyPackages).ToString() + "x";
                foreach (KeyValuePair<KeyValuePair<int, int>, Package> cur in f.field)
                {
                    Package p = cur.Value;
                    if (p.getType() == 0) continue;
                    res += p.xCoord.ToString() + " " + p.yCoord.ToString()
                        + " " + p.getType().ToString() + " " + p.id + " " + p.Price.ToString() + " " + p.Date + "x";
                }
            }
            return "1593572x" + res;
        }
        public bool setCons(string s)
        {
            string[] text = s.Split(new char[] { 'x' }, StringSplitOptions.RemoveEmptyEntries);
            if (text[0] != "1593572") return false;
            lf.Clear();
            int l = 1;
            int numOfFields = int.Parse(text[l++]);
            for (int i = 0; i < numOfFields; ++i)
            {
                string line = text[l++];
                string[] tmp = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Field f = new Field(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[4]), int.Parse(tmp[3]), double.Parse(tmp[2]));
                int numOfPackages = int.Parse(tmp[5]);
                for (int j = 0; j < numOfPackages; ++j)
                {
                    line = text[l++];
                    tmp = (line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    int packageType = int.Parse(tmp[2]);
                    Package p;
                    if (packageType == 1)
                        p = new Package1();
                    else
                        p = new Package2();
                    p.xCoord = int.Parse(tmp[0]);
                    p.yCoord = int.Parse(tmp[1]);
                    p.id = tmp[3];
                    p.Price = int.Parse(tmp[4]);
                    p.field = i;
                    p.Date = tmp[5];
                    f.add(new KeyValuePair<int, int>(p.xCoord, p.yCoord), p);
                }
                this.add(f);
            }
            return true;
        }
        public bool removeField(int index)
        {
            if (index < 0 || index >= lf.Count)
                return false;
            lf.Remove(lf[index]);
            return true;
        }
    }
#endregion
}