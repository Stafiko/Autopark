namespace AutoparkWindow
{
    partial class RouteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DistanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.BeginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ маршрута";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(127, 12);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(151, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // DepartureTextBox
            // 
            this.DepartureTextBox.Location = new System.Drawing.Point(127, 38);
            this.DepartureTextBox.Name = "DepartureTextBox";
            this.DepartureTextBox.Size = new System.Drawing.Size(151, 20);
            this.DepartureTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пункт отправления";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(127, 64);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(151, 20);
            this.DestinationTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пункт назначения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Расстояние (км)";
            // 
            // DistanceNumeric
            // 
            this.DistanceNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DistanceNumeric.Location = new System.Drawing.Point(127, 90);
            this.DistanceNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DistanceNumeric.Name = "DistanceNumeric";
            this.DistanceNumeric.Size = new System.Drawing.Size(151, 20);
            this.DistanceNumeric.TabIndex = 7;
            // 
            // BeginDatePicker
            // 
            this.BeginDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BeginDatePicker.Location = new System.Drawing.Point(292, 24);
            this.BeginDatePicker.Name = "BeginDatePicker";
            this.BeginDatePicker.Size = new System.Drawing.Size(148, 20);
            this.BeginDatePicker.TabIndex = 8;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndDatePicker.Location = new System.Drawing.Point(292, 90);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(148, 20);
            this.EndDatePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время отправления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Время прибытия";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 128);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 35);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(305, 128);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(139, 35);
            this.NoButton.TabIndex = 13;
            this.NoButton.Text = "Отмена";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(160, 128);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(139, 35);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 170);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.BeginDatePicker);
            this.Controls.Add(this.DistanceNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepartureTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление маршрута";
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox DepartureTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown DistanceNumeric;
        public System.Windows.Forms.DateTimePicker BeginDatePicker;
        public System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button NoButton;
        public System.Windows.Forms.Button SaveButton;
    }
}