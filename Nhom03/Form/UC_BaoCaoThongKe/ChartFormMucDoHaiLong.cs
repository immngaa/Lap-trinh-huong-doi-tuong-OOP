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
	public partial class ChartFormMucDoHaiLong : Form
	{

		public ChartFormMucDoHaiLong(int rating1, int rating2, int rating3, int rating4, int rating5)
		{
			InitializeComponent();
			ShowChart(rating1, rating2, rating3, rating4, rating5);
		}

		private void ShowChart(int rating1, int rating2, int rating3, int rating4, int rating5)
		{
			// Clear any existing series
			chartMucDoHL.Series.Clear();

			// Create a new series for the chart
			Series series = new Series("Ratings")
			{
				ChartType = SeriesChartType.Column, // Set chart type to column
				IsValueShownAsLabel = true, // Display value on top of each column
				Color = Color.CornflowerBlue // Set column color
			};

			// Add points to the series for each rating
			series.Points.AddXY("1 Sao", rating1);
			series.Points.AddXY("2 Sao", rating2);
			series.Points.AddXY("3 Sao", rating3);
			series.Points.AddXY("4 Sao", rating4);
			series.Points.AddXY("5 Sao", rating5);

			// Add the series to the chart
			chartMucDoHL.Series.Add(series);

			// Customize chart appearance
			chartMucDoHL.ChartAreas[0].AxisX.Title = "Mức độ đánh giá";
			chartMucDoHL.ChartAreas[0].AxisY.Title = "Số lượng đánh giá";

			foreach (DataPoint point in series.Points)
			{
				point.Font = new Font("Arial", 12, FontStyle.Regular);
			}

			// Customize font for X and Y axis labels
			chartMucDoHL.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
			chartMucDoHL.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
			// Disable gridlines on both X and Y axes
			chartMucDoHL.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
			chartMucDoHL.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
			chartMucDoHL.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
			chartMucDoHL.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
		}
	}
}