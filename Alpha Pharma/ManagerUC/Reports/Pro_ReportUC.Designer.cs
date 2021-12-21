namespace Alpha_Pharma.ManagerUC
{
    partial class Pro_ReportUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.compo_Check = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv_pro_info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txb_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // compo_Check
            // 
            this.compo_Check.AutoRoundedCorners = true;
            this.compo_Check.BackColor = System.Drawing.Color.Transparent;
            this.compo_Check.BorderRadius = 5;
            this.compo_Check.BorderThickness = 0;
            this.compo_Check.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.compo_Check.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compo_Check.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.compo_Check.FocusedColor = System.Drawing.Color.Empty;
            this.compo_Check.FocusedState.Parent = this.compo_Check;
            this.compo_Check.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.compo_Check.ForeColor = System.Drawing.Color.White;
            this.compo_Check.FormattingEnabled = true;
            this.compo_Check.HoverState.Parent = this.compo_Check;
            this.compo_Check.ItemHeight = 30;
            this.compo_Check.Items.AddRange(new object[] {
            "Valid Medicine",
            "Expired  Medicine",
            "View All Medicine"});
            this.compo_Check.ItemsAppearance.Parent = this.compo_Check;
            this.compo_Check.Location = new System.Drawing.Point(730, 20);
            this.compo_Check.Name = "compo_Check";
            this.compo_Check.ShadowDecoration.Parent = this.compo_Check;
            this.compo_Check.Size = new System.Drawing.Size(392, 36);
            this.compo_Check.TabIndex = 8;
            this.compo_Check.SelectedIndexChanged += new System.EventHandler(this.compo_Emp_position_SelectedIndexChanged);
            // 
            // dgv_pro_info
            // 
            this.dgv_pro_info.AllowUserToAddRows = false;
            this.dgv_pro_info.AllowUserToDeleteRows = false;
            this.dgv_pro_info.AllowUserToResizeColumns = false;
            this.dgv_pro_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgv_pro_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_pro_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pro_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pro_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pro_info.CausesValidation = false;
            this.dgv_pro_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_pro_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pro_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_pro_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pro_info.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_pro_info.EnableHeadersVisualStyles = false;
            this.dgv_pro_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_pro_info.Location = new System.Drawing.Point(0, 94);
            this.dgv_pro_info.Name = "dgv_pro_info";
            this.dgv_pro_info.ReadOnly = true;
            this.dgv_pro_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pro_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_pro_info.RowHeadersVisible = false;
            this.dgv_pro_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_pro_info.RowTemplate.Height = 24;
            this.dgv_pro_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pro_info.Size = new System.Drawing.Size(1264, 1055);
            this.dgv_pro_info.TabIndex = 16;
            this.dgv_pro_info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_pro_info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_pro_info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_pro_info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_pro_info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_pro_info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_pro_info.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_pro_info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_pro_info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.dgv_pro_info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pro_info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_pro_info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_pro_info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_pro_info.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_pro_info.ThemeStyle.ReadOnly = true;
            this.dgv_pro_info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_pro_info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_pro_info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_pro_info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_pro_info.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_pro_info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_pro_info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(814, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Medicine Validaity Check";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Alpha_Pharma.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(19, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // txb_search
            // 
            this.txb_search.BackColor = System.Drawing.Color.Transparent;
            this.txb_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.txb_search.BorderRadius = 5;
            this.txb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_search.DefaultText = "";
            this.txb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.DisabledState.Parent = this.txb_search;
            this.txb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.FocusedState.Parent = this.txb_search;
            this.txb_search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.ForeColor = System.Drawing.Color.Black;
            this.txb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.HoverState.Parent = this.txb_search;
            this.txb_search.Location = new System.Drawing.Point(118, 31);
            this.txb_search.Margin = new System.Windows.Forms.Padding(5);
            this.txb_search.Name = "txb_search";
            this.txb_search.PasswordChar = '\0';
            this.txb_search.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txb_search.PlaceholderText = "Search for Employee....";
            this.txb_search.SelectedText = "";
            this.txb_search.ShadowDecoration.Parent = this.txb_search;
            this.txb_search.Size = new System.Drawing.Size(416, 36);
            this.txb_search.TabIndex = 21;
            this.txb_search.TextOffset = new System.Drawing.Point(0, -2);
            this.txb_search.TextChanged += new System.EventHandler(this.txb_search_TextChanged);
            // 
            // Pro_ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.compo_Check);
            this.Controls.Add(this.dgv_pro_info);
            this.Name = "Pro_ReportUC";
            this.Size = new System.Drawing.Size(1250, 765);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox compo_Check;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_pro_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txb_search;
    }
}
