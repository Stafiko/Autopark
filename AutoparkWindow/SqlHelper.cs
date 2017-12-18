using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoparkWindow
{
    public static class SqlHelper
    {
        public const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Autopark;Integrated Security=True";

        public static DataSet GetTable(string tableName, string sqlCommand = null)
        {
            var dataSet = new DataSet();
            var command = sqlCommand ?? $"SELECT * FROM {tableName}";
            try
            {
                using (var dataAdapter = new SqlDataAdapter(command, ConnectionString))
                    dataAdapter.Fill(dataSet, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так...", "OMG?!");
            }

            return dataSet;
        }

        public static void FillGrid(DataGridView grid, string tableName, string gridTableName = null, int gridTableId = -1, string sqlCommand = null)
        {
            var dataSet = GetTable(tableName, sqlCommand);
            var view = gridTableId > -1
                ? dataSet.Tables[gridTableId].DefaultView
                : gridTableName != null
                    ? dataSet.Tables[gridTableName].DefaultView
                    : dataSet.Tables[tableName].DefaultView;

            grid.DataSource = view;
        }

        public static void ExecuteQuery(string sqlCommand)
        {
            if (string.IsNullOrWhiteSpace(sqlCommand))
                return;
            
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так...", "OMG?!");
                }

                connection.Close();
            }
        }
    }
}
