namespace AutoparkWindow
{
    partial class TicketForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.PassportTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PassengerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscountCheck = new System.Windows.Forms.CheckBox();
            this.BuyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.PlaceNumeric = new System.Windows.Forms.NumericUpDown();
            this.PriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
            // 
            // PassportTextBox
            // 
            this.PassportTextBox.Location = new System.Drawing.Point(12, 143);
            this.PassportTextBox.Name = "PassportTextBox";
            this.PassportTextBox.Size = new System.Drawing.Size(218, 20);
            this.PassportTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Паспорт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата покупки";
            // 
            // PassengerTextBox
            // 
            this.PassengerTextBox.Location = new System.Drawing.Point(12, 104);
            this.PassengerTextBox.Name = "PassengerTextBox";
            this.PassengerTextBox.Size = new System.Drawing.Size(218, 20);
            this.PassengerTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ф.И.О. пассажира";
            // 
            // DiscountCheck
            // 
            this.DiscountCheck.AutoSize = true;
            this.DiscountCheck.Location = new System.Drawing.Point(12, 169);
            this.DiscountCheck.Name = "DiscountCheck";
            this.DiscountCheck.Size = new System.Drawing.Size(64, 17);
            this.DiscountCheck.TabIndex = 10;
            this.DiscountCheck.Text = "Льготы";
            this.DiscountCheck.UseVisualStyleBackColor = true;
            // 
            // BuyDatePicker
            // 
            this.BuyDatePicker.CustomFormat = "MM.dd.yyyy (dddd) | HH:mm";
            this.BuyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BuyDatePicker.Location = new System.Drawing.Point(12, 65);
            this.BuyDatePicker.Name = "BuyDatePicker";
            this.BuyDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BuyDatePicker.Size = new System.Drawing.Size(218, 20);
            this.BuyDatePicker.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 192);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(218, 24);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(12, 252);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(218, 24);
            this.NoButton.TabIndex = 13;
            this.NoButton.Text = "Отмена";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // PlaceNumeric
            // 
            this.PlaceNumeric.Location = new System.Drawing.Point(13, 25);
            this.PlaceNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlaceNumeric.Name = "PlaceNumeric";
            this.PlaceNumeric.Size = new System.Drawing.Size(98, 20);
            this.PlaceNumeric.TabIndex = 14;
            this.PlaceNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PriceNumeric
            // 
            this.PriceNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PriceNumeric.Location = new System.Drawing.Point(132, 25);
            this.PriceNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceNumeric.Name = "PriceNumeric";
            this.PriceNumeric.Size = new System.Drawing.Size(98, 20);
            this.PriceNumeric.TabIndex = 15;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(12, 222);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(218, 24);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 283);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceNumeric);
            this.Controls.Add(this.PlaceNumeric);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BuyDatePicker);
            this.Controls.Add(this.DiscountCheck);
            this.Controls.Add(this.PassengerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassportTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Билеты";
            ((System.ComponentModel.ISupportInitialize)(this.PlaceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PassportTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox PassengerTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox DiscountCheck;
        public System.Windows.Forms.DateTimePicker BuyDatePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button NoButton;
        public System.Windows.Forms.NumericUpDown PlaceNumeric;
        public System.Windows.Forms.NumericUpDown PriceNumeric;
        public System.Windows.Forms.Button SaveButton;
    }
}