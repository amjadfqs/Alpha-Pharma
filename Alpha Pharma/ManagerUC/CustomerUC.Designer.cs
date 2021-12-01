namespace Alpha_Pharma.ManagerUC
{
    partial class CustomerUC
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
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.group_Box_Customer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.id_lb = new System.Windows.Forms.Label();
            this.mb_CPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_CG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datetimepicker_CD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txb_CFN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_CLN = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_customer_info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.group_Box_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer_info)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_add.BorderRadius = 19;
            this.btn_add.BorderThickness = 1;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = global::Alpha_Pharma.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add.ImageOffset = new System.Drawing.Point(6, 0);
            this.btn_add.Location = new System.Drawing.Point(990, 82);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(120, 40);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_clear.BorderRadius = 19;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Image = global::Alpha_Pharma.Properties.Resources.eraser;
            this.btn_clear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_clear.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_clear.Location = new System.Drawing.Point(990, 135);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(120, 40);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_delete.BorderRadius = 19;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Image = global::Alpha_Pharma.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete.Location = new System.Drawing.Point(1115, 135);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(125, 40);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoRoundedCorners = true;
            this.btn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.btn_update.BorderRadius = 19;
            this.btn_update.BorderThickness = 1;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Image = global::Alpha_Pharma.Properties.Resources.updating;
            this.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_update.Location = new System.Drawing.Point(1115, 81);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(125, 40);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // group_Box_Customer
            // 
            this.group_Box_Customer.BackColor = System.Drawing.Color.Transparent;
            this.group_Box_Customer.BorderColor = System.Drawing.Color.Transparent;
            this.group_Box_Customer.BorderThickness = 0;
            this.group_Box_Customer.Controls.Add(this.id_lb);
            this.group_Box_Customer.Controls.Add(this.mb_CPN);
            this.group_Box_Customer.Controls.Add(this.label3);
            this.group_Box_Customer.Controls.Add(this.combo_CG);
            this.group_Box_Customer.Controls.Add(this.datetimepicker_CD);
            this.group_Box_Customer.Controls.Add(this.txb_CFN);
            this.group_Box_Customer.Controls.Add(this.label1);
            this.group_Box_Customer.Controls.Add(this.txb_CLN);
            this.group_Box_Customer.Controls.Add(this.btn_update);
            this.group_Box_Customer.Controls.Add(this.btn_delete);
            this.group_Box_Customer.Controls.Add(this.btn_clear);
            this.group_Box_Customer.Controls.Add(this.btn_add);
            this.group_Box_Customer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.group_Box_Customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.group_Box_Customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.group_Box_Customer.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Box_Customer.ForeColor = System.Drawing.Color.White;
            this.group_Box_Customer.Location = new System.Drawing.Point(0, 642);
            this.group_Box_Customer.Name = "group_Box_Customer";
            this.group_Box_Customer.ShadowDecoration.Parent = this.group_Box_Customer;
            this.group_Box_Customer.Size = new System.Drawing.Size(1250, 233);
            this.group_Box_Customer.TabIndex = 3;
            this.group_Box_Customer.Text = "Customer Managment";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(438, 166);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(0, 24);
            this.id_lb.TabIndex = 10;
            this.id_lb.Visible = false;
            // 
            // mb_CPN
            // 
            this.mb_CPN.BackColor = System.Drawing.Color.Transparent;
            this.mb_CPN.BorderColor = System.Drawing.Color.Transparent;
            this.mb_CPN.BorderRadius = 8;
            this.mb_CPN.BorderThickness = 0;
            this.mb_CPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mb_CPN.DefaultText = "";
            this.mb_CPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mb_CPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mb_CPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mb_CPN.DisabledState.Parent = this.mb_CPN;
            this.mb_CPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mb_CPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.mb_CPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mb_CPN.FocusedState.Parent = this.mb_CPN;
            this.mb_CPN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb_CPN.ForeColor = System.Drawing.Color.White;
            this.mb_CPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mb_CPN.HoverState.Parent = this.mb_CPN;
            this.mb_CPN.Location = new System.Drawing.Point(429, 62);
            this.mb_CPN.Margin = new System.Windows.Forms.Padding(5);
            this.mb_CPN.Name = "mb_CPN";
            this.mb_CPN.PasswordChar = '\0';
            this.mb_CPN.PlaceholderText = "Phone Number";
            this.mb_CPN.SelectedText = "";
            this.mb_CPN.ShadowDecoration.Parent = this.mb_CPN;
            this.mb_CPN.Size = new System.Drawing.Size(190, 33);
            this.mb_CPN.TabIndex = 9;
            this.mb_CPN.TextOffset = new System.Drawing.Point(0, -2);
            this.mb_CPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mb_CPN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(223, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth";
            // 
            // combo_CG
            // 
            this.combo_CG.AutoRoundedCorners = true;
            this.combo_CG.BackColor = System.Drawing.Color.Transparent;
            this.combo_CG.BorderRadius = 17;
            this.combo_CG.BorderThickness = 0;
            this.combo_CG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_CG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_CG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.combo_CG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_CG.FocusedColor = System.Drawing.Color.Empty;
            this.combo_CG.FocusedState.Parent = this.combo_CG;
            this.combo_CG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_CG.ForeColor = System.Drawing.Color.White;
            this.combo_CG.FormattingEnabled = true;
            this.combo_CG.HoverState.Parent = this.combo_CG;
            this.combo_CG.ItemHeight = 30;
            this.combo_CG.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_CG.ItemsAppearance.Parent = this.combo_CG;
            this.combo_CG.Location = new System.Drawing.Point(22, 163);
            this.combo_CG.Name = "combo_CG";
            this.combo_CG.ShadowDecoration.Parent = this.combo_CG;
            this.combo_CG.Size = new System.Drawing.Size(190, 36);
            this.combo_CG.TabIndex = 3;
            // 
            // datetimepicker_CD
            // 
            this.datetimepicker_CD.Animated = true;
            this.datetimepicker_CD.AutoRoundedCorners = true;
            this.datetimepicker_CD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.datetimepicker_CD.BorderRadius = 17;
            this.datetimepicker_CD.CheckedState.Parent = this.datetimepicker_CD;
            this.datetimepicker_CD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.datetimepicker_CD.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker_CD.ForeColor = System.Drawing.Color.White;
            this.datetimepicker_CD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepicker_CD.HoverState.Parent = this.datetimepicker_CD;
            this.datetimepicker_CD.Location = new System.Drawing.Point(226, 163);
            this.datetimepicker_CD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker_CD.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datetimepicker_CD.Name = "datetimepicker_CD";
            this.datetimepicker_CD.ShadowDecoration.Parent = this.datetimepicker_CD;
            this.datetimepicker_CD.Size = new System.Drawing.Size(190, 36);
            this.datetimepicker_CD.TabIndex = 4;
            this.datetimepicker_CD.UseTransparentBackground = true;
            this.datetimepicker_CD.Value = new System.DateTime(2021, 11, 15, 21, 32, 55, 0);
            // 
            // txb_CFN
            // 
            this.txb_CFN.BackColor = System.Drawing.Color.Transparent;
            this.txb_CFN.BorderRadius = 8;
            this.txb_CFN.BorderThickness = 0;
            this.txb_CFN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_CFN.DefaultText = "";
            this.txb_CFN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_CFN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_CFN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CFN.DisabledState.Parent = this.txb_CFN;
            this.txb_CFN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CFN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_CFN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CFN.FocusedState.Parent = this.txb_CFN;
            this.txb_CFN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CFN.ForeColor = System.Drawing.Color.White;
            this.txb_CFN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CFN.HoverState.Parent = this.txb_CFN;
            this.txb_CFN.Location = new System.Drawing.Point(22, 62);
            this.txb_CFN.Margin = new System.Windows.Forms.Padding(6);
            this.txb_CFN.Name = "txb_CFN";
            this.txb_CFN.PasswordChar = '\0';
            this.txb_CFN.PlaceholderText = "First Name";
            this.txb_CFN.SelectedText = "";
            this.txb_CFN.ShadowDecoration.Parent = this.txb_CFN;
            this.txb_CFN.Size = new System.Drawing.Size(190, 30);
            this.txb_CFN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gender";
            // 
            // txb_CLN
            // 
            this.txb_CLN.BackColor = System.Drawing.Color.Transparent;
            this.txb_CLN.BorderRadius = 8;
            this.txb_CLN.BorderThickness = 0;
            this.txb_CLN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_CLN.DefaultText = "";
            this.txb_CLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_CLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_CLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CLN.DisabledState.Parent = this.txb_CLN;
            this.txb_CLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CLN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_CLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CLN.FocusedState.Parent = this.txb_CLN;
            this.txb_CLN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CLN.ForeColor = System.Drawing.Color.White;
            this.txb_CLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CLN.HoverState.Parent = this.txb_CLN;
            this.txb_CLN.Location = new System.Drawing.Point(226, 62);
            this.txb_CLN.Margin = new System.Windows.Forms.Padding(8);
            this.txb_CLN.Name = "txb_CLN";
            this.txb_CLN.PasswordChar = '\0';
            this.txb_CLN.PlaceholderText = "Last Name";
            this.txb_CLN.SelectedText = "";
            this.txb_CLN.ShadowDecoration.Parent = this.txb_CLN;
            this.txb_CLN.Size = new System.Drawing.Size(190, 32);
            this.txb_CLN.TabIndex = 1;
            // 
            // dgv_customer_info
            // 
            this.dgv_customer_info.AllowUserToAddRows = false;
            this.dgv_customer_info.AllowUserToDeleteRows = false;
            this.dgv_customer_info.AllowUserToResizeColumns = false;
            this.dgv_customer_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_customer_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customer_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customer_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_customer_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customer_info.CausesValidation = false;
            this.dgv_customer_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_customer_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customer_info.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_customer_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_customer_info.EnableHeadersVisualStyles = false;
            this.dgv_customer_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer_info.Location = new System.Drawing.Point(0, 0);
            this.dgv_customer_info.Name = "dgv_customer_info";
            this.dgv_customer_info.ReadOnly = true;
            this.dgv_customer_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_customer_info.RowHeadersVisible = false;
            this.dgv_customer_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_customer_info.RowTemplate.Height = 24;
            this.dgv_customer_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customer_info.Size = new System.Drawing.Size(1250, 642);
            this.dgv_customer_info.TabIndex = 5;
            this.dgv_customer_info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_customer_info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer_info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_customer_info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_customer_info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_customer_info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_customer_info.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer_info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer_info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.dgv_customer_info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer_info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_customer_info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_customer_info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_customer_info.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_customer_info.ThemeStyle.ReadOnly = true;
            this.dgv_customer_info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer_info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer_info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_customer_info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer_info.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_customer_info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer_info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_info_CellClick);
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_customer_info);
            this.Controls.Add(this.group_Box_Customer);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1250, 875);
            this.group_Box_Customer.ResumeLayout(false);
            this.group_Box_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        public Guna.UI2.WinForms.Guna2GroupBox group_Box_Customer;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox combo_CG;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker_CD;
        private Guna.UI2.WinForms.Guna2TextBox txb_CFN;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txb_CLN;
        private Guna.UI2.WinForms.Guna2TextBox mb_CPN;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_customer_info;
        private System.Windows.Forms.Label id_lb;
    }
}
