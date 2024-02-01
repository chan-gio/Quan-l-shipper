namespace HoanThien.FormChildShipper
{
    partial class frm_QuenMK
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
            this.pnl_BGdoiMK = new System.Windows.Forms.Panel();
            this.LoaiTK_cbbox = new QuanLyShipper.RJControls.RJComboBox();
            this.lbl_nhaplaimkmoi = new QuanLyShipper.RJControls.RJLogin();
            this.txt_quenemail = new QuanLyShipper.RJControls.RJButton();
            this.lbl_mkmoi = new QuanLyShipper.RJControls.RJLogin();
            this.txt_quensdt = new QuanLyShipper.RJControls.RJButton();
            this.lbl_mkcu = new QuanLyShipper.RJControls.RJLogin();
            this.txt_quentaikhoan = new QuanLyShipper.RJControls.RJButton();
            this.btn_xacnhanquenmk = new QuanLyShipper.RJControls.RJLogin();
            this.pnl_BGdoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BGdoiMK
            // 
            this.pnl_BGdoiMK.BackColor = System.Drawing.Color.MediumPurple;
            this.pnl_BGdoiMK.Controls.Add(this.LoaiTK_cbbox);
            this.pnl_BGdoiMK.Controls.Add(this.lbl_nhaplaimkmoi);
            this.pnl_BGdoiMK.Controls.Add(this.txt_quenemail);
            this.pnl_BGdoiMK.Controls.Add(this.lbl_mkmoi);
            this.pnl_BGdoiMK.Controls.Add(this.txt_quensdt);
            this.pnl_BGdoiMK.Controls.Add(this.lbl_mkcu);
            this.pnl_BGdoiMK.Controls.Add(this.txt_quentaikhoan);
            this.pnl_BGdoiMK.Controls.Add(this.btn_xacnhanquenmk);
            this.pnl_BGdoiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BGdoiMK.Location = new System.Drawing.Point(0, 0);
            this.pnl_BGdoiMK.Name = "pnl_BGdoiMK";
            this.pnl_BGdoiMK.Size = new System.Drawing.Size(284, 385);
            this.pnl_BGdoiMK.TabIndex = 2;
            // 
            // LoaiTK_cbbox
            // 
            this.LoaiTK_cbbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LoaiTK_cbbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LoaiTK_cbbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoaiTK_cbbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LoaiTK_cbbox.BorderSize = 1;
            this.LoaiTK_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.LoaiTK_cbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoaiTK_cbbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoaiTK_cbbox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.LoaiTK_cbbox.Items.AddRange(new object[] {
            "Shipper",
            "KhachHang"});
            this.LoaiTK_cbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.LoaiTK_cbbox.ListTextColor = System.Drawing.Color.Black;
            this.LoaiTK_cbbox.Location = new System.Drawing.Point(46, 28);
            this.LoaiTK_cbbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.LoaiTK_cbbox.Name = "LoaiTK_cbbox";
            this.LoaiTK_cbbox.Padding = new System.Windows.Forms.Padding(1);
            this.LoaiTK_cbbox.Size = new System.Drawing.Size(200, 30);
            this.LoaiTK_cbbox.TabIndex = 35;
            this.LoaiTK_cbbox.Texts = "Loại Tài Khoản";
            this.LoaiTK_cbbox.UseWaitCursor = true;
            // 
            // lbl_nhaplaimkmoi
            // 
            this.lbl_nhaplaimkmoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nhaplaimkmoi.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_nhaplaimkmoi.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.lbl_nhaplaimkmoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_nhaplaimkmoi.BorderRadius = 0;
            this.lbl_nhaplaimkmoi.BorderSize = 0;
            this.lbl_nhaplaimkmoi.FlatAppearance.BorderSize = 0;
            this.lbl_nhaplaimkmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nhaplaimkmoi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhaplaimkmoi.ForeColor = System.Drawing.Color.White;
            this.lbl_nhaplaimkmoi.Location = new System.Drawing.Point(21, 229);
            this.lbl_nhaplaimkmoi.Name = "lbl_nhaplaimkmoi";
            this.lbl_nhaplaimkmoi.Size = new System.Drawing.Size(195, 26);
            this.lbl_nhaplaimkmoi.TabIndex = 34;
            this.lbl_nhaplaimkmoi.Text = "Email:";
            this.lbl_nhaplaimkmoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_nhaplaimkmoi.TextColor = System.Drawing.Color.White;
            this.lbl_nhaplaimkmoi.UseVisualStyleBackColor = false;
            // 
            // txt_quenemail
            // 
            this.txt_quenemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quenemail.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_quenemail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_quenemail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_quenemail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_quenemail.BorderRadius = 15;
            this.txt_quenemail.BorderSize = 3;
            this.txt_quenemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quenemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_quenemail.Location = new System.Drawing.Point(21, 254);
            this.txt_quenemail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quenemail.Multiline = false;
            this.txt_quenemail.Name = "txt_quenemail";
            this.txt_quenemail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_quenemail.PasswordChar = false;
            this.txt_quenemail.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_quenemail.PlaceholderText = "Nhập Email";
            this.txt_quenemail.ReadOnly = false;
            this.txt_quenemail.Size = new System.Drawing.Size(250, 31);
            this.txt_quenemail.TabIndex = 33;
            this.txt_quenemail.Texts = "";
            this.txt_quenemail.UnderlinedStyle = false;
            // 
            // lbl_mkmoi
            // 
            this.lbl_mkmoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mkmoi.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkmoi.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkmoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_mkmoi.BorderRadius = 0;
            this.lbl_mkmoi.BorderSize = 0;
            this.lbl_mkmoi.FlatAppearance.BorderSize = 0;
            this.lbl_mkmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_mkmoi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkmoi.ForeColor = System.Drawing.Color.White;
            this.lbl_mkmoi.Location = new System.Drawing.Point(21, 161);
            this.lbl_mkmoi.Name = "lbl_mkmoi";
            this.lbl_mkmoi.Size = new System.Drawing.Size(150, 26);
            this.lbl_mkmoi.TabIndex = 32;
            this.lbl_mkmoi.Text = "SDT:";
            this.lbl_mkmoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mkmoi.TextColor = System.Drawing.Color.White;
            this.lbl_mkmoi.UseVisualStyleBackColor = false;
            // 
            // txt_quensdt
            // 
            this.txt_quensdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quensdt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_quensdt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_quensdt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_quensdt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_quensdt.BorderRadius = 15;
            this.txt_quensdt.BorderSize = 3;
            this.txt_quensdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quensdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_quensdt.Location = new System.Drawing.Point(21, 185);
            this.txt_quensdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quensdt.Multiline = false;
            this.txt_quensdt.Name = "txt_quensdt";
            this.txt_quensdt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_quensdt.PasswordChar = false;
            this.txt_quensdt.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_quensdt.PlaceholderText = "Nhập số điện thoại";
            this.txt_quensdt.ReadOnly = false;
            this.txt_quensdt.Size = new System.Drawing.Size(250, 31);
            this.txt_quensdt.TabIndex = 31;
            this.txt_quensdt.Texts = "";
            this.txt_quensdt.UnderlinedStyle = false;
            this.txt_quensdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quensdt_KeyPress);
            // 
            // lbl_mkcu
            // 
            this.lbl_mkcu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mkcu.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkcu.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkcu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_mkcu.BorderRadius = 0;
            this.lbl_mkcu.BorderSize = 0;
            this.lbl_mkcu.FlatAppearance.BorderSize = 0;
            this.lbl_mkcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_mkcu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkcu.ForeColor = System.Drawing.Color.White;
            this.lbl_mkcu.Location = new System.Drawing.Point(21, 99);
            this.lbl_mkcu.Name = "lbl_mkcu";
            this.lbl_mkcu.Size = new System.Drawing.Size(150, 26);
            this.lbl_mkcu.TabIndex = 29;
            this.lbl_mkcu.Text = "Tài khoản:";
            this.lbl_mkcu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mkcu.TextColor = System.Drawing.Color.White;
            this.lbl_mkcu.UseVisualStyleBackColor = false;
            // 
            // txt_quentaikhoan
            // 
            this.txt_quentaikhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quentaikhoan.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_quentaikhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_quentaikhoan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_quentaikhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_quentaikhoan.BorderRadius = 15;
            this.txt_quentaikhoan.BorderSize = 3;
            this.txt_quentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quentaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_quentaikhoan.Location = new System.Drawing.Point(21, 123);
            this.txt_quentaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quentaikhoan.Multiline = false;
            this.txt_quentaikhoan.Name = "txt_quentaikhoan";
            this.txt_quentaikhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_quentaikhoan.PasswordChar = false;
            this.txt_quentaikhoan.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_quentaikhoan.PlaceholderText = "Nhập tài khoản";
            this.txt_quentaikhoan.ReadOnly = false;
            this.txt_quentaikhoan.Size = new System.Drawing.Size(250, 31);
            this.txt_quentaikhoan.TabIndex = 25;
            this.txt_quentaikhoan.Texts = "";
            this.txt_quentaikhoan.UnderlinedStyle = false;
            // 
            // btn_xacnhanquenmk
            // 
            this.btn_xacnhanquenmk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_xacnhanquenmk.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_xacnhanquenmk.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_xacnhanquenmk.BorderColor = System.Drawing.Color.White;
            this.btn_xacnhanquenmk.BorderRadius = 15;
            this.btn_xacnhanquenmk.BorderSize = 0;
            this.btn_xacnhanquenmk.FlatAppearance.BorderSize = 0;
            this.btn_xacnhanquenmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhanquenmk.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhanquenmk.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhanquenmk.Location = new System.Drawing.Point(21, 322);
            this.btn_xacnhanquenmk.Name = "btn_xacnhanquenmk";
            this.btn_xacnhanquenmk.Size = new System.Drawing.Size(245, 30);
            this.btn_xacnhanquenmk.TabIndex = 27;
            this.btn_xacnhanquenmk.Text = "Xác nhận";
            this.btn_xacnhanquenmk.TextColor = System.Drawing.Color.White;
            this.btn_xacnhanquenmk.UseVisualStyleBackColor = false;
            this.btn_xacnhanquenmk.Click += new System.EventHandler(this.btn_xacnhanquenmk_Click);
            // 
            // frm_QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 385);
            this.Controls.Add(this.pnl_BGdoiMK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK";
            this.pnl_BGdoiMK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BGdoiMK;
        private QuanLyShipper.RJControls.RJLogin lbl_mkmoi;
        private QuanLyShipper.RJControls.RJButton txt_quensdt;
        private QuanLyShipper.RJControls.RJLogin lbl_mkcu;
        private QuanLyShipper.RJControls.RJButton txt_quentaikhoan;
        private QuanLyShipper.RJControls.RJLogin btn_xacnhanquenmk;
        private QuanLyShipper.RJControls.RJComboBox LoaiTK_cbbox;
        private QuanLyShipper.RJControls.RJLogin lbl_nhaplaimkmoi;
        private QuanLyShipper.RJControls.RJButton txt_quenemail;
    }
}