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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            справочникToolStripMenuItem = new ToolStripMenuItem();
            добавлениеЗаписейВБДToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            справочникToolStripMenuItem1 = new ToolStripMenuItem();
            добавлениеЗаписейВБДToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            учётToolStripMenuItem = new ToolStripMenuItem();
            справочникToolStripMenuItem2 = new ToolStripMenuItem();
            добавлениеНовыхПользователейToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { справочникToolStripMenuItem, добавлениеЗаписейВБДToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(216, 48);
            // 
            // справочникToolStripMenuItem
            // 
            справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            справочникToolStripMenuItem.Size = new Size(215, 22);
            справочникToolStripMenuItem.Text = "Справочник";
            // 
            // добавлениеЗаписейВБДToolStripMenuItem
            // 
            добавлениеЗаписейВБДToolStripMenuItem.Name = "добавлениеЗаписейВБДToolStripMenuItem";
            добавлениеЗаписейВБДToolStripMenuItem.Size = new Size(215, 22);
            добавлениеЗаписейВБДToolStripMenuItem.Text = "Добавление записей в БД";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { справочникToolStripMenuItem1, добавлениеЗаписейВБДToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(216, 48);
            // 
            // справочникToolStripMenuItem1
            // 
            справочникToolStripMenuItem1.Name = "справочникToolStripMenuItem1";
            справочникToolStripMenuItem1.Size = new Size(215, 22);
            справочникToolStripMenuItem1.Text = "Справочник";
            // 
            // добавлениеЗаписейВБДToolStripMenuItem1
            // 
            добавлениеЗаписейВБДToolStripMenuItem1.Name = "добавлениеЗаписейВБДToolStripMenuItem1";
            добавлениеЗаписейВБДToolStripMenuItem1.Size = new Size(215, 22);
            добавлениеЗаписейВБДToolStripMenuItem1.Text = "Добавление записей в БД";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, справочникToolStripMenuItem2, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(446, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
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
            добавлениеНовыхПользователейToolStripMenuItem.Size = new Size(239, 22);
            добавлениеНовыхПользователейToolStripMenuItem.Text = "Добавление новых пациентов";
            добавлениеНовыхПользователейToolStripMenuItem.Click += добавлениеНовыхПользователейToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 178);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Учёт вакцинации";
            Load += Main_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem справочникToolStripMenuItem;
        private ToolStripMenuItem добавлениеЗаписейВБДToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem справочникToolStripMenuItem1;
        private ToolStripMenuItem добавлениеЗаписейВБДToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem учётToolStripMenuItem;
        private ToolStripMenuItem справочникToolStripMenuItem2;
        private ToolStripMenuItem добавлениеНовыхПользователейToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}