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
            this.components = new System.ComponentModel.Container();
            this.currencyconv = new System.Windows.Forms.Button();
            this.calcbtn = new System.Windows.Forms.Button();
            this.tempconv = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyconv
            // 
            this.currencyconv.BackColor = System.Drawing.Color.OrangeRed;
            this.currencyconv.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyconv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currencyconv.Location = new System.Drawing.Point(51, 178);
            this.currencyconv.Name = "currencyconv";
            this.currencyconv.Size = new System.Drawing.Size(201, 126);
            this.currencyconv.TabIndex = 0;
            this.currencyconv.Text = "CURRENCY CONVERTER";
            this.currencyconv.UseVisualStyleBackColor = false;
            this.currencyconv.Click += new System.EventHandler(this.currencyconv_Click);
            // 
            // calcbtn
            // 
            this.calcbtn.BackColor = System.Drawing.Color.Orange;
            this.calcbtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcbtn.Location = new System.Drawing.Point(299, 178);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(201, 126);
            this.calcbtn.TabIndex = 1;
            this.calcbtn.Text = "CALCULATOR";
            this.calcbtn.UseVisualStyleBackColor = false;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // tempconv
            // 
            this.tempconv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tempconv.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempconv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tempconv.Location = new System.Drawing.Point(551, 178);
            this.tempconv.Name = "tempconv";
            this.tempconv.Size = new System.Drawing.Size(201, 126);
            this.tempconv.TabIndex = 2;
            this.tempconv.Text = "TEMPERATURE CONVERTER";
            this.tempconv.UseVisualStyleBackColor = false;
            this.tempconv.Click += new System.EventHandler(this.tempconv_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Location = new System.Drawing.Point(713, 415);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME! YOU ARE LOGGED IN!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.Location = new System.Drawing.Point(601, 47);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(0, 41);
            this.labeltime.TabIndex = 5;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tempconv);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.currencyconv);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button currencyconv;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.Button tempconv;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltime;
    }
}