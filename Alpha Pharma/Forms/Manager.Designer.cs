﻿namespace Alpha_Pharma.Forms
{
    partial class Manager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.product_report = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SaleMana = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DrugMana = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SuppMana = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CusMana = new Guna.UI2.WinForms.Guna2Button();
            this.btn_EmpMana = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.guna2Panel1.Controls.Add(this.product_report);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.Controls.Add(this.btn_SaleMana);
            this.guna2Panel1.Controls.Add(this.btn_DrugMana);
            this.guna2Panel1.Controls.Add(this.btn_SuppMana);
            this.guna2Panel1.Controls.Add(this.btn_CusMana);
            this.guna2Panel1.Controls.Add(this.btn_EmpMana);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(306, 875);
            this.guna2Panel1.TabIndex = 1;
            // 
            // product_report
            // 
            this.product_report.BorderRadius = 20;
            this.product_report.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.product_report.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.product_report.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.product_report.CheckedState.Parent = this.product_report;
            this.product_report.CustomImages.Parent = this.product_report;
            this.product_report.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.product_report.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_report.ForeColor = System.Drawing.Color.White;
            this.product_report.HoverState.Parent = this.product_report;
            this.product_report.Image = global::Alpha_Pharma.Properties.Resources.report;
            this.product_report.ImageOffset = new System.Drawing.Point(-22, 0);
            this.product_report.ImageSize = new System.Drawing.Size(30, 30);
            this.product_report.Location = new System.Drawing.Point(7, 581);
            this.product_report.Name = "product_report";
            this.product_report.ShadowDecoration.Parent = this.product_report;
            this.product_report.Size = new System.Drawing.Size(292, 45);
            this.product_report.TabIndex = 7;
            this.product_report.Text = "Reports";
            this.product_report.Click += new System.EventHandler(this.product_report_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 721);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BorderRadius = 20;
            this.btn_logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_logout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_logout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.CheckedState.Parent = this.btn_logout;
            this.btn_logout.CustomImages.Parent = this.btn_logout;
            this.btn_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_logout.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.HoverState.Parent = this.btn_logout;
            this.btn_logout.Image = global::Alpha_Pharma.Properties.Resources.logout;
            this.btn_logout.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_logout.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_logout.Location = new System.Drawing.Point(8, 656);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Parent = this.btn_logout;
            this.btn_logout.Size = new System.Drawing.Size(291, 45);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // btn_SaleMana
            // 
            this.btn_SaleMana.BorderRadius = 20;
            this.btn_SaleMana.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_SaleMana.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_SaleMana.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_SaleMana.CheckedState.Parent = this.btn_SaleMana;
            this.btn_SaleMana.CustomImages.Parent = this.btn_SaleMana;
            this.btn_SaleMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_SaleMana.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleMana.ForeColor = System.Drawing.Color.White;
            this.btn_SaleMana.HoverState.Parent = this.btn_SaleMana;
            this.btn_SaleMana.Image = global::Alpha_Pharma.Properties.Resources.sales;
            this.btn_SaleMana.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btn_SaleMana.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_SaleMana.Location = new System.Drawing.Point(8, 514);
            this.btn_SaleMana.Name = "btn_SaleMana";
            this.btn_SaleMana.ShadowDecoration.Parent = this.btn_SaleMana;
            this.btn_SaleMana.Size = new System.Drawing.Size(291, 45);
            this.btn_SaleMana.TabIndex = 5;
            this.btn_SaleMana.Text = "Sales Managment";
            this.btn_SaleMana.Click += new System.EventHandler(this.btn_SaleMana_Click);
            // 
            // btn_DrugMana
            // 
            this.btn_DrugMana.BorderRadius = 20;
            this.btn_DrugMana.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_DrugMana.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_DrugMana.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_DrugMana.CheckedState.Parent = this.btn_DrugMana;
            this.btn_DrugMana.CustomImages.Parent = this.btn_DrugMana;
            this.btn_DrugMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_DrugMana.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DrugMana.ForeColor = System.Drawing.Color.White;
            this.btn_DrugMana.HoverState.Parent = this.btn_DrugMana;
            this.btn_DrugMana.Image = global::Alpha_Pharma.Properties.Resources.drugs;
            this.btn_DrugMana.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btn_DrugMana.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_DrugMana.Location = new System.Drawing.Point(7, 444);
            this.btn_DrugMana.Name = "btn_DrugMana";
            this.btn_DrugMana.ShadowDecoration.Parent = this.btn_DrugMana;
            this.btn_DrugMana.Size = new System.Drawing.Size(292, 45);
            this.btn_DrugMana.TabIndex = 5;
            this.btn_DrugMana.Text = "Drug Managment";
            this.btn_DrugMana.Click += new System.EventHandler(this.btn_DrugMana_Click);
            // 
            // btn_SuppMana
            // 
            this.btn_SuppMana.BorderRadius = 20;
            this.btn_SuppMana.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_SuppMana.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_SuppMana.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_SuppMana.CheckedState.Parent = this.btn_SuppMana;
            this.btn_SuppMana.CustomImages.Parent = this.btn_SuppMana;
            this.btn_SuppMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_SuppMana.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuppMana.ForeColor = System.Drawing.Color.White;
            this.btn_SuppMana.HoverState.Parent = this.btn_SuppMana;
            this.btn_SuppMana.Image = global::Alpha_Pharma.Properties.Resources.supplier;
            this.btn_SuppMana.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_SuppMana.Location = new System.Drawing.Point(7, 375);
            this.btn_SuppMana.Name = "btn_SuppMana";
            this.btn_SuppMana.ShadowDecoration.Parent = this.btn_SuppMana;
            this.btn_SuppMana.Size = new System.Drawing.Size(292, 45);
            this.btn_SuppMana.TabIndex = 5;
            this.btn_SuppMana.Text = "Supplier Managment";
            this.btn_SuppMana.Click += new System.EventHandler(this.btn_SuppMana_Click);
            // 
            // btn_CusMana
            // 
            this.btn_CusMana.BorderRadius = 20;
            this.btn_CusMana.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CusMana.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_CusMana.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_CusMana.CheckedState.Parent = this.btn_CusMana;
            this.btn_CusMana.CustomImages.Parent = this.btn_CusMana;
            this.btn_CusMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_CusMana.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CusMana.ForeColor = System.Drawing.Color.White;
            this.btn_CusMana.HoverState.Parent = this.btn_CusMana;
            this.btn_CusMana.Image = global::Alpha_Pharma.Properties.Resources.profile;
            this.btn_CusMana.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_CusMana.Location = new System.Drawing.Point(7, 307);
            this.btn_CusMana.Margin = new System.Windows.Forms.Padding(3, 90, 3, 3);
            this.btn_CusMana.Name = "btn_CusMana";
            this.btn_CusMana.ShadowDecoration.Parent = this.btn_CusMana;
            this.btn_CusMana.Size = new System.Drawing.Size(291, 45);
            this.btn_CusMana.TabIndex = 5;
            this.btn_CusMana.Text = "Customer Managment";
            this.btn_CusMana.Click += new System.EventHandler(this.btn_CusMana_Click);
            // 
            // btn_EmpMana
            // 
            this.btn_EmpMana.BorderRadius = 20;
            this.btn_EmpMana.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_EmpMana.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_EmpMana.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_EmpMana.CheckedState.Parent = this.btn_EmpMana;
            this.btn_EmpMana.CustomImages.Parent = this.btn_EmpMana;
            this.btn_EmpMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_EmpMana.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmpMana.ForeColor = System.Drawing.Color.White;
            this.btn_EmpMana.HoverState.Parent = this.btn_EmpMana;
            this.btn_EmpMana.Image = global::Alpha_Pharma.Properties.Resources.profile;
            this.btn_EmpMana.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_EmpMana.Location = new System.Drawing.Point(7, 239);
            this.btn_EmpMana.Name = "btn_EmpMana";
            this.btn_EmpMana.ShadowDecoration.Parent = this.btn_EmpMana;
            this.btn_EmpMana.Size = new System.Drawing.Size(291, 45);
            this.btn_EmpMana.TabIndex = 5;
            this.btn_EmpMana.Text = "Employee Managment";
            this.btn_EmpMana.Click += new System.EventHandler(this.btn_EmpMana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::Alpha_Pharma.Properties.Resources.manager;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(306, 155);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContainer.Location = new System.Drawing.Point(305, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.ShadowDecoration.Parent = this.panelContainer;
            this.panelContainer.Size = new System.Drawing.Size(1250, 875);
            this.panelContainer.TabIndex = 2;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_logout;
            this.ClientSize = new System.Drawing.Size(1556, 875);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_SaleMana;
        private Guna.UI2.WinForms.Guna2Button btn_DrugMana;
        private Guna.UI2.WinForms.Guna2Button btn_SuppMana;
        private Guna.UI2.WinForms.Guna2Button btn_CusMana;
        private Guna.UI2.WinForms.Guna2Button btn_EmpMana;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button product_report;
    }
}