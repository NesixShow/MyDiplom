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
using tipoDiplom.Forms;
using tipoDiplom.Models;


namespace tipoDiplom.Forms
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();

            Db db = new Db();
            comboBoxRole.DataSource = (db.Role.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAuth auth = new FormAuth();
            this.Hide();
            auth.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Db db = new Db();

                if (comboBoxRole.SelectedIndex == null)
                {
                    return;
                }

                var role = db.Role.Where(x => x.Id == ((Role)comboBoxRole.SelectedItem).Id).FirstOrDefault();

                var newUser = new Users()
                {
                    Login = textBoxLog.Text,
                    Password = textBoxPass.Text,
                    Roles = role
                };
                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен");
            }
            catch { 
                MessageBox.Show("Ошибка заполнения полей!"); 
            }
            
        }
    }
}
