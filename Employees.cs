using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaccined
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            SQLConnect.connection = new MySqlConnection(SQLConnect.conn);
            SQLConnect.connection.Open();
            string sql = "SELECT Login, Pswrd FROM Users";
            MySqlCommand command = new MySqlCommand(sql, SQLConnect.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string? login = reader[0].ToString();
                string? pass = reader[1].ToString();
                listBox1.Items.Add($"Логин: {login} | Пароль: {pass}");
            }
            reader.Close();
            SQLConnect.connection.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLConnect.connection.Open();

            int insertCount = 0;
            string log = textBox1.Text;
            string pass = textBox2.Text;
            string sql = $"INSERT INTO Users(Login, Pswrd) VALUES('{log}', '{pass}')";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, SQLConnect.connection);
                insertCount = Convert.ToInt32(command.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления пользователя! Что-то пошло не так - {ex.Message}");
            }
            finally
            {
                SQLConnect.connection.Close();
            }
        }
    }
}
