using tipoDiplom.Properties;

namespace tipoDiplom.Forms
{
    partial class WareAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareAdd));
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxKol = new TextBox();
            textBoxNuy = new TextBox();
            label4 = new Label();
            textBoxSell = new TextBox();
            label5 = new Label();
            genderBindingSource = new BindingSource(components);
            postsBindingSource = new BindingSource(components);
            roleBindingSource = new BindingSource(components);
            usersBindingSource = new BindingSource(components);
            comboBoxType = new ComboBox();
            matTypeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(10, 148);
            button1.Name = "button1";
            button1.Size = new Size(195, 45);
            button1.TabIndex = 0;
            button1.Text = "Вернуться назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(234, 148);
            button2.Name = "button2";
            button2.Size = new Size(222, 45);
            button2.TabIndex = 1;
            button2.Text = "Добавить данные";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(10, 15);
            label2.Name = "label2";
            label2.Size = new Size(224, 23);
            label2.TabIndex = 3;
            label2.Text = "Выберите тип материала:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(10, 49);
            label3.Name = "label3";
            label3.Size = new Size(177, 23);
            label3.TabIndex = 4;
            label3.Text = "Введите количество:";
            // 
            // textBoxKol
            // 
            textBoxKol.Location = new Point(234, 46);
            textBoxKol.Name = "textBoxKol";
            textBoxKol.Size = new Size(222, 28);
            textBoxKol.TabIndex = 6;
            // 
            // textBoxNuy
            // 
            textBoxNuy.Location = new Point(234, 80);
            textBoxNuy.Name = "textBoxNuy";
            textBoxNuy.Size = new Size(222, 28);
            textBoxNuy.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(10, 83);
            label4.Name = "label4";
            label4.Size = new Size(180, 23);
            label4.TabIndex = 7;
            label4.Text = "Введите цену закупа:";
            // 
            // textBoxSell
            // 
            textBoxSell.Location = new Point(234, 114);
            textBoxSell.Name = "textBoxSell";
            textBoxSell.Size = new Size(222, 28);
            textBoxSell.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(10, 117);
            label5.Name = "label5";
            label5.Size = new Size(195, 23);
            label5.TabIndex = 9;
            label5.Text = "Введите цену продажи:";
            // 
            // genderBindingSource
            // 
            genderBindingSource.DataSource = typeof(Models.Gender);
            // 
            // postsBindingSource
            // 
            postsBindingSource.DataSource = typeof(Models.Posts);
            // 
            // roleBindingSource
            // 
            roleBindingSource.DataSource = typeof(Models.Role);
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // comboBoxType
            // 
            comboBoxType.DataSource = matTypeBindingSource;
            comboBoxType.DisplayMember = "Name";
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(234, 12);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(222, 31);
            comboBoxType.TabIndex = 11;
            comboBoxType.ValueMember = "Name";
            // 
            // matTypeBindingSource
            // 
            matTypeBindingSource.DataSource = typeof(Models.MatType);
            // 
            // WareAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(468, 206);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxSell);
            Controls.Add(label5);
            Controls.Add(textBoxNuy);
            Controls.Add(label4);
            Controls.Add(textBoxKol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(556, 603);
            MinimizeBox = false;
            Name = "WareAdd";
            Text = "Добавление данных склада";
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)postsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)matTypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox textBoxKol;
        private TextBox textBoxNuy;
        private Label label4;
        private TextBox textBoxSell;
        private Label label5;
        private BindingSource genderBindingSource;
        private BindingSource postsBindingSource;
        private BindingSource roleBindingSource;
        private BindingSource usersBindingSource;
        private ComboBox comboBoxType;
        private BindingSource matTypeBindingSource;
    }
}