using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;
using Alpha_Pharma.ManagerUC;

namespace Alpha_Pharma.Forms
{
    public partial class Employee : Form
    {
        private Session session = new Session();
        public Employee()
        {
            InitializeComponent();
        }
        private void openUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_CusMana_Click(object sender, EventArgs e)
        {
            CustomerUC uc = new CustomerUC();
            openUserControl(uc);
        }

        private void btn_SuppMana_Click(object sender, EventArgs e)
        {
            SuppilerUC uc = new SuppilerUC();
            openUserControl(uc);
        }

        private void btn_SaleMana_Click(object sender, EventArgs e)
        {

        }

        private void product_report_Click(object sender, EventArgs e)
        {
            Pro_ReportUC uc = new Pro_ReportUC();
            openUserControl(uc);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            session.ID = User.User_ID.ToString();
            session.SessionStart = Login.startSession.ToString();
            session.SessionEnd = DateTime.Now.ToString();
            session.InsertSession(session);

            this.Hide();
            Login f = new Login();
            f.Show();
        }
    }
    
}
