namespace HoanThien.Forms
{
    partial class FormChinhSuaDonHang
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
            this.lblTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblDiaChiNhanHang = new System.Windows.Forms.Label();
            this.txtDiaChiNhanHang = new System.Windows.Forms.TextBox();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnLuu = new QuanLyShipper.RJControls.RJLogin();
            this.btnHuy = new QuanLyShipper.RJControls.RJLogin();
            this.SuspendLayout();
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.Location = new System.Drawing.Point(12, 76);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(62, 15);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên Hàng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(135, 73);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(200, 20);
            this.txtTenHang.TabIndex = 1;
            // 
            // lblDiaChiNhanHang
            // 
            this.lblDiaChiNhanHang.AutoSize = true;
            this.lblDiaChiNhanHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiNhanHang.Location = new System.Drawing.Point(12, 102);
            this.lblDiaChiNhanHang.Name = "lblDiaChiNhanHang";
            this.lblDiaChiNhanHang.Size = new System.Drawing.Size(107, 15);
            this.lblDiaChiNhanHang.TabIndex = 2;
            this.lblDiaChiNhanHang.Text = "Địa chỉ nhận hàng:";
            // 
            // txtDiaChiNhanHang
            // 
            this.txtDiaChiNhanHang.Location = new System.Drawing.Point(135, 99);
            this.txtDiaChiNhanHang.Name = "txtDiaChiNhanHang";
            this.txtDiaChiNhanHang.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChiNhanHang.TabIndex = 3;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(135, 21);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(200, 20);
            this.txtMaDon.TabIndex = 6;
            this.txtMaDon.TextChanged += new System.EventHandler(this.txtMaDon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(135, 47);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(200, 20);
            this.txtMaSP.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(34, 151);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 34);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(221, 151);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 34);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            
            // 
            // FormChinhSuaDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(399, 218);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDon);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiaChiNhanHang);
            this.Controls.Add(this.lblDiaChiNhanHang);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.lblTenHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChinhSuaDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Đơn Hàng";
            this.Load += new System.EventHandler(this.FormChinhSuaDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblDiaChiNhanHang;
        private System.Windows.Forms.TextBox txtDiaChiNhanHang;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private QuanLyShipper.RJControls.RJLogin btnLuu;
        private QuanLyShipper.RJControls.RJLogin btnHuy;
    }
}
