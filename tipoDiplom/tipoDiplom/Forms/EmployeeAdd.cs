using Microsoft.EntityFrameworkCore;
using tipoDiplom.Data;
using tipoDiplom.Models;
using tipoDiplom.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipoDiplom.Properties.DataSources
{
    public partial class EmployeeAdd : Form
    {
        DataGridView dataGridViewProject;

        public EmployeeAdd(DataGridView dataGridViewProject)
        {
            this.dataGridViewProject = dataGridViewProject;

            InitializeComponent();

            var db = new Db();
            comboBoxGender.DataSource = (db.Gender.ToArray());
            comboBoxPost.DataSource = (db.Posts.ToArray());
            comboBoxLog.DataSource = (db.Users.ToArray());
        }

        private void FormChoice_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedItem == null)
            {
                return;
            }
            if (comboBoxPost.SelectedItem == null)
            {
                return;
            }

            var db = new Db();

            var gender = db.Gender.Where(x => x.Id == ((Gender)comboBoxGender.SelectedItem).Id).FirstOrDefault();
            var post = db.Posts.Where(x => x.Id == ((Posts)comboBoxPost.SelectedItem).Id).FirstOrDefault();
            var login = db.Users.Where(x => x.Id == ((Users)comboBoxLog.SelectedItem).Id).FirstOrDefault();
            try
            {
                var employee = new Employeers()
                {

                    User = login,
                    Surname = textBoxSurname.Text,
                    Name = textBoxName.Text,
                    Patronymic = textBoxPatronimyc.Text,
                    Genders = gender,
                    DateBirth = DateOnly.Parse(textBoxBirth.Text),
                    Post = post,
                    Email = textBoxEmail.Text,
                    PhoneNumber = textBoxNumber.Text,
                    DateEmployment = DateOnly.Parse(textBoxDate.Text),
                    Experience = textBoxExp.Text,

                };

                db.Employeers.Add(employee);
                db.SaveChanges();

                var emp = db.Employeers
                    .Include(x => x.User)
                    .Include(x => x.Genders)
                    .Include(x => x.Post)
                    .ToList();
                dataGridViewProject.DataSource = emp;
                dataGridViewProject.Refresh();

                MessageBox.Show("Пользователь успешно добавлен");
            }
            catch { MessageBox.Show("Проверьте корректность данных"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
