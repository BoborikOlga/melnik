namespace models_01
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.IntervalsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpectancyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RatioTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AperiodicTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(12, 43);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 22);
            this.ATextBox.TabIndex = 2;
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(142, 43);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(100, 22);
            this.RTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "R0:";
            // 
            // MTextBox
            // 
            this.MTextBox.Location = new System.Drawing.Point(274, 43);
            this.MTextBox.Name = "MTextBox";
            this.MTextBox.Size = new System.Drawing.Size(100, 22);
            this.MTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "m:";
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(12, 133);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frequencies";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(1279, 387);
            this.Graph.TabIndex = 7;
            this.Graph.Text = "Graph";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 83);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(87, 23);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // IntervalsTextBox
            // 
            this.IntervalsTextBox.Location = new System.Drawing.Point(411, 43);
            this.IntervalsTextBox.Name = "IntervalsTextBox";
            this.IntervalsTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntervalsTextBox.TabIndex = 10;
            this.IntervalsTextBox.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Intervals:";
            // 
            // DTextBox
            // 
            this.DTextBox.Location = new System.Drawing.Point(683, 43);
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.Size = new System.Drawing.Size(100, 22);
            this.DTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "D:";
            // 
            // ExpectancyTextBox
            // 
            this.ExpectancyTextBox.Location = new System.Drawing.Point(802, 43);
            this.ExpectancyTextBox.Name = "ExpectancyTextBox";
            this.ExpectancyTextBox.Size = new System.Drawing.Size(100, 22);
            this.ExpectancyTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "M:";
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Location = new System.Drawing.Point(918, 43);
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.Size = new System.Drawing.Size(100, 22);
            this.AverageTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(915, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Average:";
            // 
            // RatioTextBox
            // 
            this.RatioTextBox.Location = new System.Drawing.Point(683, 93);
            this.RatioTextBox.Name = "RatioTextBox";
            this.RatioTextBox.Size = new System.Drawing.Size(100, 22);
            this.RatioTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "2K/N:";
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Location = new System.Drawing.Point(802, 93);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(100, 22);
            this.PeriodTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Period:";
            // 
            // AperiodicTextBox
            // 
            this.AperiodicTextBox.Location = new System.Drawing.Point(918, 93);
            this.AperiodicTextBox.Name = "AperiodicTextBox";
            this.AperiodicTextBox.Size = new System.Drawing.Size(100, 22);
            this.AperiodicTextBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(915, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Aperiodic:";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(542, 43);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(100, 22);
            this.CountTextBox.TabIndex = 24;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(539, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Count:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 532);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AperiodicTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RatioTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AverageTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExpectancyTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IntervalsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.MTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Models 1-2";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.TextBox IntervalsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExpectancyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RatioTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AperiodicTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label11;
    }
}

