using tipoDiplom.Properties;

namespace tipoDiplom.Forms
{
    partial class FormReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            button1 = new Button();
            button2 = new Button();
            genderBindingSource = new BindingSource(components);
            postsBindingSource = new BindingSource(components);
            label13 = new Label();
            textBoxLog = new TextBox();
            textBoxPass = new TextBox();
            label14 = new Label();
            comboBoxRole = new ComboBox();
            roleBindingSource = new BindingSource(components);
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(15, 116);
            button1.Name = "button1";
            button1.Size = new Size(110, 48);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(131, 116);
            button2.Name = "button2";
            button2.Size = new Size(255, 45);
            button2.TabIndex = 1;
            button2.Text = "Добавить тользователя";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // genderBindingSource
            // 
            genderBindingSource.DataSource = typeof(Models.Gender);
            // 
            // postsBindingSource
            // 
            postsBindingSource.DataSource = typeof(Models.Posts);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Location = new Point(15, 17);
            label13.Name = "label13";
            label13.Size = new Size(130, 23);
            label13.TabIndex = 23;
            label13.Text = "Введите логин:";
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(164, 12);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(222, 28);
            textBoxLog.TabIndex = 24;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(164, 46);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(222, 28);
            textBoxPass.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.Location = new Point(15, 51);
            label14.Name = "label14";
            label14.Size = new Size(139, 23);
            label14.TabIndex = 25;
            label14.Text = "Введите пароль:";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DataSource = roleBindingSource;
            comboBoxRole.DisplayMember = "Name";
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(164, 80);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(222, 31);
            comboBoxRole.TabIndex = 28;
            comboBoxRole.ValueMember = "Name";
            // 
            // roleBindingSource
            // 
            roleBindingSource.DataSource = typeof(Models.Role);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Location = new Point(15, 85);
            label12.Name = "label12";
            label12.Size = new Size(135, 23);
            label12.TabIndex = 27;
            label12.Text = "Выберите роль:";
            // 
            // FormReg
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(398, 169);
            Controls.Add(comboBoxRole);
            Controls.Add(label12);
            Controls.Add(textBoxPass);
            Controls.Add(label14);
            Controls.Add(textBoxLog);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(424, 243);
            MinimizeBox = false;
            Name = "FormReg";
            Text = "Регистрация пользователя";
            ((System.ComponentModel.ISupportInitialize)genderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)postsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label13;
        private TextBox textBoxLog;
        private TextBox textBoxPass;
        private Label label14;
        private BindingSource genderBindingSource;
        private BindingSource postsBindingSource;
        private ComboBox comboBoxRole;
        private BindingSource roleBindingSource;
        private Label label12;
    }
}