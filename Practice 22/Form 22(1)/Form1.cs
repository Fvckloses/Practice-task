using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_22_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
             double x = -15.246;
             double y = 4.642 * Math.Pow(10, -2);
             double z = 20.001 * Math.Pow(10, 2);
             double a = -182.036;
             double u = Math.Log10(Math.Pow(y, Math.Sqrt(Math.Abs(-x)))) * (x - y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2);
             textBox1.Text = u.ToString();
        }
    }
}
