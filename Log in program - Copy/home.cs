using System;
using System.Windows.Forms;

namespace Log_in_program
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void currencyconv_Click(object sender, EventArgs e)
        {
            currencyconv newForm = new currencyconv();
            newForm.Show();

            this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();

            this.Close();
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            calculator newForm = new calculator();

            newForm.Show();
            this.Close();
        }

        private void tempconv_Click(object sender, EventArgs e)
        {

            Tempconv newForm = new Tempconv();
            newForm.Show();
            this.Close();
        }
    }
}
