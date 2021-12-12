namespace Alpha_Pharma.ManagerUC
{
    partial class SuppilerUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gro = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txb_sup_desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.txb_SPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_SA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_SN = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Supplier_info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_info)).BeginInit();
            this.SuspendLayout();
            // 
            // gro
            // 
            this.gro.BackColor = System.Drawing.Color.Transparent;
            this.gro.BorderColor = System.Drawing.Color.Transparent;
            this.gro.BorderThickness = 0;
            this.gro.Controls.Add(this.txb_sup_desc);
            this.gro.Controls.Add(this.label2);
            this.gro.Controls.Add(this.lb_id);
            this.gro.Controls.Add(this.btn_Update);
            this.gro.Controls.Add(this.btn_Delete);
            this.gro.Controls.Add(this.btn_Clear);
            this.gro.Controls.Add(this.btn_Add);
            this.gro.Controls.Add(this.txb_SPN);
            this.gro.Controls.Add(this.txb_SA);
            this.gro.Controls.Add(this.txb_SN);
            this.gro.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.gro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.gro.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro.ForeColor = System.Drawing.Color.White;
            this.gro.Location = new System.Drawing.Point(0, 640);
            this.gro.Name = "gro";
            this.gro.ShadowDecoration.Parent = this.gro;
            this.gro.Size = new System.Drawing.Size(1250, 235);
            this.gro.TabIndex = 1;
            this.gro.Text = "Supplier Managment";
            // 
            // txb_sup_desc
            // 
            this.txb_sup_desc.BackColor = System.Drawing.Color.Transparent;
            this.txb_sup_desc.BorderColor = System.Drawing.Color.Transparent;
            this.txb_sup_desc.BorderRadius = 8;
            this.txb_sup_desc.BorderThickness = 0;
            this.txb_sup_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_sup_desc.DefaultText = "";
            this.txb_sup_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_sup_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_sup_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_sup_desc.DisabledState.Parent = this.txb_sup_desc;
            this.txb_sup_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_sup_desc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_sup_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sup_desc.FocusedState.Parent = this.txb_sup_desc;
            this.txb_sup_desc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sup_desc.ForeColor = System.Drawing.Color.White;
            this.txb_sup_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sup_desc.HoverState.Parent = this.txb_sup_desc;
            this.txb_sup_desc.Location = new System.Drawing.Point(342, 85);
            this.txb_sup_desc.Margin = new System.Windows.Forms.Padding(5);
            this.txb_sup_desc.Multiline = true;
            this.txb_sup_desc.Name = "txb_sup_desc";
            this.txb_sup_desc.PasswordChar = '\0';
            this.txb_sup_desc.PlaceholderText = "type here....";
            this.txb_sup_desc.SelectedText = "";
            this.txb_sup_desc.ShadowDecoration.Parent = this.txb_sup_desc;
            this.txb_sup_desc.Size = new System.Drawing.Size(306, 114);
            this.txb_sup_desc.TabIndex = 29;
            this.txb_sup_desc.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(350, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Supplier Description:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(307, 69);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 24);
            this.lb_id.TabIndex = 8;
            this.lb_id.Visible = false;
            // 
            // btn_Update
            // 
            this.btn_Update.AutoRoundedCorners = true;
            this.btn_Update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_Update.BorderRadius = 19;
            this.btn_Update.BorderThickness = 1;
            this.btn_Update.CheckedState.Parent = this.btn_Update;
            this.btn_Update.CustomImages.Parent = this.btn_Update;
            this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.Parent = this.btn_Update;
            this.btn_Update.Image = global::Alpha_Pharma.Properties.Resources.updating;
            this.btn_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Update.Location = new System.Drawing.Point(1097, 91);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(125, 40);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoRoundedCorners = true;
            this.btn_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_Delete.BorderRadius = 19;
            this.btn_Delete.BorderThickness = 1;
            this.btn_Delete.CheckedState.Parent = this.btn_Delete;
            this.btn_Delete.CustomImages.Parent = this.btn_Delete;
            this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.HoverState.Parent = this.btn_Delete;
            this.btn_Delete.Image = global::Alpha_Pharma.Properties.Resources.delete;
            this.btn_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Delete.Location = new System.Drawing.Point(1097, 145);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(125, 40);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AutoRoundedCorners = true;
            this.btn_Clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_Clear.BorderRadius = 19;
            this.btn_Clear.BorderThickness = 1;
            this.btn_Clear.CheckedState.Parent = this.btn_Clear;
            this.btn_Clear.CustomImages.Parent = this.btn_Clear;
            this.btn_Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.HoverState.Parent = this.btn_Clear;
            this.btn_Clear.Image = global::Alpha_Pharma.Properties.Resources.eraser;
            this.btn_Clear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Clear.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Clear.Location = new System.Drawing.Point(972, 145);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.ShadowDecoration.Parent = this.btn_Clear;
            this.btn_Clear.Size = new System.Drawing.Size(120, 40);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoRoundedCorners = true;
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_Add.BorderRadius = 19;
            this.btn_Add.BorderThickness = 1;
            this.btn_Add.CheckedState.Parent = this.btn_Add;
            this.btn_Add.CustomImages.Parent = this.btn_Add;
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.HoverState.Parent = this.btn_Add;
            this.btn_Add.Image = global::Alpha_Pharma.Properties.Resources.add;
            this.btn_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Add.ImageOffset = new System.Drawing.Point(6, 0);
            this.btn_Add.Location = new System.Drawing.Point(972, 92);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ShadowDecoration.Parent = this.btn_Add;
            this.btn_Add.Size = new System.Drawing.Size(120, 40);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txb_SPN
            // 
            this.txb_SPN.BackColor = System.Drawing.Color.Transparent;
            this.txb_SPN.BorderColor = System.Drawing.Color.Transparent;
            this.txb_SPN.BorderRadius = 8;
            this.txb_SPN.BorderThickness = 0;
            this.txb_SPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_SPN.DefaultText = "";
            this.txb_SPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_SPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_SPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SPN.DisabledState.Parent = this.txb_SPN;
            this.txb_SPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_SPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SPN.FocusedState.Parent = this.txb_SPN;
            this.txb_SPN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SPN.ForeColor = System.Drawing.Color.White;
            this.txb_SPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SPN.HoverState.Parent = this.txb_SPN;
            this.txb_SPN.Location = new System.Drawing.Point(83, 174);
            this.txb_SPN.Margin = new System.Windows.Forms.Padding(5);
            this.txb_SPN.Name = "txb_SPN";
            this.txb_SPN.PasswordChar = '\0';
            this.txb_SPN.PlaceholderText = "Phone Number";
            this.txb_SPN.SelectedText = "";
            this.txb_SPN.ShadowDecoration.Parent = this.txb_SPN;
            this.txb_SPN.Size = new System.Drawing.Size(190, 30);
            this.txb_SPN.TabIndex = 3;
            this.txb_SPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_SPN_KeyPress);
            // 
            // txb_SA
            // 
            this.txb_SA.BackColor = System.Drawing.Color.Transparent;
            this.txb_SA.BorderRadius = 8;
            this.txb_SA.BorderThickness = 0;
            this.txb_SA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_SA.DefaultText = "";
            this.txb_SA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_SA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_SA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SA.DisabledState.Parent = this.txb_SA;
            this.txb_SA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_SA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SA.FocusedState.Parent = this.txb_SA;
            this.txb_SA.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SA.ForeColor = System.Drawing.Color.White;
            this.txb_SA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SA.HoverState.Parent = this.txb_SA;
            this.txb_SA.Location = new System.Drawing.Point(83, 122);
            this.txb_SA.Margin = new System.Windows.Forms.Padding(8);
            this.txb_SA.Name = "txb_SA";
            this.txb_SA.PasswordChar = '\0';
            this.txb_SA.PlaceholderText = "Address";
            this.txb_SA.SelectedText = "";
            this.txb_SA.ShadowDecoration.Parent = this.txb_SA;
            this.txb_SA.Size = new System.Drawing.Size(190, 30);
            this.txb_SA.TabIndex = 2;
            // 
            // txb_SN
            // 
            this.txb_SN.BackColor = System.Drawing.Color.Transparent;
            this.txb_SN.BorderRadius = 8;
            this.txb_SN.BorderThickness = 0;
            this.txb_SN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_SN.DefaultText = "";
            this.txb_SN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_SN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_SN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SN.DisabledState.Parent = this.txb_SN;
            this.txb_SN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_SN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SN.FocusedState.Parent = this.txb_SN;
            this.txb_SN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SN.ForeColor = System.Drawing.Color.White;
            this.txb_SN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SN.HoverState.Parent = this.txb_SN;
            this.txb_SN.Location = new System.Drawing.Point(83, 69);
            this.txb_SN.Margin = new System.Windows.Forms.Padding(6);
            this.txb_SN.Name = "txb_SN";
            this.txb_SN.PasswordChar = '\0';
            this.txb_SN.PlaceholderText = "Name";
            this.txb_SN.SelectedText = "";
            this.txb_SN.ShadowDecoration.Parent = this.txb_SN;
            this.txb_SN.Size = new System.Drawing.Size(190, 30);
            this.txb_SN.TabIndex = 1;
            // 
            // dgv_Supplier_info
            // 
            this.dgv_Supplier_info.AllowUserToAddRows = false;
            this.dgv_Supplier_info.AllowUserToDeleteRows = false;
            this.dgv_Supplier_info.AllowUserToResizeColumns = false;
            this.dgv_Supplier_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Supplier_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supplier_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Supplier_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Supplier_info.CausesValidation = false;
            this.dgv_Supplier_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Supplier_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Supplier_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Supplier_info.ColumnHeadersHeight = 27;
            this.dgv_Supplier_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Supplier_info.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Supplier_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Supplier_info.EnableHeadersVisualStyles = false;
            this.dgv_Supplier_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Supplier_info.Location = new System.Drawing.Point(0, 0);
            this.dgv_Supplier_info.Name = "dgv_Supplier_info";
            this.dgv_Supplier_info.ReadOnly = true;
            this.dgv_Supplier_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Supplier_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Supplier_info.RowHeadersVisible = false;
            this.dgv_Supplier_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_Supplier_info.RowTemplate.Height = 24;
            this.dgv_Supplier_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Supplier_info.Size = new System.Drawing.Size(1250, 640);
            this.dgv_Supplier_info.TabIndex = 5;
            this.dgv_Supplier_info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Supplier_info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier_info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Supplier_info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Supplier_info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Supplier_info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Supplier_info.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier_info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Supplier_info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.dgv_Supplier_info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Supplier_info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Supplier_info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Supplier_info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Supplier_info.ThemeStyle.HeaderStyle.Height = 27;
            this.dgv_Supplier_info.ThemeStyle.ReadOnly = true;
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Supplier_info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Supplier_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Supplier_info_CellClick);
            // 
            // SuppilerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Supplier_info);
            this.Controls.Add(this.gro);
            this.Name = "SuppilerUC";
            this.Size = new System.Drawing.Size(1250, 875);
            this.Load += new System.EventHandler(this.SuppilerUC_Load);
            this.gro.ResumeLayout(false);
            this.gro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gro;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2TextBox txb_SPN;
        private Guna.UI2.WinForms.Guna2TextBox txb_SA;
        private Guna.UI2.WinForms.Guna2TextBox txb_SN;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Supplier_info;
        private System.Windows.Forms.Label lb_id;
        private Guna.UI2.WinForms.Guna2TextBox txb_sup_desc;
        private System.Windows.Forms.Label label2;
    }
}
