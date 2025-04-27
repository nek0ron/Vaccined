using MySql.Data.MySqlClient;
using System.Data;

namespace Vaccined
{
    public partial class Employees : Form
    {
        MySqlDataAdapter MyDA = new();
        BindingSource bSource = new();
        DataTable table = new();

        public void GetListUsers()
        {
            SQLConnect.connection.Open();
            string commandStr = "SELECT UserId AS 'Код пользователя', " +
                                "Name  AS 'Имя', " +
                                "Surname AS 'Фамилия', " +
                                "Login AS 'Логин', " +
                                "Pswrd  AS 'Пароль', " +
                                "IsUserActive  AS 'Состояние активности' " +
                                "FROM Users";

            MyDA.SelectCommand = new MySqlCommand(commandStr, SQLConnect.connection);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;

            SQLConnect.connection.Close();
        }
        public Employees()
        {
            InitializeComponent();
            SQLConnect.connection = new(SQLConnect.conn);
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            GetListUsers();

            int columnCount = 6;

            for (int i = 0; i < columnCount; i++)
            {
                var column = dataGridView1.Columns[i];
                column.ReadOnly = true;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        public void EditUser()
        {
            if (dataGridView1.CurrentRow == null) return;

            string? UserId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Name = DialogMode.ShowDialog("Изменить имя:", "Редактирование пользователя", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            string Surname = DialogMode.ShowDialog("Изменить фамилию:", "Редактирование пользователя", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string Login = DialogMode.ShowDialog("Изменить логин:", "Редактирование пользователя", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            string Pswrd = DialogMode.ShowDialog("Изменить пароль:", "Редактирование пользователя", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            string IsUserActive = DialogMode.ShowDialog("Изменить активность (1/0):", "Редактирование пользователя", dataGridView1.CurrentRow.Cells[5].Value.ToString());

            string commandStr = "UPDATE Users SET Name = @Name, Login = @Login, Pswrd = @Pswrd, IsUserActive = @IsUserActive WHERE UserId = @UserId";
            using (MySqlCommand cmd = new(commandStr, SQLConnect.connection))
            {
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Pswrd", Pswrd);
                cmd.Parameters.AddWithValue("@IsUserActive", IsUserActive);
                SQLConnect.connection.Open();
                cmd.ExecuteNonQuery();
                SQLConnect.connection.Close();
            }
            table.Clear();
            GetListUsers();
        }
        public void DeleteUser()
        {
            if (dataGridView1.CurrentRow == null) return;

            string? UserId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную запись?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            string commandStr = "DELETE FROM Users WHERE UserId = @UserId";
            using (MySqlCommand cmd = new MySqlCommand(commandStr, SQLConnect.connection))
            {
                cmd.Parameters.AddWithValue("@UserId", UserId);
                SQLConnect.connection.Open();
                cmd.ExecuteNonQuery();
                SQLConnect.connection.Close();
            }
            table.Clear();
            GetListUsers();
        }
        public void AddUser()
        {
            string? UserId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Name = DialogMode.ShowDialog("Введите имя:", "Добавление пользователя");
            string Surname = DialogMode.ShowDialog("Введите фамилию:", "Добавление пользователя");
            string Login = DialogMode.ShowDialog("Введите логин:", "Добавление пользователя");
            string Pswrd = DialogMode.ShowDialog("Введите пароль", "Добавление пользователя");
            string IsUserActive = DialogMode.ShowDialog("Введите активность (1/0):", "Добавление пользователя");

            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Surname) || String.IsNullOrEmpty(Login) || String.IsNullOrEmpty(Pswrd) || String.IsNullOrEmpty(IsUserActive)) return;

            string commandStr = "INSERT INTO Users (Name, Surname, Login, Pswrd, IsUserActive) VALUES (@Name, @Surname, @Login, @Pswrd, @IsUserActive)";
            using (MySqlCommand cmd = new MySqlCommand(commandStr, SQLConnect.connection))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Pswrd", Pswrd);
                cmd.Parameters.AddWithValue("@IsUserActive", IsUserActive);
                SQLConnect.connection.Open();
                cmd.ExecuteNonQuery();
                SQLConnect.connection.Close();
            }
            table.Clear();
            GetListUsers();
        }
        public static class DialogMode
        {
            public static string ShowDialog(string? text, string? caption, string? defaultValue = "")
            {
                Form prompt = new()
                {
                    Width = 400,
                    Height = 150,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterParent
                };
                Label textLabel = new() { Left = 25, Top = 25, Text = text, Width = 350 };
                TextBox inputBox = new() { Left = 25, Top = 50, Width = 350, Text = defaultValue };
                Button confirmation = new() { Text = "OK", Left = 270, Width = 90, Top = 80 };
                confirmation.Click += (sender, e) => prompt.Close();
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                prompt.ShowDialog();
                return inputBox.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}
