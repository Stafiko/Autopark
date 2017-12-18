namespace AutoparkWindow
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.TransportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DispatchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterMask = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransportDelButton = new System.Windows.Forms.Button();
            this.TransportAddButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ViewDispatcherButton = new System.Windows.Forms.Button();
            this.ViewDriverButton = new System.Windows.Forms.Button();
            this.ViewBusButton = new System.Windows.Forms.Button();
            this.ViewRouteButton = new System.Windows.Forms.Button();
            this.ViewTicketButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CommandDelButton = new System.Windows.Forms.Button();
            this.CommandAddButton = new System.Windows.Forms.Button();
            this.ViewData = new System.Windows.Forms.DataGridView();
            this.TransportChangeButton = new System.Windows.Forms.Button();
            this.CommandChangeButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransportToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(923, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // TransportToolStripMenuItem
            // 
            this.TransportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.TransportToolStripMenuItem.Name = "TransportToolStripMenuItem";
            this.TransportToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.TransportToolStripMenuItem.Text = "Перевозка";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolStripMenuItem.Text = "Добавить...";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddTransport);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DelToolStripMenuItem.Text = "Удалить...";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelTransport);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TicketsToolStripMenuItem,
            this.RoutesToolStripMenuItem,
            this.BusesToolStripMenuItem,
            this.DriversToolStripMenuItem,
            this.DispatchersToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ViewToolStripMenuItem.Text = "Просмотр";
            // 
            // TicketsToolStripMenuItem
            // 
            this.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem";
            this.TicketsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TicketsToolStripMenuItem.Text = "Билеты";
            this.TicketsToolStripMenuItem.Click += new System.EventHandler(this.ViewTickets);
            // 
            // RoutesToolStripMenuItem
            // 
            this.RoutesToolStripMenuItem.Name = "RoutesToolStripMenuItem";
            this.RoutesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RoutesToolStripMenuItem.Text = "Маршруты";
            this.RoutesToolStripMenuItem.Click += new System.EventHandler(this.ViewRoutes);
            // 
            // BusesToolStripMenuItem
            // 
            this.BusesToolStripMenuItem.Name = "BusesToolStripMenuItem";
            this.BusesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BusesToolStripMenuItem.Text = "Автобусы";
            this.BusesToolStripMenuItem.Click += new System.EventHandler(this.ViewBuses);
            // 
            // DriversToolStripMenuItem
            // 
            this.DriversToolStripMenuItem.Name = "DriversToolStripMenuItem";
            this.DriversToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DriversToolStripMenuItem.Text = "Водители";
            this.DriversToolStripMenuItem.Click += new System.EventHandler(this.ViewDrivers);
            // 
            // DispatchersToolStripMenuItem
            // 
            this.DispatchersToolStripMenuItem.Name = "DispatchersToolStripMenuItem";
            this.DispatchersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DispatchersToolStripMenuItem.Text = "Диспетчеры";
            this.DispatchersToolStripMenuItem.Click += new System.EventHandler(this.ViewDispatchers);
            // 
            // TransportData
            // 
            this.TransportData.AllowUserToAddRows = false;
            this.TransportData.AllowUserToDeleteRows = false;
            this.TransportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportData.Location = new System.Drawing.Point(12, 27);
            this.TransportData.Name = "TransportData";
            this.TransportData.ReadOnly = true;
            this.TransportData.Size = new System.Drawing.Size(693, 242);
            this.TransportData.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterMask);
            this.groupBox1.Controls.Add(this.FilterComboBox);
            this.groupBox1.Controls.Add(this.FilterButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(711, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // FilterMask
            // 
            this.FilterMask.Location = new System.Drawing.Point(10, 72);
            this.FilterMask.Name = "FilterMask";
            this.FilterMask.Size = new System.Drawing.Size(184, 20);
            this.FilterMask.TabIndex = 4;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "№ перевозки",
            "№ маршрута",
            "Пункт отправления",
            "Пункт назначения",
            "Пассажир",
            "Водитель"});
            this.FilterComboBox.Location = new System.Drawing.Point(10, 32);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(184, 21);
            this.FilterComboBox.TabIndex = 3;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(10, 98);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(184, 23);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Применить";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.Filter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Маска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransportChangeButton);
            this.groupBox2.Controls.Add(this.TransportDelButton);
            this.groupBox2.Controls.Add(this.TransportAddButton);
            this.groupBox2.Location = new System.Drawing.Point(711, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перевозка";
            // 
            // TransportDelButton
            // 
            this.TransportDelButton.Location = new System.Drawing.Point(10, 50);
            this.TransportDelButton.Name = "TransportDelButton";
            this.TransportDelButton.Size = new System.Drawing.Size(184, 23);
            this.TransportDelButton.TabIndex = 1;
            this.TransportDelButton.Text = "Удалить...";
            this.TransportDelButton.UseVisualStyleBackColor = true;
            this.TransportDelButton.Click += new System.EventHandler(this.DelTransport);
            // 
            // TransportAddButton
            // 
            this.TransportAddButton.Location = new System.Drawing.Point(10, 21);
            this.TransportAddButton.Name = "TransportAddButton";
            this.TransportAddButton.Size = new System.Drawing.Size(89, 23);
            this.TransportAddButton.TabIndex = 0;
            this.TransportAddButton.Text = "Добавить...";
            this.TransportAddButton.UseVisualStyleBackColor = true;
            this.TransportAddButton.Click += new System.EventHandler(this.AddTransport);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ViewDispatcherButton);
            this.groupBox3.Controls.Add(this.ViewDriverButton);
            this.groupBox3.Controls.Add(this.ViewBusButton);
            this.groupBox3.Controls.Add(this.ViewRouteButton);
            this.groupBox3.Controls.Add(this.ViewTicketButton);
            this.groupBox3.Location = new System.Drawing.Point(711, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 176);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр";
            // 
            // ViewDispatcherButton
            // 
            this.ViewDispatcherButton.Location = new System.Drawing.Point(10, 136);
            this.ViewDispatcherButton.Name = "ViewDispatcherButton";
            this.ViewDispatcherButton.Size = new System.Drawing.Size(184, 23);
            this.ViewDispatcherButton.TabIndex = 4;
            this.ViewDispatcherButton.Text = "Диспетчеры";
            this.ViewDispatcherButton.UseVisualStyleBackColor = true;
            this.ViewDispatcherButton.Click += new System.EventHandler(this.ViewDispatchers);
            // 
            // ViewDriverButton
            // 
            this.ViewDriverButton.Location = new System.Drawing.Point(10, 107);
            this.ViewDriverButton.Name = "ViewDriverButton";
            this.ViewDriverButton.Size = new System.Drawing.Size(184, 23);
            this.ViewDriverButton.TabIndex = 3;
            this.ViewDriverButton.Text = "Водители";
            this.ViewDriverButton.UseVisualStyleBackColor = true;
            this.ViewDriverButton.Click += new System.EventHandler(this.ViewDrivers);
            // 
            // ViewBusButton
            // 
            this.ViewBusButton.Location = new System.Drawing.Point(10, 78);
            this.ViewBusButton.Name = "ViewBusButton";
            this.ViewBusButton.Size = new System.Drawing.Size(184, 23);
            this.ViewBusButton.TabIndex = 2;
            this.ViewBusButton.Text = "Автобусы";
            this.ViewBusButton.UseVisualStyleBackColor = true;
            this.ViewBusButton.Click += new System.EventHandler(this.ViewBuses);
            // 
            // ViewRouteButton
            // 
            this.ViewRouteButton.Location = new System.Drawing.Point(10, 49);
            this.ViewRouteButton.Name = "ViewRouteButton";
            this.ViewRouteButton.Size = new System.Drawing.Size(184, 23);
            this.ViewRouteButton.TabIndex = 1;
            this.ViewRouteButton.Text = "Маршруты";
            this.ViewRouteButton.UseVisualStyleBackColor = true;
            this.ViewRouteButton.Click += new System.EventHandler(this.ViewRoutes);
            // 
            // ViewTicketButton
            // 
            this.ViewTicketButton.Location = new System.Drawing.Point(10, 20);
            this.ViewTicketButton.Name = "ViewTicketButton";
            this.ViewTicketButton.Size = new System.Drawing.Size(184, 23);
            this.ViewTicketButton.TabIndex = 0;
            this.ViewTicketButton.Text = "Билеты";
            this.ViewTicketButton.UseVisualStyleBackColor = true;
            this.ViewTicketButton.Click += new System.EventHandler(this.ViewTickets);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CommandChangeButton);
            this.groupBox4.Controls.Add(this.CommandDelButton);
            this.groupBox4.Controls.Add(this.CommandAddButton);
            this.groupBox4.Location = new System.Drawing.Point(711, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 82);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Команды";
            // 
            // CommandDelButton
            // 
            this.CommandDelButton.Location = new System.Drawing.Point(10, 48);
            this.CommandDelButton.Name = "CommandDelButton";
            this.CommandDelButton.Size = new System.Drawing.Size(184, 23);
            this.CommandDelButton.TabIndex = 2;
            this.CommandDelButton.Text = "Удалить...";
            this.CommandDelButton.UseVisualStyleBackColor = true;
            this.CommandDelButton.Click += new System.EventHandler(this.DelFromCommand);
            // 
            // CommandAddButton
            // 
            this.CommandAddButton.Location = new System.Drawing.Point(10, 19);
            this.CommandAddButton.Name = "CommandAddButton";
            this.CommandAddButton.Size = new System.Drawing.Size(89, 23);
            this.CommandAddButton.TabIndex = 2;
            this.CommandAddButton.Text = "Добавить...";
            this.CommandAddButton.UseVisualStyleBackColor = true;
            this.CommandAddButton.Click += new System.EventHandler(this.AddFromCommand);
            // 
            // ViewData
            // 
            this.ViewData.AllowUserToAddRows = false;
            this.ViewData.AllowUserToDeleteRows = false;
            this.ViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewData.Location = new System.Drawing.Point(12, 281);
            this.ViewData.Name = "ViewData";
            this.ViewData.ReadOnly = true;
            this.ViewData.Size = new System.Drawing.Size(693, 242);
            this.ViewData.TabIndex = 7;
            // 
            // TransportChangeButton
            // 
            this.TransportChangeButton.Location = new System.Drawing.Point(105, 21);
            this.TransportChangeButton.Name = "TransportChangeButton";
            this.TransportChangeButton.Size = new System.Drawing.Size(89, 23);
            this.TransportChangeButton.TabIndex = 2;
            this.TransportChangeButton.Text = "Изменить...";
            this.TransportChangeButton.UseVisualStyleBackColor = true;
            this.TransportChangeButton.Click += new System.EventHandler(this.ChangeTransport);
            // 
            // CommandChangeButton
            // 
            this.CommandChangeButton.Location = new System.Drawing.Point(105, 19);
            this.CommandChangeButton.Name = "CommandChangeButton";
            this.CommandChangeButton.Size = new System.Drawing.Size(89, 23);
            this.CommandChangeButton.TabIndex = 3;
            this.CommandChangeButton.Text = "Изменить...";
            this.CommandChangeButton.UseVisualStyleBackColor = true;
            this.CommandChangeButton.Click += new System.EventHandler(this.ChangeFromCommand);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 532);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransportData);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "Менеджер автовокзала";
            this.Load += new System.EventHandler(this.FormLoad);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem TransportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DispatchersToolStripMenuItem;
        private System.Windows.Forms.DataGridView TransportData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FilterMask;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TransportDelButton;
        private System.Windows.Forms.Button TransportAddButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ViewDispatcherButton;
        private System.Windows.Forms.Button ViewDriverButton;
        private System.Windows.Forms.Button ViewBusButton;
        private System.Windows.Forms.Button ViewRouteButton;
        private System.Windows.Forms.Button ViewTicketButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CommandDelButton;
        private System.Windows.Forms.Button CommandAddButton;
        private System.Windows.Forms.DataGridView ViewData;
        private System.Windows.Forms.Button TransportChangeButton;
        private System.Windows.Forms.Button CommandChangeButton;
    }
}

