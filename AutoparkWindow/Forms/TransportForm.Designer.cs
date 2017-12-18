namespace AutoparkWindow
{
    partial class TransportForm
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
            this.TransportId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RouteButton = new System.Windows.Forms.Button();
            this.RouteTextBox = new System.Windows.Forms.TextBox();
            this.RouteComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DispatcherText = new System.Windows.Forms.TextBox();
            this.BusText = new System.Windows.Forms.TextBox();
            this.DriverText = new System.Windows.Forms.TextBox();
            this.TicketText = new System.Windows.Forms.TextBox();
            this.RouteText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TicketButton = new System.Windows.Forms.Button();
            this.TicketTextBox = new System.Windows.Forms.TextBox();
            this.TicketComboBox = new System.Windows.Forms.ComboBox();
            this.RouteData = new System.Windows.Forms.DataGridView();
            this.TicketData = new System.Windows.Forms.DataGridView();
            this.DriverData = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.BusData = new System.Windows.Forms.DataGridView();
            this.DispatcherData = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RouteData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispatcherData)).BeginInit();
            this.SuspendLayout();
            // 
            // TransportId
            // 
            this.TransportId.Location = new System.Drawing.Point(9, 51);
            this.TransportId.Name = "TransportId";
            this.TransportId.Size = new System.Drawing.Size(100, 20);
            this.TransportId.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RouteButton);
            this.groupBox1.Controls.Add(this.RouteTextBox);
            this.groupBox1.Controls.Add(this.RouteComboBox);
            this.groupBox1.Location = new System.Drawing.Point(135, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Маршрут";
            // 
            // RouteButton
            // 
            this.RouteButton.Location = new System.Drawing.Point(7, 94);
            this.RouteButton.Name = "RouteButton";
            this.RouteButton.Size = new System.Drawing.Size(156, 23);
            this.RouteButton.TabIndex = 2;
            this.RouteButton.Text = "Применить";
            this.RouteButton.UseVisualStyleBackColor = true;
            this.RouteButton.Click += new System.EventHandler(this.RouteButtonClick);
            // 
            // RouteTextBox
            // 
            this.RouteTextBox.Location = new System.Drawing.Point(7, 51);
            this.RouteTextBox.Name = "RouteTextBox";
            this.RouteTextBox.Size = new System.Drawing.Size(156, 20);
            this.RouteTextBox.TabIndex = 1;
            // 
            // RouteComboBox
            // 
            this.RouteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RouteComboBox.FormattingEnabled = true;
            this.RouteComboBox.Items.AddRange(new object[] {
            "№ маршрута",
            "Пункт назначения",
            "Пункт отправления"});
            this.RouteComboBox.Location = new System.Drawing.Point(7, 20);
            this.RouteComboBox.Name = "RouteComboBox";
            this.RouteComboBox.Size = new System.Drawing.Size(156, 21);
            this.RouteComboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DispatcherText);
            this.groupBox3.Controls.Add(this.BusText);
            this.groupBox3.Controls.Add(this.DriverText);
            this.groupBox3.Controls.Add(this.TicketText);
            this.groupBox3.Controls.Add(this.RouteText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(487, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбрано";
            // 
            // DispatcherText
            // 
            this.DispatcherText.Location = new System.Drawing.Point(75, 129);
            this.DispatcherText.Name = "DispatcherText";
            this.DispatcherText.ReadOnly = true;
            this.DispatcherText.Size = new System.Drawing.Size(524, 20);
            this.DispatcherText.TabIndex = 9;
            // 
            // BusText
            // 
            this.BusText.Location = new System.Drawing.Point(75, 77);
            this.BusText.Name = "BusText";
            this.BusText.ReadOnly = true;
            this.BusText.Size = new System.Drawing.Size(524, 20);
            this.BusText.TabIndex = 8;
            // 
            // DriverText
            // 
            this.DriverText.Location = new System.Drawing.Point(75, 103);
            this.DriverText.Name = "DriverText";
            this.DriverText.ReadOnly = true;
            this.DriverText.Size = new System.Drawing.Size(524, 20);
            this.DriverText.TabIndex = 7;
            // 
            // TicketText
            // 
            this.TicketText.Location = new System.Drawing.Point(75, 48);
            this.TicketText.Name = "TicketText";
            this.TicketText.ReadOnly = true;
            this.TicketText.Size = new System.Drawing.Size(524, 20);
            this.TicketText.TabIndex = 6;
            // 
            // RouteText
            // 
            this.RouteText.Location = new System.Drawing.Point(75, 22);
            this.RouteText.Name = "RouteText";
            this.RouteText.ReadOnly = true;
            this.RouteText.Size = new System.Drawing.Size(524, 20);
            this.RouteText.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Диспетчер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Автобус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Водитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Билет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Маршрут";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TransportId);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Перевозка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ перевозки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TicketButton);
            this.groupBox2.Controls.Add(this.TicketTextBox);
            this.groupBox2.Controls.Add(this.TicketComboBox);
            this.groupBox2.Location = new System.Drawing.Point(310, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Билет";
            // 
            // TicketButton
            // 
            this.TicketButton.Location = new System.Drawing.Point(6, 94);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(158, 23);
            this.TicketButton.TabIndex = 2;
            this.TicketButton.Text = "Применить";
            this.TicketButton.UseVisualStyleBackColor = true;
            this.TicketButton.Click += new System.EventHandler(this.TicketButtonClick);
            // 
            // TicketTextBox
            // 
            this.TicketTextBox.Location = new System.Drawing.Point(7, 51);
            this.TicketTextBox.Name = "TicketTextBox";
            this.TicketTextBox.Size = new System.Drawing.Size(158, 20);
            this.TicketTextBox.TabIndex = 1;
            // 
            // TicketComboBox
            // 
            this.TicketComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketComboBox.FormattingEnabled = true;
            this.TicketComboBox.Items.AddRange(new object[] {
            "Место",
            "Ф.И.О пассажира"});
            this.TicketComboBox.Location = new System.Drawing.Point(7, 20);
            this.TicketComboBox.Name = "TicketComboBox";
            this.TicketComboBox.Size = new System.Drawing.Size(158, 21);
            this.TicketComboBox.TabIndex = 0;
            // 
            // RouteData
            // 
            this.RouteData.AllowUserToAddRows = false;
            this.RouteData.AllowUserToDeleteRows = false;
            this.RouteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteData.Location = new System.Drawing.Point(12, 200);
            this.RouteData.Name = "RouteData";
            this.RouteData.ReadOnly = true;
            this.RouteData.Size = new System.Drawing.Size(527, 150);
            this.RouteData.TabIndex = 4;
            this.RouteData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RouteDataSelect);
            this.RouteData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RouteDataSelect);
            // 
            // TicketData
            // 
            this.TicketData.AllowUserToAddRows = false;
            this.TicketData.AllowUserToDeleteRows = false;
            this.TicketData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketData.Location = new System.Drawing.Point(545, 200);
            this.TicketData.Name = "TicketData";
            this.TicketData.ReadOnly = true;
            this.TicketData.Size = new System.Drawing.Size(547, 150);
            this.TicketData.TabIndex = 5;
            this.TicketData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataSelect);
            this.TicketData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataSelect);
            // 
            // DriverData
            // 
            this.DriverData.AllowUserToAddRows = false;
            this.DriverData.AllowUserToDeleteRows = false;
            this.DriverData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverData.Location = new System.Drawing.Point(12, 373);
            this.DriverData.Name = "DriverData";
            this.DriverData.ReadOnly = true;
            this.DriverData.Size = new System.Drawing.Size(359, 150);
            this.DriverData.TabIndex = 6;
            this.DriverData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriverDataSelect);
            this.DriverData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriverDataSelect);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 143);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(154, 30);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Билет";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Маршрут";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Водитель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Автобус";
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(327, 143);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(154, 30);
            this.NoButton.TabIndex = 10;
            this.NoButton.Text = "Отменить";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // BusData
            // 
            this.BusData.AllowUserToAddRows = false;
            this.BusData.AllowUserToDeleteRows = false;
            this.BusData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusData.Location = new System.Drawing.Point(377, 373);
            this.BusData.Name = "BusData";
            this.BusData.ReadOnly = true;
            this.BusData.Size = new System.Drawing.Size(340, 150);
            this.BusData.TabIndex = 11;
            this.BusData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusDataSelect);
            this.BusData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusDataSelect);
            // 
            // DispatcherData
            // 
            this.DispatcherData.AllowUserToAddRows = false;
            this.DispatcherData.AllowUserToDeleteRows = false;
            this.DispatcherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispatcherData.Location = new System.Drawing.Point(723, 373);
            this.DispatcherData.Name = "DispatcherData";
            this.DispatcherData.ReadOnly = true;
            this.DispatcherData.Size = new System.Drawing.Size(369, 150);
            this.DispatcherData.TabIndex = 12;
            this.DispatcherData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DispatcherDataSelect);
            this.DispatcherData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DispatcherDataSelect);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(720, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Диспетчер";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(169, 143);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(154, 30);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 532);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DispatcherData);
            this.Controls.Add(this.BusData);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DriverData);
            this.Controls.Add(this.TicketData);
            this.Controls.Add(this.RouteData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление перевозки";
            this.Load += new System.EventHandler(this.FormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RouteData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispatcherData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TransportId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RouteButton;
        private System.Windows.Forms.TextBox RouteTextBox;
        private System.Windows.Forms.ComboBox RouteComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TicketButton;
        private System.Windows.Forms.TextBox TicketTextBox;
        private System.Windows.Forms.ComboBox TicketComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView RouteData;
        public System.Windows.Forms.DataGridView TicketData;
        public System.Windows.Forms.DataGridView DriverData;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button NoButton;
        public System.Windows.Forms.DataGridView BusData;
        public System.Windows.Forms.DataGridView DispatcherData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DispatcherText;
        private System.Windows.Forms.TextBox BusText;
        private System.Windows.Forms.TextBox DriverText;
        private System.Windows.Forms.TextBox TicketText;
        private System.Windows.Forms.TextBox RouteText;
        public System.Windows.Forms.Button SaveButton;
    }
}