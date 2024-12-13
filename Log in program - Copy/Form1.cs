using System;
using System.Windows.Forms;

namespace Log_in_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordtextbox.PasswordChar = '*';
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            string[] users = {"12413969", "1", "user1"};
            string[] passwords = {"12Dec2005/", "1", "password1" };

            home newForm = new home();
            

            if (usertextbox.Text == users[0] && passwordtextbox.Text == passwords[0])
            {
                MessageBox.Show("Log In Successful!, Welcome user " + users[0], "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();         
                newForm.Show();
                //this.Close();
                this.Hide();
            }
            else if (usertextbox.Text == users[1] && passwordtextbox.Text == passwords[1])
            {
                MessageBox.Show("Log In Successful!, Welcome user " + users[1], "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                newForm.Show();
                //this.Close();
                this.Hide();
            }
            else if (usertextbox.Text == users[2] && passwordtextbox.Text == passwords[2])
            {
                MessageBox.Show("Log In Successful!, Welcome user " + users[2], "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                newForm.Show();
                //this.Close();
                this.Hide();
            }
            else if (usertextbox.Text != passwordtextbox.Text)
            {
                MessageBox.Show("Error! username or password is incorect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error! No Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usertextbox.Clear();
                passwordtextbox.Clear();
                usertextbox.Focus();

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usertextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
