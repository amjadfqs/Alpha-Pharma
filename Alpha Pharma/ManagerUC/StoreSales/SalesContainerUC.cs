using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.StoreSales
{
    public partial class SalesContainerUC : UserControl
    {
        public SalesContainerUC()
        {
            InitializeComponent();
        }

        private void openSalesControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Sales_container.Controls.Clear();
            panel_Sales_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            StoreUC uc = new StoreUC();
            openSalesControl(uc);
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            ReceiptUC uc = new ReceiptUC();
            openSalesControl(uc);
        }

        private void SalesContainerUC_Load(object sender, EventArgs e)
        {
            if (User.User_Type == "Employee")
            {
                btn_store.Enabled = false;
            }
        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            IncomeUC uc = new IncomeUC();
            openSalesControl(uc);
        }
    }
}
