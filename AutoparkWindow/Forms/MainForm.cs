using System;
using System.Linq;
using System.Windows.Forms;
using AutoparkWindow.Forms;

namespace AutoparkWindow
{
    public partial class MainForm : Form
    {
        private ActiveTable activeTable = ActiveTable.Ticket;

        enum ActiveTable
        {
            Ticket,
            Route,
            Bus,
            Driver,
            Dispatcher
        }

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void Filter(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Transport].[Id], " +
                              "[Transport].[Number] as [№ перевозки], " +
                              "[Route].[Number] as [№ маршрута], " +
                              "[Route].[Departure] as [Место отправления], " +
                              "[Route].[Destination] as [Место назначения], " +
                              "[Route].[BeginDate] as [Дата отбытия], " +
                              "[Route].[EndDate] as [Дата прибытия], " +
                              "[Ticket].[Place] as [Место пассажира], " +
                              "[Ticket].[Passenger] as [Пассажир], " +
                              "[Ticket].[Price] as [Цена билета (р)], " +
                              "[Ticket].[BuyDate] as [Дата покупки], " +
                              "[Driver].[Name] as [Водитель] " +
                          "FROM " +
                              "[Transport], " +
                              "[Route], " +
                              "[Ticket], " +
                              "[Driver] " +
                          "WHERE " +
                              "([Transport].[RouteId] = [Route].[Id]) AND " +
                              "([Transport].[TicketId] = [Ticket].[Id]) AND " +
                              "([Transport].[DriverId] = [Driver].[Id]) ";

            if (this.FilterMask.Text != string.Empty)
            {
                switch (this.FilterComboBox.SelectedIndex)
                {
                    case 0:
                        command += $" AND ([Transport].[Number] = N'{this.FilterMask.Text}') ";
                        break;
                    case 1:
                        command += $" AND ([Route].[Number] = N'{this.FilterMask.Text}') ";
                        break;
                    case 2:
                        command += $" AND ([Route].[Departure] LIKE N'{this.FilterMask.Text}%') ";
                        break;
                    case 3:
                        command += $" AND ([Route].[Destination] LIKE N'{this.FilterMask.Text}%') ";
                        break;
                    case 4:
                        command += $" AND ([Ticket].[Passenger] LIKE N'{this.FilterMask.Text}%') ";
                        break;
                    case 5:
                        command += $" AND ([Driver].[Name] LIKE N'{this.FilterMask.Text}%') ";
                        break;
                    default:
                        return;
                }
            }

            SqlHelper.FillGrid(this.TransportData, "[Transport]", sqlCommand: command);
            this.TransportData.Columns[0].Visible = false;
            this.TransportData.Columns["Дата отбытия"].DefaultCellStyle.Format = "HH:mm:ss";
            this.TransportData.Columns["Дата прибытия"].DefaultCellStyle.Format = "HH:mm:ss";
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.FilterComboBox.SelectedIndex = 0;
            this.Filter(sender, e);
            this.ViewTickets(sender, e);
        }



        private void AddTransport(object sender, EventArgs e)
        {
            var isChange = Equals(sender, this.TransportChangeButton) && this.TransportData.CurrentRow != null;
            var id = isChange
                ? Convert.ToInt32(this.TransportData.CurrentRow.Cells[0].Value)
                : -1;

            var form = new TransportForm(id);
            var result = form.ShowDialog();

            if (result != DialogResult.OK &&
                result != DialogResult.Retry) 
                return;

            string command;
            var transportNumber = string.IsNullOrWhiteSpace(form.TransportId.Text)
                ? "0"
                : form.TransportId.Text;

            var row = form.RouteData.CurrentCell.RowIndex;
            var routeId = (int)form.RouteData[0, row].Value;

            row = form.TicketData.CurrentCell.RowIndex;
            var ticketId = (int)form.TicketData[0, row].Value;

            row = form.DispatcherData.CurrentCell.RowIndex;
            var dispatcherId = (int)form.DispatcherData[0, row].Value;

            row = form.BusData.CurrentCell.RowIndex;
            var busId = (int)form.BusData[0, row].Value;

            row = form.DriverData.CurrentCell.RowIndex;
            var driverId = (int)form.DriverData[0, row].Value;

            switch (result)
            {
                case DialogResult.OK:
                    command = "INSERT INTO [Transport] " +
                              " (Number, RouteId, TicketId, DispatcherId, BusId, DriverId) " +
                              "VALUES " +
                              $" (N'{transportNumber}', {routeId}, {ticketId}, {dispatcherId}, {busId}, {driverId}) ";
                    break;
                case DialogResult.Retry:
                    command = "UPDATE [Transport] " +
                              "SET " +
                              $" [Number] = N'{transportNumber}', " +
                              $" [RouteId] = {routeId}, " +
                              $" [TicketId] = {ticketId}, " +
                              $" [DispatcherId] = {dispatcherId}, " +
                              $" [BusId] = {busId}, " +
                              $" [DriverId] = {driverId} " +
                              $"WHERE [Id] = {id} ";
                    break;
                default:
                    return;
            }

            SqlHelper.ExecuteQuery(command);
            this.Filter(sender, e);
        }

        private void DelTransport(object sender, EventArgs e)
        {
            if (this.TransportData.CurrentRow == null)
                return;

            var form = new DelForm();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            var index = TransportData.CurrentRow.Index;
            var number = Convert.ToInt32(TransportData[0, index].Value);
            var command = $"DELETE FROM [Transport] WHERE [Transport].[Id] = {number} ";

            SqlHelper.ExecuteQuery(command);
            this.Filter(sender, e);
        }
        
        private void ChangeTransport(object sender, EventArgs e)
        {
            if (this.TransportData.CurrentRow == null)
                return;

            this.AddTransport(sender, e);
        }

        private void ViewTickets(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id], " +
                              "[Place] as [Место пассажира], " +
                              "[Price] as [Цена билета], " +
                              "[BuyDate] as [Дата покупки], " +
                              "[Passenger] as [Пассажир], " +
                              "[Passport] as [Пасспорт], " +
                              "[Discount] as [Льготы?] " +
                          "FROM " +
                            "[Ticket] ";
            SqlHelper.FillGrid(this.ViewData, "[Ticket]", gridTableId:0, sqlCommand:command);
            this.ViewData.Columns[0].Visible = false;
            this.ViewData.Columns["Дата покупки"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            this.activeTable = ActiveTable.Ticket;
        }

        private void ViewRoutes(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id], " +
                              "[Number] as [№ маршрута], " +
                              "[Departure] as [Место отправления], " +
                              "[Destination] as [Место прибытия], " +
                              "[Distance] as [Расстояние (км)], " +
                              "[BeginDate] as [Время отправления], " +
                              "[EndDate] as [Время прибытия] " +
                          "FROM " +
                            "[Route] ";
            SqlHelper.FillGrid(this.ViewData, "[Route]", gridTableId:0, sqlCommand:command);
            this.ViewData.Columns[0].Visible = false;
            this.ViewData.Columns["Время отправления"].DefaultCellStyle.Format = "HH:mm:ss";
            this.ViewData.Columns["Время прибытия"].DefaultCellStyle.Format = "HH:mm:ss";
            this.activeTable = ActiveTable.Route;
        }

        private void ViewBuses(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id], " +
                              "[Number] as [№ автобуса], " +
                              "[Model] as [Модель автобуса], " +
                              "[Numberplate] as [Номерной знак], " +
                              "[Size] as [Кол-во посадочных мест] " +
                          "FROM " +
                            "[Bus] ";
            SqlHelper.FillGrid(this.ViewData, "[Bus]", gridTableId: 0, sqlCommand: command);
            this.ViewData.Columns[0].Visible = false;
            this.activeTable = ActiveTable.Bus;
        }

        private void ViewDrivers(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id], " +
                              "[Name] as [Водитель], " +
                              "[BirthDate] as [Дата рождения], " +
                              "[Passport] as [Пасспорт], " +
                              "[Address] as [Адрес] " +
                          "FROM " +
                            "[Driver] ";
            SqlHelper.FillGrid(this.ViewData, "[Driver]", gridTableId: 0, sqlCommand: command);
            this.ViewData.Columns["Дата рождения"].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.ViewData.Columns[0].Visible = false;
            this.activeTable = ActiveTable.Driver;
        }

        private void ViewDispatchers(object sender, EventArgs e)
        {
            var command = "SELECT " +
                              "[Id], " +
                              "[Name] as [Диспетчер], " +
                              "[BirthDate] as [Дата рождения], " +
                              "[Passport] as [Пасспорт], " +
                              "[Address] as [Адрес] " +
                          "FROM " +
                            "[Dispatcher] ";
            SqlHelper.FillGrid(this.ViewData, "[Dispatcher]", gridTableId: 0, sqlCommand: command);
            this.ViewData.Columns["Дата рождения"].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.ViewData.Columns[0].Visible = false;
            this.activeTable = ActiveTable.Dispatcher;
        }

        private void AddFromCommand(object sender, EventArgs e)
        {
            var isChange = Equals(sender, this.CommandChangeButton) && this.ViewData.CurrentRow != null;
            var id = isChange
                ? (int) this.ViewData.CurrentRow.Cells[0].Value
                : -1;

            switch (this.activeTable)
            {
                case ActiveTable.Bus:
                {
                    var form = new BusForm();
                    if (isChange)
                    {
                        form.SaveButton.Enabled = true;
                        form.NumberTextBox.Text = (string) this.ViewData.CurrentRow.Cells["№ автобуса"].Value;
                        form.ModelTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Модель автобуса"].Value;
                        form.NumberplateTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Номерной знак"].Value;
                        form.SizeNumeric.Value = (int) this.ViewData.CurrentRow.Cells["Кол-во посадочных мест"].Value;
                    }

                    var result = form.ShowDialog();

                    string command;
                    var number = form.NumberTextBox.Text;
                    var model = form.ModelTextBox.Text;
                    var numberplate = form.NumberplateTextBox.Text;
                    var size = (int) form.SizeNumeric.Value;
                    switch (result)
                    {
                        case DialogResult.OK:
                            command = "INSERT INTO [Bus] " +
                                      " ([Number], [Model], [Numberplate], [Size]) " +
                                      "VALUES " +
                                      $" (N'{number}', N'{model}', N'{numberplate}', {size}) ";
                            break;
                        case DialogResult.Retry:
                            command = "UPDATE [Bus] " +
                                      "SET " +
                                      $" [Number] = N'{number}', " +
                                      $" [Model] = N'{model}', " +
                                      $" [Numberplate] = N'{numberplate}', " +
                                      $" [Size] = {size} " +
                                      $"WHERE [Id] = {id} ";
                            break;
                        default:
                            return;
                    }
                    SqlHelper.ExecuteQuery(command);
                    this.ViewBuses(sender, e);
                    break;
                }

                case ActiveTable.Dispatcher:
                {
                    var form = new DispatcherForm();
                    if (isChange)
                    {
                        form.SaveButton.Enabled = true;
                        form.NameTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Диспетчер"].Value;
                        form.BirthDatePicker.Value = (DateTime) this.ViewData.CurrentRow.Cells["Дата рождения"].Value;
                        form.AddressTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Адрес"].Value;
                        form.PassportTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Пасспорт"].Value;
                    }

                    var result = form.ShowDialog();

                    string command;
                    var name = form.NameTextBox.Text;
                    var birth = form.BirthDatePicker.Value.ToString("yyyy-MM-dd");
                    var address = form.AddressTextBox.Text;
                    var passport = form.PassportTextBox.Text;

                    switch (result)
                    {
                        case DialogResult.OK:
                            command = "INSERT INTO [Dispatcher] " +
                                      " ([Name], [BirthDate], [Address], [Passport]) " +
                                      "VALUES " +
                                      $" (N'{name}', N'{birth}', N'{address}', N'{passport}') ";
                            break;
                        case DialogResult.Retry:
                            command = "UPDATE [Dispatcher] " +
                                      "SET " +
                                      $" [Name] = N'{name}', " +
                                      $" [BirthDate] = N'{birth}', " +
                                      $" [Address] = N'{address}', " +
                                      $" [Passport] = N'{passport}' " +
                                      $"WHERE [Id] = {id} ";
                            break;
                        default:
                            return;
                    }
                    SqlHelper.ExecuteQuery(command);
                    this.ViewDispatchers(sender, e);
                    break;
                }

                case ActiveTable.Driver:
                {
                    var form = new DriverForm();
                    if (isChange)
                    {
                        form.SaveButton.Enabled = true;
                        form.NameTextBox.Text = (string)this.ViewData.CurrentRow.Cells["Водитель"].Value;
                        form.BirthDatePicker.Value = (DateTime)this.ViewData.CurrentRow.Cells["Дата рождения"].Value;
                        form.AddressTextBox.Text = (string)this.ViewData.CurrentRow.Cells["Адрес"].Value;
                        form.PassportTextBox.Text = (string)this.ViewData.CurrentRow.Cells["Пасспорт"].Value;
                    }

                    var result = form.ShowDialog();

                    string command;
                    var name = form.NameTextBox.Text;
                    var birth = form.BirthDatePicker.Value.ToString("yyyy-MM-dd");
                    var address = form.AddressTextBox.Text;
                    var passport = form.PassportTextBox.Text;
                    switch (result)
                    {
                        case DialogResult.OK:
                            command = "INSERT INTO [Driver] " +
                                      " ([Name], [BirthDate], [Address], [Passport]) " +
                                      "VALUES " +
                                      $" (N'{name}', N'{birth}', N'{address}', N'{passport}')" ;
                            break;
                        case DialogResult.Retry:
                            command = "UPDATE [Driver] " +
                                      "SET " +
                                      $" [Name] = N'{name}', " +
                                      $" [BirthDate] = N'{birth}', " +
                                      $" [Address] = N'{address}', " +
                                      $" [Passport] = N'{passport}' " +
                                      $"WHERE [Id] = {id} ";
                            break;
                        default:
                            return;
                    }
                    SqlHelper.ExecuteQuery(command);
                    this.ViewDrivers(sender, e);
                    break;
                }

                case ActiveTable.Route:
                {
                    var form = new RouteForm();
                    if (isChange)
                    {
                        form.SaveButton.Enabled = true;
                        form.IdTextBox.Text = (string) this.ViewData.CurrentRow.Cells["№ маршрута"].Value;
                        form.DepartureTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Место отправления"].Value;
                        form.DestinationTextBox.Text = (string) this.ViewData.CurrentRow.Cells["Место прибытия"].Value;
                        form.DistanceNumeric.Value = Convert.ToDecimal(this.ViewData.CurrentRow.Cells["Расстояние (км)"].Value);
                        form.BeginDatePicker.Value = (DateTime) this.ViewData.CurrentRow.Cells["Время отправления"].Value;
                        form.EndDatePicker.Value = (DateTime) this.ViewData.CurrentRow.Cells["Время прибытия"].Value;
                    }

                    var result = form.ShowDialog();

                    string command;
                    var number = form.IdTextBox.Text;
                    var departure = form.DepartureTextBox.Text;
                    var destination = form.DestinationTextBox.Text;
                    var distance = (int) form.DistanceNumeric.Value;
                    var begin = form.BeginDatePicker.Value.ToString("HH:mm:ss");
                    var end = form.EndDatePicker.Value.ToString("HH:mm:ss");
                    switch (result)
                    {
                        case DialogResult.OK:
                            command = "INSERT INTO [Route] " +
                                      " ([Number], [Departure], [Destination], [Distance], [BeginDate], [EndDate]) " +
                                      "VALUES " +
                                      $" (N'{number}', N'{departure}', N'{destination}', {distance}, N'{begin}', N'{end}') ";
                            break;
                        case DialogResult.Retry:
                            command = "UPDATE [Route] " +
                                      "SET" +
                                      $" [Number] = N'{number}', " +
                                      $" [Departure] = N'{departure}', " +
                                      $" [Destination] = N'{destination}', " +
                                      $" [Distance] = {distance}, " +
                                      $" [BeginDate] = N'{begin}', " +
                                      $" [EndDate] = N'{end}' " +
                                      $"WHERE [Id] = {id} ";
                            break;
                        default:
                            return;
                    }
                    SqlHelper.ExecuteQuery(command);
                    this.ViewRoutes(sender, e);
                    break;
                }

                case ActiveTable.Ticket:
                {
                    var form = new TicketForm();
                    if (isChange)
                    {
                        form.SaveButton.Enabled = true;
                        form.PriceNumeric.Value = Convert.ToDecimal(this.ViewData.CurrentRow.Cells["Цена билета"].Value);
                        form.BuyDatePicker.Value = (DateTime)this.ViewData.CurrentRow.Cells["Дата покупки"].Value;
                        form.PlaceNumeric.Value = Convert.ToDecimal(this.ViewData.CurrentRow.Cells["Место пассажира"].Value);
                        form.PassengerTextBox.Text = (string)this.ViewData.CurrentRow.Cells["Пассажир"].Value;
                        form.PassportTextBox.Text = (string)this.ViewData.CurrentRow.Cells["Пасспорт"].Value;
                        form.DiscountCheck.Checked = (bool)this.ViewData.CurrentRow.Cells["Льготы?"].Value;
                    }

                    var result = form.ShowDialog();

                    string command;
                    var price = (int)form.PriceNumeric.Value;
                    var buy = form.BuyDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    var place = (int)form.PlaceNumeric.Value;
                    var passenger = form.PassengerTextBox.Text;
                    var passport = form.PassportTextBox.Text;
                    var discount = form.DiscountCheck.Checked ? 1 : 0;
                    switch (result)
                    {
                        case DialogResult.OK:
                            command = "INSERT INTO [Ticket] " +
                                      " ([Price], [BuyDate], [Place], [Passenger], [Passport], [Discount]) " +
                                      "VALUES " +
                                      $" ({price}, N'{buy}', {place}, N'{passenger}', N'{passport}', {discount})";
                            break;
                        case DialogResult.Retry:
                            command = "UPDATE [Ticket] " +
                                      "SET " +
                                      $" [Price] = {price}, " +
                                      $" [BuyDate] = N'{buy}', " +
                                      $" [Place] = {place}, " +
                                      $" [Passenger] = N'{passenger}', " +
                                      $" [Passport] = N'{passport}', " +
                                      $" [Discount] = {discount} " +
                                      $"WHERE [Id] = {id}";
                            break;
                        default:
                            return;
                    }
                    SqlHelper.ExecuteQuery(command);
                    this.ViewTickets(sender, e);
                    break;
                }
                default:
                    return;
            }
        }

        private void DelFromCommand(object sender, EventArgs e)
        {
            if (this.ViewData.CurrentRow == null)
                return;

            var delForm = new DelForm();
            if (delForm.ShowDialog() != DialogResult.OK)
                return;

            var command = "DELETE FROM ";
            var index = this.ViewData.CurrentRow.Index;
            var id = Convert.ToString(this.ViewData[0, index].Value);
            switch (activeTable)
            {
                case ActiveTable.Bus:
                    command += $"[Bus] WHERE [Bus].[Id] = {id} ";
                    break;
                case ActiveTable.Dispatcher:
                    command += $"[Dispatcher] WHERE [Dispatcher].[Id] = {id} ";
                    break;
                case ActiveTable.Driver:
                    command += $"[Driver] WHERE [Driver].[Id] = {id} ";
                    break;
                case ActiveTable.Route:
                    command += $"[Route] WHERE [Route].[Id] = {id} ";
                    break;
                case ActiveTable.Ticket:
                    command += $"[Ticket] WHERE [Ticket].[Id] = {id} ";
                    break;
                default:
                    return;
            }
            SqlHelper.ExecuteQuery(command);

            switch (activeTable)
            {
                case ActiveTable.Bus:
                    this.ViewBuses(sender, e);
                    break;
                case ActiveTable.Dispatcher:
                    this.ViewDispatchers(sender, e);
                    break;
                case ActiveTable.Driver:
                    this.ViewDrivers(sender, e);
                    break;
                case ActiveTable.Route:
                    this.ViewRoutes(sender, e);
                    break;
                case ActiveTable.Ticket:
                    this.ViewTickets(sender, e);
                    break;
                default:
                    return;
            }
        }

        private void ChangeFromCommand(object sender, EventArgs e)
        {
            if (this.ViewData.CurrentRow == null)
                return;

            this.AddFromCommand(sender, e);
        }
    }
}
