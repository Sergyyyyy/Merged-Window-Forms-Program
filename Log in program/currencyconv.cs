using System;
using System.Windows.Forms;

namespace Log_in_program
{
    public partial class currencyconv : Form
    {
        public currencyconv()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void currencyconv_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            home newForm = new home();

            newForm.Show();
            this.Close();
        }

        private void convertbtn_Click(object sender, EventArgs e)
        {
            int amount;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out amount))
            {
                MessageBox.Show("Error! Invalid or No Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                {
                    outputlabel.Text = "output: " + amount + " USD" + " is equal to " + (amount * 57.84).ToString("F2") + " PHP";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
                {
                    outputlabel.Text = "output: " + amount + " USD" + " is equal to " + (amount * 146.59).ToString("F2") + " JYP";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
                {
                    outputlabel.Text = "output: " + amount + " PHP" + " is equal to " + (amount * 0.01729).ToString("F2") + " USD";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    outputlabel.Text = "output: " + amount + " PHP" + " is equal to " + (amount * 2.53).ToString("F2") + " JYP";
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
                {
                    outputlabel.Text = "output: " + amount + " JYP" + " is equal to " + (amount * 0.00682).ToString("F2") + " USD";
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
                {
                    outputlabel.Text = "output: " + amount + " JYP" + " is equal to " + (amount * 0.395).ToString("F2") + " PHP";
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
                {
                    outputlabel.Text = "output: " + amount + " USD" + " is equal to " + amount + " USD";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    outputlabel.Text = "output: " + amount + " PHP" + " is equal to " + amount + " PHP";
                }
                else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
                {
                    outputlabel.Text = "output: " + amount + " JYP" + " is equal to " + amount + " JYP";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            outputlabel.Text = string.Empty;    
        }
    }
}
