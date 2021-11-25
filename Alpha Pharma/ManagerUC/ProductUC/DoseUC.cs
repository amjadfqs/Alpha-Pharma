using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.ProductUC
{
    public partial class DoseUC : UserControl
    {
        private Dose dose = new Dose();
        public DoseUC()
        {
            InitializeComponent();
            dgv_dose_info.DataSource = Dose.GetDose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_DoseQ.Text))
            {
                MessageBox.Show("Please Enter the Dose Quantity");
            }
            else
            {
                dose.DoseQuantity = txb_DoseQ.Text;

                bool success = dose.InsertDose(dose);
                dgv_dose_info.DataSource = Dose.GetDose();
                if (success)
                {
                    txb_DoseQ.Text = "";
                    MessageBox.Show(@"Dose has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                dose.ID = lb_QID.Text;
                dose.DoseQuantity = txb_DoseQ.Text;

                bool success = dose.UpdateDose(dose);
                dgv_dose_info.DataSource = Dose.GetDose();
                if (success)
                {
                    txb_DoseQ.Text = "";
                    MessageBox.Show(@"Dose has been Updated successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select Row to Update !", "Error");
            }
        }

        private void dgv_dose_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_QID.Text = dgv_dose_info.Rows[index].Cells[0].Value.ToString();
                txb_DoseQ.Text = dgv_dose_info.Rows[index].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dose.ID = lb_QID.Text;

                bool success = dose.DeleteDose(dose);
                dgv_dose_info.DataSource = Dose.GetDose();
                if (success)
                {
                    txb_DoseQ.Text = "";
                    MessageBox.Show(@"Dose has been Deleted successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select Row to Delete !", "Error");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txb_DoseQ.Text = "";
            lb_QID.Text = "";
        }
    }
}
