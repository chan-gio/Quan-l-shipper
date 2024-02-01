namespace HoanThien.Forms
{
    partial class FormPBShipper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.btnXemViTri = new QuanLyShipper.RJControls.RJLogin();
            this.cboDiaDiem = new System.Windows.Forms.ComboBox();
            this.lblCenterCoordinates = new System.Windows.Forms.Label();
            this.mapContainer = new System.Windows.Forms.Panel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.mapContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.rjPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 571);
            this.panel1.TabIndex = 1;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 20;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.btnXemViTri);
            this.rjPanel1.Controls.Add(this.cboDiaDiem);
            this.rjPanel1.Controls.Add(this.lblCenterCoordinates);
            this.rjPanel1.Controls.Add(this.mapContainer);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(-1, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(966, 565);
            this.rjPanel1.TabIndex = 0;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnXemViTri
            // 
            this.btnXemViTri.BackColor = System.Drawing.Color.Aqua;
            this.btnXemViTri.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnXemViTri.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnXemViTri.BorderRadius = 8;
            this.btnXemViTri.BorderSize = 3;
            this.btnXemViTri.FlatAppearance.BorderSize = 0;
            this.btnXemViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemViTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXemViTri.Location = new System.Drawing.Point(682, 106);
            this.btnXemViTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemViTri.Name = "btnXemViTri";
            this.btnXemViTri.Size = new System.Drawing.Size(133, 37);
            this.btnXemViTri.TabIndex = 47;
            this.btnXemViTri.Text = "Xem vị trí ";
            this.btnXemViTri.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXemViTri.UseVisualStyleBackColor = false;
            this.btnXemViTri.Click += new System.EventHandler(this.btnXemViTri_Click);
            // 
            // cboDiaDiem
            // 
            this.cboDiaDiem.FormattingEnabled = true;
            this.cboDiaDiem.Location = new System.Drawing.Point(382, 24);
            this.cboDiaDiem.Name = "cboDiaDiem";
            this.cboDiaDiem.Size = new System.Drawing.Size(197, 21);
            this.cboDiaDiem.TabIndex = 11;

            // 
            // lblCenterCoordinates
            // 
            this.lblCenterCoordinates.AutoSize = true;
            this.lblCenterCoordinates.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterCoordinates.Location = new System.Drawing.Point(664, 13);
            this.lblCenterCoordinates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCenterCoordinates.Name = "lblCenterCoordinates";
            this.lblCenterCoordinates.Size = new System.Drawing.Size(126, 19);
            this.lblCenterCoordinates.TabIndex = 8;
            this.lblCenterCoordinates.Text = "Tọa độ trung tâm";
            // 
            // mapContainer
            // 
            this.mapContainer.Controls.Add(this.gmap);
            this.mapContainer.Location = new System.Drawing.Point(22, 52);
            this.mapContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapContainer.Name = "mapContainer";
            this.mapContainer.Size = new System.Drawing.Size(575, 493);
            this.mapContainer.TabIndex = 7;
            this.mapContainer.SizeChanged += new System.EventHandler(this.FormPBShipper_Load);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(7, 127);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(514, 229);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            // 
            // FormPBShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 571);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPBShipper";
            this.Text = "Phân bổ Shipper";
            this.Load += new System.EventHandler(this.FormPBShipper_Load);
            this.panel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.mapContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Panel mapContainer;
        private System.Windows.Forms.Label lblCenterCoordinates;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ComboBox cboDiaDiem;
        private QuanLyShipper.RJControls.RJLogin btnXemViTri;
    }
}