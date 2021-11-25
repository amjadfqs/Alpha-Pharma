using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.ProductUC
{
    public partial class SectionUC : UserControl
    {
        private Section section = new Section();
        public SectionUC()
        {
            InitializeComponent();
            dgv_section_info.DataSource = Section.GetSection();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_SecN.Text))
            {
                section.SectionName = txb_SecN.Text;

                bool success = section.InsertSection(section);
                dgv_section_info.DataSource = Section.GetSection();
                if (success)
                {
                    txb_SecN.Text = "";
                    MessageBox.Show(@"Section has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Section Name !");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                section.ID = lb_SID.Text;
                section.SectionName = txb_SecN.Text;

                bool success = section.UpdateSection(section);
                dgv_section_info.DataSource = Section.GetSection();
                if (success)
                {
                    txb_SecN.Text = "";
                    MessageBox.Show(@"Section has been Updated successfully");
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
                section.ID = lb_SID.Text;
                section.SectionName = txb_SecN.Text;

                bool success = section.DeleteSection(section);
                dgv_section_info.DataSource = Section.GetSection();
                if (success)
                {
                    txb_SecN.Text = "";
                    MessageBox.Show(@"Section has been Deleted successfully");
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
            lb_SID.Text = "";
            txb_SecN.Text = "";
        }

        private void dgv_section_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_SID.Text = dgv_section_info.Rows[index].Cells[0].Value.ToString();
                txb_SecN.Text = dgv_section_info.Rows[index].Cells[1].Value.ToString();
            }
            catch (Exception exception)
            {
                return;
            }
        }
    }
}
