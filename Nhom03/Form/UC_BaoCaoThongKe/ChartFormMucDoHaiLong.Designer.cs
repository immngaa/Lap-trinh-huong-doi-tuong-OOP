namespace Nhom03
{
	partial class ChartFormMucDoHaiLong
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMucDoHL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMucDoHL)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMucDoHL
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMucDoHL.ChartAreas.Add(chartArea1);
            this.chartMucDoHL.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartMucDoHL.Legends.Add(legend1);
            this.chartMucDoHL.Location = new System.Drawing.Point(0, 0);
            this.chartMucDoHL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartMucDoHL.Name = "chartMucDoHL";
            this.chartMucDoHL.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "chartMucDoHL";
            this.chartMucDoHL.Series.Add(series1);
            this.chartMucDoHL.Size = new System.Drawing.Size(904, 629);
            this.chartMucDoHL.TabIndex = 258;
            this.chartMucDoHL.Text = "chartMucDoHL";
            title1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.Navy;
            title1.Name = "chartMucDoHL";
            title1.Text = "Mức độ hài lòng của khách hàng";
            this.chartMucDoHL.Titles.Add(title1);
            // 
            // ChartFormMucDoHaiLong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 629);
            this.Controls.Add(this.chartMucDoHL);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartFormMucDoHaiLong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ mức độ hài lòng của khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.chartMucDoHL)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartMucDoHL;
	}
}