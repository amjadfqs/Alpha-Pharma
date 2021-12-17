using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;
using Alpha_Pharma.ManagerUC;
using Alpha_Pharma.ManagerUC.Emp___User;
using Alpha_Pharma.ManagerUC.ProductUC;
using Alpha_Pharma.ManagerUC.Reports;
using Alpha_Pharma.ManagerUC.StoreSales;


namespace Alpha_Pharma.Forms
{
    public partial class Manager : Form
    {
        private Session session = new Session();
        public Manager()
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

        private void btn_EmpMana_Click(object sender, EventArgs e)
        {
            Emp___User uc = new Emp___User();
            openUserControl(uc);
        }

        private void btn_CusMana_Click(object sender, EventArgs e)
        {
            CustomerUC uc = new CustomerUC();
            openUserControl(uc);
        }

        private void btn_DrugMana_Click(object sender, EventArgs e)
        {
            ProductUC uc = new ProductUC();
            openUserControl(uc);
        }

        private void btn_SuppMana_Click(object sender, EventArgs e)
        {
            SuppilerUC uc = new SuppilerUC();
            openUserControl(uc);
        }


        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            session.ID = User.User_ID.ToString();
            session.SessionStart = Login.startSession.ToString();
            session.SessionEnd = DateTime.Now.ToString();
            session.InsertSession(session);
           
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void product_report_Click(object sender, EventArgs e)
        {
            Reports uc = new Reports();
            openUserControl(uc);
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_logout.PerformClick();
        }

        private void btn_SaleMana_Click(object sender, EventArgs e)
        {
            SalesContainerUC uc = new SalesContainerUC();
            openUserControl(uc);
        }
    }
}
