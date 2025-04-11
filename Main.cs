﻿using MySql.Data.MySqlClient;

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

        }
        private void добавлениеНовыхПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
