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
    public partial class PackageForm : Form
    {
        public PackageForm(Package pa)
        {
            InitializeComponent();
            txtID.Text = pa.id.ToString();
            txtX.Text = pa.xCoord.ToString();
            txtY.Text = pa.yCoord.ToString();
            txtSize.Text = pa.getType().ToString();
            txtDate.Text = pa.Date.ToString();
            txtPrice.Text = pa.Price.ToString();
            txtField.Text = pa.field.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
