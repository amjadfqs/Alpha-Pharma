using System;
using System.Windows.Forms;
using Alpha_Pharma.Classes;

namespace Alpha_Pharma.ManagerUC.StoreSales
{
    public partial class StoreUC : UserControl
    {
        private Store store = new Store();
        public StoreUC()
        {
            InitializeComponent();
            dgv_store_info.DataSource = Store.GetStore();
        }

        private void StoreUC_Load(object sender, EventArgs e)
        {
            combo_product.DataSource = Drug.GetDrug();
            combo_product.DisplayMember = "DrugAll";
            combo_product.ValueMember = "ID";
            combo_product.SelectedIndex = -1;

            combo_supplier.DataSource = Supplier.GetSuppliers();
            combo_supplier.DisplayMember = "Name";
            combo_supplier.ValueMember = "ID";
            combo_supplier.SelectedIndex = -1;

            date_proExp.Value = DateTime.Now;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            store.Pro_ID = combo_product.SelectedValue.ToString();
            store.Sup_ID = combo_supplier.SelectedValue.ToString();
            store.Pro_Expire = date_proExp.Text;
            store.Pro_Price = txb_proPrice.Text;
            store.Pro_Qty = txb_proQty.Text;
            store.Pro_Code = txb_proCode.Text;

            bool success = store.InsertStore(store);
            dgv_store_info.DataSource = Store.GetStore();
            if (success)
            {
                ClearControls();
                MessageBox.Show(@"Information has been added successfully");
            }
            else
            {
                MessageBox.Show(@"Error occurd. Pleas try again...");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            store.ID = lb_store.Text;
            store.Pro_ID = combo_product.SelectedValue.ToString();
            store.Sup_ID = combo_supplier.SelectedValue.ToString();
            store.Pro_Expire = date_proExp.Text;
            store.Pro_Price = txb_proPrice.Text;
            store.Pro_Qty = txb_proQty.Text;
            store.Pro_Code = txb_proCode.Text;

            bool success = store.UpdateStore(store);
            dgv_store_info.DataSource = Store.GetStore();

            if (success)
            {
                ClearControls();
                MessageBox.Show(@"Information has been Updated successfully");
            }
            else
            {
                MessageBox.Show(@"Error occurd. Pleas try again...");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            store.ID = lb_store.Text;

            bool success = store.DeleteStore(store);
            dgv_store_info.DataSource = Store.GetStore();

            if (success)
            {
                ClearControls();
                MessageBox.Show(@"Information has been Deleted successfully");
            }
            else
            {
                MessageBox.Show(@"Error occurd. Pleas try again...");
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        void ClearControls()
        {
            lb_store.Clear();
            combo_product.Text = "";
            combo_supplier.Text = "";
            date_proExp.Value = DateTime.Now;
            txb_proCode.Clear();
            txb_proPrice.Clear();
            txb_proQty.Clear();
        }

        private void dgv_store_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            lb_store.Text = dgv_store_info.Rows[index].Cells[0].Value.ToString();
            combo_product.Text = dgv_store_info.Rows[index].Cells[1].Value.ToString();
            combo_supplier.Text = dgv_store_info.Rows[index].Cells[2].Value.ToString();
            date_proExp.Text = dgv_store_info.Rows[index].Cells[3].Value.ToString();
            txb_proPrice.Text = dgv_store_info.Rows[index].Cells[4].Value.ToString();
            txb_proQty.Text = dgv_store_info.Rows[index].Cells[5].Value.ToString();
            txb_proCode.Text = dgv_store_info.Rows[index].Cells[7].Value.ToString();
        }
    }
}
