using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.Reports
{
    public partial class SessionUC : UserControl
    {
        public SessionUC()
        {
            InitializeComponent();
            dgv_Session_info.DataSource = Session.GetSession();
        }

        private void SessionUC_Load(object sender, System.EventArgs e)
        {
            dgv_Session_info.Columns[1].Width = 100;
            dgv_Session_info.Columns[2].Width = 100;
        }
    }
}
