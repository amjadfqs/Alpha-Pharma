using System;
using System.Windows.Forms;

namespace Alpha_Pharma.ManagerUC.Emp___User
{
    public partial class Emp___User : UserControl
    {
        public Emp___User()
        {
            InitializeComponent();
        }

        private void openUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_EUcontainer.Controls.Clear();
            panel_EUcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            EmployeeUC uc = new EmployeeUC();
            openUserControl(uc);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserUC uc = new UserUC();
            openUserControl(uc);
        }

        private void btn_Session_Click(object sender, EventArgs e)
        {
         
        }
    }
}
