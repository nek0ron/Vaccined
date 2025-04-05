using MySql.Data.MySqlClient;

namespace Vaccined
{

    public partial class Auth : Form
    {
        string conn = "server=stud-mysql.sdlik.ru;port=33445;user=st_333_19;database=is_333_19_KR;password=92263238";
        MySqlConnection connection;
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
            connection = new MySqlConnection(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pass = textBox2.Text;
            connection.Open();

            try
            {
                UsersAuth.CheckingExceptions(log, pass);
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

            string sql = $"SELECT COUNT(UserId) FROM Users WHERE Login='{log}' AND Pswrd='{pass}'";
            MySqlCommand command = new MySqlCommand(sql, connection);
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
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
