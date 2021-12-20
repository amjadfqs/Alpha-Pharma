namespace Alpha_Pharma.ManagerUC.ProductUC
{
    partial class DoseUC
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.lb_QID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_DoseQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_dose_info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dose_info)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.btn_Update);
            this.guna2GroupBox1.Controls.Add(this.btn_Delete);
            this.guna2GroupBox1.Controls.Add(this.btn_Clear);
            this.guna2GroupBox1.Controls.Add(this.btn_Add);
            this.guna2GroupBox1.Controls.Add(this.lb_QID);
            this.guna2GroupBox1.Controls.Add(this.txb_DoseQ);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 625);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1250, 200);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Dose Managment";
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
            this.btn_Update.Location = new System.Drawing.Point(1110, 76);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(125, 40);
            this.btn_Update.TabIndex = 1;
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
            this.btn_Delete.Location = new System.Drawing.Point(1110, 130);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(125, 40);
            this.btn_Delete.TabIndex = 3;
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
            this.btn_Clear.Location = new System.Drawing.Point(985, 130);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.ShadowDecoration.Parent = this.btn_Clear;
            this.btn_Clear.Size = new System.Drawing.Size(120, 40);
            this.btn_Clear.TabIndex = 2;
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
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_QID
            // 
            this.lb_QID.BackColor = System.Drawing.Color.Transparent;
            this.lb_QID.BorderRadius = 8;
            this.lb_QID.BorderThickness = 0;
            this.lb_QID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_QID.DefaultText = "";
            this.lb_QID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.lb_QID.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lb_QID.DisabledState.Parent = this.lb_QID;
            this.lb_QID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lb_QID.Enabled = false;
            this.lb_QID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.lb_QID.FocusedState.Parent = this.lb_QID;
            this.lb_QID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QID.ForeColor = System.Drawing.Color.White;
            this.lb_QID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lb_QID.HoverState.Parent = this.lb_QID;
            this.lb_QID.Location = new System.Drawing.Point(137, 104);
            this.lb_QID.Margin = new System.Windows.Forms.Padding(6);
            this.lb_QID.Name = "lb_QID";
            this.lb_QID.PasswordChar = '\0';
            this.lb_QID.PlaceholderText = "Quantity ID";
            this.lb_QID.ReadOnly = true;
            this.lb_QID.SelectedText = "";
            this.lb_QID.ShadowDecoration.Parent = this.lb_QID;
            this.lb_QID.Size = new System.Drawing.Size(120, 30);
            this.lb_QID.TabIndex = 4;
            // 
            // txb_DoseQ
            // 
            this.txb_DoseQ.BackColor = System.Drawing.Color.Transparent;
            this.txb_DoseQ.BorderRadius = 8;
            this.txb_DoseQ.BorderThickness = 0;
            this.txb_DoseQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_DoseQ.DefaultText = "";
            this.txb_DoseQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_DoseQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_DoseQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_DoseQ.DisabledState.Parent = this.txb_DoseQ;
            this.txb_DoseQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_DoseQ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_DoseQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_DoseQ.FocusedState.Parent = this.txb_DoseQ;
            this.txb_DoseQ.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DoseQ.ForeColor = System.Drawing.Color.White;
            this.txb_DoseQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_DoseQ.HoverState.Parent = this.txb_DoseQ;
            this.txb_DoseQ.Location = new System.Drawing.Point(274, 104);
            this.txb_DoseQ.Margin = new System.Windows.Forms.Padding(6);
            this.txb_DoseQ.Name = "txb_DoseQ";
            this.txb_DoseQ.PasswordChar = '\0';
            this.txb_DoseQ.PlaceholderText = "Dose Quantity";
            this.txb_DoseQ.SelectedText = "";
            this.txb_DoseQ.ShadowDecoration.Parent = this.txb_DoseQ;
            this.txb_DoseQ.Size = new System.Drawing.Size(190, 30);
            this.txb_DoseQ.TabIndex = 5;
            // 
            // dgv_dose_info
            // 
            this.dgv_dose_info.AllowUserToAddRows = false;
            this.dgv_dose_info.AllowUserToDeleteRows = false;
            this.dgv_dose_info.AllowUserToResizeColumns = false;
            this.dgv_dose_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_dose_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dose_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dose_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dose_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dose_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_dose_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dose_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dose_info.ColumnHeadersHeight = 27;
            this.dgv_dose_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dose_info.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_dose_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dose_info.EnableHeadersVisualStyles = false;
            this.dgv_dose_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_dose_info.Location = new System.Drawing.Point(0, 0);
            this.dgv_dose_info.Name = "dgv_dose_info";
            this.dgv_dose_info.ReadOnly = true;
            this.dgv_dose_info.RowHeadersVisible = false;
            this.dgv_dose_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_dose_info.RowTemplate.Height = 24;
            this.dgv_dose_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dose_info.Size = new System.Drawing.Size(1250, 625);
            this.dgv_dose_info.TabIndex = 3;
            this.dgv_dose_info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_dose_info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_dose_info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_dose_info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_dose_info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_dose_info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_dose_info.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_dose_info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_dose_info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.dgv_dose_info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_dose_info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_dose_info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_dose_info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dose_info.ThemeStyle.HeaderStyle.Height = 27;
            this.dgv_dose_info.ThemeStyle.ReadOnly = true;
            this.dgv_dose_info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_dose_info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_dose_info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_dose_info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_dose_info.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_dose_info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_dose_info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_dose_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dose_info_CellClick);
            // 
            // DoseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_dose_info);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "DoseUC";
            this.Size = new System.Drawing.Size(1250, 825);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dose_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2TextBox txb_DoseQ;
        private Guna.UI2.WinForms.Guna2TextBox lb_QID;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_dose_info;
    }
}
