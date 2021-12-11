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
    }
}
