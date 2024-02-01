namespace HoanThien.Forms
{
    partial class FormQLHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.btnThongKe = new QuanLyShipper.RJControls.RJLogin();
            this.btnLoc = new QuanLyShipper.RJControls.RJLogin();
            this.btnReset = new QuanLyShipper.RJControls.RJLogin();
            this.rjPanel4 = new QuanLyShipper.RJControls.RJPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.rjPanel3 = new QuanLyShipper.RJControls.RJPanel();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DGVDonHang = new System.Windows.Forms.DataGridView();
            this.rjPanel2 = new QuanLyShipper.RJControls.RJPanel();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.rjPanel5 = new QuanLyShipper.RJControls.RJPanel();
            this.cmbMaSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new QuanLyShipper.RJControls.RJLogin();
            this.btn_Sua = new QuanLyShipper.RJControls.RJLogin();
            this.panel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDonHang)).BeginInit();
            this.rjPanel2.SuspendLayout();
            this.rjPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.rjPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 571);
            this.panel1.TabIndex = 0;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 20;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.btnThongKe);
            this.rjPanel1.Controls.Add(this.btnLoc);
            this.rjPanel1.Controls.Add(this.btnReset);
            this.rjPanel1.Controls.Add(this.rjPanel4);
            this.rjPanel1.Controls.Add(this.label9);
            this.rjPanel1.Controls.Add(this.rjPanel3);
            this.rjPanel1.Controls.Add(this.btn_Xoa);
            this.rjPanel1.Controls.Add(this.btn_Sua);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(1, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(962, 568);
            this.rjPanel1.TabIndex = 0;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThongKe.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnThongKe.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongKe.BorderRadius = 10;
            this.btnThongKe.BorderSize = 0;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(802, 124);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(150, 40);
            this.btnThongKe.TabIndex = 30;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextColor = System.Drawing.Color.White;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoc.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnLoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoc.BorderRadius = 10;
            this.btnLoc.BorderSize = 0;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(802, 200);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(150, 40);
            this.btnLoc.TabIndex = 29;
            this.btnLoc.Text = "Lọc Đơn";
            this.btnLoc.TextColor = System.Drawing.Color.White;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 10;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(802, 413);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel4.BorderRadius = 0;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.ForeColor = System.Drawing.Color.White;
            this.rjPanel4.Location = new System.Drawing.Point(798, 43);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(150, 6);
            this.rjPanel4.TabIndex = 23;
            this.rjPanel4.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Quản Lý Hàng";
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel3.BorderColor = System.Drawing.Color.White;
            this.rjPanel3.BorderRadius = 20;
            this.rjPanel3.BorderSize = 3;
            this.rjPanel3.Controls.Add(this.chartThongKe);
            this.rjPanel3.Controls.Add(this.DGVDonHang);
            this.rjPanel3.Controls.Add(this.rjPanel2);
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.Location = new System.Drawing.Point(-1, 0);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(788, 565);
            this.rjPanel3.TabIndex = 21;
            this.rjPanel3.TextColor = System.Drawing.Color.White;
            // 
            // chartThongKe
            // 
            this.chartThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(4, 347);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(781, 215);
            this.chartThongKe.TabIndex = 30;
            this.chartThongKe.Text = "ThongKe";
            // 
            // DGVDonHang
            // 
            this.DGVDonHang.AllowUserToAddRows = false;
            this.DGVDonHang.AllowUserToDeleteRows = false;
            this.DGVDonHang.AllowUserToResizeColumns = false;
            this.DGVDonHang.AllowUserToResizeRows = false;
            this.DGVDonHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.DGVDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDonHang.ColumnHeadersHeight = 35;
            this.DGVDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDonHang.EnableHeadersVisualStyles = false;
            this.DGVDonHang.Location = new System.Drawing.Point(3, 77);
            this.DGVDonHang.Name = "DGVDonHang";
            this.DGVDonHang.ReadOnly = true;
            this.DGVDonHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDonHang.RowHeadersVisible = false;
            this.DGVDonHang.RowHeadersWidth = 30;
            this.DGVDonHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVDonHang.RowTemplate.DividerHeight = 2;
            this.DGVDonHang.RowTemplate.Height = 20;
            this.DGVDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDonHang.Size = new System.Drawing.Size(782, 264);
            this.DGVDonHang.TabIndex = 6;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel2.BorderColor = System.Drawing.Color.White;
            this.rjPanel2.BorderRadius = 20;
            this.rjPanel2.BorderSize = 3;
            this.rjPanel2.Controls.Add(this.cmbTinhTrang);
            this.rjPanel2.Controls.Add(this.cmbLoaiHang);
            this.rjPanel2.Controls.Add(this.rjPanel5);
            this.rjPanel2.Controls.Add(this.label5);
            this.rjPanel2.Controls.Add(this.label2);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(788, 79);
            this.rjPanel2.TabIndex = 5;
            this.rjPanel2.TextColor = System.Drawing.Color.White;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(194, 8);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(135, 21);
            this.cmbTinhTrang.TabIndex = 28;
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(522, 9);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(135, 21);
            this.cmbLoaiHang.TabIndex = 27;
            // 
            // rjPanel5
            // 
            this.rjPanel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel5.BorderColor = System.Drawing.Color.White;
            this.rjPanel5.BorderRadius = 15;
            this.rjPanel5.BorderSize = 3;
            this.rjPanel5.Controls.Add(this.cmbMaSP);
            this.rjPanel5.Controls.Add(this.label3);
            this.rjPanel5.Controls.Add(this.cmbMaKH);
            this.rjPanel5.Controls.Add(this.label1);
            this.rjPanel5.ForeColor = System.Drawing.Color.White;
            this.rjPanel5.Location = new System.Drawing.Point(0, 35);
            this.rjPanel5.Name = "rjPanel5";
            this.rjPanel5.Size = new System.Drawing.Size(788, 45);
            this.rjPanel5.TabIndex = 21;
            this.rjPanel5.TextColor = System.Drawing.Color.White;
            // 
            // cmbMaSP
            // 
            this.cmbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSP.FormattingEnabled = true;
            this.cmbMaSP.Location = new System.Drawing.Point(522, 12);
            this.cmbMaSP.Name = "cmbMaSP";
            this.cmbMaSP.Size = new System.Drawing.Size(135, 21);
            this.cmbMaSP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Shipper";
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(194, 12);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(135, 21);
            this.cmbMaKH.TabIndex = 5;
            this.cmbMaKH.SelectedIndexChanged += new System.EventHandler(this.cmbMaKH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tình Trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại Hàng";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.Red;
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(802, 347);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(150, 40);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Lime;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.Lime;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 10;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(802, 279);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(150, 40);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // FormQLHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 571);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLHang";
            this.Text = "Quản Lý Hàng";
            this.Load += new System.EventHandler(this.FormQLHang_Load_1);
            this.panel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.rjPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDonHang)).EndInit();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel5.ResumeLayout(false);
            this.rjPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private QuanLyShipper.RJControls.RJPanel rjPanel3;
        private QuanLyShipper.RJControls.RJLogin btn_Xoa;
        private QuanLyShipper.RJControls.RJLogin btn_Sua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private QuanLyShipper.RJControls.RJPanel rjPanel2;
        private System.Windows.Forms.DataGridView DGVDonHang;
        private QuanLyShipper.RJControls.RJPanel rjPanel4;
        private QuanLyShipper.RJControls.RJLogin btnReset;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private QuanLyShipper.RJControls.RJLogin btnLoc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private QuanLyShipper.RJControls.RJLogin btnThongKe;
        private QuanLyShipper.RJControls.RJPanel rjPanel5;
        private System.Windows.Forms.ComboBox cmbMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.Label label1;
    }
}