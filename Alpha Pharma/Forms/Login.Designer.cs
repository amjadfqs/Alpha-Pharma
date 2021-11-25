namespace Alpha_Pharma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.txb_Pass = new System.Windows.Forms.TextBox();
            this.btn_Mini = new System.Windows.Forms.Button();
            this.but_enter = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_UserName
            // 
            this.txb_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_UserName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_UserName.ForeColor = System.Drawing.Color.White;
            this.txb_UserName.Location = new System.Drawing.Point(114, 428);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(372, 20);
            this.txb_UserName.TabIndex = 0;
            // 
            // txb_Pass
            // 
            this.txb_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.txb_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Pass.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Pass.ForeColor = System.Drawing.Color.White;
            this.txb_Pass.Location = new System.Drawing.Point(114, 560);
            this.txb_Pass.Name = "txb_Pass";
            this.txb_Pass.PasswordChar = '*';
            this.txb_Pass.Size = new System.Drawing.Size(372, 20);
            this.txb_Pass.TabIndex = 1;
            // 
            // btn_Mini
            // 
            this.btn_Mini.BackColor = System.Drawing.Color.Transparent;
            this.btn_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Mini.FlatAppearance.BorderSize = 0;
            this.btn_Mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mini.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mini.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Mini.Location = new System.Drawing.Point(513, 2);
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.Size = new System.Drawing.Size(40, 43);
            this.btn_Mini.TabIndex = 6;
            this.btn_Mini.Text = "__";
            this.btn_Mini.UseVisualStyleBackColor = false;
            this.btn_Mini.Click += new System.EventHandler(this.btn_Mini_Click);
            // 
            // but_enter
            // 
            this.but_enter.BackColor = System.Drawing.Color.Transparent;
            this.but_enter.BackgroundImage = global::Alpha_Pharma.Properties.Resources.Enter;
            this.but_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.but_enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(167)))));
            this.but_enter.FlatAppearance.BorderSize = 0;
            this.but_enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_enter.ForeColor = System.Drawing.Color.Transparent;
            this.but_enter.Location = new System.Drawing.Point(490, 700);
            this.but_enter.Name = "but_enter";
            this.but_enter.Size = new System.Drawing.Size(110, 101);
            this.but_enter.TabIndex = 3;
            this.but_enter.Text = " ";
            this.but_enter.UseVisualStyleBackColor = false;
            this.but_enter.Click += new System.EventHandler(this.but_enter_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(554, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 43);
            this.btn_close.TabIndex = 7;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.but_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.btn_Mini);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txb_Pass);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.but_enter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_enter;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.TextBox txb_Pass;
        private System.Windows.Forms.Button btn_Mini;
        private System.Windows.Forms.Button btn_close;
    }
}

