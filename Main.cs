using MySql.Data.MySqlClient;

namespace Vaccined
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            this.Hide();
            Auth auth = new Auth();
            auth.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SQLConnect.connection = new MySqlConnection(SQLConnect.conn);
            SQLConnect.connection.Open();
            string sql = "SELECT Login, Pswrd FROM Users";
            MySqlCommand command = new MySqlCommand(sql, SQLConnect.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string login = reader[0].ToString();
                string pass = reader[1].ToString();
                listBox1.Items.Add($"{login} {pass}");
            }
            reader.Close();
            SQLConnect.connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLConnect.connection.Open();

            string log = textBox1.Text;
            string pass = textBox2.Text;
            string sql = $"INSERT INTO Users (Login, Pswrd) VALUES('{log}', '{pass}')";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, SQLConnect.connection);
                int insertCount = Convert.ToInt32(command.ExecuteNonQuery());
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
