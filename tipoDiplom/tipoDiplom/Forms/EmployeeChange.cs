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
using Microsoft.VisualBasic.Devices;

namespace tipoDiplom.Forms
{
    public partial class EmployeeChange : Form
    {
        Employeers employee;
        DataGridView dataGridViewProject;
        public int Id { get; set; } //id этого элемента
        public EmployeeChange(Employeers employee, DataGridView dataGridViewProject)
        {
            this.dataGridViewProject = dataGridViewProject;
            this.employee = employee;
            

            InitializeComponent();
            textBoxSurname.Text = employee.Surname;
            textBoxName.Text = employee.Name;
            textBoxPatronimyc.Text = employee.Patronymic;
            textBoxBirth.Text = employee.DateBirth.ToString();
            textBoxEmail.Text = employee.Email;
            textBoxNumber.Text = employee.PhoneNumber;
            textBoxDate.Text = employee.DateEmployment.ToString();
            textBoxExp.Text = employee.Experience;

            var db = new Db();

            comboBoxLog.DataSource = db.Users.ToArray();
            comboBoxGender.DataSource = db.Gender.ToArray();
            comboBoxPost.DataSource = db.Posts.ToArray();

            comboBoxLog.SelectedItem = employee.User;
            comboBoxGender.SelectedItem = employee.Genders;
            comboBoxPost.SelectedItem = employee.Post;
        }

        private void EmployeeChange_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBoxGender.SelectedItem == null)
            {
                return;
            }
            if(comboBoxPost.SelectedItem == null)
            {
                return;
            }
            if(comboBoxLog.SelectedItem == null)
            {
                return;
            }
            try
            {
                var db = new Db();

                var log = db.Users.Where(x => x.Id == ((Users)comboBoxLog.SelectedItem).Id).FirstOrDefault();
                var gender = db.Gender.Where(x => x.Id == ((Gender)comboBoxGender.SelectedItem).Id).FirstOrDefault();
                var post = db.Posts.Where(x => x.Id == ((Posts)comboBoxPost.SelectedItem).Id).FirstOrDefault();

                employee.User = log;
                employee.Surname = textBoxSurname.Text;
                employee.Name = textBoxName.Text;
                employee.Patronymic = textBoxPatronimyc.Text;
                employee.Genders = gender;
                employee.DateBirth = DateOnly.Parse(textBoxBirth.Text);
                employee.Post = post;
                employee.Email = textBoxEmail.Text;
                employee.PhoneNumber = textBoxNumber.Text;
                employee.DateEmployment = DateOnly.Parse(textBoxDate.Text);
                employee.Experience = textBoxExp.Text;

                db.Employeers.Update(employee);
                db.SaveChanges();

                var emp = db.Employeers
                    .Include(x => x.User)
                    .Include(x => x.Genders)
                    .Include(x => x.Post)
                    .ToList();
                dataGridViewProject.DataSource = emp;
                dataGridViewProject.RowTemplate.Height = 50;
                dataGridViewProject.Refresh();

                MessageBox.Show("Пользователь успешно изменён");
            }catch { MessageBox.Show("Проверьте данные"); }
        }
    }
}
