namespace Log_in_program
{
    partial class Tempconv
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
            this.combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "",
            "Celsius to Kelvin",
            "Celsius to Fahrenheit",
            "Kelvin to Celsius",
            "Kelvin to Fahrenheit",
            "Fahrenheit to Celsius",
            "Fahrenheit to Kelvin"});
            this.combobox.Location = new System.Drawing.Point(203, 111);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(211, 41);
            this.combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversions:";
            // 
            // convbtn
            // 
            this.convbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convbtn.Location = new System.Drawing.Point(12, 356);
            this.convbtn.Name = "convbtn";
            this.convbtn.Size = new System.Drawing.Size(106, 30);
            this.convbtn.TabIndex = 2;
            this.convbtn.Text = "convert";
            this.convbtn.UseVisualStyleBackColor = false;
            this.convbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputbox
            // 
            this.inputbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.Location = new System.Drawing.Point(12, 111);
            this.inputbox.Multiline = true;
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(133, 41);
            this.inputbox.TabIndex = 4;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.IndianRed;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearbtn.Location = new System.Drawing.Point(162, 357);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(106, 30);
            this.clearbtn.TabIndex = 5;
            this.clearbtn.Text = "clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(308, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputlabel.Location = new System.Drawing.Point(77, 228);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(121, 40);
            this.outputlabel.TabIndex = 7;
            this.outputlabel.Text = "Output:";
            // 
            // Tempconv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 398);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox);
            this.Name = "Tempconv";
            this.Text = "Tempconv";
            this.Load += new System.EventHandler(this.Tempconv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label outputlabel;
    }
}