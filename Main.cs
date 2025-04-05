using MySql.Data.MySqlClient;

namespace Vaccined
{
    public partial class Main : Form
    {
        string conn = "server=stud-mysql.sdlik.ru;port=33445;user=st_333_19;database=is_333_19_KR;password=92263238";
        MySqlConnection connection;
        public Main()
        {
            InitializeComponent();
            this.Hide();
            Auth auth = new Auth();
            auth.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(conn);
            connection.Open();
            string sql = "SELECT Login, Pswrd FROM Users";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string login = reader[0].ToString();
                string pass = reader[1].ToString();
                listBox1.Items.Add($"{login} {pass}");
            }
            reader.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection?.Open();

            int insertCount = 0;

            string login = textBox1.Text;
            string pswd = textBox2.Text;
            string sql = $"INSERT INTO Users (Login, Pswrd) VALUES('{login}', '{pswd}')";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                insertCount = Convert.ToInt32(command.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Операция добавления пользователя закончилась с ошибкой!" + " " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
