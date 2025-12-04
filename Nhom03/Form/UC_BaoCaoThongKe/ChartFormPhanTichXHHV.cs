using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom03
{
    public partial class ChartFormPhanTichXHHV : Form
    {
        private readonly DataTable _dt;  // Biến lưu DataTable được truyền vào từ form chính

        // Constructor nhận DataTable từ form chính
        public ChartFormPhanTichXHHV(DataTable dataTable)
        {
            InitializeComponent();
            _dt = dataTable;  // Lưu DataTable vào biến _dt
            ShowChart();  // Gọi phương thức ShowChart để vẽ biểu đồ
        }

        private void ShowChart()
        {
            // Kiểm tra xem có dữ liệu không
            if (_dt == null || _dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xóa các series cũ trong biểu đồ
            chartXuHuongMH.Series.Clear();

            // Tạo ChartArea nếu chưa có
            if (chartXuHuongMH.ChartAreas.Count == 0)
            {
                chartXuHuongMH.ChartAreas.Add(new ChartArea("ChartArea1"));
            }

            // Tạo hai Series cho khách hàng thân thiết và khách hàng tiềm năng
            Series seriesKhachHangThanThiet = new Series("Khách hàng thân thiết")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true // Hiển thị giá trị lên cột
            };

            Series seriesKhachHangTiemNang = new Series("Khách hàng tiềm năng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true // Hiển thị giá trị lên cột
            };

            // Dictionary để lưu dữ liệu tổng cho mỗi thương hiệu
            var thuongHieuDict = new Dictionary<string, (int khachHangThanThiet, int khachHangTiemNang)>();

            try
            {
                // Duyệt qua DataTable và lưu số liệu vào dictionary
                foreach (DataRow row in _dt.Rows)
                {
                    string thuongHieu = row["Tên thương hiệu"]?.ToString()?.Trim(); // Tên thương hiệu
                    string nhomKH = row["TenNhomKH"]?.ToString()?.Trim(); // Nhóm khách hàng (Thân thiết hoặc Tiềm năng)
                    int soLuong = Convert.ToInt32(row["Tổng số lượng sản phẩm"]); // Tổng số lượng sản phẩm

                    // Nếu thương hiệu chưa có trong dictionary, khởi tạo với giá trị 0 cho cả hai nhóm
                    if (!thuongHieuDict.ContainsKey(thuongHieu))
                    {
                        thuongHieuDict[thuongHieu] = (0, 0); // (Khách hàng thân thiết, Khách hàng tiềm năng)
                    }

                    // Cập nhật số lượng cho nhóm khách hàng tương ứng
                    if (nhomKH == "Khách hàng thân thiết")
                    {
                        thuongHieuDict[thuongHieu] = (
                            thuongHieuDict[thuongHieu].khachHangThanThiet + soLuong,
                            thuongHieuDict[thuongHieu].khachHangTiemNang
                        );
                    }
                    else if (nhomKH == "Khách hàng tiềm năng")
                    {
                        thuongHieuDict[thuongHieu] = (
                            thuongHieuDict[thuongHieu].khachHangThanThiet,
                            thuongHieuDict[thuongHieu].khachHangTiemNang + soLuong
                        );
                    }
                }

                // Thêm điểm dữ liệu vào các series từ dictionary
                foreach (var item in thuongHieuDict)
                {
                    string thuongHieu = item.Key;
                    int soLuongKhachHangThanThiet = item.Value.khachHangThanThiet;
                    int soLuongKhachHangTiemNang = item.Value.khachHangTiemNang;

                    // Thêm dữ liệu vào các series
                    seriesKhachHangThanThiet.Points.AddXY(thuongHieu, soLuongKhachHangThanThiet);
                    seriesKhachHangTiemNang.Points.AddXY(thuongHieu, soLuongKhachHangTiemNang);
                }

                // Thêm các series vào biểu đồ
                chartXuHuongMH.Series.Add(seriesKhachHangThanThiet);
                chartXuHuongMH.Series.Add(seriesKhachHangTiemNang);

                // Cấu hình các trục X, Y của biểu đồ
                chartXuHuongMH.ChartAreas[0].AxisX.Title = "Thương hiệu";
                chartXuHuongMH.ChartAreas[0].AxisY.Title = "Tổng số lượng sản phẩm";

                // Cấu hình Font cho các nhãn trục X và Y
                chartXuHuongMH.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                chartXuHuongMH.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 12, FontStyle.Bold);

                // Tắt lưới cho trục X và Y
                chartXuHuongMH.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartXuHuongMH.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                chartXuHuongMH.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chartXuHuongMH.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
