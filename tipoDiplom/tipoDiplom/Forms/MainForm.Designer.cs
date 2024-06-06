namespace tipoDiplom.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridViewProject = new DataGridView();
            imageDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MatType = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responsibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeStructureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flatAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            houseBindingSource = new BindingSource(components);
            buttonOnly = new Button();
            buttonSecond = new Button();
            buttonMulti = new Button();
            buttonAll = new Button();
            houseBindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            подсчитатьЗаработнуюПлатуToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            списокСотрудниковToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            складToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            отАДоЯToolStripMenuItem = new ToolStripMenuItem();
            отЯДоАToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripMenuItem4 = new ToolStripMenuItem();
            textBoxSearch = new ToolStripTextBox();
            найтиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            buttonAdd = new Button();
            buttonRed = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProject
            // 
            dataGridViewProject.AllowUserToAddRows = false;
            dataGridViewProject.AllowUserToDeleteRows = false;
            dataGridViewProject.AutoGenerateColumns = false;
            dataGridViewProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProject.Columns.AddRange(new DataGridViewColumn[] { imageDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, MatType, descriptionDataGridViewTextBoxColumn, responsibleDataGridViewTextBoxColumn, typeStructureDataGridViewTextBoxColumn, floorAmountDataGridViewTextBoxColumn, flatAmountDataGridViewTextBoxColumn });
            dataGridViewProject.DataSource = houseBindingSource;
            dataGridViewProject.Location = new Point(8, 41);
            dataGridViewProject.Name = "dataGridViewProject";
            dataGridViewProject.RowHeadersVisible = false;
            dataGridViewProject.Size = new Size(1407, 501);
            dataGridViewProject.TabIndex = 0;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            imageDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            imageDataGridViewTextBoxColumn.HeaderText = "Макет объекта";
            imageDataGridViewTextBoxColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            imageDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            imageDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            imageDataGridViewTextBoxColumn.Width = 94;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 108;
            // 
            // MatType
            // 
            MatType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MatType.DataPropertyName = "MatType";
            MatType.HeaderText = "Тип материала";
            MatType.Name = "MatType";
            MatType.Width = 142;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 107;
            // 
            // responsibleDataGridViewTextBoxColumn
            // 
            responsibleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            responsibleDataGridViewTextBoxColumn.DataPropertyName = "Employeer";
            responsibleDataGridViewTextBoxColumn.HeaderText = "Ответственный";
            responsibleDataGridViewTextBoxColumn.Name = "responsibleDataGridViewTextBoxColumn";
            responsibleDataGridViewTextBoxColumn.Width = 169;
            // 
            // typeStructureDataGridViewTextBoxColumn
            // 
            typeStructureDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            typeStructureDataGridViewTextBoxColumn.DataPropertyName = "TypeStructure";
            typeStructureDataGridViewTextBoxColumn.HeaderText = "Тип здания";
            typeStructureDataGridViewTextBoxColumn.Name = "typeStructureDataGridViewTextBoxColumn";
            typeStructureDataGridViewTextBoxColumn.Width = 111;
            // 
            // floorAmountDataGridViewTextBoxColumn
            // 
            floorAmountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            floorAmountDataGridViewTextBoxColumn.DataPropertyName = "FloorAmount";
            floorAmountDataGridViewTextBoxColumn.HeaderText = "Количество этажей";
            floorAmountDataGridViewTextBoxColumn.Name = "floorAmountDataGridViewTextBoxColumn";
            floorAmountDataGridViewTextBoxColumn.Width = 177;
            // 
            // flatAmountDataGridViewTextBoxColumn
            // 
            flatAmountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            flatAmountDataGridViewTextBoxColumn.DataPropertyName = "FlatAmount";
            flatAmountDataGridViewTextBoxColumn.HeaderText = "Количество помещений";
            flatAmountDataGridViewTextBoxColumn.Name = "flatAmountDataGridViewTextBoxColumn";
            flatAmountDataGridViewTextBoxColumn.Width = 200;
            // 
            // houseBindingSource
            // 
            houseBindingSource.DataSource = typeof(Models.House);
            // 
            // buttonOnly
            // 
            buttonOnly.BackgroundImage = Properties.Resources.solo;
            buttonOnly.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOnly.Location = new Point(1421, 41);
            buttonOnly.Name = "buttonOnly";
            buttonOnly.Size = new Size(120, 120);
            buttonOnly.TabIndex = 1;
            buttonOnly.UseVisualStyleBackColor = true;
            buttonOnly.Click += buttonOnly_Click;
            // 
            // buttonSecond
            // 
            buttonSecond.BackgroundImage = Properties.Resources.multi;
            buttonSecond.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSecond.Location = new Point(1421, 217);
            buttonSecond.Name = "buttonSecond";
            buttonSecond.Size = new Size(120, 120);
            buttonSecond.TabIndex = 4;
            buttonSecond.UseVisualStyleBackColor = true;
            buttonSecond.Click += buttonSecond_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackgroundImage = Properties.Resources.ес;
            buttonMulti.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMulti.Location = new Point(1421, 396);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(120, 120);
            buttonMulti.TabIndex = 5;
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
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
            // houseBindingSource1
            // 
            houseBindingSource1.DataSource = typeof(Models.House);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(1421, 164);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 7;
            label1.Text = "Одноэтажные";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(1415, 340);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 8;
            label2.Text = "Многоэтажное";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(1444, 519);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 9;
            label3.Text = "ТЦ\\ТРЦ";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            menuStrip1.Items.AddRange(new ToolStripItem[] { подсчитатьЗаработнуюПлатуToolStripMenuItem, toolStripMenuItem1, списокСотрудниковToolStripMenuItem, toolStripMenuItem7, складToolStripMenuItem, toolStripMenuItem6, сортировкаToolStripMenuItem, toolStripMenuItem5, toolStripComboBox1, toolStripMenuItem4, textBoxSearch, найтиToolStripMenuItem, toolStripMenuItem3, выйтиToolStripMenuItem, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1553, 36);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // подсчитатьЗаработнуюПлатуToolStripMenuItem
            // 
            подсчитатьЗаработнуюПлатуToolStripMenuItem.BackColor = Color.White;
            подсчитатьЗаработнуюПлатуToolStripMenuItem.Name = "подсчитатьЗаработнуюПлатуToolStripMenuItem";
            подсчитатьЗаработнуюПлатуToolStripMenuItem.Size = new Size(279, 32);
            подсчитатьЗаработнуюПлатуToolStripMenuItem.Text = "Подсчитать заработную плату";
            подсчитатьЗаработнуюПлатуToolStripMenuItem.Click += подсчитатьЗаработнуюПлатуToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(29, 32);
            toolStripMenuItem1.Text = "|";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            списокСотрудниковToolStripMenuItem.BackColor = Color.White;
            списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            списокСотрудниковToolStripMenuItem.Size = new Size(181, 32);
            списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            списокСотрудниковToolStripMenuItem.Click += списокСотрудниковToolStripMenuItem_Click_1;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Enabled = false;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(29, 32);
            toolStripMenuItem7.Text = "|";
            // 
            // складToolStripMenuItem
            // 
            складToolStripMenuItem.BackColor = Color.White;
            складToolStripMenuItem.Name = "складToolStripMenuItem";
            складToolStripMenuItem.Size = new Size(68, 32);
            складToolStripMenuItem.Text = "Склад";
            складToolStripMenuItem.Click += складToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Enabled = false;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(29, 32);
            toolStripMenuItem6.Text = "|";
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.BackColor = Color.White;
            сортировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отАДоЯToolStripMenuItem, отЯДоАToolStripMenuItem });
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(117, 32);
            сортировкаToolStripMenuItem.Text = "Сортировка";
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
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Enabled = false;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(29, 32);
            toolStripMenuItem5.Text = "|";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = Color.White;
            toolStripComboBox1.DropDownHeight = 140;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.DropDownWidth = 160;
            toolStripComboBox1.IntegralHeight = false;
            toolStripComboBox1.Items.AddRange(new object[] { "Сортировка от А до Я", "Сортировка от Я до А" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(170, 32);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(29, 32);
            toolStripMenuItem4.Text = "|";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Sitka Subheading", 14F, FontStyle.Bold | FontStyle.Italic);
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
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = SystemColors.Control;
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.ForeColor = Color.White;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(54, 32);
            toolStripMenuItem3.Text = "____";
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
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(29, 32);
            toolStripMenuItem2.Text = "|";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(360, 548);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(346, 52);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Добавить объект";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.White;
            buttonRed.Location = new Point(712, 548);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(351, 52);
            buttonRed.TabIndex = 12;
            buttonRed.Text = "Изменить объект";
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.White;
            buttonDel.Location = new Point(1069, 548);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(346, 52);
            buttonDel.TabIndex = 13;
            buttonDel.Text = "Удалить объект";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1553, 608);
            Controls.Add(buttonDel);
            Controls.Add(buttonRed);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAll);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSecond);
            Controls.Add(buttonOnly);
            Controls.Add(dataGridViewProject);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1575, 650);
            MinimumSize = new Size(1560, 640);
            Name = "MainForm";
            Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProject;
        private Button buttonOnly;
        private Button buttonSecond;
        private Button buttonMulti;
        private Button buttonAll;
        private BindingSource houseBindingSource;
        private DataGridViewTextBoxColumn typeMaterialsDataGridViewTextBoxColumn;
        private BindingSource houseBindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem подсчитатьЗаработнуюПлатуToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem складToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem отАДоЯToolStripMenuItem;
        private ToolStripMenuItem отЯДоАToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripComboBox toolStripComboBox1;
        private Button buttonAdd;
        private Button buttonRed;
        private Button buttonDel;
        private ToolStripTextBox textBoxSearch;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem5;
        private DataGridViewImageColumn imageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MatType;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeStructureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flatAmountDataGridViewTextBoxColumn;
    }
}