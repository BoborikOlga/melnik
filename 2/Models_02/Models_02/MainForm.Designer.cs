namespace Models_02
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
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpectancyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlgComboBox = new System.Windows.Forms.ComboBox();
            this.MTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SigmaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Location = new System.Drawing.Point(918, 31);
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.Size = new System.Drawing.Size(100, 22);
            this.AverageTextBox.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(915, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Average:";
            // 
            // ExpectancyTextBox
            // 
            this.ExpectancyTextBox.Location = new System.Drawing.Point(802, 31);
            this.ExpectancyTextBox.Name = "ExpectancyTextBox";
            this.ExpectancyTextBox.Size = new System.Drawing.Size(100, 22);
            this.ExpectancyTextBox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "M:";
            // 
            // DTextBox
            // 
            this.DTextBox.Location = new System.Drawing.Point(683, 31);
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.Size = new System.Drawing.Size(100, 22);
            this.DTextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "D:";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 123);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(87, 23);
            this.GenerateButton.TabIndex = 29;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(274, 31);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 22);
            this.NTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "n:";
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(142, 31);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(100, 22);
            this.BTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "b:";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(12, 31);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 22);
            this.ATextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "a:";
            // 
            // AlgComboBox
            // 
            this.AlgComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgComboBox.FormattingEnabled = true;
            this.AlgComboBox.Location = new System.Drawing.Point(421, 31);
            this.AlgComboBox.Name = "AlgComboBox";
            this.AlgComboBox.Size = new System.Drawing.Size(231, 24);
            this.AlgComboBox.TabIndex = 38;
            // 
            // MTextBox
            // 
            this.MTextBox.Location = new System.Drawing.Point(142, 81);
            this.MTextBox.Name = "MTextBox";
            this.MTextBox.Size = new System.Drawing.Size(100, 22);
            this.MTextBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "m:";
            // 
            // SigmaTextBox
            // 
            this.SigmaTextBox.Location = new System.Drawing.Point(12, 81);
            this.SigmaTextBox.Name = "SigmaTextBox";
            this.SigmaTextBox.Size = new System.Drawing.Size(100, 22);
            this.SigmaTextBox.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sigma:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 511);
            this.Controls.Add(this.MTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SigmaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AlgComboBox);
            this.Controls.Add(this.AverageTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExpectancyTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Task 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExpectancyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AlgComboBox;
        private System.Windows.Forms.TextBox MTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SigmaTextBox;
        private System.Windows.Forms.Label label8;
    }
}

