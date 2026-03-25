using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace codeGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            CodeGenerator cg = new CodeGenerator();
            cg.name = Nametxt.Text;
            cg.dob = Convert.ToInt32(comboBoxYears.Text);
            cg.department = depCmb.Text;

            cg.code = cg.changedName()
                + cg.calcAge() + cg.depInits()
                + cg.randomNum();
            listOfCode.Items.Add(cg.code);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= 1950; i--)
            {
                comboBoxYears.Items.Add(i);
            }
        }
    }
}
