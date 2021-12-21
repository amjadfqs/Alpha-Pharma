using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.StoreSales
{
    public partial class IncomeUC : UserControl
    {
        public IncomeUC()
        {
            InitializeComponent();
            dgv_income_info.DataSource = ReceiptDetails.GetReceiptDetail();
        }

        private void IncomeUC_Load(object sender, EventArgs e)
        {
            dgv_income_info.Columns[0].Width = 50;
            dgv_income_info.Columns[1].Width = 50;
        }
    }
}
