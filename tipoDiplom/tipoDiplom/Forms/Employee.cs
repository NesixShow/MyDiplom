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
using Microsoft.EntityFrameworkCore;
using tipoDiplom.Properties.DataSources;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace tipoDiplom.Forms
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            PostsCombo.SelectedIndex = 0;
            try
            {
                Db db = new Db();
                var employee = db.Employeers
                    .Include(x => x.User)
                    .Include(x => x.Genders)
                    .Include(x => x.Post)
                    .ToList();
                dataGridViewProject.DataSource = employee;
                dataGridViewProject.RowTemplate.Height = 50;
            }
            catch { MessageBox.Show("Error"); }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuth auth = new FormAuth();
            this.Hide();
            auth.ShowDialog();
            this.Close();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouse = new WarehouseForm();
            this.Hide();
            warehouse.ShowDialog();
            this.Close();
        }

        private void подсчитатьЗаработнуюПлатуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Db db = new Db();

                var text = textBoxSearch.Text;

                var employee = db.Employeers
                    .Include(x => x.User)
                    .Include(x => x.Genders)
                    .Include(x => x.Post)
                    .Where(x => x.Name.Contains(text) ||
                           x.Surname.Contains(text) ||
                           x.Patronymic.Contains(text) ||
                           x.Genders!.Name.Contains(text) ||
                           x.Post!.Name.Contains(text) ||
                           x.Email.Contains(text) ||
                           x.PhoneNumber.Contains(text) ||
                           x.Experience.Contains(text))
                    .ToList();
                dataGridViewProject.DataSource = employee;
                dataGridViewProject.RowTemplate.Height = 50;
            }
            catch { MessageBox.Show("Error"); }
        }

        private void отАДоЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Db db = new Db();

                var employee = db.Employeers
                    .Include(x => x.User)
                    .Include(x => x.Genders)
                    .Include(x => x.Post)
                    .OrderBy(x => x.Surname)
                    .ToList();
                dataGridViewProject.DataSource = employee;
                dataGridViewProject.RowTemplate.Height = 50;
            }
            catch { MessageBox.Show("Error"); }
        }

        private void отЯДоАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Db db = new Db();

                var employee = db.Employeers
                    .Include(x => x.User)
                    .Include(x => x.Genders)
                    .Include(x => x.Post)
                    .OrderByDescending(x => x.Surname)
                    .ToList();
                dataGridViewProject.DataSource = employee;
                dataGridViewProject.RowTemplate.Height = 50;
            }
            catch { MessageBox.Show("Error"); }
        }

        private void PostsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Db db = new Db();

                if (PostsCombo.SelectedIndex == 0)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Рабочий")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                if (PostsCombo.SelectedIndex == 1)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Бухгалтер")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                if (PostsCombo.SelectedIndex == 2)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Директор")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                if (PostsCombo.SelectedIndex == 3)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Бригадир")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;

                }
                if (PostsCombo.SelectedIndex == 4)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Электрик")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                if (PostsCombo.SelectedIndex == 5)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Мастер")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }

                if (PostsCombo.SelectedIndex == 6)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Слесарь")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                if (PostsCombo.SelectedIndex == 7)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Водитель")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                if (PostsCombo.SelectedIndex == 8)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Инженер")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }
                else if (PostsCombo.SelectedIndex == 9)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Администратор")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }

                else if (PostsCombo.SelectedIndex == 10)
                {
                    var employee = db.Employeers
                        .Include(x => x.User)
                        .Include(x => x.Genders)
                        .Include(x => x.Post)
                        .Where(x => x.Post!.Name == "Кладовщик")
                        .ToList();
                    dataGridViewProject.DataSource = employee;
                    dataGridViewProject.RowTemplate.Height = 50;
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            Db db = new Db();

            var employee = db.Employeers
                .Include(x => x.User)
                .Include(x => x.Genders)
                .Include(x => x.Post)
                .ToList();
            dataGridViewProject.DataSource = employee;
            dataGridViewProject.RowTemplate.Height = 50;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new EmployeeAdd(dataGridViewProject).ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var emp = (Employeers)dataGridViewProject.CurrentRow.DataBoundItem;

            if (emp != null)
            {
                Db db = new Db();
                db.Employeers.Remove(emp);
                db.Users.Remove(emp.User);
                db.SaveChanges();

                var employee = db.Employeers
                .Include(x => x.User)
                .Include(x => x.Genders)
                .Include(x => x.Post)
                .ToList();
                dataGridViewProject.DataSource = employee;
                dataGridViewProject.RowTemplate.Height = 50;
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            var emp = (Employeers)dataGridViewProject.CurrentRow.DataBoundItem;
            if (emp != null)
            {
                new EmployeeChange(emp, dataGridViewProject).ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменение не возможно");
            }
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PostsCombo_Click(object sender, EventArgs e)
        {

        }
    }
}
