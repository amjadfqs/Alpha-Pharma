using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma
{
    public partial class Form1 : Form
    {
        private User user = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void but_enter_Click(object sender, EventArgs e)
        {
            string type_user = user.loginChecker(txb_UserName.Text, txb_Pass.Text);

            if (type_user == "Manager")
            {
                this.Hide();
                new Manager().ShowDialog();
            }
            else if (type_user == "Admin")
            {
                this.Hide();

                MessageBox.Show(type_user);
            }
            else if (type_user == "Employee")
            {
                this.Hide();

                MessageBox.Show(type_user);
            }
            else
            {
                MessageBox.Show("Invalid Inforamtion !", "Try Again");
            }
        }

       
    }
}
