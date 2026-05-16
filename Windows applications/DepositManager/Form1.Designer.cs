namespace DepositManager
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
            this.btnTestTypes = new System.Windows.Forms.Button();
            this.btnTestOverloads = new System.Windows.Forms.Button();
            this.btnTestOverride = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestTypes
            // 
            this.btnTestTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestTypes.Location = new System.Drawing.Point(270, 103);
            this.btnTestTypes.Name = "btnTestTypes";
            this.btnTestTypes.Size = new System.Drawing.Size(229, 38);
            this.btnTestTypes.TabIndex = 0;
            this.btnTestTypes.Text = "Class vs Struct ";
            this.btnTestTypes.UseVisualStyleBackColor = true;
            this.btnTestTypes.Click += new System.EventHandler(this.btnTestTypes_Click);
            // 
            // btnTestOverloads
            // 
            this.btnTestOverloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestOverloads.Location = new System.Drawing.Point(270, 147);
            this.btnTestOverloads.Name = "btnTestOverloads";
            this.btnTestOverloads.Size = new System.Drawing.Size(229, 38);
            this.btnTestOverloads.TabIndex = 1;
            this.btnTestOverloads.Text = "Test Overloading";
            this.btnTestOverloads.UseVisualStyleBackColor = true;
            this.btnTestOverloads.Click += new System.EventHandler(this.btnTestOverloads_Click);
            // 
            // btnTestOverride
            // 
            this.btnTestOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestOverride.Location = new System.Drawing.Point(270, 191);
            this.btnTestOverride.Name = "btnTestOverride";
            this.btnTestOverride.Size = new System.Drawing.Size(229, 38);
            this.btnTestOverride.TabIndex = 2;
            this.btnTestOverride.Text = "Test Overriding";
            this.btnTestOverride.UseVisualStyleBackColor = true;
            this.btnTestOverride.Click += new System.EventHandler(this.btnTestOverride_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveLog.Location = new System.Drawing.Point(270, 235);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(229, 38);
            this.btnSaveLog.TabIndex = 3;
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.btnTestOverride);
            this.Controls.Add(this.btnTestOverloads);
            this.Controls.Add(this.btnTestTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestTypes;
        private System.Windows.Forms.Button btnTestOverloads;
        private System.Windows.Forms.Button btnTestOverride;
        private System.Windows.Forms.Button btnSaveLog;
    }
}

