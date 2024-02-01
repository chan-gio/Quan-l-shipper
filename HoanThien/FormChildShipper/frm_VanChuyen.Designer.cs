namespace HoanThien.FormChildShipper
{
    partial class frm_VanChuyen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_donhangdanhan = new System.Windows.Forms.Label();
            this.btn_dagiao = new QuanLyShipper.RJControls.RJLogin();
            this.btn_huydon = new QuanLyShipper.RJControls.RJLogin();
            this.btn_chitietdonhang = new QuanLyShipper.RJControls.RJLogin();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 573);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(969, 466);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_dagiao);
            this.panel6.Controls.Add(this.btn_huydon);
            this.panel6.Controls.Add(this.btn_chitietdonhang);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 519);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 54);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.lbl_donhangdanhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(970, 50);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_donhangdanhan
            // 
            this.lbl_donhangdanhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_donhangdanhan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donhangdanhan.Location = new System.Drawing.Point(0, 0);
            this.lbl_donhangdanhan.Name = "lbl_donhangdanhan";
            this.lbl_donhangdanhan.Size = new System.Drawing.Size(970, 50);
            this.lbl_donhangdanhan.TabIndex = 1;
            this.lbl_donhangdanhan.Text = "Đơn hàng đã nhận";
            this.lbl_donhangdanhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_donhangdanhan.Click += new System.EventHandler(this.lbl_donhangdanhan_Click);
            // 
            // btn_dagiao
            // 
            this.btn_dagiao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dagiao.BackColor = System.Drawing.Color.Lavender;
            this.btn_dagiao.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_dagiao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dagiao.BorderRadius = 10;
            this.btn_dagiao.BorderSize = 0;
            this.btn_dagiao.FlatAppearance.BorderSize = 0;
            this.btn_dagiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dagiao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dagiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dagiao.Location = new System.Drawing.Point(162, 6);
            this.btn_dagiao.Name = "btn_dagiao";
            this.btn_dagiao.Size = new System.Drawing.Size(150, 40);
            this.btn_dagiao.TabIndex = 3;
            this.btn_dagiao.Text = "Đã Giao";
            this.btn_dagiao.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dagiao.UseVisualStyleBackColor = false;
            this.btn_dagiao.Click += new System.EventHandler(this.btn_dagiao_Click);
            // 
            // btn_huydon
            // 
            this.btn_huydon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huydon.BackColor = System.Drawing.Color.Lavender;
            this.btn_huydon.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_huydon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_huydon.BorderRadius = 10;
            this.btn_huydon.BorderSize = 0;
            this.btn_huydon.FlatAppearance.BorderSize = 0;
            this.btn_huydon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huydon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huydon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huydon.Location = new System.Drawing.Point(808, 6);
            this.btn_huydon.Name = "btn_huydon";
            this.btn_huydon.Size = new System.Drawing.Size(150, 40);
            this.btn_huydon.TabIndex = 2;
            this.btn_huydon.Text = "Hủy đơn";
            this.btn_huydon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huydon.UseVisualStyleBackColor = false;
            this.btn_huydon.Click += new System.EventHandler(this.btn_huydon_Click_1);
            this.btn_huydon.Resize += new System.EventHandler(this.btn_huydon_Resize);
            // 
            // btn_chitietdonhang
            // 
            this.btn_chitietdonhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chitietdonhang.BackColor = System.Drawing.Color.Lavender;
            this.btn_chitietdonhang.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_chitietdonhang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_chitietdonhang.BorderRadius = 10;
            this.btn_chitietdonhang.BorderSize = 0;
            this.btn_chitietdonhang.FlatAppearance.BorderSize = 0;
            this.btn_chitietdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chitietdonhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitietdonhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_chitietdonhang.Location = new System.Drawing.Point(6, 6);
            this.btn_chitietdonhang.Name = "btn_chitietdonhang";
            this.btn_chitietdonhang.Size = new System.Drawing.Size(150, 40);
            this.btn_chitietdonhang.TabIndex = 1;
            this.btn_chitietdonhang.Text = "Chi tiết đơn hàng";
            this.btn_chitietdonhang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_chitietdonhang.UseVisualStyleBackColor = false;
            this.btn_chitietdonhang.Click += new System.EventHandler(this.btn_chitietdonhang_Click);
            // 
            // frm_VanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 573);
            this.Controls.Add(this.panel2);
            this.Name = "frm_VanChuyen";
            this.Text = "Vận chuyển ";
            this.Load += new System.EventHandler(this.frm_VanChuyen_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_donhangdanhan;
        private QuanLyShipper.RJControls.RJLogin btn_huydon;
        private QuanLyShipper.RJControls.RJLogin btn_chitietdonhang;
        private QuanLyShipper.RJControls.RJLogin btn_dagiao;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}