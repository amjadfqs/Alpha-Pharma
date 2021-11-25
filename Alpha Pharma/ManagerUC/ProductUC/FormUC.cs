using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.ProductUC
{
    public partial class FormUC : UserControl
    {
        private For form = new For();
        public FormUC()
        {
            InitializeComponent();
            dgv_form_info.DataSource = For.GetForm();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_FormN.Text))
            {
                form.FormName = txb_FormN.Text;

                bool success = form.InsertForm(form);
                dgv_form_info.DataSource = For.GetForm();
                if (success)
                {
                    txb_FormN.Text = "";
                    MessageBox.Show(@"Dose has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Form Name !");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                form.ID = lb_FID.Text;
                form.FormName = txb_FormN.Text;

                bool success = form.UpdateForm(form);
                dgv_form_info.DataSource = For.GetForm();
                if (success)
                {
                    txb_FormN.Text = "";
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                form.ID = lb_FID.Text;
                form.FormName = txb_FormN.Text;

                bool success = form.DeleteForm(form);
                dgv_form_info.DataSource = For.GetForm();
                if (success)
                {
                    txb_FormN.Text = "";
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

        private void dgv_form_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_FID.Text = dgv_form_info.Rows[index].Cells[0].Value.ToString();
                txb_FormN.Text = dgv_form_info.Rows[index].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lb_FID.Text = "";
            txb_FormN.Text = "";
        }
    }
}
