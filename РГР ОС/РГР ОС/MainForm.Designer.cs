namespace РГР_ОС
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
            this.ProducerGroupBox = new System.Windows.Forms.GroupBox();
            this.ProducerListView = new System.Windows.Forms.ListView();
            this.BufferSizeLabel = new System.Windows.Forms.Label();
            this.BufferSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConsumerGroupBox = new System.Windows.Forms.GroupBox();
            this.ConsumerListView = new System.Windows.Forms.ListView();
            this.StartButton = new System.Windows.Forms.Button();
            this.BufferLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.ProducerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BufferSizeNumericUpDown)).BeginInit();
            this.ConsumerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProducerGroupBox
            // 
            this.ProducerGroupBox.Controls.Add(this.ProducerListView);
            this.ProducerGroupBox.Location = new System.Drawing.Point(14, 14);
            this.ProducerGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProducerGroupBox.Name = "ProducerGroupBox";
            this.ProducerGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProducerGroupBox.Size = new System.Drawing.Size(390, 484);
            this.ProducerGroupBox.TabIndex = 0;
            this.ProducerGroupBox.TabStop = false;
            this.ProducerGroupBox.Text = "Производитель";
            // 
            // ProducerListView
            // 
            this.ProducerListView.HideSelection = false;
            this.ProducerListView.Location = new System.Drawing.Point(8, 35);
            this.ProducerListView.Name = "ProducerListView";
            this.ProducerListView.Size = new System.Drawing.Size(377, 441);
            this.ProducerListView.TabIndex = 0;
            this.ProducerListView.UseCompatibleStateImageBehavior = false;
            this.ProducerListView.View = System.Windows.Forms.View.List;
            // 
            // BufferSizeLabel
            // 
            this.BufferSizeLabel.AutoSize = true;
            this.BufferSizeLabel.Location = new System.Drawing.Point(14, 569);
            this.BufferSizeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BufferSizeLabel.Name = "BufferSizeLabel";
            this.BufferSizeLabel.Size = new System.Drawing.Size(293, 29);
            this.BufferSizeLabel.TabIndex = 1;
            this.BufferSizeLabel.Text = "Введите размер буфера";
            // 
            // BufferSizeNumericUpDown
            // 
            this.BufferSizeNumericUpDown.Location = new System.Drawing.Point(315, 569);
            this.BufferSizeNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BufferSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BufferSizeNumericUpDown.Name = "BufferSizeNumericUpDown";
            this.BufferSizeNumericUpDown.Size = new System.Drawing.Size(56, 34);
            this.BufferSizeNumericUpDown.TabIndex = 2;
            this.BufferSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ConsumerGroupBox
            // 
            this.ConsumerGroupBox.Controls.Add(this.ConsumerListView);
            this.ConsumerGroupBox.Location = new System.Drawing.Point(414, 14);
            this.ConsumerGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.ConsumerGroupBox.Name = "ConsumerGroupBox";
            this.ConsumerGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ConsumerGroupBox.Size = new System.Drawing.Size(396, 484);
            this.ConsumerGroupBox.TabIndex = 3;
            this.ConsumerGroupBox.TabStop = false;
            this.ConsumerGroupBox.Text = "Потребитель";
            // 
            // ConsumerListView
            // 
            this.ConsumerListView.HideSelection = false;
            this.ConsumerListView.Location = new System.Drawing.Point(8, 35);
            this.ConsumerListView.Name = "ConsumerListView";
            this.ConsumerListView.Size = new System.Drawing.Size(377, 441);
            this.ConsumerListView.TabIndex = 0;
            this.ConsumerListView.UseCompatibleStateImageBehavior = false;
            this.ConsumerListView.View = System.Windows.Forms.View.List;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(641, 556);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(169, 54);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BufferLabel
            // 
            this.BufferLabel.AutoSize = true;
            this.BufferLabel.Location = new System.Drawing.Point(14, 503);
            this.BufferLabel.Name = "BufferLabel";
            this.BufferLabel.Size = new System.Drawing.Size(267, 29);
            this.BufferLabel.TabIndex = 5;
            this.BufferLabel.Text = "Содержимое буфера: ";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(460, 556);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(169, 54);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Остановить";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 614);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.BufferLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ConsumerGroupBox);
            this.Controls.Add(this.BufferSizeNumericUpDown);
            this.Controls.Add(this.BufferSizeLabel);
            this.Controls.Add(this.ProducerGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 661);
            this.MinimumSize = new System.Drawing.Size(842, 661);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ProducerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BufferSizeNumericUpDown)).EndInit();
            this.ConsumerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProducerGroupBox;
        private System.Windows.Forms.ListView ProducerListView;
        private System.Windows.Forms.Label BufferSizeLabel;
        private System.Windows.Forms.NumericUpDown BufferSizeNumericUpDown;
        private System.Windows.Forms.GroupBox ConsumerGroupBox;
        private System.Windows.Forms.ListView ConsumerListView;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label BufferLabel;
        private System.Windows.Forms.Button StopButton;
    }
}

