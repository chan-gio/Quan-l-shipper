using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace HoanThien.Forms
{
    public partial class FormPBShipper : Form
    {
        private string connectionString = "Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True";
        private GMapOverlay markersOverlay;
        private Random random = new Random();

        public FormPBShipper()
        {
            InitializeComponent();
            markersOverlay = new GMapOverlay("markers");
            gmap.Overlays.Add(markersOverlay);
        }

        private void FormPBShipper_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<MapMarker> mapMarkers = GetMapMarkers();

                foreach (MapMarker marker in mapMarkers)
                {
                    cboDiaDiem.Items.Add(marker.MaSP);
                }

                connection.Close();
            }

            gmap.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            PointLatLng haNoi = new PointLatLng(21.0285, 105.8542);
            gmap.Position = haNoi;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 18;
            gmap.Zoom = 10;
            mapContainer.Controls.Add(gmap);
            gmap.Dock = DockStyle.Fill;

            mapContainer.SizeChanged += (s, args) =>
            {
                gmap.Size = mapContainer.Size;
            };

            markersOverlay = new GMapOverlay("markers");
            gmap.Overlays.Add(markersOverlay);

            // Hiển thị marker ngẫu nhiên trên bản đồ
            RandomizeMarkers();
        }

        private void RandomizeMarkers()
        {
            // Xóa các marker cũ
            markersOverlay.Markers.Clear();

            // Lấy danh sách MaSP từ cơ sở dữ liệu
            List<string> maSPList = GetMaSPList();

            foreach (string maSPValue in maSPList)
            {
                double randomizedLat = 21.0285 + (random.NextDouble() - 0.5) * 0.1;
                double randomizedLng = 105.8542 + (random.NextDouble() - 0.5) * 0.1;

                MapMarker marker = new MapMarker(randomizedLat, randomizedLng, maSPValue);
                GMarkerGoogle gMarker = new GMarkerGoogle(new PointLatLng(marker.Latitude, marker.Longitude), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(gMarker);
            }

            // Đặt lại tâm và zoom cho bản đồ
            gmap.ZoomAndCenterMarkers("markers");
            gmap.Zoom = 15;
        }

        public class MapMarker
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string MaSP { get; set; }

            public MapMarker(double latitude, double longitude, string maSP)
            {
                Latitude = latitude;
                Longitude = longitude;
                MaSP = maSP;
            }
        }

        private List<string> GetMaSPList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                List<string> maSPList = new List<string>();

                string query = "SELECT MaSP FROM Shipper";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maSPValue = reader["MaSP"].ToString();
                            maSPList.Add(maSPValue);
                        }
                    }
                }

                return maSPList;
            }
        }

        private void btnXemViTri_Click(object sender, EventArgs e)
        {
            string selectedMaSP = cboDiaDiem.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedMaSP))
            {
                markersOverlay.Markers.Clear();

                List<MapMarker> mapMarkers = GetMapMarkers(selectedMaSP);

                foreach (MapMarker marker in mapMarkers)
                {
                    GMarkerGoogle gMarker = new GMarkerGoogle(new PointLatLng(marker.Latitude, marker.Longitude), GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(gMarker);
                }

                gmap.ZoomAndCenterMarkers("markers");
                gmap.Zoom = 15;
            }
        }

        private List<MapMarker> GetMapMarkers(string maSP = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                List<MapMarker> mapMarkers = new List<MapMarker>();

                string query = "SELECT MaSP FROM Shipper";

                if (!string.IsNullOrEmpty(maSP))
                {
                    query += " WHERE MaSP = @MaSP";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(maSP))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maSPValue = reader["MaSP"].ToString();
                            double randomizedLat = 21.0285 + (random.NextDouble() - 0.5) * 0.1;
                            double randomizedLng = 105.8542 + (random.NextDouble() - 0.5) * 0.1;

                            MapMarker marker = new MapMarker(randomizedLat, randomizedLng, maSPValue);
                            mapMarkers.Add(marker);
                        }
                    }
                }

                return mapMarkers;
            }
        }
    }
}
