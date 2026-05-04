using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.A = Convert.ToInt32(textBox1.Text);
            r.B = Convert.ToInt32(textBox2.Text);
            textBox3.Text = r.Area().ToString();

            Graphics gr = textBox4.CreateGraphics();
            Pen p = new Pen(Color.Magenta, 4);
            gr.DrawRectangle(p, 20, 20, 150, 75); // x, y, width, height
            SolidBrush sb = new SolidBrush(Color.Yellow);
            gr.FillRectangle(sb, 21, 21, 148, 73);
        }
    }
}
