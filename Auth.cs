
namespace Vaccined
{

    public partial class Auth : Form
    {
            private static void CheckingExceptions(string log, string pass)
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
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            SQLConnect.connection = new(SQLConnect.conn);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Pswrd = textBox2.Text;
            try
            {
                SQLConnect.connection.Open();
                CheckingExceptions(Login, Pswrd);
                string commandStr = "SELECT COUNT(UserId) FROM Users WHERE Login = @Login AND Pswrd = @Pswrd";
                MySqlCommand command = new(commandStr, SQLConnect.connection);
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Pswrd", Pswrd);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Успешная авторизация!");
                    Close();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
