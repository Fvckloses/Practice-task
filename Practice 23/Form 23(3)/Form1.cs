using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_23_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Black, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawLine(pen, 300, 390, 320, 390);
            g.DrawLine(pen, 300, 390, 300, 350);
            g.DrawLine(pen, 320, 390, 320, 350);
            g.DrawLine(pen, 320, 350, 350, 380);
            g.DrawLine(pen, 350, 380, 320, 320);
            g.DrawLine(pen, 320, 320, 345, 350);
            g.DrawLine(pen, 345, 350, 315, 285);
            g.DrawLine(pen, 315, 285, 335, 310);
            g.DrawLine(pen, 335, 310, 310, 260);
            g.DrawLine(pen, 300, 350, 270, 380);
            g.DrawLine(pen, 270, 380, 300, 320);
            g.DrawLine(pen, 300, 320, 275, 350);
            g.DrawLine(pen, 275, 350, 305, 285);
            g.DrawLine(pen, 305, 285, 285, 310);
            g.DrawLine(pen, 285, 310, 310, 260);
        }
    }
}
