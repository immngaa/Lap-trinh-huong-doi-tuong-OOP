using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom03
{
	public partial class ChartFormHieuSuatNV : Form
	{
		private DataTable _dataTable;

		public ChartFormHieuSuatNV(DataTable dataTable)
		{
			InitializeComponent();
			_dataTable = dataTable;
			ShowChart();
		}

		private void ShowChart()
		{
			// Clear any existing series
			chartHieuSuatNV.Series.Clear();

			// Create a new series for the chart
			Series series = new Series("Performance")
			{
				ChartType = SeriesChartType.Column, // Set chart type to column
				IsValueShownAsLabel = true, // Show values on top of each column
				Color = Color.CornflowerBlue // Set column color
			};

			// Loop through the DataTable and add points to the series
			foreach (DataRow row in _dataTable.Rows)
			{
				string employeeName = row["TenNhanVien"].ToString();
				int performanceCount = Convert.ToInt32(row["SoLanTuVan"]);

				// Add the employee name and performance count to the chart
				series.Points.AddXY(employeeName, performanceCount);
			}

			// Add the series to the chart
			chartHieuSuatNV.Series.Add(series);

			// Customize chart appearance
			chartHieuSuatNV.ChartAreas[0].AxisX.Title = "Nhân viên";
			chartHieuSuatNV.ChartAreas[0].AxisY.Title = "Số lần tư vấn";

			// Customize font for X and Y axis labels
			chartHieuSuatNV.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
			chartHieuSuatNV.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);

			// Disable gridlines on both X and Y axes
			chartHieuSuatNV.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
			chartHieuSuatNV.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
			chartHieuSuatNV.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
			chartHieuSuatNV.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
		}
	}
}
