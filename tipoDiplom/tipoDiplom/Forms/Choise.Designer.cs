namespace tipoDiplom.Forms
{
    partial class Choise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choise));
            buttonMain = new Button();
            buttonEmployee = new Button();
            buttonWarehouse = new Button();
            SuspendLayout();
            // 
            // buttonMain
            // 
            buttonMain.Location = new Point(15, 18);
            buttonMain.Margin = new Padding(4, 5, 4, 5);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(252, 71);
            buttonMain.TabIndex = 0;
            buttonMain.Text = "Главная";
            buttonMain.UseVisualStyleBackColor = true;
            buttonMain.Click += buttonMain_Click;
            // 
            // buttonEmployee
            // 
            buttonEmployee.Location = new Point(15, 98);
            buttonEmployee.Margin = new Padding(4, 5, 4, 5);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(252, 71);
            buttonEmployee.TabIndex = 1;
            buttonEmployee.Text = "Сотрудники";
            buttonEmployee.UseVisualStyleBackColor = true;
            buttonEmployee.Click += buttonEmployee_Click;
            // 
            // buttonWarehouse
            // 
            buttonWarehouse.Location = new Point(15, 178);
            buttonWarehouse.Margin = new Padding(4, 5, 4, 5);
            buttonWarehouse.Name = "buttonWarehouse";
            buttonWarehouse.Size = new Size(252, 71);
            buttonWarehouse.TabIndex = 2;
            buttonWarehouse.Text = "Склад";
            buttonWarehouse.UseVisualStyleBackColor = true;
            buttonWarehouse.Click += buttonWarehouse_Click;
            // 
            // Choise
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1614265459_58_p_cherno_belii_fon_steni_77;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(283, 264);
            Controls.Add(buttonWarehouse);
            Controls.Add(buttonEmployee);
            Controls.Add(buttonMain);
            DoubleBuffered = true;
            Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Choise";
            Text = "Выбор рабочих областей";
            Load += Choise_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMain;
        private Button buttonEmployee;
        private Button buttonWarehouse;
    }
}