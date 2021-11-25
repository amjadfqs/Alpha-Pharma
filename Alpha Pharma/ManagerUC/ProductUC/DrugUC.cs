using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.ProductUC
{
    public partial class DrugUC : UserControl
    {
        private static string myconn = Properties.Settings.Default.Pharmacy_dbConnectionString;

        private Drug drug = new Drug();
        public DrugUC()
        {
            InitializeComponent();
            dgv_drug_info.DataSource = Drug.GetDrug();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_DrugN.Text) && 
                combo_DoseID.SelectedIndex != -1 && combo_FormID.SelectedIndex != -1 && combo_SecID.SelectedIndex != -1)
            {
                try
                {
                    drug.DrugName = txb_DrugN.Text;
                    drug.Section = combo_SecID.Text;
                    drug.Form = combo_FormID.Text;
                    drug.Dose = combo_DoseID.Text;

                    bool success = drug.InsertDrug(drug);
                    dgv_drug_info.DataSource = Drug.GetDrug();
                    if (success)
                    {
                        lb_DID.Text = "";
                        txb_DrugN.Text = "";
                        combo_DoseID.SelectedIndex = -1;
                        combo_SecID.SelectedIndex = -1;
                        combo_FormID.SelectedIndex = -1;
                        MessageBox.Show(@"Dose has been added successfully");
                    }
                    else
                    {
                        MessageBox.Show(@"Error occurd. Pleas try again...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter All Information Required !", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
           
            
        }



        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                drug.ID = lb_DID.Text;
                drug.DrugName = txb_DrugN.Text;
                drug.Section = combo_SecID.Text;
                drug.Form = combo_FormID.Text;
                drug.Dose = combo_DoseID.Text;

                bool success = drug.UpdateDrug(drug);
                dgv_drug_info.DataSource = Drug.GetDrug();
                if (success)
                {
                    lb_DID.Text = "";
                    txb_DrugN.Text = "";
                    combo_DoseID.SelectedIndex = -1;
                    combo_SecID.SelectedIndex = -1;
                    combo_FormID.SelectedIndex = -1;
                    MessageBox.Show("Dose has been Updated successfully");
                }
                else
                {
                    MessageBox.Show("Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter All Information Required !", "Error");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                drug.ID = lb_DID.Text;

                bool success = drug.DeleteDrug(drug);
                dgv_drug_info.DataSource = Drug.GetDrug();
                if (success)
                {
                    lb_DID.Text = "";
                    txb_DrugN.Text = "";
                    combo_DoseID.SelectedIndex = -1;
                    combo_SecID.SelectedIndex = -1;
                    combo_FormID.SelectedIndex = -1;
                    MessageBox.Show("Dose has been Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error occurd. Pleas try again...");
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lb_DID.Text = "";
            txb_DrugN.Text = "";
            combo_DoseID.SelectedIndex = -1;
            combo_SecID.SelectedIndex = -1;
            combo_FormID.SelectedIndex = -1;
        }

        private void DrugUC_Load(object sender, EventArgs e)
        {
            string DQ = "select dos_qty from Doses";
            string SQ = "select sec_name from Sections";
            string FQ = "select for_name from Forms";

            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DQ, con))
                {
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        while (DR.Read())
                        {
                            combo_DoseID.Items.Add(DR[0]);
                        }
                    }
                }
                using (SqlCommand com = new SqlCommand(SQ, con))
                {
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        while (DR.Read())
                        {
                            combo_SecID.Items.Add(DR[0]);
                        }
                    }
                }
                using (SqlCommand com = new SqlCommand(FQ, con))
                {
                    using (SqlDataReader DR = com.ExecuteReader())
                    {
                        while (DR.Read())
                        {
                            combo_FormID.Items.Add(DR[0]);
                        }
                    }
                }
            }

        }

        private void dgv_drug_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                lb_DID.Text = dgv_drug_info.Rows[index].Cells[0].Value.ToString();
                txb_DrugN.Text = dgv_drug_info.Rows[index].Cells[1].Value.ToString();
                combo_SecID.Text = dgv_drug_info.Rows[index].Cells[2].Value.ToString();
                combo_FormID.Text = dgv_drug_info.Rows[index].Cells[3].Value.ToString();
                combo_DoseID.Text = dgv_drug_info.Rows[index].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }

        }
    }
}
