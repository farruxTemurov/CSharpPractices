namespace codeGeneratorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.listOfCode = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(155, 78);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(240, 22);
            this.Nametxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Of Birth";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // depCmb
            // 
            this.depCmb.FormattingEnabled = true;
            this.depCmb.Items.AddRange(new object[] {
            "Computer Engineering",
            "International relations",
            "Diatetics"});
            this.depCmb.Location = new System.Drawing.Point(155, 154);
            this.depCmb.Name = "depCmb";
            this.depCmb.Size = new System.Drawing.Size(240, 24);
            this.depCmb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Department";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.generateBtn.Location = new System.Drawing.Point(179, 205);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(186, 42);
            this.generateBtn.TabIndex = 8;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // listOfCode
            // 
            this.listOfCode.FormattingEnabled = true;
            this.listOfCode.ItemHeight = 16;
            this.listOfCode.Location = new System.Drawing.Point(503, 116);
            this.listOfCode.Name = "listOfCode";
            this.listOfCode.Size = new System.Drawing.Size(330, 84);
            this.listOfCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(498, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "List of generated Code";
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(155, 114);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(240, 24);
            this.comboBoxYears.TabIndex = 12;
            this.comboBoxYears.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 492);
            this.Controls.Add(this.comboBoxYears);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listOfCode);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox depCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.ListBox listOfCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxYears;
    }
}

