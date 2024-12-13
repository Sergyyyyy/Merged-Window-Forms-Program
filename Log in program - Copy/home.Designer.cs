namespace Log_in_program
{
    partial class home
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
            this.currencyconv = new System.Windows.Forms.Button();
            this.calcbtn = new System.Windows.Forms.Button();
            this.tempconv = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currencyconv
            // 
            this.currencyconv.Location = new System.Drawing.Point(46, 145);
            this.currencyconv.Name = "currencyconv";
            this.currencyconv.Size = new System.Drawing.Size(201, 126);
            this.currencyconv.TabIndex = 0;
            this.currencyconv.Text = "CURRENCY CONVERTER";
            this.currencyconv.UseVisualStyleBackColor = true;
            this.currencyconv.Click += new System.EventHandler(this.currencyconv_Click);
            // 
            // calcbtn
            // 
            this.calcbtn.Location = new System.Drawing.Point(294, 145);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(201, 126);
            this.calcbtn.TabIndex = 1;
            this.calcbtn.Text = "CALCULATOR";
            this.calcbtn.UseVisualStyleBackColor = true;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // tempconv
            // 
            this.tempconv.Location = new System.Drawing.Point(546, 145);
            this.tempconv.Name = "tempconv";
            this.tempconv.Size = new System.Drawing.Size(201, 126);
            this.tempconv.TabIndex = 2;
            this.tempconv.Text = "TEMPERATURE CONVERTER";
            this.tempconv.UseVisualStyleBackColor = true;
            this.tempconv.Click += new System.EventHandler(this.tempconv_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(713, 415);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tempconv);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.currencyconv);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button currencyconv;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.Button tempconv;
        private System.Windows.Forms.Button backbtn;
    }
}