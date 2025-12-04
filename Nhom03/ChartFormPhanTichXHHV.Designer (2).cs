namespace Nhom03
{
	partial class ChartFormPhanTichXHHV
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
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chartXuHuongMH = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartXuHuongMH)).BeginInit();
			this.SuspendLayout();
			// 
			// chartXuHuongMH
			// 
			chartArea1.Name = "ChartArea1";
			this.chartXuHuongMH.ChartAreas.Add(chartArea1);
			this.chartXuHuongMH.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chartXuHuongMH.Legends.Add(legend1);
			this.chartXuHuongMH.Location = new System.Drawing.Point(0, 0);
			this.chartXuHuongMH.Name = "chartXuHuongMH";
			this.chartXuHuongMH.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "khách hàng thân thiết";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "khách hàng tiềm năng";
			this.chartXuHuongMH.Series.Add(series1);
			this.chartXuHuongMH.Series.Add(series2);
			this.chartXuHuongMH.Size = new System.Drawing.Size(1393, 795);
			this.chartXuHuongMH.TabIndex = 0;
			this.chartXuHuongMH.Text = "chartXuHuongMH";
			title1.Font = new System.Drawing.Font("Verdana", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title1.Name = "chartXuHuongMH";
			title1.Text = "Xu hướng mua hàng của khách hàng";
			this.chartXuHuongMH.Titles.Add(title1);
			// 
			// ChartFormPhanTichXHHV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1393, 795);
			this.Controls.Add(this.chartXuHuongMH);
			this.Name = "ChartFormPhanTichXHHV";
			this.Text = "Biểu đồ phân tích xu hướng hành vi mua sắm của KH";
			((System.ComponentModel.ISupportInitialize)(this.chartXuHuongMH)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartXuHuongMH;
	}
}