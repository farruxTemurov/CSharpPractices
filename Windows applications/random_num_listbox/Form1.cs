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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Show")
            {
                textBox2.PasswordChar = '\0';
                button3.Text = "Hide";
            }
            else
            {
                textBox2.PasswordChar = '*';
                button3.Text = "Show";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?",
                 "Confirm Exit",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person.name = textBox1.Text;
            Person.dob = dateTimePicker1.Value;
            Person.password = textBox2.Text;

            NumberGenerator ng = new NumberGenerator();
            ng.ShowDialog();
        }
    }
}
