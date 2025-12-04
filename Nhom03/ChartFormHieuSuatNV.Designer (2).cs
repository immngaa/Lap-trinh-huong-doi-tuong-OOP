namespace Nhom03
{
	partial class ChartFormHieuSuatNV
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chartHieuSuatNV = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartHieuSuatNV)).BeginInit();
			this.SuspendLayout();
			// 
			// chartHieuSuatNV
			// 
			chartArea2.Name = "ChartArea1";
			this.chartHieuSuatNV.ChartAreas.Add(chartArea2);
			this.chartHieuSuatNV.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.chartHieuSuatNV.Legends.Add(legend2);
			this.chartHieuSuatNV.Location = new System.Drawing.Point(0, 0);
			this.chartHieuSuatNV.Name = "chartHieuSuatNV";
			this.chartHieuSuatNV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartHieuSuatNV.Series.Add(series2);
			this.chartHieuSuatNV.Size = new System.Drawing.Size(1176, 760);
			this.chartHieuSuatNV.TabIndex = 0;
			this.chartHieuSuatNV.Text = "chartHieuSuatNV";
			title2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
			title2.ForeColor = System.Drawing.Color.IndianRed;
			title2.Name = "chartHieuSuatNV";
			title2.Text = "Hiệu suất nhân viên";
			this.chartHieuSuatNV.Titles.Add(title2);
			// 
			// ChartFormHieuSuatNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 760);
			this.Controls.Add(this.chartHieuSuatNV);
			this.Name = "ChartFormHieuSuatNV";
			this.Text = "ChartFormHieuSuatNV";
			((System.ComponentModel.ISupportInitialize)(this.chartHieuSuatNV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartHieuSuatNV;
	}
}