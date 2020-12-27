
namespace splain
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.drawingButton = new System.Windows.Forms.Button();
            this.splineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingButton
            // 
            this.drawingButton.Location = new System.Drawing.Point(26, 403);
            this.drawingButton.Name = "drawingButton";
            this.drawingButton.Size = new System.Drawing.Size(197, 46);
            this.drawingButton.TabIndex = 0;
            this.drawingButton.Text = "Построить сплайн";
            this.drawingButton.UseVisualStyleBackColor = true;
            this.drawingButton.Click += new System.EventHandler(this.drawingButton_Click);
            // 
            // splineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.splineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.splineChart.Legends.Add(legend1);
            this.splineChart.Location = new System.Drawing.Point(273, 37);
            this.splineChart.Name = "splineChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Сплайн";
            series1.Name = "splineSeries";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Соедененные точки";
            series2.Name = "Series2";
            this.splineChart.Series.Add(series1);
            this.splineChart.Series.Add(series2);
            this.splineChart.Size = new System.Drawing.Size(874, 546);
            this.splineChart.TabIndex = 1;
            this.splineChart.Text = "Spline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество точек в отрезке:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(26, 363);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(63, 22);
            this.numberTextBox.TabIndex = 3;
            this.numberTextBox.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 607);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splineChart);
            this.Controls.Add(this.drawingButton);
            this.Name = "Form1";
            this.Text = "Построение кубический сплайнов";
            ((System.ComponentModel.ISupportInitialize)(this.splineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawingButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart splineChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

