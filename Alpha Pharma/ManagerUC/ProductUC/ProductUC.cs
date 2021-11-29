using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_Pharma.ManagerUC.ProductUC
{
    public partial class ProductUC : UserControl
    {
        public ProductUC()
        {
            InitializeComponent();
        }

        private void openUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Pcontainer.Controls.Clear();
            panel_Pcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void dose_Mana_Click(object sender, EventArgs e)
        {
            DoseUC uc = new DoseUC();
            openUserControl(uc);
        }

        private void form_Mana_Click(object sender, EventArgs e)
        {
            FormUC uc = new FormUC();
            openUserControl(uc);
        }

        private void sec_mana_Click(object sender, EventArgs e)
        {
            SectionUC uc = new SectionUC();
            openUserControl(uc);
        }

        private void drug_Mana_Click(object sender, EventArgs e)
        {
            DrugUC uc = new DrugUC();
            openUserControl(uc);
        }
    }
}
