using MySql.Data.MySqlClient;

namespace Vaccined
{

    public partial class Auth : Form
    {
        class NullLoginOrPass : Exception
        {
            public NullLoginOrPass(string mess) : base(mess)
            {

            }
        }
        class ShortLogin : Exception
        {
            public ShortLogin(string mess) : base(mess)
            {

            }
        }
        class ShortPass : Exception
        {
            public ShortPass(string mess) : base(mess)
            {

            }
        }
        class UsersAuth
        {
            public static void CheckingExceptions(string log, string pass)
            {
                if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pass))
                {
                    throw new NullLoginOrPass("Пожалуйста, введите логин и пароль.");
                }
                else if (log.Length <= 3)
                {
                    throw new ShortLogin("Длина логина должна составлять более трёх символов.");
                }
                else if (pass.Length <= 5)
                {
                    throw new ShortPass("Длина пароля должна составлять более пяти символов.");
                }
            }
        }
        public Auth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           SQLConnect.connection = new MySqlConnection(SQLConnect.conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Pswrd = textBox2.Text;
            try
            {
                SQLConnect.connection.Open();
                UsersAuth.CheckingExceptions(Login, Pswrd);
                string sql = "SELECT COUNT(UserId) FROM Users WHERE Login = @Login AND Pswrd = @Pswrd";
                MySqlCommand command = new MySqlCommand(sql, SQLConnect.connection);
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Pswrd", Pswrd);
                int count = Convert.ToInt32(command.ExecuteScalar().ToString());

                if (count > 0)
                {
                    MessageBox.Show("Успешная авторизация!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка подключения! Логин или пароль введены неверно");
                }
            }
            catch (NullLoginOrPass ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ShortLogin ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ShortPass ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConnect.connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
