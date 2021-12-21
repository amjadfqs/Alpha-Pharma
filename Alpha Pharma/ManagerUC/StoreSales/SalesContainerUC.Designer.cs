namespace Alpha_Pharma.ManagerUC.StoreSales
{
    partial class SalesContainerUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_income = new Guna.UI2.WinForms.Guna2Button();
            this.btn_store = new Guna.UI2.WinForms.Guna2Button();
            this.btn_receipt = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Sales_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.btn_income);
            this.panel1.Controls.Add(this.btn_store);
            this.panel1.Controls.Add(this.btn_receipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 60);
            this.panel1.TabIndex = 4;
            // 
            // btn_income
            // 
            this.btn_income.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_income.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_income.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_income.CheckedState.Parent = this.btn_income;
            this.btn_income.CustomImages.Parent = this.btn_income;
            this.btn_income.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_income.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income.ForeColor = System.Drawing.Color.White;
            this.btn_income.HoverState.Parent = this.btn_income;
            this.btn_income.Location = new System.Drawing.Point(360, 25);
            this.btn_income.Name = "btn_income";
            this.btn_income.ShadowDecoration.Parent = this.btn_income;
            this.btn_income.Size = new System.Drawing.Size(175, 36);
            this.btn_income.TabIndex = 2;
            this.btn_income.Text = "Income";
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_store
            // 
            this.btn_store.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_store.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_store.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_store.CheckedState.Parent = this.btn_store;
            this.btn_store.CustomImages.Parent = this.btn_store;
            this.btn_store.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_store.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store.ForeColor = System.Drawing.Color.White;
            this.btn_store.HoverState.Parent = this.btn_store;
            this.btn_store.Location = new System.Drawing.Point(0, 25);
            this.btn_store.Name = "btn_store";
            this.btn_store.ShadowDecoration.Parent = this.btn_store;
            this.btn_store.Size = new System.Drawing.Size(175, 36);
            this.btn_store.TabIndex = 1;
            this.btn_store.Text = "Store";
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_receipt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_receipt.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_receipt.CheckedState.Parent = this.btn_receipt;
            this.btn_receipt.CustomImages.Parent = this.btn_receipt;
            this.btn_receipt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_receipt.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receipt.ForeColor = System.Drawing.Color.White;
            this.btn_receipt.HoverState.Parent = this.btn_receipt;
            this.btn_receipt.Location = new System.Drawing.Point(180, 25);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.ShadowDecoration.Parent = this.btn_receipt;
            this.btn_receipt.Size = new System.Drawing.Size(175, 36);
            this.btn_receipt.TabIndex = 1;
            this.btn_receipt.Text = "Receipt";
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // panel_Sales_container
            // 
            this.panel_Sales_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Sales_container.Location = new System.Drawing.Point(0, 60);
            this.panel_Sales_container.Name = "panel_Sales_container";
            this.panel_Sales_container.Size = new System.Drawing.Size(1250, 765);
            this.panel_Sales_container.TabIndex = 5;
            // 
            // SalesContainerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Sales_container);
            this.Controls.Add(this.panel1);
            this.Name = "SalesContainerUC";
            this.Size = new System.Drawing.Size(1250, 825);
            this.Load += new System.EventHandler(this.SalesContainerUC_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_store;
        private Guna.UI2.WinForms.Guna2Button btn_receipt;
        private System.Windows.Forms.Panel panel_Sales_container;
        private Guna.UI2.WinForms.Guna2Button btn_income;
    }
}
