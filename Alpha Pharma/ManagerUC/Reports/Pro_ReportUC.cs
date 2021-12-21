using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC
{
    public partial class Pro_ReportUC : UserControl
    {
        
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        public Pro_ReportUC()
        {

            InitializeComponent();
        }

        private void compo_Emp_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compo_Check.SelectedIndex == 0)
            {
                dgv_pro_info.DataSource = productReport.GetExpiredProduct();
            }
            else if (compo_Check.SelectedIndex == 1)
            {
                dgv_pro_info.DataSource = productReport.GetValidProduct();
            }
            else
            {
                dgv_pro_info.DataSource = productReport.GetAllProduct();
            }
            
        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {
            DataView Dv = new DataView(Store.GetStore());
            Dv.RowFilter = "DrugInfo like '%" + txb_search.Text + "%'";
            dgv_pro_info.DataSource = Dv;
        }
    }
}
