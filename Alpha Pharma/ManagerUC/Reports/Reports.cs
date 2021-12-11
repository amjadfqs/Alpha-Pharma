using System;
using System.Windows.Forms;

namespace Alpha_Pharma.ManagerUC.Reports
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void openReportControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Re_container.Controls.Clear();
            panel_Re_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            Pro_ReportUC uc = new Pro_ReportUC();
            openReportControl(uc);
        }

        private void btn_session_Click(object sender, EventArgs e)
        {
            SessionUC uc = new SessionUC();
            openReportControl(uc);
        }
    }
}
