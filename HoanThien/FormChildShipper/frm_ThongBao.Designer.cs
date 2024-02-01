namespace HoanThien.FormChildShipper
{
    partial class frm_ThongBao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_donhangdagiaothanhcong = new System.Windows.Forms.Label();
            this.DonHangDaGiao_dgv = new System.Windows.Forms.DataGridView();
            this.btn_KiemTra = new QuanLyShipper.RJControls.RJLogin();
            this.Thang_cbbox = new QuanLyShipper.RJControls.RJComboBox();
            this.Nam_cb = new QuanLyShipper.RJControls.RJComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangDaGiao_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.lbl_donhangdagiaothanhcong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 50);
            this.panel4.TabIndex = 1;
            // 
            // lbl_donhangdagiaothanhcong
            // 
            this.lbl_donhangdagiaothanhcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_donhangdagiaothanhcong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donhangdagiaothanhcong.Location = new System.Drawing.Point(0, 0);
            this.lbl_donhangdagiaothanhcong.Name = "lbl_donhangdagiaothanhcong";
            this.lbl_donhangdagiaothanhcong.Size = new System.Drawing.Size(800, 50);
            this.lbl_donhangdagiaothanhcong.TabIndex = 1;
            this.lbl_donhangdagiaothanhcong.Text = "Đơn hàng đã giao thành công";
            this.lbl_donhangdagiaothanhcong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_donhangdagiaothanhcong.Click += new System.EventHandler(this.lbl_donhangdanhan_Click);
            // 
            // DonHangDaGiao_dgv
            // 
            this.DonHangDaGiao_dgv.AllowUserToAddRows = false;
            this.DonHangDaGiao_dgv.AllowUserToDeleteRows = false;
            this.DonHangDaGiao_dgv.AllowUserToResizeRows = false;
            this.DonHangDaGiao_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DonHangDaGiao_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DonHangDaGiao_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DonHangDaGiao_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DonHangDaGiao_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DonHangDaGiao_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.DonHangDaGiao_dgv.Location = new System.Drawing.Point(0, 50);
            this.DonHangDaGiao_dgv.Name = "DonHangDaGiao_dgv";
            this.DonHangDaGiao_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DonHangDaGiao_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DonHangDaGiao_dgv.RowHeadersWidth = 51;
            this.DonHangDaGiao_dgv.Size = new System.Drawing.Size(800, 277);
            this.DonHangDaGiao_dgv.TabIndex = 3;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_KiemTra.BackColor = System.Drawing.Color.Lavender;
            this.btn_KiemTra.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_KiemTra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_KiemTra.BorderRadius = 10;
            this.btn_KiemTra.BorderSize = 0;
            this.btn_KiemTra.FlatAppearance.BorderSize = 0;
            this.btn_KiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemTra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_KiemTra.Location = new System.Drawing.Point(36, 364);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(150, 40);
            this.btn_KiemTra.TabIndex = 4;
            this.btn_KiemTra.Text = "Kiểm tra đơn";
            this.btn_KiemTra.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_KiemTra.UseVisualStyleBackColor = false;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // Thang_cbbox
            // 
            this.Thang_cbbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Thang_cbbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Thang_cbbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Thang_cbbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Thang_cbbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Thang_cbbox.BorderSize = 1;
            this.Thang_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.Thang_cbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Thang_cbbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Thang_cbbox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Thang_cbbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Thang_cbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.Thang_cbbox.ListTextColor = System.Drawing.Color.Black;
            this.Thang_cbbox.Location = new System.Drawing.Point(226, 344);
            this.Thang_cbbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.Thang_cbbox.Name = "Thang_cbbox";
            this.Thang_cbbox.Padding = new System.Windows.Forms.Padding(1);
            this.Thang_cbbox.Size = new System.Drawing.Size(200, 30);
            this.Thang_cbbox.TabIndex = 13;
            this.Thang_cbbox.Texts = "Tháng";
            this.Thang_cbbox.UseWaitCursor = true;
            // 
            // Nam_cb
            // 
            this.Nam_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nam_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Nam_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Nam_cb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nam_cb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Nam_cb.BorderSize = 1;
            this.Nam_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.Nam_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nam_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Nam_cb.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Nam_cb.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.Nam_cb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.Nam_cb.ListTextColor = System.Drawing.Color.Black;
            this.Nam_cb.Location = new System.Drawing.Point(226, 392);
            this.Nam_cb.MinimumSize = new System.Drawing.Size(200, 30);
            this.Nam_cb.Name = "Nam_cb";
            this.Nam_cb.Padding = new System.Windows.Forms.Padding(1);
            this.Nam_cb.Size = new System.Drawing.Size(200, 30);
            this.Nam_cb.TabIndex = 14;
            this.Nam_cb.Texts = "Năm";
            this.Nam_cb.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.Nam_cb);
            this.panel2.Controls.Add(this.Thang_cbbox);
            this.panel2.Controls.Add(this.btn_KiemTra);
            this.panel2.Controls.Add(this.DonHangDaGiao_dgv);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 2;
            // 
            // frm_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "frm_ThongBao";
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.frm_ThongBao_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DonHangDaGiao_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_donhangdagiaothanhcong;
        private System.Windows.Forms.DataGridView DonHangDaGiao_dgv;
        private QuanLyShipper.RJControls.RJLogin btn_KiemTra;
        private QuanLyShipper.RJControls.RJComboBox Thang_cbbox;
        private QuanLyShipper.RJControls.RJComboBox Nam_cb;
        private System.Windows.Forms.Panel panel2;
    }
}