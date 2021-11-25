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
using Alpha_Pharma.ManagerUC.ProductUC;

namespace Alpha_Pharma
{
    public partial class Manager : Form
    {
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
            EmployeeUC uc = new EmployeeUC();
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

        private void btn_SaleMana_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
