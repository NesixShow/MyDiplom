namespace tipoDiplom.Forms
{
    partial class Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            label1 = new Label();
            tbHour = new TextBox();
            tbDay = new TextBox();
            label2 = new Label();
            tbResult = new TextBox();
            buttonResult = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(336, 23);
            label1.TabIndex = 0;
            label1.Text = "Введите сколько часов в день работаете:";
            // 
            // tbHour
            // 
            tbHour.Location = new Point(361, 12);
            tbHour.Name = "tbHour";
            tbHour.Size = new Size(183, 28);
            tbHour.TabIndex = 1;
            // 
            // tbDay
            // 
            tbDay.Location = new Point(361, 46);
            tbDay.Name = "tbDay";
            tbDay.Size = new Size(183, 28);
            tbDay.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(345, 23);
            label2.TabIndex = 2;
            label2.Text = "Введите количество отработанных дней:";
            // 
            // tbResult
            // 
            tbResult.Font = new Font("Sitka Subheading", 11F, FontStyle.Bold | FontStyle.Italic);
            tbResult.Location = new Point(14, 162);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(532, 93);
            tbResult.TabIndex = 5;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.White;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(14, 117);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(531, 39);
            buttonResult.TabIndex = 6;
            buttonResult.Text = "Подсчитать заработную плату";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(361, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 31);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(10, 83);
            label3.Name = "label3";
            label3.Size = new Size(230, 23);
            label3.TabIndex = 8;
            label3.Text = "Выберите свою должность:";
            label3.Click += label3_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(557, 266);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(buttonResult);
            Controls.Add(tbResult);
            Controls.Add(tbDay);
            Controls.Add(label2);
            Controls.Add(tbHour);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimumSize = new Size(573, 264);
            Name = "Calc";
            Text = "Подсчёт заработной платы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbHour;
        private TextBox tbDay;
        private Label label2;
        private TextBox tbResult;
        private Button buttonResult;
        private ComboBox comboBox1;
        private Label label3;
    }
}