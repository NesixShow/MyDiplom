using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tipoDiplom.Data;
using tipoDiplom.Models;
using tipoDiplom.Forms;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace tipoDiplom.Forms
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
            checkBox_PassChar.Checked = true;

        }



        private void checkBox_PassChar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PassChar.Checked)
            {
                textBox_pass.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_pass.UseSystemPasswordChar = false;
            }
        }


        public static string RoleName = "";
        public void button_log_Click(object sender, EventArgs e)
        {

            Db db = new Db();
            if (textBox_log.Text == "" && textBox_pass.Text == "")
            {
                Guest guest = new Guest();
                this.Hide();
                guest.ShowDialog();
                this.Close();
            }


            var user = db.Users
                .Include(x => x.Roles)
                .Where(x => x.Login == textBox_log.Text && x.Password == textBox_pass.Text)
                .FirstOrDefault();

            if (user != null)
            {

                
                if (user.Roles!.Name == "Сотрудник")
                {
                    MessageBox.Show("Успешный вход");
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else if (user.Roles!.Name == "Кладовщик")
                {
                    MessageBox.Show("Успешный вход");
                    WarehouseForm warehouse = new WarehouseForm();
                    this.Hide();
                    warehouse.ShowDialog();
                    this.Close();
                }
                else if (user.Roles!.Name == "Администратор")
                {
                    MessageBox.Show("Успешный вход");
                    Choise choise = new Choise();
                    this.Hide();
                    choise.ShowDialog();
                    this.Close();
                }
                else if (user.Roles!.Name == "Директор")
                {
                    MessageBox.Show("Успешный вход");
                    Choise choise = new Choise();
                    this.Hide();
                    choise.ShowDialog();
                    this.Close();
                }
                
            }

            else { MessageBox.Show("Проверьте введённые данные!!!"); }


        }


        private void button_Reg_Click(object sender, EventArgs e)
        {

        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReg reg = new FormReg();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }
    }
}
