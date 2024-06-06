using tipoDiplom.Properties;

namespace tipoDiplom.Forms
{
    partial class MatAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatAdd));
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBoxName = new TextBox();
            genderBindingSource = new BindingSource(components);
            postsBindingSource = new BindingSource(components);
            roleBindingSource = new BindingSource(components);
            usersBindingSource = new BindingSource(components);
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
            button1.Location = new Point(8, 46);
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
            button2.Location = new Point(232, 46);
            button2.Name = "button2";
            button2.Size = new Size(222, 45);
            button2.TabIndex = 1;
            button2.Text = "Добавить материал";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 4;
            label3.Text = "Введите название:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(234, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(222, 28);
            textBoxName.TabIndex = 6;
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
            // matTypeBindingSource
            // 
            matTypeBindingSource.DataSource = typeof(Models.MatType);
            // 
            // MatAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(468, 99);
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
            Name = "MatAdd";
            Text = "Добавление материалов";
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
        private Label label3;
        private TextBox textBoxName;
        private BindingSource genderBindingSource;
        private BindingSource postsBindingSource;
        private BindingSource roleBindingSource;
        private BindingSource usersBindingSource;
        private BindingSource matTypeBindingSource;
    }
}