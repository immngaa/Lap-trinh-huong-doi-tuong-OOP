using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom03
{
    public partial class UC_KhieuNaiCuaKH : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

        public UC_KhieuNaiCuaKH()
        {
            InitializeComponent();
            LoadData();
            btnTimKiem.Click += BtnTimKiem_Click;
            btnHienThiBieuDo.Click += BtnHienThiBieuDo_Click;
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM khieunai"; // Thay "khuyenmai" bằng tên bảng thực tế
                DataTable dt = ketNoi.ExecuteQuery(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu Khiếu Nại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã khuyến mãi cần tìm từ TextBox
                string query = $"SELECT * FROM khieunai WHERE TinhTrang = '{txtTimKiem.Text}'";

                // Sử dụng phương thức ExecuteQuery từ KetNoiCSDL
                DataTable dt = ketNoi.ExecuteQuery(query);

                // Kiểm tra kết quả
                if (dt.Rows.Count > 0)
                {
                    // Gán dữ liệu vào DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    // Thông báo nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hiển thị biểu đồ cột: Số lượng khiếu nại theo tháng
        private void ShowBarChart()
        {
            try
            {
                string query = "SELECT MONTH(NgayKhieuNai) AS Thang, COUNT(*) AS SoLuong FROM khieunai GROUP BY MONTH(NgayKhieuNai)";
                DataTable dt = ketNoi.ExecuteQuery(query); // Lấy dữ liệu từ cơ sở dữ liệu

                chart1.Series.Clear(); // Xóa dữ liệu cũ trên biểu đồ
                chart1.ChartAreas.Clear(); // Xóa các vùng hiển thị cũ
                chart1.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Default"));

                var series = chart1.Series.Add("Số lượng khiếu nại theo tháng");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY($"Tháng {row["Thang"]}", row["SoLuong"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị biểu đồ cột: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hiển thị biểu đồ tròn: Tỷ lệ phần trăm khiếu nại theo tình trạng
        private void ShowPieChart()
        {
            try
            {
                string query = "SELECT TinhTrang, COUNT(*) AS SoLuong FROM khieunai GROUP BY TinhTrang";
                DataTable dt = ketNoi.ExecuteQuery(query); // Lấy dữ liệu từ cơ sở dữ liệu

                chart2.Series.Clear(); // Xóa dữ liệu cũ trên biểu đồ
                chart2.ChartAreas.Clear(); // Xóa các vùng hiển thị cũ
                chart2.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Default"));

                var series = chart2.Series.Add("Tỷ lệ tình trạng khiếu nại");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY($"{row["TinhTrang"]} ({row["SoLuong"]})", row["SoLuong"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị biểu đồ tròn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Gọi hiển thị biểu đồ sau khi tải dữ liệu
        private void BtnHienThiBieuDo_Click(object sender, EventArgs e)
        {
            ShowBarChart();
            ShowPieChart();
        }
    }
}
