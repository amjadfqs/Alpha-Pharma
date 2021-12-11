namespace Alpha_Pharma.ManagerUC.Reports
{
    partial class Reports
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
            this.btn_pro = new Guna.UI2.WinForms.Guna2Button();
            this.btn_session = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Re_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.btn_pro);
            this.panel1.Controls.Add(this.btn_session);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 60);
            this.panel1.TabIndex = 3;
            // 
            // btn_pro
            // 
            this.btn_pro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_pro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_pro.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_pro.CheckedState.Parent = this.btn_pro;
            this.btn_pro.CustomImages.Parent = this.btn_pro;
            this.btn_pro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_pro.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro.ForeColor = System.Drawing.Color.White;
            this.btn_pro.HoverState.Parent = this.btn_pro;
            this.btn_pro.Location = new System.Drawing.Point(0, 25);
            this.btn_pro.Name = "btn_pro";
            this.btn_pro.ShadowDecoration.Parent = this.btn_pro;
            this.btn_pro.Size = new System.Drawing.Size(175, 36);
            this.btn_pro.TabIndex = 1;
            this.btn_pro.Text = "Products";
            this.btn_pro.Click += new System.EventHandler(this.btn_pro_Click);
            // 
            // btn_session
            // 
            this.btn_session.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_session.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(144)))));
            this.btn_session.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_session.CheckedState.Parent = this.btn_session;
            this.btn_session.CustomImages.Parent = this.btn_session;
            this.btn_session.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.btn_session.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_session.ForeColor = System.Drawing.Color.White;
            this.btn_session.HoverState.Parent = this.btn_session;
            this.btn_session.Location = new System.Drawing.Point(181, 25);
            this.btn_session.Name = "btn_session";
            this.btn_session.ShadowDecoration.Parent = this.btn_session;
            this.btn_session.Size = new System.Drawing.Size(175, 36);
            this.btn_session.TabIndex = 1;
            this.btn_session.Text = "Sessions";
            this.btn_session.Click += new System.EventHandler(this.btn_session_Click);
            // 
            // panel_Re_container
            // 
            this.panel_Re_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Re_container.Location = new System.Drawing.Point(0, 60);
            this.panel_Re_container.Name = "panel_Re_container";
            this.panel_Re_container.Size = new System.Drawing.Size(1250, 765);
            this.panel_Re_container.TabIndex = 4;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Re_container);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1250, 825);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_pro;
        private Guna.UI2.WinForms.Guna2Button btn_session;
        private System.Windows.Forms.Panel panel_Re_container;
    }
}
