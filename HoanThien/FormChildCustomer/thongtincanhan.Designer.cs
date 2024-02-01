namespace HoanThien.FormChildCustomer
{
    partial class thongtincanhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pnl_Hoten = new System.Windows.Forms.Panel();
            this.TenKH = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SDT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.thoat = new QuanLyShipper.RJControls.RJLogin();
            this.update = new QuanLyShipper.RJControls.RJLogin();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.Pnl_Hoten.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Điện Thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // Pnl_Hoten
            // 
            this.Pnl_Hoten.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnl_Hoten.Controls.Add(this.TenKH);
            this.Pnl_Hoten.Location = new System.Drawing.Point(309, 31);
            this.Pnl_Hoten.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_Hoten.Name = "Pnl_Hoten";
            this.Pnl_Hoten.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Pnl_Hoten.Size = new System.Drawing.Size(255, 32);
            this.Pnl_Hoten.TabIndex = 36;
            // 
            // TenKH
            // 
            this.TenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TenKH.Location = new System.Drawing.Point(0, 0);
            this.TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.TenKH.Multiline = true;
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(255, 28);
            this.TenKH.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.SDT);
            this.panel3.Location = new System.Drawing.Point(309, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel3.Size = new System.Drawing.Size(255, 32);
            this.panel3.TabIndex = 38;
            // 
            // SDT
            // 
            this.SDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SDT.Location = new System.Drawing.Point(0, 0);
            this.SDT.Margin = new System.Windows.Forms.Padding(4);
            this.SDT.Multiline = true;
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(255, 28);
            this.SDT.TabIndex = 0;
            this.SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SDT_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.Email);
            this.panel4.Location = new System.Drawing.Point(309, 266);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel4.Size = new System.Drawing.Size(255, 32);
            this.panel4.TabIndex = 38;
            // 
            // Email
            // 
            this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email.Location = new System.Drawing.Point(0, 0);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(255, 28);
            this.Email.TabIndex = 0;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 5;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(45, 469);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(533, 6);
            this.rjPanel1.TabIndex = 41;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.thoat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.thoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.thoat.BorderRadius = 15;
            this.thoat.BorderSize = 0;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.White;
            this.thoat.Location = new System.Drawing.Point(379, 519);
            this.thoat.Margin = new System.Windows.Forms.Padding(4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(200, 49);
            this.thoat.TabIndex = 40;
            this.thoat.Text = "Thoát";
            this.thoat.TextColor = System.Drawing.Color.White;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // update
            // 
            this.update.AutoEllipsis = true;
            this.update.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.update.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.update.BorderRadius = 15;
            this.update.BorderSize = 0;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(51, 519);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(200, 49);
            this.update.TabIndex = 39;
            this.update.Text = "Cập nhật";
            this.update.TextColor = System.Drawing.Color.White;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // thongtincanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(645, 583);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Pnl_Hoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "thongtincanhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin cá nhân";
            this.Load += new System.EventHandler(this.thongtincanhan_Load);
            this.Pnl_Hoten.ResumeLayout(false);
            this.Pnl_Hoten.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private System.Windows.Forms.Panel Pnl_Hoten;
        private System.Windows.Forms.TextBox TenKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Email;
        private QuanLyShipper.RJControls.RJLogin update;
        private QuanLyShipper.RJControls.RJLogin thoat;
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
    }
}