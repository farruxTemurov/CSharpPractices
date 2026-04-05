using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.name = cbItemName.Text;
            p.amount = Convert.ToDouble(txtAmount.Text);
            p.unitPrice = Convert.ToDouble(txtUnitPrice.Text);
            txtTotal.Text = p.CalculateTotalPrice().ToString();

            FileStream fs = new FileStream("ProductInfo.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(p.ProductString());
            sw.Close();
            fs.Close();

            MessageBox.Show("Product info was added!");

            cbItemName.Text = "";
            txtAmount.Clear();
            txtUnitPrice.Clear();
            txtTotal.Clear();

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ProductInfo.txt", FileMode.Open, FileAccess.Read);
        }
    }
}
