namespace PriceCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbItemName = new System.Windows.Forms.ComboBox();
            this.itemName = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.inpTotal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbItemName
            // 
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.Items.AddRange(new object[] {
            "Orange",
            "Banana",
            "Kiwi",
            "Mango",
            "Avacado",
            "Watermelon",
            "Onions",
            "Garlic",
            "Hazelnut"});
            this.cbItemName.Location = new System.Drawing.Point(192, 49);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(121, 24);
            this.cbItemName.TabIndex = 0;
            this.cbItemName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemName.Location = new System.Drawing.Point(58, 45);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(106, 25);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Item Name";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amount.Location = new System.Drawing.Point(58, 93);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(120, 25);
            this.amount.TabIndex = 3;
            this.amount.Text = "Amount (kg)";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unitPrice.Location = new System.Drawing.Point(58, 140);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(95, 25);
            this.unitPrice.TabIndex = 5;
            this.unitPrice.Text = "Unit Price";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(192, 95);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(192, 143);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(121, 22);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(193, 298);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inpTotal
            // 
            this.inpTotal.AutoSize = true;
            this.inpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inpTotal.Location = new System.Drawing.Point(59, 294);
            this.inpTotal.Name = "inpTotal";
            this.inpTotal.Size = new System.Drawing.Size(105, 25);
            this.inpTotal.TabIndex = 8;
            this.inpTotal.Text = "Total Price";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(527, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 132);
            this.listBox1.TabIndex = 10;
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCart.Location = new System.Drawing.Point(527, 339);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(239, 37);
            this.btnCart.TabIndex = 11;
            this.btnCart.Text = "Show Cart Items";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(597, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalc.Location = new System.Drawing.Point(58, 188);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(255, 37);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.inpTotal);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.cbItemName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItemName;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label inpTotal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
    }
}

