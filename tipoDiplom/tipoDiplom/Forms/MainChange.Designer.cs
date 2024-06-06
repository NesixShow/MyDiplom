using tipoDiplom.Properties;

namespace tipoDiplom.Forms
{
    partial class MainChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChange));
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxDesc = new TextBox();
            label4 = new Label();
            label6 = new Label();
            comboBoxRes = new ComboBox();
            employeersBindingSource = new BindingSource(components);
            comboBoxType = new ComboBox();
            typeStructureBindingSource = new BindingSource(components);
            label7 = new Label();
            textBoxFloor = new TextBox();
            label8 = new Label();
            textBoxFlat = new TextBox();
            label9 = new Label();
            label13 = new Label();
            comboBoxMat = new ComboBox();
            matTypeBindingSource = new BindingSource(components);
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)employeersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeStructureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(14, 440);
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
            button2.Location = new Point(296, 440);
            button2.Name = "button2";
            button2.Size = new Size(222, 45);
            button2.TabIndex = 1;
            button2.Text = "Обновить объект";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(14, 121);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 4;
            label3.Text = "Введите название:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(296, 118);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(222, 28);
            textBoxName.TabIndex = 6;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(296, 152);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(222, 103);
            textBoxDesc.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(14, 155);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 7;
            label4.Text = "Введите описание:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Location = new Point(14, 264);
            label6.Name = "label6";
            label6.Size = new Size(235, 23);
            label6.TabIndex = 11;
            label6.Text = "Выберите ответственного:";
            // 
            // comboBoxRes
            // 
            comboBoxRes.DataSource = employeersBindingSource;
            comboBoxRes.DisplayMember = "Name";
            comboBoxRes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRes.FormattingEnabled = true;
            comboBoxRes.Location = new Point(296, 261);
            comboBoxRes.Name = "comboBoxRes";
            comboBoxRes.Size = new Size(222, 31);
            comboBoxRes.TabIndex = 12;
            comboBoxRes.ValueMember = "Name";
            // 
            // employeersBindingSource
            // 
            employeersBindingSource.DataSource = typeof(Models.Employeers);
            // 
            // comboBoxType
            // 
            comboBoxType.DataSource = typeStructureBindingSource;
            comboBoxType.DisplayMember = "Name";
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(296, 298);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(222, 31);
            comboBoxType.TabIndex = 14;
            comboBoxType.ValueMember = "Name";
            // 
            // typeStructureBindingSource
            // 
            typeStructureBindingSource.DataSource = typeof(Models.TypeStructure);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Location = new Point(14, 301);
            label7.Name = "label7";
            label7.Size = new Size(229, 23);
            label7.TabIndex = 13;
            label7.Text = "Выберите тип структуры:";
            // 
            // textBoxFloor
            // 
            textBoxFloor.Location = new Point(296, 372);
            textBoxFloor.Name = "textBoxFloor";
            textBoxFloor.Size = new Size(222, 28);
            textBoxFloor.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Location = new Point(14, 375);
            label8.Name = "label8";
            label8.Size = new Size(243, 23);
            label8.TabIndex = 15;
            label8.Text = "Введите количество этажей:";
            // 
            // textBoxFlat
            // 
            textBoxFlat.Location = new Point(296, 406);
            textBoxFlat.Name = "textBoxFlat";
            textBoxFlat.Size = new Size(222, 28);
            textBoxFlat.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Location = new Point(14, 409);
            label9.Name = "label9";
            label9.Size = new Size(269, 23);
            label9.TabIndex = 17;
            label9.Text = "Введите количество помещений:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Location = new Point(14, 338);
            label13.Name = "label13";
            label13.Size = new Size(224, 23);
            label13.TabIndex = 23;
            label13.Text = "Выберите тип материала:";
            // 
            // comboBoxMat
            // 
            comboBoxMat.DataSource = matTypeBindingSource;
            comboBoxMat.DisplayMember = "Name";
            comboBoxMat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMat.FormattingEnabled = true;
            comboBoxMat.Location = new Point(296, 335);
            comboBoxMat.Name = "comboBoxMat";
            comboBoxMat.Size = new Size(222, 31);
            comboBoxMat.TabIndex = 24;
            comboBoxMat.ValueMember = "Name";
            // 
            // matTypeBindingSource
            // 
            matTypeBindingSource.DataSource = typeof(Models.MatType);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 25;
            label2.Text = "Добавьте изображение:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(296, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(402, 12);
            button3.Name = "button3";
            button3.Size = new Size(116, 63);
            button3.TabIndex = 27;
            button3.Text = "Добавить изображение:";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainChange
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(530, 493);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(comboBoxMat);
            Controls.Add(label13);
            Controls.Add(textBoxFlat);
            Controls.Add(label9);
            Controls.Add(textBoxFloor);
            Controls.Add(label8);
            Controls.Add(comboBoxType);
            Controls.Add(label7);
            Controls.Add(comboBoxRes);
            Controls.Add(label6);
            Controls.Add(textBoxDesc);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(556, 603);
            MinimizeBox = false;
            MinimumSize = new Size(536, 508);
            Name = "MainChange";
            Text = "Изменение объекта (строения)";
            ((System.ComponentModel.ISupportInitialize)employeersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeStructureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)matTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxDesc;
        private Label label4;
        private Label label6;
        private ComboBox comboBoxRes;
        private ComboBox comboBoxType;
        private Label label7;
        private TextBox textBoxFloor;
        private Label label8;
        private TextBox textBoxFlat;
        private Label label9;
        private Label label13;
        private ComboBox comboBoxMat;
        private BindingSource employeersBindingSource;
        private BindingSource typeStructureBindingSource;
        private BindingSource matTypeBindingSource;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}