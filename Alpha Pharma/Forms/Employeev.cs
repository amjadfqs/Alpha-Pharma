using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha_Pharma.ManagerUC;
using Alpha_Pharma.ManagerUC.Reports;

namespace Alpha_Pharma.Forms
{
    public partial class Employeev : Form
    {
        Customer custmer = new Customer();
        public Employeev()
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
            Reports uc = new Reports();
            openUserControl(uc);
        }
    }
}
