namespace Nhom03
{
    partial class ChartFormHieuSuatNhanVien
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
            this.chartHieuSuatNV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHieuSuatNV)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHieuSuatNV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHieuSuatNV.ChartAreas.Add(chartArea1);
            this.chartHieuSuatNV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartHieuSuatNV.Legends.Add(legend1);
            this.chartHieuSuatNV.Location = new System.Drawing.Point(0, 0);
            this.chartHieuSuatNV.Name = "chartHieuSuatNV";
            this.chartHieuSuatNV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHieuSuatNV.Series.Add(series1);
            this.chartHieuSuatNV.Size = new System.Drawing.Size(1150, 689);
            this.chartHieuSuatNV.TabIndex = 1;
            this.chartHieuSuatNV.Text = "chartHieuSuatNV";
            title1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.IndianRed;
            title1.Name = "chartHieuSuatNV";
            title1.Text = "Hiệu suất nhân viên";
            this.chartHieuSuatNV.Titles.Add(title1);
            // 
            // ChartFormHieuSuatNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 689);
            this.Controls.Add(this.chartHieuSuatNV);
            this.Name = "ChartFormHieuSuatNhanVien";
            this.Text = "ChartFormHieuSuatNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.chartHieuSuatNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHieuSuatNV;
    }
}