using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Schedule.DB
{
    public class Connection
    {
        public void ConnectionFun()
        {
            string server = "sql8.freesqldatabase.com";
            string database = "sql8751184";
            string user = "sql8751184";
            string password = "KFLf9dkgar";

            string connectionString = $"Server={server};Database={database};User ID={user};Password={password};Port=3306;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Соединение установлено!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Соединение не установлено", "Неудача :(", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
      
    }
}
