namespace tipoDiplom.Forms
{
    partial class FormAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            button_log = new Button();
            checkBox_PassChar = new CheckBox();
            label_log = new Label();
            label_pass = new Label();
            textBox_log = new TextBox();
            textBox_pass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_log
            // 
            button_log.BackColor = Color.White;
            button_log.BackgroundImageLayout = ImageLayout.Stretch;
            button_log.Cursor = Cursors.Hand;
            button_log.FlatStyle = FlatStyle.Popup;
            button_log.ForeColor = SystemColors.ControlText;
            button_log.Location = new Point(12, 78);
            button_log.Name = "button_log";
            button_log.Size = new Size(153, 39);
            button_log.TabIndex = 0;
            button_log.Text = "Войти";
            button_log.UseVisualStyleBackColor = false;
            button_log.Click += button_log_Click;
            // 
            // checkBox_PassChar
            // 
            checkBox_PassChar.AutoSize = true;
            checkBox_PassChar.BackColor = SystemColors.Control;
            checkBox_PassChar.Cursor = Cursors.Hand;
            checkBox_PassChar.FlatStyle = FlatStyle.Popup;
            checkBox_PassChar.Location = new Point(171, 85);
            checkBox_PassChar.Name = "checkBox_PassChar";
            checkBox_PassChar.Size = new Size(150, 27);
            checkBox_PassChar.TabIndex = 2;
            checkBox_PassChar.Text = "Защита пароля";
            checkBox_PassChar.UseVisualStyleBackColor = false;
            checkBox_PassChar.CheckedChanged += checkBox_PassChar_CheckedChanged;
            // 
            // label_log
            // 
            label_log.AutoSize = true;
            label_log.BackColor = SystemColors.Control;
            label_log.Location = new Point(12, 12);
            label_log.Name = "label_log";
            label_log.Size = new Size(63, 23);
            label_log.TabIndex = 3;
            label_log.Text = "Логин:";
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.BackColor = SystemColors.Control;
            label_pass.Location = new Point(12, 47);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(73, 23);
            label_pass.TabIndex = 4;
            label_pass.Text = "Пароля:";
            // 
            // textBox_log
            // 
            textBox_log.BorderStyle = BorderStyle.FixedSingle;
            textBox_log.Cursor = Cursors.IBeam;
            textBox_log.Location = new Point(101, 9);
            textBox_log.Name = "textBox_log";
            textBox_log.Size = new Size(222, 28);
            textBox_log.TabIndex = 5;
            // 
            // textBox_pass
            // 
            textBox_pass.BorderStyle = BorderStyle.FixedSingle;
            textBox_pass.Cursor = Cursors.IBeam;
            textBox_pass.Location = new Point(101, 44);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(222, 28);
            textBox_pass.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 123);
            button1.Name = "button1";
            button1.Size = new Size(311, 39);
            button1.TabIndex = 7;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormAuth
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(332, 170);
            Controls.Add(button1);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_log);
            Controls.Add(label_pass);
            Controls.Add(label_log);
            Controls.Add(checkBox_PassChar);
            Controls.Add(button_log);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(348, 213);
            MinimizeBox = false;
            Name = "FormAuth";
            Text = "Авторизация";
            Load += FormAuth_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_log;
        private CheckBox checkBox_PassChar;
        private Label label_log;
        private Label label_pass;
        private TextBox textBox_log;
        private TextBox textBox_pass;
        private Button button1;
    }
}