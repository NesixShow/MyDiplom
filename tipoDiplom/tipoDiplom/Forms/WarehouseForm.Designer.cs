namespace tipoDiplom.Forms
{
    partial class WarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            dataGridViewProject = new DataGridView();
            matTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matAmountDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            matCountBuyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matCountSellDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            warehouseBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            menuStrip1 = new MenuStrip();
            папапаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            удалитьМатериалToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            авторизоватьсяToolStripMenuItem = new ToolStripMenuItem();
            buttonSecond = new Button();
            buttonMulti = new Button();
            buttonAll = new Button();
            matAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textBoxFind = new TextBox();
            buttonAddT = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warehouseBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProject
            // 
            dataGridViewProject.AllowUserToAddRows = false;
            dataGridViewProject.AllowUserToDeleteRows = false;
            dataGridViewProject.AutoGenerateColumns = false;
            dataGridViewProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProject.Columns.AddRange(new DataGridViewColumn[] { matTypeDataGridViewTextBoxColumn, matAmountDataGridViewTextBoxColumn1, matCountBuyDataGridViewTextBoxColumn, matCountSellDataGridViewTextBoxColumn });
            dataGridViewProject.DataSource = warehouseBindingSource;
            dataGridViewProject.Location = new Point(8, 41);
            dataGridViewProject.Name = "dataGridViewProject";
            dataGridViewProject.RowHeadersVisible = false;
            dataGridViewProject.Size = new Size(514, 489);
            dataGridViewProject.TabIndex = 0;
            // 
            // matTypeDataGridViewTextBoxColumn
            // 
            matTypeDataGridViewTextBoxColumn.DataPropertyName = "MatType";
            matTypeDataGridViewTextBoxColumn.HeaderText = "Название материала";
            matTypeDataGridViewTextBoxColumn.Name = "matTypeDataGridViewTextBoxColumn";
            matTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // matAmountDataGridViewTextBoxColumn1
            // 
            matAmountDataGridViewTextBoxColumn1.DataPropertyName = "MatAmount";
            matAmountDataGridViewTextBoxColumn1.HeaderText = "Количество";
            matAmountDataGridViewTextBoxColumn1.Name = "matAmountDataGridViewTextBoxColumn1";
            matAmountDataGridViewTextBoxColumn1.Width = 110;
            // 
            // matCountBuyDataGridViewTextBoxColumn
            // 
            matCountBuyDataGridViewTextBoxColumn.DataPropertyName = "MatCountBuy";
            matCountBuyDataGridViewTextBoxColumn.HeaderText = "Цена закупки";
            matCountBuyDataGridViewTextBoxColumn.Name = "matCountBuyDataGridViewTextBoxColumn";
            // 
            // matCountSellDataGridViewTextBoxColumn
            // 
            matCountSellDataGridViewTextBoxColumn.DataPropertyName = "MatCountSell";
            matCountSellDataGridViewTextBoxColumn.HeaderText = "Цена продажи";
            matCountSellDataGridViewTextBoxColumn.Name = "matCountSellDataGridViewTextBoxColumn";
            // 
            // warehouseBindingSource
            // 
            warehouseBindingSource.DataSource = typeof(Models.Warehouse);
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(528, 41);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 120);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Сортировать от А до Я";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { папапаToolStripMenuItem, toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem4, удалитьМатериалToolStripMenuItem, toolStripMenuItem1, авторизоватьсяToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(654, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // папапаToolStripMenuItem
            // 
            папапаToolStripMenuItem.BackColor = Color.White;
            папапаToolStripMenuItem.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold | FontStyle.Italic);
            папапаToolStripMenuItem.Name = "папапаToolStripMenuItem";
            папапаToolStripMenuItem.Size = new Size(173, 27);
            папапаToolStripMenuItem.Text = "Добавить материал";
            папапаToolStripMenuItem.Click += папапаToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(22, 27);
            toolStripMenuItem3.Text = "|";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.White;
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem2.CheckState = CheckState.Checked;
            toolStripMenuItem2.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold | FontStyle.Italic);
            toolStripMenuItem2.ForeColor = SystemColors.ControlText;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShowShortcutKeys = false;
            toolStripMenuItem2.Size = new Size(177, 27);
            toolStripMenuItem2.Text = "Изменить материал";
            toolStripMenuItem2.ToolTipText = "212121";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(22, 27);
            toolStripMenuItem4.Text = "|";
            // 
            // удалитьМатериалToolStripMenuItem
            // 
            удалитьМатериалToolStripMenuItem.BackColor = Color.White;
            удалитьМатериалToolStripMenuItem.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            удалитьМатериалToolStripMenuItem.Name = "удалитьМатериалToolStripMenuItem";
            удалитьМатериалToolStripMenuItem.Size = new Size(90, 27);
            удалитьМатериалToolStripMenuItem.Text = "Удалить";
            удалитьМатериалToolStripMenuItem.Click += удалитьМатериалToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(22, 27);
            toolStripMenuItem1.Text = "|";
            // 
            // авторизоватьсяToolStripMenuItem
            // 
            авторизоватьсяToolStripMenuItem.BackColor = Color.White;
            авторизоватьсяToolStripMenuItem.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            авторизоватьсяToolStripMenuItem.Name = "авторизоватьсяToolStripMenuItem";
            авторизоватьсяToolStripMenuItem.Size = new Size(112, 27);
            авторизоватьсяToolStripMenuItem.Text = "На главную";
            авторизоватьсяToolStripMenuItem.Click += авторизоватьсяToolStripMenuItem_Click;
            // 
            // buttonSecond
            // 
            buttonSecond.BackColor = Color.White;
            buttonSecond.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSecond.Location = new Point(528, 167);
            buttonSecond.Name = "buttonSecond";
            buttonSecond.Size = new Size(120, 120);
            buttonSecond.TabIndex = 4;
            buttonSecond.Text = "Сортировать от Я до А";
            buttonSecond.UseVisualStyleBackColor = false;
            buttonSecond.Click += buttonSecond_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = Color.White;
            buttonMulti.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMulti.Location = new Point(528, 536);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(120, 60);
            buttonMulti.TabIndex = 5;
            buttonMulti.Text = "Найти материал";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonAll
            // 
            buttonAll.BackColor = Color.White;
            buttonAll.Location = new Point(528, 293);
            buttonAll.Name = "buttonAll";
            buttonAll.Size = new Size(120, 120);
            buttonAll.TabIndex = 6;
            buttonAll.Text = "Отобразить список материалов";
            buttonAll.UseVisualStyleBackColor = false;
            buttonAll.Click += buttonAll_Click;
            // 
            // matAmountDataGridViewTextBoxColumn
            // 
            matAmountDataGridViewTextBoxColumn.DataPropertyName = "MatAmount";
            matAmountDataGridViewTextBoxColumn.HeaderText = "MatAmount";
            matAmountDataGridViewTextBoxColumn.Name = "matAmountDataGridViewTextBoxColumn";
            // 
            // textBoxFind
            // 
            textBoxFind.Location = new Point(8, 536);
            textBoxFind.Multiline = true;
            textBoxFind.Name = "textBoxFind";
            textBoxFind.Size = new Size(514, 60);
            textBoxFind.TabIndex = 7;
            // 
            // buttonAddT
            // 
            buttonAddT.BackColor = Color.White;
            buttonAddT.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddT.Location = new Point(528, 419);
            buttonAddT.Name = "buttonAddT";
            buttonAddT.Size = new Size(120, 111);
            buttonAddT.TabIndex = 8;
            buttonAddT.Text = "Добавить тип материала";
            buttonAddT.UseVisualStyleBackColor = false;
            buttonAddT.Click += buttonAddT_Click;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(654, 608);
            Controls.Add(buttonAddT);
            Controls.Add(textBoxFind);
            Controls.Add(buttonAll);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSecond);
            Controls.Add(menuStrip1);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewProject);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1575, 650);
            Name = "WarehouseForm";
            Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)warehouseBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProject;
        private Button buttonAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem папапаToolStripMenuItem;
        private Button buttonSecond;
        private Button buttonMulti;
        private Button buttonAll;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem авторизоватьсяToolStripMenuItem;
        private DataGridViewTextBoxColumn typeMaterialsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MatType;
        private BindingSource warehouseBindingSource;
        private DataGridViewTextBoxColumn matAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matAmountDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn matCountBuyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matCountSellDataGridViewTextBoxColumn;
        private ToolStripMenuItem удалитьМатериалToolStripMenuItem;
        private TextBox textBoxFind;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button buttonAddT;
    }
}