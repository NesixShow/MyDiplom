namespace tipoDiplom.Properties.DataSources;

partial class EmployeeAdd
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAdd));
        button1 = new Button();
        button2 = new Button();
        label2 = new Label();
        label3 = new Label();
        textBoxSurname = new TextBox();
        textBoxName = new TextBox();
        textBoxPatronimyc = new TextBox();
        label4 = new Label();
        textBoxBirth = new TextBox();
        label5 = new Label();
        label6 = new Label();
        comboBoxGender = new ComboBox();
        genderBindingSource = new BindingSource(components);
        comboBoxPost = new ComboBox();
        postsBindingSource = new BindingSource(components);
        label7 = new Label();
        textBoxEmail = new TextBox();
        label8 = new Label();
        textBoxNumber = new TextBox();
        label9 = new Label();
        textBoxDate = new TextBox();
        label10 = new Label();
        textBoxExp = new TextBox();
        label11 = new Label();
        label13 = new Label();
        roleBindingSource = new BindingSource(components);
        comboBoxLog = new ComboBox();
        usersBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)genderBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)postsBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)roleBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.White;
        button1.Location = new Point(14, 395);
        button1.Name = "button1";
        button1.Size = new Size(272, 45);
        button1.TabIndex = 0;
        button1.Text = "Вернуться назад";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.White;
        button2.Location = new Point(296, 395);
        button2.Name = "button2";
        button2.Size = new Size(222, 45);
        button2.TabIndex = 1;
        button2.Text = "Добавить тользователя";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = SystemColors.Control;
        label2.Location = new Point(14, 15);
        label2.Name = "label2";
        label2.Size = new Size(159, 23);
        label2.TabIndex = 3;
        label2.Text = "Введите фамилию:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = SystemColors.Control;
        label3.Location = new Point(14, 49);
        label3.Name = "label3";
        label3.Size = new Size(116, 23);
        label3.TabIndex = 4;
        label3.Text = "Введите имя:";
        // 
        // textBoxSurname
        // 
        textBoxSurname.Location = new Point(296, 12);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(222, 28);
        textBoxSurname.TabIndex = 5;
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(296, 46);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(222, 28);
        textBoxName.TabIndex = 6;
        // 
        // textBoxPatronimyc
        // 
        textBoxPatronimyc.Location = new Point(296, 80);
        textBoxPatronimyc.Name = "textBoxPatronimyc";
        textBoxPatronimyc.Size = new Size(222, 28);
        textBoxPatronimyc.TabIndex = 8;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = SystemColors.Control;
        label4.Location = new Point(14, 83);
        label4.Name = "label4";
        label4.Size = new Size(164, 23);
        label4.TabIndex = 7;
        label4.Text = "Введите отчество:";
        // 
        // textBoxBirth
        // 
        textBoxBirth.Location = new Point(296, 151);
        textBoxBirth.Name = "textBoxBirth";
        textBoxBirth.Size = new Size(222, 28);
        textBoxBirth.TabIndex = 10;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.BackColor = SystemColors.Control;
        label5.Location = new Point(14, 154);
        label5.Name = "label5";
        label5.Size = new Size(208, 23);
        label5.TabIndex = 9;
        label5.Text = "Введите дату рождения:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.BackColor = SystemColors.Control;
        label6.Location = new Point(14, 117);
        label6.Name = "label6";
        label6.Size = new Size(127, 23);
        label6.TabIndex = 11;
        label6.Text = "Выберите пол:";
        // 
        // comboBoxGender
        // 
        comboBoxGender.BackColor = SystemColors.Window;
        comboBoxGender.DataSource = genderBindingSource;
        comboBoxGender.DisplayMember = "Name";
        comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxGender.FormattingEnabled = true;
        comboBoxGender.Location = new Point(296, 114);
        comboBoxGender.Name = "comboBoxGender";
        comboBoxGender.Size = new Size(222, 31);
        comboBoxGender.TabIndex = 12;
        comboBoxGender.ValueMember = "Name";
        // 
        // genderBindingSource
        // 
        genderBindingSource.DataSource = typeof(Models.Gender);
        // 
        // comboBoxPost
        // 
        comboBoxPost.DataSource = postsBindingSource;
        comboBoxPost.DisplayMember = "Name";
        comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxPost.FormattingEnabled = true;
        comboBoxPost.Location = new Point(296, 185);
        comboBoxPost.Name = "comboBoxPost";
        comboBoxPost.Size = new Size(222, 31);
        comboBoxPost.TabIndex = 14;
        comboBoxPost.ValueMember = "Name";
        // 
        // postsBindingSource
        // 
        postsBindingSource.DataSource = typeof(Models.Posts);
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.BackColor = SystemColors.Control;
        label7.Location = new Point(14, 188);
        label7.Name = "label7";
        label7.Size = new Size(189, 23);
        label7.TabIndex = 13;
        label7.Text = "Выберите должность:";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(296, 222);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(222, 28);
        textBoxEmail.TabIndex = 16;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.BackColor = SystemColors.Control;
        label8.Location = new Point(14, 225);
        label8.Name = "label8";
        label8.Size = new Size(136, 23);
        label8.TabIndex = 15;
        label8.Text = "Введите почту:";
        // 
        // textBoxNumber
        // 
        textBoxNumber.Location = new Point(296, 256);
        textBoxNumber.Name = "textBoxNumber";
        textBoxNumber.Size = new Size(222, 28);
        textBoxNumber.TabIndex = 18;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.BackColor = SystemColors.Control;
        label9.Location = new Point(14, 259);
        label9.Name = "label9";
        label9.Size = new Size(217, 23);
        label9.TabIndex = 17;
        label9.Text = "Введите номер телефона:";
        // 
        // textBoxDate
        // 
        textBoxDate.Location = new Point(296, 290);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.Size = new Size(222, 28);
        textBoxDate.TabIndex = 20;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.BackColor = SystemColors.Control;
        label10.Location = new Point(14, 293);
        label10.Name = "label10";
        label10.Size = new Size(276, 23);
        label10.TabIndex = 19;
        label10.Text = "Введите дату трудоустройства:";
        // 
        // textBoxExp
        // 
        textBoxExp.Location = new Point(296, 324);
        textBoxExp.Name = "textBoxExp";
        textBoxExp.Size = new Size(222, 28);
        textBoxExp.TabIndex = 22;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.BackColor = SystemColors.Control;
        label11.Location = new Point(14, 327);
        label11.Name = "label11";
        label11.Size = new Size(198, 23);
        label11.TabIndex = 21;
        label11.Text = "Введите опыт работы:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.BackColor = SystemColors.Control;
        label13.Location = new Point(14, 361);
        label13.Name = "label13";
        label13.Size = new Size(181, 23);
        label13.TabIndex = 23;
        label13.Text = "Выберите свой логин:";
        // 
        // roleBindingSource
        // 
        roleBindingSource.DataSource = typeof(Models.Role);
        // 
        // comboBoxLog
        // 
        comboBoxLog.DataSource = usersBindingSource;
        comboBoxLog.DisplayMember = "Login";
        comboBoxLog.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxLog.FormattingEnabled = true;
        comboBoxLog.Location = new Point(296, 358);
        comboBoxLog.Name = "comboBoxLog";
        comboBoxLog.Size = new Size(222, 31);
        comboBoxLog.TabIndex = 24;
        comboBoxLog.ValueMember = "Login";
        // 
        // usersBindingSource
        // 
        usersBindingSource.DataSource = typeof(Models.Users);
        // 
        // EmployeeAdd
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(530, 453);
        Controls.Add(comboBoxLog);
        Controls.Add(label13);
        Controls.Add(textBoxExp);
        Controls.Add(label11);
        Controls.Add(textBoxDate);
        Controls.Add(label10);
        Controls.Add(textBoxNumber);
        Controls.Add(label9);
        Controls.Add(textBoxEmail);
        Controls.Add(label8);
        Controls.Add(comboBoxPost);
        Controls.Add(label7);
        Controls.Add(comboBoxGender);
        Controls.Add(label6);
        Controls.Add(textBoxBirth);
        Controls.Add(label5);
        Controls.Add(textBoxPatronimyc);
        Controls.Add(label4);
        Controls.Add(textBoxName);
        Controls.Add(textBoxSurname);
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
        Name = "EmployeeAdd";
        Text = "Добавление пользователя";
        Load += FormChoice_Load;
        ((System.ComponentModel.ISupportInitialize)genderBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)postsBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)roleBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Label label2;
    private Label label3;
    private TextBox textBoxSurname;
    private TextBox textBoxName;
    private TextBox textBoxPatronimyc;
    private Label label4;
    private TextBox textBoxBirth;
    private Label label5;
    private Label label6;
    private ComboBox comboBoxGender;
    private ComboBox comboBoxPost;
    private Label label7;
    private TextBox textBoxEmail;
    private Label label8;
    private TextBox textBoxNumber;
    private Label label9;
    private TextBox textBoxDate;
    private Label label10;
    private TextBox textBoxExp;
    private Label label11;
    private Label label13;
    private BindingSource genderBindingSource;
    private BindingSource postsBindingSource;
    private BindingSource roleBindingSource;
    private ComboBox comboBoxLog;
    private BindingSource usersBindingSource;
}