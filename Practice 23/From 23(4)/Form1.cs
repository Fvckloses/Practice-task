using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_23_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            if (textBox1.Text == "К" | textBox1.Text == "к")
            {
                Button butt = new Button();
                butt.Location = new Point(a, b);
                this.Controls.Add(butt);
                butt.MouseMove += ctrButton_MouseMove;
            }
            if (textBox1.Text == "м" | textBox1.Text == "М")
            {
                Label lab = new Label();
                lab.Location = new Point(a, b);
                lab.Text = "Метка";
                this.Controls.Add(lab);
                lab.MouseMove += ctrLabel_MouseMove;
            }
            if (textBox1.Text == "П" | textBox1.Text == "п")
            {
                TextBox textb = new TextBox();
                textb.Location = new Point(a, b);
                this.Controls.Add(textb);
                textb.MouseMove += ctrTextbox_MouseMove;
            }
        }
        private void ctrButton_MouseMove(Object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();
        }
        private void ctrTextbox_MouseMove(Object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Dispose();
        }
        public void ctrLabel_MouseMove(Object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Dispose();
        }
    }
}
