namespace Lab2
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.encryptedTextChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedTextChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(563, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный текст";
            // 
            // textChart
            // 
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.Name = "ChartArea1";
            this.textChart.ChartAreas.Add(chartArea1);
            this.textChart.Location = new System.Drawing.Point(16, 44);
            this.textChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textChart.Name = "textChart";
            this.textChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.Maroon;
            series1.Name = "Series1";
            this.textChart.Series.Add(series1);
            this.textChart.Size = new System.Drawing.Size(1247, 215);
            this.textChart.TabIndex = 1;
            this.textChart.Text = "chart1";
            // 
            // encryptedTextChart
            // 
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.CursorX.LineColor = System.Drawing.Color.DarkRed;
            chartArea2.Name = "ChartArea1";
            this.encryptedTextChart.ChartAreas.Add(chartArea2);
            this.encryptedTextChart.Location = new System.Drawing.Point(16, 324);
            this.encryptedTextChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encryptedTextChart.Name = "encryptedTextChart";
            this.encryptedTextChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.LabelForeColor = System.Drawing.Color.Maroon;
            series2.Name = "Series1";
            this.encryptedTextChart.Series.Add(series2);
            this.encryptedTextChart.Size = new System.Drawing.Size(1247, 215);
            this.encryptedTextChart.TabIndex = 2;
            this.encryptedTextChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(517, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зашифрованный текст";
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1279, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptedTextChart);
            this.Controls.Add(this.textChart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Graphs";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.textChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedTextChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart textChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart encryptedTextChart;
        private System.Windows.Forms.Label label2;
    }
}