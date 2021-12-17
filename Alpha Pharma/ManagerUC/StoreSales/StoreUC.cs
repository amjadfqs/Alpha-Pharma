using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    MessageBox.Show(@"Information has been added successfully");
                }
                else
                {
                    MessageBox.Show(@"Error occurd. Pleas try again...");
                }
    
        }
    }
}
