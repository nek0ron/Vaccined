namespace Vaccined
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            учётToolStripMenuItem = new ToolStripMenuItem();
            справочникToolStripMenuItem2 = new ToolStripMenuItem();
            добавлениеНовыхПользователейToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { учётToolStripMenuItem });
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(63, 20);
            главнаяToolStripMenuItem.Text = "Главная";
            // 
            // учётToolStripMenuItem
            // 
            учётToolStripMenuItem.Name = "учётToolStripMenuItem";
            учётToolStripMenuItem.Size = new Size(99, 22);
            учётToolStripMenuItem.Text = "Учёт";
            // 
            // справочникToolStripMenuItem2
            // 
            справочникToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { добавлениеНовыхПользователейToolStripMenuItem });
            справочникToolStripMenuItem2.Name = "справочникToolStripMenuItem2";
            справочникToolStripMenuItem2.Size = new Size(87, 20);
            справочникToolStripMenuItem2.Text = "Справочник";
            // 
            // добавлениеНовыхПользователейToolStripMenuItem
            // 
            добавлениеНовыхПользователейToolStripMenuItem.Name = "добавлениеНовыхПользователейToolStripMenuItem";
            добавлениеНовыхПользователейToolStripMenuItem.Size = new Size(204, 22);
            добавлениеНовыхПользователейToolStripMenuItem.Text = "Работа с БД (пациенты)";
            добавлениеНовыхПользователейToolStripMenuItem.Click += добавлениеНовыхПользователейToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, справочникToolStripMenuItem2, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(345, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 157);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Учёт вакцинации";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem учётToolStripMenuItem;
        private ToolStripMenuItem справочникToolStripMenuItem2;
        private ToolStripMenuItem добавлениеНовыхПользователейToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}