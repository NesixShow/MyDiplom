namespace tipoDiplom.Forms
{
    partial class Employee
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
        ///  #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            dataGridViewProject = new DataGridView();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patronymicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gendersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateEmploymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            experienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeersBindingSource = new BindingSource(components);
            buttonAll = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            складToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            отАДоЯToolStripMenuItem = new ToolStripMenuItem();
            отЯДоАToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            textBoxSearch = new ToolStripTextBox();
            найтиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            PostsCombo = new ToolStripComboBox();
            toolStripMenuItem6 = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            buttonAdd = new Button();
            buttonRed = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeersBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProject
            // 
            dataGridViewProject.AllowUserToAddRows = false;
            dataGridViewProject.AllowUserToDeleteRows = false;
            dataGridViewProject.AutoGenerateColumns = false;
            dataGridViewProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProject.Columns.AddRange(new DataGridViewColumn[] { userDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, patronymicDataGridViewTextBoxColumn, gendersDataGridViewTextBoxColumn, dateBirthDataGridViewTextBoxColumn, postDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, dateEmploymentDataGridViewTextBoxColumn, experienceDataGridViewTextBoxColumn });
            dataGridViewProject.DataSource = employeersBindingSource;
            dataGridViewProject.Location = new Point(8, 41);
            dataGridViewProject.Name = "dataGridViewProject";
            dataGridViewProject.RowHeadersVisible = false;
            dataGridViewProject.Size = new Size(1279, 501);
            dataGridViewProject.TabIndex = 0;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "Логин";
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            patronymicDataGridViewTextBoxColumn.Width = 140;
            // 
            // gendersDataGridViewTextBoxColumn
            // 
            gendersDataGridViewTextBoxColumn.DataPropertyName = "Genders";
            gendersDataGridViewTextBoxColumn.HeaderText = "Пол";
            gendersDataGridViewTextBoxColumn.Name = "gendersDataGridViewTextBoxColumn";
            gendersDataGridViewTextBoxColumn.Width = 95;
            // 
            // dateBirthDataGridViewTextBoxColumn
            // 
            dateBirthDataGridViewTextBoxColumn.DataPropertyName = "DateBirth";
            dateBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            dateBirthDataGridViewTextBoxColumn.Name = "dateBirthDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            postDataGridViewTextBoxColumn.HeaderText = "Должность";
            postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            postDataGridViewTextBoxColumn.Width = 140;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 140;
            // 
            // dateEmploymentDataGridViewTextBoxColumn
            // 
            dateEmploymentDataGridViewTextBoxColumn.DataPropertyName = "DateEmployment";
            dateEmploymentDataGridViewTextBoxColumn.HeaderText = "Дата трудоустройства";
            dateEmploymentDataGridViewTextBoxColumn.Name = "dateEmploymentDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            experienceDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // employeersBindingSource
            // 
            employeersBindingSource.DataSource = typeof(Models.Employeers);
            // 
            // buttonAll
            // 
            buttonAll.BackColor = Color.White;
            buttonAll.Location = new Point(8, 548);
            buttonAll.Name = "buttonAll";
            buttonAll.Size = new Size(346, 52);
            buttonAll.TabIndex = 6;
            buttonAll.Text = "Отобразить все существующие объекты";
            buttonAll.UseVisualStyleBackColor = false;
            buttonAll.Click += buttonAll_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, складToolStripMenuItem, toolStripMenuItem4, сортировкаToolStripMenuItem, toolStripMenuItem3, textBoxSearch, найтиToolStripMenuItem, toolStripMenuItem5, PostsCombo, toolStripMenuItem6, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1293, 36);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(112, 32);
            toolStripMenuItem1.Text = "На главную";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(29, 32);
            toolStripMenuItem2.Text = "|";
            // 
            // складToolStripMenuItem
            // 
            складToolStripMenuItem.BackColor = Color.White;
            складToolStripMenuItem.Name = "складToolStripMenuItem";
            складToolStripMenuItem.Size = new Size(68, 32);
            складToolStripMenuItem.Text = "Склад";
            складToolStripMenuItem.Click += складToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(29, 32);
            toolStripMenuItem4.Text = "|";
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.BackColor = Color.White;
            сортировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отАДоЯToolStripMenuItem, отЯДоАToolStripMenuItem });
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(117, 32);
            сортировкаToolStripMenuItem.Text = "Сортировка";
            сортировкаToolStripMenuItem.Click += сортировкаToolStripMenuItem_Click;
            // 
            // отАДоЯToolStripMenuItem
            // 
            отАДоЯToolStripMenuItem.Name = "отАДоЯToolStripMenuItem";
            отАДоЯToolStripMenuItem.Size = new Size(156, 28);
            отАДоЯToolStripMenuItem.Text = "От А до Я";
            отАДоЯToolStripMenuItem.Click += отАДоЯToolStripMenuItem_Click;
            // 
            // отЯДоАToolStripMenuItem
            // 
            отЯДоАToolStripMenuItem.Name = "отЯДоАToolStripMenuItem";
            отЯДоАToolStripMenuItem.Size = new Size(156, 28);
            отЯДоАToolStripMenuItem.Text = "От Я до А";
            отЯДоАToolStripMenuItem.Click += отЯДоАToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(29, 32);
            toolStripMenuItem3.Text = "|";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(350, 32);
            // 
            // найтиToolStripMenuItem
            // 
            найтиToolStripMenuItem.BackColor = Color.White;
            найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            найтиToolStripMenuItem.Size = new Size(75, 32);
            найтиToolStripMenuItem.Text = "Найти";
            найтиToolStripMenuItem.Click += найтиToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Enabled = false;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(29, 32);
            toolStripMenuItem5.Text = "|";
            // 
            // PostsCombo
            // 
            PostsCombo.DropDownWidth = 150;
            PostsCombo.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            PostsCombo.Items.AddRange(new object[] { "Рабочий", "Бухгалтер", "Директор", "Бригадир", "Электрик", "Мастер", "Слесарь", "Водитель", "Инженер", "Администратор", "Кладовщик" });
            PostsCombo.Name = "PostsCombo";
            PostsCombo.Size = new Size(170, 32);
            PostsCombo.SelectedIndexChanged += PostsCombo_SelectedIndexChanged;
            PostsCombo.Click += PostsCombo_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Enabled = false;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(174, 32);
            toolStripMenuItem6.Text = "___________________";
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.BackColor = SystemColors.ControlDark;
            выйтиToolStripMenuItem.Font = new Font("Sitka Subheading", 14F, FontStyle.Bold | FontStyle.Italic);
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(89, 32);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(360, 548);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(305, 52);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Добавить объект";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.White;
            buttonRed.Location = new Point(671, 548);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(305, 52);
            buttonRed.TabIndex = 12;
            buttonRed.Text = "Изменить объект";
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.White;
            buttonDel.Location = new Point(982, 548);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(305, 52);
            buttonDel.TabIndex = 13;
            buttonDel.Text = "Удалить объект";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1293, 608);
            Controls.Add(buttonDel);
            Controls.Add(buttonRed);
            Controls.Add(buttonAdd);
            Controls.Add(buttonAll);
            Controls.Add(dataGridViewProject);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1575, 650);
            MinimizeBox = false;
            Name = "Employee";
            Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeersBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAll;
        private DataGridViewTextBoxColumn typeMaterialsDataGridViewTextBoxColumn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem складToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem отАДоЯToolStripMenuItem;
        private ToolStripMenuItem отЯДоАToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private Button buttonAdd;
        private Button buttonRed;
        private Button buttonDel;
        private BindingSource employeersBindingSource;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gendersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEmploymentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private ToolStripTextBox textBoxSearch;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripComboBox PostsCombo;
        private ToolStripMenuItem toolStripMenuItem6;
        private DataGridView dataGridViewProject;
    }
}