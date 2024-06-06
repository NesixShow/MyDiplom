namespace tipoDiplom
{
    partial class Guest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            dataGridViewProject = new DataGridView();
            houseBindingSource = new BindingSource(components);
            buttonOnly = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            авторизоватьсяToolStripMenuItem = new ToolStripMenuItem();
            buttonSecond = new Button();
            buttonMulti = new Button();
            buttonAll = new Button();
            houseBindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            imageDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MatType = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responsibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeStructureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flatAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource1).BeginInit();
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
            // houseBindingSource
            // 
            houseBindingSource.DataSource = typeof(Models.House);
            // 
            // buttonOnly
            // 
            buttonOnly.BackColor = Color.White;
            buttonOnly.BackgroundImage = Properties.Resources.solo;
            buttonOnly.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOnly.Location = new Point(1421, 41);
            buttonOnly.Name = "buttonOnly";
            buttonOnly.Size = new Size(120, 120);
            buttonOnly.TabIndex = 1;
            buttonOnly.UseVisualStyleBackColor = false;
            buttonOnly.Click += buttonOnly_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, авторизоватьсяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1553, 36);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem2.CheckState = CheckState.Checked;
            toolStripMenuItem2.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            toolStripMenuItem2.ForeColor = SystemColors.Control;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShowShortcutKeys = false;
            toolStripMenuItem2.Size = new Size(1358, 32);
            toolStripMenuItem2.Text = "_______________________________________________________________________________________________________________________________________________________________________";
            toolStripMenuItem2.ToolTipText = "212121";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // авторизоватьсяToolStripMenuItem
            // 
            авторизоватьсяToolStripMenuItem.BackColor = Color.White;
            авторизоватьсяToolStripMenuItem.Font = new Font("Sitka Subheading", 14F, FontStyle.Bold | FontStyle.Italic);
            авторизоватьсяToolStripMenuItem.Name = "авторизоватьсяToolStripMenuItem";
            авторизоватьсяToolStripMenuItem.Size = new Size(179, 32);
            авторизоватьсяToolStripMenuItem.Text = "Авторизоваться";
            авторизоватьсяToolStripMenuItem.Click += авторизоватьсяToolStripMenuItem_Click;
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
            buttonAll.Size = new Size(1407, 52);
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
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(1421, 164);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 7;
            label1.Text = "Одноэтажные";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(1415, 340);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 8;
            label2.Text = "Многоэтажное";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(1444, 519);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 9;
            label3.Text = "ТЦ\\ТРЦ";
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
            // Guest
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1553, 608);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAll);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSecond);
            Controls.Add(menuStrip1);
            Controls.Add(buttonOnly);
            Controls.Add(dataGridViewProject);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1575, 650);
            MinimumSize = new Size(1560, 640);
            Name = "Guest";
            Text = "Главная страница (Авторизируйтесь для полного функционирования)";
            Load += Guest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)houseBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProject;
        private Button buttonOnly;
        private MenuStrip menuStrip1;
        private Button buttonSecond;
        private Button buttonMulti;
        private Button buttonAll;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem авторизоватьсяToolStripMenuItem;
        private BindingSource houseBindingSource;
        private DataGridViewTextBoxColumn typeMaterialsDataGridViewTextBoxColumn;
        private BindingSource houseBindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
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
