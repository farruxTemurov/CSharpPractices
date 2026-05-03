using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_num_listbox
{
    public partial class NumberGenerator : Form
    {
        public NumberGenerator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            textBox1.Text = r.Next(0, 999).ToString();
        }

        List<int> Nums = new List<int>();
        private void button4_Click(object sender, EventArgs e)
        {
            Nums.Add(Convert.ToInt32(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int n in Nums)
            {
                listBox1.Items.Add(n);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Nums.Sort();
            MessageBox.Show("Sorted!");
        }
    }
}
