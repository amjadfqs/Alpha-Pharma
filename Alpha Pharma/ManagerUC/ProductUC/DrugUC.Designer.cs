namespace Alpha_Pharma.ManagerUC.ProductUC
{
    partial class DrugUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lb_DID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DrugN = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_drug_info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.combo_DoseID = new System.Windows.Forms.ComboBox();
            this.combo_FormID = new System.Windows.Forms.ComboBox();
            this.combo_SecID = new System.Windows.Forms.ComboBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drug_info)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.combo_SecID);
            this.guna2GroupBox1.Controls.Add(this.combo_FormID);
            this.guna2GroupBox1.Controls.Add(this.combo_DoseID);
            this.guna2GroupBox1.Controls.Add(this.lb_DID);
            this.guna2GroupBox1.Controls.Add(this.btn_Update);
            this.guna2GroupBox1.Controls.Add(this.btn_Delete);
            this.guna2GroupBox1.Controls.Add(this.btn_Clear);
            this.guna2GroupBox1.Controls.Add(this.btn_Add);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.txb_DrugN);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 625);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1250, 200);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Drug Managment";
            // 
            // lb_DID
            // 
            this.lb_DID.BackColor = System.Drawing.Color.Transparent;
            this.lb_DID.BorderRadius = 8;
            this.lb_DID.BorderThickness = 0;
            this.lb_DID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_DID.DefaultText = "";
            this.lb_DID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.lb_DID.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lb_DID.DisabledState.Parent = this.lb_DID;
            this.lb_DID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lb_DID.Enabled = false;
            this.lb_DID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.lb_DID.FocusedState.Parent = this.lb_DID;
            this.lb_DID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DID.ForeColor = System.Drawing.Color.White;
            this.lb_DID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lb_DID.HoverState.Parent = this.lb_DID;
            this.lb_DID.Location = new System.Drawing.Point(98, 77);
            this.lb_DID.Margin = new System.Windows.Forms.Padding(6);
            this.lb_DID.Name = "lb_DID";
            this.lb_DID.PasswordChar = '\0';
            this.lb_DID.PlaceholderText = "Drug ID";
            this.lb_DID.ReadOnly = true;
            this.lb_DID.SelectedText = "";
            this.lb_DID.ShadowDecoration.Parent = this.lb_DID;
            this.lb_DID.Size = new System.Drawing.Size(120, 30);
            this.lb_DID.TabIndex = 9;
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
            this.btn_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update.Location = new System.Drawing.Point(1111, 77);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(125, 40);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete.Location = new System.Drawing.Point(1111, 132);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(125, 40);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_Clear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Clear.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Clear.Location = new System.Drawing.Point(985, 132);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.ShadowDecoration.Parent = this.btn_Clear;
            this.btn_Clear.Size = new System.Drawing.Size(120, 40);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add.ImageOffset = new System.Drawing.Point(6, 0);
            this.btn_Add.Location = new System.Drawing.Point(985, 77);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ShadowDecoration.Parent = this.btn_Add;
            this.btn_Add.Size = new System.Drawing.Size(120, 40);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(659, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 6;
            this.label3.Tag = " ";
            this.label3.Text = "Dose :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(454, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Form :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(250, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Section :";
            // 
            // txb_DrugN
            // 
            this.txb_DrugN.BackColor = System.Drawing.Color.Transparent;
            this.txb_DrugN.BorderRadius = 8;
            this.txb_DrugN.BorderThickness = 0;
            this.txb_DrugN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_DrugN.DefaultText = "";
            this.txb_DrugN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_DrugN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_DrugN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_DrugN.DisabledState.Parent = this.txb_DrugN;
            this.txb_DrugN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_DrugN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_DrugN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_DrugN.FocusedState.Parent = this.txb_DrugN;
            this.txb_DrugN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DrugN.ForeColor = System.Drawing.Color.White;
            this.txb_DrugN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_DrugN.HoverState.Parent = this.txb_DrugN;
            this.txb_DrugN.Location = new System.Drawing.Point(247, 77);
            this.txb_DrugN.Margin = new System.Windows.Forms.Padding(6);
            this.txb_DrugN.Name = "txb_DrugN";
            this.txb_DrugN.PasswordChar = '\0';
            this.txb_DrugN.PlaceholderText = "Drug Name";
            this.txb_DrugN.SelectedText = "";
            this.txb_DrugN.ShadowDecoration.Parent = this.txb_DrugN;
            this.txb_DrugN.Size = new System.Drawing.Size(190, 30);
            this.txb_DrugN.TabIndex = 0;
            // 
            // dgv_drug_info
            // 
            this.dgv_drug_info.AllowUserToAddRows = false;
            this.dgv_drug_info.AllowUserToDeleteRows = false;
            this.dgv_drug_info.AllowUserToResizeColumns = false;
            this.dgv_drug_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_drug_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_drug_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drug_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_drug_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_drug_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_drug_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_drug_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_drug_info.ColumnHeadersHeight = 27;
            this.dgv_drug_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_drug_info.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_drug_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_drug_info.EnableHeadersVisualStyles = false;
            this.dgv_drug_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_drug_info.Location = new System.Drawing.Point(0, 0);
            this.dgv_drug_info.Name = "dgv_drug_info";
            this.dgv_drug_info.ReadOnly = true;
            this.dgv_drug_info.RowHeadersVisible = false;
            this.dgv_drug_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_drug_info.RowTemplate.Height = 24;
            this.dgv_drug_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_drug_info.Size = new System.Drawing.Size(1250, 625);
            this.dgv_drug_info.TabIndex = 2;
            this.dgv_drug_info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_drug_info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_drug_info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_drug_info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_drug_info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_drug_info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_drug_info.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_drug_info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_drug_info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.dgv_drug_info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_drug_info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_drug_info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_drug_info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_drug_info.ThemeStyle.HeaderStyle.Height = 27;
            this.dgv_drug_info.ThemeStyle.ReadOnly = true;
            this.dgv_drug_info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_drug_info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_drug_info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_drug_info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_drug_info.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_drug_info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_drug_info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_drug_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drug_info_CellClick);
            // 
            // combo_DoseID
            // 
            this.combo_DoseID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_DoseID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_DoseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.combo_DoseID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_DoseID.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_DoseID.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_DoseID.Location = new System.Drawing.Point(663, 142);
            this.combo_DoseID.Name = "combo_DoseID";
            this.combo_DoseID.Size = new System.Drawing.Size(180, 26);
            this.combo_DoseID.TabIndex = 10;
            this.combo_DoseID.Text = "Select Dose";
            // 
            // combo_FormID
            // 
            this.combo_FormID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_FormID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_FormID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.combo_FormID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_FormID.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_FormID.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_FormID.Location = new System.Drawing.Point(457, 142);
            this.combo_FormID.Name = "combo_FormID";
            this.combo_FormID.Size = new System.Drawing.Size(180, 26);
            this.combo_FormID.TabIndex = 11;
            this.combo_FormID.Text = "Select Dose";
            // 
            // combo_SecID
            // 
            this.combo_SecID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_SecID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_SecID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.combo_SecID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_SecID.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_SecID.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_SecID.Location = new System.Drawing.Point(253, 142);
            this.combo_SecID.Name = "combo_SecID";
            this.combo_SecID.Size = new System.Drawing.Size(180, 26);
            this.combo_SecID.TabIndex = 12;
            this.combo_SecID.Text = "Select Dose";
            // 
            // DrugUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_drug_info);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "DrugUC";
            this.Size = new System.Drawing.Size(1250, 825);
            this.Load += new System.EventHandler(this.DrugUC_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drug_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txb_DrugN;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox lb_DID;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_drug_info;
        private System.Windows.Forms.ComboBox combo_DoseID;
        private System.Windows.Forms.ComboBox combo_SecID;
        private System.Windows.Forms.ComboBox combo_FormID;
    }
}
