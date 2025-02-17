﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in_program
{
    public partial class Tempconv : Form
    {
        public Tempconv()
        {
            InitializeComponent();
        }

        private void Tempconv_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(inputbox.Text);

            switch (combobox.SelectedIndex)
            {
                case 0: 
                    outputlabel.Text = "Output: " + (value + 273.15) + " K";
                    break;
                case 1: 
                    outputlabel.Text = "Output: " + ((value * 9 / 5) + 32) + " F";
                    break;
                case 2:
                    outputlabel.Text = "Output: " + (value - 273.15) + " C";
                    break;
                case 3: 
                    outputlabel.Text = "Output: " + ((value - 273.15) * 9 / 5 + 32) + " F";
                    break;
                case 4: 
                    outputlabel.Text = "Output: " + ((value - 32) * 5 / 9) + " C";
                    break;
                case 5:
                    outputlabel.Text = "Output: " + ((value - 32) * 5 / 9 + 273.15) + " K";
                    break;
                default:
                    outputlabel.Text = "Invalid selection.";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home newForm = new home();

            newForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            inputbox.Clear();
            combobox.Text = string.Empty;
        }
    }
}
