using System;
using System.Windows.Forms;

namespace HoanThien.Forms
{
    partial class FormQLShipper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.rjPanel4 = new QuanLyShipper.RJControls.RJPanel();
            this.PnlTimKiem = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new QuanLyShipper.RJControls.RJLogin();
            this.PnlAdd = new QuanLyShipper.RJControls.RJPanel();
            this.DGVShipper = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLuu = new QuanLyShipper.RJControls.RJLogin();
            this.btnHuy = new QuanLyShipper.RJControls.RJLogin();
            this.rjPanel2 = new QuanLyShipper.RJControls.RJPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlDiaChi = new System.Windows.Forms.Panel();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.PnlTaiKhoan = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlCCCD = new System.Windows.Forms.Panel();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlSDT = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.PnlTenSP = new System.Windows.Forms.Panel();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new QuanLyShipper.RJControls.RJLogin();
            this.btnSua = new QuanLyShipper.RJControls.RJLogin();
            this.btnThem = new QuanLyShipper.RJControls.RJLogin();
            this.panel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.PnlTimKiem.SuspendLayout();
            this.PnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShipper)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlDiaChi.SuspendLayout();
            this.PnlTaiKhoan.SuspendLayout();
            this.PnlCCCD.SuspendLayout();
            this.PnlSDT.SuspendLayout();
            this.PnlTenSP.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 20;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.rjPanel4);
            this.rjPanel1.Controls.Add(this.PnlTimKiem);
            this.rjPanel1.Controls.Add(this.btnSearch);
            this.rjPanel1.Controls.Add(this.PnlAdd);
            this.rjPanel1.Controls.Add(this.label9);
            this.rjPanel1.Controls.Add(this.btnXoa);
            this.rjPanel1.Controls.Add(this.btnSua);
            this.rjPanel1.Controls.Add(this.btnThem);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(1, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(965, 565);
            this.rjPanel1.TabIndex = 0;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel4.BorderRadius = 0;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.ForeColor = System.Drawing.Color.White;
            this.rjPanel4.Location = new System.Drawing.Point(35, 39);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(180, 5);
            this.rjPanel4.TabIndex = 24;
            this.rjPanel4.TextColor = System.Drawing.Color.White;
            // 
            // PnlTimKiem
            // 
            this.PnlTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlTimKiem.Controls.Add(this.txtSearch);
            this.PnlTimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlTimKiem.Location = new System.Drawing.Point(526, 18);
            this.PnlTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTimKiem.Name = "PnlTimKiem";
            this.PnlTimKiem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlTimKiem.Size = new System.Drawing.Size(311, 26);
            this.PnlTimKiem.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BackgroundImage = global::HoanThien.Properties.Resources.v;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 17;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(844, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PnlAdd
            // 
            this.PnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PnlAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PnlAdd.BorderColor = System.Drawing.Color.White;
            this.PnlAdd.BorderRadius = 0;
            this.PnlAdd.BorderSize = 3;
            this.PnlAdd.Controls.Add(this.DGVShipper);
            this.PnlAdd.Controls.Add(this.panel4);
            this.PnlAdd.Controls.Add(this.label7);
            this.PnlAdd.Controls.Add(this.panel3);
            this.PnlAdd.Controls.Add(this.panel2);
            this.PnlAdd.Controls.Add(this.btnLuu);
            this.PnlAdd.Controls.Add(this.btnHuy);
            this.PnlAdd.Controls.Add(this.rjPanel2);
            this.PnlAdd.Controls.Add(this.lblTitle);
            this.PnlAdd.Controls.Add(this.label6);
            this.PnlAdd.Controls.Add(this.label5);
            this.PnlAdd.Controls.Add(this.label4);
            this.PnlAdd.Controls.Add(this.PnlDiaChi);
            this.PnlAdd.Controls.Add(this.PnlTaiKhoan);
            this.PnlAdd.Controls.Add(this.label3);
            this.PnlAdd.Controls.Add(this.PnlCCCD);
            this.PnlAdd.Controls.Add(this.label2);
            this.PnlAdd.Controls.Add(this.PnlSDT);
            this.PnlAdd.Controls.Add(this.label1);
            this.PnlAdd.Controls.Add(this.lblTenSP);
            this.PnlAdd.Controls.Add(this.PnlTenSP);
            this.PnlAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlAdd.ForeColor = System.Drawing.Color.White;
            this.PnlAdd.Location = new System.Drawing.Point(-1, 56);
            this.PnlAdd.Margin = new System.Windows.Forms.Padding(0);
            this.PnlAdd.Name = "PnlAdd";
            this.PnlAdd.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PnlAdd.Size = new System.Drawing.Size(965, 437);
            this.PnlAdd.TabIndex = 16;
            this.PnlAdd.TextColor = System.Drawing.Color.White;
            this.PnlAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlAdd_Paint);
            // 
            // DGVShipper
            // 
            this.DGVShipper.AllowUserToAddRows = false;
            this.DGVShipper.AllowUserToDeleteRows = false;
            this.DGVShipper.AllowUserToResizeColumns = false;
            this.DGVShipper.AllowUserToResizeRows = false;
            this.DGVShipper.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.DGVShipper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVShipper.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVShipper.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShipper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShipper.ColumnHeadersHeight = 35;
            this.DGVShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShipper.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShipper.EnableHeadersVisualStyles = false;
            this.DGVShipper.Location = new System.Drawing.Point(8, 4);
            this.DGVShipper.Margin = new System.Windows.Forms.Padding(2);
            this.DGVShipper.Name = "DGVShipper";
            this.DGVShipper.ReadOnly = true;
            this.DGVShipper.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVShipper.RowHeadersVisible = false;
            this.DGVShipper.RowHeadersWidth = 30;
            this.DGVShipper.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVShipper.RowTemplate.DividerHeight = 2;
            this.DGVShipper.RowTemplate.Height = 20;
            this.DGVShipper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVShipper.Size = new System.Drawing.Size(947, 431);
            this.DGVShipper.TabIndex = 0;
            this.DGVShipper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVShipper_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.txtDiaChi);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(642, 172);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel4.Size = new System.Drawing.Size(230, 25);
            this.panel4.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(0, 0);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 21);
            this.txtDiaChi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Địa Chỉ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(642, 303);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel3.Size = new System.Drawing.Size(230, 25);
            this.panel3.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(0, 0);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(230, 23);
            this.txtMatKhau.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(642, 234);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel2.Size = new System.Drawing.Size(230, 25);
            this.panel2.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(0, 0);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(273, 381);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 35);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(545, 381);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 35);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel2.BorderRadius = 0;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(183, 69);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(630, 5);
            this.rjPanel2.TabIndex = 14;
            this.rjPanel2.TextColor = System.Drawing.Color.White;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(399, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 32);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Bổ Sung Shipper";
            this.lblTitle.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Shipper";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // PnlDiaChi
            // 
            this.PnlDiaChi.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlDiaChi.Controls.Add(this.txtMaSP);
            this.PnlDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlDiaChi.Location = new System.Drawing.Point(181, 114);
            this.PnlDiaChi.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDiaChi.Name = "PnlDiaChi";
            this.PnlDiaChi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlDiaChi.Size = new System.Drawing.Size(230, 25);
            this.PnlDiaChi.TabIndex = 3;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMaSP.Location = new System.Drawing.Point(0, 0);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(230, 23);
            this.txtMaSP.TabIndex = 0;
            // 
            // PnlTaiKhoan
            // 
            this.PnlTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlTaiKhoan.Controls.Add(this.txtEmail);
            this.PnlTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlTaiKhoan.Location = new System.Drawing.Point(642, 111);
            this.PnlTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTaiKhoan.Name = "PnlTaiKhoan";
            this.PnlTaiKhoan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlTaiKhoan.Size = new System.Drawing.Size(230, 25);
            this.PnlTaiKhoan.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CCCD";
            // 
            // PnlCCCD
            // 
            this.PnlCCCD.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlCCCD.Controls.Add(this.txtCCCD);
            this.PnlCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlCCCD.Location = new System.Drawing.Point(181, 234);
            this.PnlCCCD.Margin = new System.Windows.Forms.Padding(0);
            this.PnlCCCD.Name = "PnlCCCD";
            this.PnlCCCD.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlCCCD.Size = new System.Drawing.Size(230, 25);
            this.PnlCCCD.TabIndex = 7;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(0, 0);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(230, 23);
            this.txtCCCD.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số ĐT";
            // 
            // PnlSDT
            // 
            this.PnlSDT.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSDT.Controls.Add(this.txtSDT);
            this.PnlSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlSDT.Location = new System.Drawing.Point(181, 302);
            this.PnlSDT.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSDT.Name = "PnlSDT";
            this.PnlSDT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlSDT.Size = new System.Drawing.Size(230, 25);
            this.PnlSDT.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(0, 0);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(230, 23);
            this.txtSDT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(80, 177);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(91, 20);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên Shipper";
            // 
            // PnlTenSP
            // 
            this.PnlTenSP.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlTenSP.Controls.Add(this.txtTenSP);
            this.PnlTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnlTenSP.Location = new System.Drawing.Point(181, 174);
            this.PnlTenSP.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTenSP.Name = "PnlTenSP";
            this.PnlTenSP.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PnlTenSP.Size = new System.Drawing.Size(230, 25);
            this.PnlTenSP.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(0, 0);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(230, 23);
            this.txtTenSP.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quản Lý Shipper";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Lavender;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnXoa.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderSize = 4;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(604, 513);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Lavender;
            this.btnSua.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnSua.BorderColor = System.Drawing.Color.Aqua;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 4;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Location = new System.Drawing.Point(410, 513);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lavender;
            this.btnThem.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnThem.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 4;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(211, 513);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormQLShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 571);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLShipper";
            this.Text = "Quản lý Shipper";
            this.Load += new System.EventHandler(this.FormQLShipper_Load);
            this.panel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.PnlTimKiem.ResumeLayout(false);
            this.PnlTimKiem.PerformLayout();
            this.PnlAdd.ResumeLayout(false);
            this.PnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShipper)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlDiaChi.ResumeLayout(false);
            this.PnlDiaChi.PerformLayout();
            this.PnlTaiKhoan.ResumeLayout(false);
            this.PnlTaiKhoan.PerformLayout();
            this.PnlCCCD.ResumeLayout(false);
            this.PnlCCCD.PerformLayout();
            this.PnlSDT.ResumeLayout(false);
            this.PnlSDT.PerformLayout();
            this.PnlTenSP.ResumeLayout(false);
            this.PnlTenSP.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PnlAdd_Paint(object sender, PaintEventArgs e)
        {
        }

        private void DGVShipper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLyShipper.RJControls.RJLogin btnXoa;
        private QuanLyShipper.RJControls.RJLogin btnSua;
        private QuanLyShipper.RJControls.RJLogin btnThem;
        private QuanLyShipper.RJControls.RJPanel PnlAdd;
        private System.Windows.Forms.DataGridView DGVShipper;
        private System.Windows.Forms.Label label9;
        private QuanLyShipper.RJControls.RJLogin btnSearch;
        private System.Windows.Forms.Panel PnlTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlDiaChi;
        private System.Windows.Forms.Panel PnlTaiKhoan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTitle;
        private QuanLyShipper.RJControls.RJPanel rjPanel2;
        private QuanLyShipper.RJControls.RJLogin btnLuu;
        private QuanLyShipper.RJControls.RJLogin btnHuy;
        private Panel PnlTimKiem;
        private TextBox txtSearch;
        private Panel panel3;
        private TextBox txtMatKhau;
        private Panel panel2;
        private TextBox txtUsername;
        private DataGridViewTextBoxColumn maSP;
        private TextBox txtMaSP;
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private Label label7;
        private Panel panel4;
        private TextBox txtDiaChi;
        private QuanLyShipper.RJControls.RJPanel rjPanel4;
    }
}