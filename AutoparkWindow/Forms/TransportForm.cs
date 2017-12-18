using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoparkWindow
{
    public partial class TransportForm : Form
    {
        private int changingId;

        public TransportForm(int change = -1)
        {
            this.InitializeComponent();
            changingId = change;
        }

        private bool CheckForSelection()
        {
            if (this.RouteData.CurrentCell != null && 
                this.TicketData.CurrentCell != null &&
                this.DispatcherData.CurrentCell != null && 
                this.BusData.CurrentCell != null &&
                this.DriverData.CurrentCell != null)
                return true;

            MessageBox.Show("Не было выбрано одно из полей.", "Что-то пошло не так...");
            return false;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (!CheckForSelection())
                return;

            this.DialogResult = DialogResult.OK;
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (!CheckForSelection())
                return;

            this.DialogResult = DialogResult.Retry;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            #region Заполнение

            var command = "SELECT " +
                          "[Id] as [№], " +
                          "[Place] as [Место пассажира], " +
                          "[Price] as [Цена билета], " +
                          "[BuyDate] as [Дата покупки], " +
                          "[Passenger] as [Пассажир], " +
                          "[Passport] as [Пасспорт], " +
                          "[Discount] as [Льготы?] " +
                          "FROM " +
                          "[Ticket]";
            SqlHelper.FillGrid(this.TicketData, "[Ticket]", sqlCommand: command);
            this.TicketData.Columns["Дата покупки"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            this.TicketData.Columns[0].Visible = false;

            command = "SELECT " +
                      "[Id] as [№], " +
                      "[Number] as [№ маршрута], " +
                      "[Departure] as [Место отправления], " +
                      "[Destination] as [Место прибытия], " +
                      "[Distance] as [Расстояние (км)], " +
                      "[BeginDate] as [Время отправления], " +
                      "[EndDate] as [Время прибытия] " +
                      "FROM " +
                      "[Route]";
            SqlHelper.FillGrid(this.RouteData, "[Route]", sqlCommand: command);
            this.RouteData.Columns["Время отправления"].DefaultCellStyle.Format = "HH:mm:ss";
            this.RouteData.Columns["Время прибытия"].DefaultCellStyle.Format = "HH:mm:ss";
            this.RouteData.Columns[0].Visible = false;

            command = "SELECT " +
                      "[Id] as [№], " +
                      "[Name] as [Водитель], " +
                      "[BirthDate] as [Дата рождения], " +
                      "[Passport] as [Пасспорт], " +
                      "[Address] as [Адрес] " +
                      "FROM " +
                      "[Driver]";
            SqlHelper.FillGrid(this.DriverData, "[Driver]", sqlCommand: command);
            this.DriverData.Columns["Дата рождения"].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.DriverData.Columns[0].Visible = false;

            command = "SELECT " +
                      "[Id] as [№], " +
                      "[Name] as [Диспетчер], " +
                      "[BirthDate] as [Дата рождения], " +
                      "[Passport] as [Пасспорт], " +
                      "[Address] as [Адрес] " +
                      "FROM " +
                      "[Dispatcher]";
            SqlHelper.FillGrid(this.DispatcherData, "[Dispatcher]", sqlCommand: command);
            this.DispatcherData.Columns["Дата рождения"].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.DispatcherData.Columns[0].Visible = false;

            command = "SELECT " +
                      "[Id] as [№], " +
                      "[Number] as [№ автобуса], " +
                      "[Model] as [Модель автобуса], " +
                      "[Numberplate] as [Номерной знак], " +
                      "[Size] as [Кол-во посадочных мест] " +
                      "FROM " +
                      "[Bus]";
            SqlHelper.FillGrid(this.BusData, "[Bus]", sqlCommand: command);
            this.BusData.Columns[0].Visible = false;

            #endregion

            this.TransportId.Text = "0";
            this.RouteComboBox.SelectedIndex = 0;
            this.TicketComboBox.SelectedIndex = 0;
            this.RouteText.Text = string.Empty;
            this.TicketText.Text = string.Empty;
            this.BusText.Text = string.Empty;
            this.DispatcherText.Text = string.Empty;
            this.DriverText.Text = string.Empty;

            if (changingId > 0)
            {
                this.SaveButton.Enabled = true;
                var transport = SqlHelper.GetTable(
                    "[Transport]",
                    $"SELECT * FROM [Transport] WHERE [Transport].[Id] = {changingId} ");

                if (transport.Tables[0].Rows.Count > 0)
                {
                    this.SelectDataRowFromId(this.RouteData, (int)transport.Tables[0].Rows[0]["RouteId"]);
                    this.SelectDataRowFromId(this.TicketData, (int)transport.Tables[0].Rows[0]["TicketId"]);
                    this.SelectDataRowFromId(this.DispatcherData, (int)transport.Tables[0].Rows[0]["DispatcherId"]);
                    this.SelectDataRowFromId(this.BusData, (int)transport.Tables[0].Rows[0]["BusId"]);
                    this.SelectDataRowFromId(this.DriverData, (int)transport.Tables[0].Rows[0]["DriverId"]);
                }
            }
        }

        private void SelectDataRowFromId(DataGridView data, int id)
        {
            var dataRow = data.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => (int)r.Cells[0].Value == id);
            if (dataRow != null)
                data.CurrentCell = data.Rows[dataRow.Index].Cells[1];
        }

        private void RouteDataSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (this.RouteData.CurrentCell == null)
                return;

            var row = this.RouteData.CurrentCell.RowIndex;
            this.RouteText.Text = $@"{this.RouteData[1, row].Value}" +
                               $@" Из {this.RouteData[2, row].Value}" +
                               $@" в {this.RouteData[3, row].Value}" +
                               $@" / {this.RouteData[4, row].Value} км" +
                               $@" / {this.RouteData[5, row].Value:HH:mm:ss}" +
                               $@" - {this.RouteData[6, row].Value:HH:mm:ss}";
        }

        private void TicketDataSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (this.TicketData.CurrentCell == null)
                return;

            var row = this.TicketData.CurrentCell.RowIndex;
            this.TicketText.Text = $@"{this.TicketData[3, row].Value}" +
                                   $@" / {this.TicketData[2, row].Value} р." +
                                   $@" / Место {this.TicketData[1, row].Value}" +
                                   $@" / {this.TicketData[4, row].Value}" +
                                   $@" : {this.TicketData[5, row].Value}";
        }

        private void DriverDataSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DriverData.CurrentCell == null)
                return;

            var row = this.DriverData.CurrentCell.RowIndex;
            this.DriverText.Text = $@"{this.DriverData[1, row].Value}";
        }

        private void BusDataSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (this.BusData.CurrentCell == null)
                return;

            var row = this.BusData.CurrentCell.RowIndex;
            this.BusText.Text = $@"{this.BusData[1, row].Value}" +
                                $@" / {this.BusData[2, row].Value}" +
                                $@" / {this.BusData[3, row].Value}" +
                                $@" / {this.BusData[4, row].Value} мест";
        }

        private void DispatcherDataSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DispatcherData.CurrentCell == null)
                return;

            var row = this.DispatcherData.CurrentCell.RowIndex;
            this.DispatcherText.Text = $@"{this.DispatcherData[1, row].Value}";
        }

        private void RouteButtonClick(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id] as [№], " +
                              "[Number] as [№ маршрута], " +
                              "[Departure] as [Место отправления], " +
                              "[Destination] as [Место прибытия], " +
                              "[Distance] as [Расстояние (км)], " +
                              "[BeginDate] as [Время отправления], " +
                              "[EndDate] as [Время прибытия] " +
                          "FROM " +
                              "[Route]";
            if (this.RouteTextBox.Text != string.Empty)
                switch (this.RouteComboBox.SelectedIndex)
                {
                    case 0:
                        command += $" WHERE [Number] = N'{this.RouteTextBox.Text}'";
                        break;
                    case 1:
                        command += $" WHERE [Destination] LIKE N'{this.RouteTextBox.Text}%'";
                        break;
                    case 2:
                        command += $" WHERE [Departure] LIKE N'{this.RouteTextBox.Text}%'";
                        break;
                }

            SqlHelper.FillGrid(this.RouteData, "[Route]", gridTableId:0, sqlCommand:command);
        }

        private void TicketButtonClick(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id] as [№], " +
                              "[Place] as [Место пассажира], " +
                              "[Price] as [Цена билета], " +
                              "[BuyDate] as [Дата покупки], " +
                              "[Passenger] as [Пассажир], " +
                              "[Passport] as [Пасспорт], " +
                              "[Discount] as [Льготы?] " +
                          "FROM " +
                              "[Ticket]";
            if (this.TicketTextBox.Text != string.Empty)
                switch (this.TicketComboBox.SelectedIndex)
                {
                    case 0:
                        command += $" WHERE [Place] = {this.TicketTextBox.Text}";
                        break;
                    case 1:
                        command += $" WHERE [Passenger] LIKE N'{this.TicketTextBox.Text}%'";
                        break;
                }
            
            SqlHelper.FillGrid(this.TicketData, "[Route]", gridTableId:0, sqlCommand:command);
        }
    }
}
