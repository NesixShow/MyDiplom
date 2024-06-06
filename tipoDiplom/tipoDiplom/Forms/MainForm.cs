using System;
using System.Collections.Generic;
using System.ComponentModel;
using tipoDiplom.Models;
using Microsoft.EntityFrameworkCore;
using tipoDiplom.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tipoDiplom.Data;
using tipoDiplom.Properties.DataSources;

namespace tipoDiplom.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolStripMenuItem2.Enabled = false;
            Db db = new Db();

            var house = db.House
                .Include(x => x.Employeer)
                .Include(x => x.TypeStructure)
                .Include(x => x.MatType)
                .ToList();
            toolStripComboBox1.SelectedIndex = 0;
            dataGridViewProject.DataSource = house;
            dataGridViewProject.RowTemplate.Height = 100;

        }

        private void buttonOnly_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Db db = new Db();
                try
                {
                    var house = db.House
                        .Include(x => x.Employeer)
                        .Include(x => x.TypeStructure)
                        .Include(x => x.MatType)
                        .Where(x => x.TypeStructureId == 2)
                        .OrderBy(x => x.Name)
                        .ToList();
                    dataGridViewProject.DataSource = house;
                    dataGridViewProject.RowTemplate.Height = 100;
                }
                catch { }
            }
            else
            {
                Db db = new Db();
                try
                {
                    var house = db.House
                        .Include(x => x.Employeer)
                        .Include(x => x.TypeStructure)
                        .Include(x => x.MatType)
                        .Where(x => x.TypeStructureId == 2)
                        .OrderByDescending(x => x.Name)
                        .ToList();
                    dataGridViewProject.DataSource = house;
                    dataGridViewProject.RowTemplate.Height = 100;
                }
                catch { }
            }
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Db db = new Db();
                try
                {
                    var house = db.House
                        .Include(x => x.Employeer)
                        .Include(x => x.TypeStructure)
                        .Include(x => x.MatType)
                        .Where(x => x.TypeStructureId == 1)
                        .OrderBy(x => x.Name)
                        .ToList();
                    dataGridViewProject.DataSource = house;
                    dataGridViewProject.RowTemplate.Height = 100;
                }
                catch { }
            }
            else
            {
                Db db = new Db();
                try
                {
                    var house = db.House
                        .Include(x => x.Employeer)
                        .Include(x => x.TypeStructure)
                        .Include(x => x.MatType)
                        .Where(x => x.TypeStructureId == 1)
                        .OrderByDescending(x => x.Name)
                        .ToList();
                    dataGridViewProject.DataSource = house;
                    dataGridViewProject.RowTemplate.Height = 100;
                }
                catch { }
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Db db = new Db();
                try
                {
                    var house = db.House
                        .Include(x => x.Employeer)
                        .Include(x => x.TypeStructure)
                        .Include(x => x.MatType)
                        .Where(x => x.TypeStructureId == 3)
                        .OrderBy(x => x.Name)
                        .ToList();
                    dataGridViewProject.DataSource = house;
                    dataGridViewProject.RowTemplate.Height = 100;
                }
                catch { }
            }
            else
            {
                Db db = new Db();
                try
                {
                    var house = db.House
                        .Include(x => x.Employeer)
                        .Include(x => x.TypeStructure)
                        .Include(x => x.MatType)
                        .Where(x => x.TypeStructureId == 3)
                        .OrderByDescending(x => x.Name)
                        .ToList();
                    dataGridViewProject.DataSource = house;
                    dataGridViewProject.RowTemplate.Height = 100;
                }
                catch { }
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            try
            {
                var house = db.House
                    .Include(x => x.Employeer)
                    .Include(x => x.TypeStructure)
                    .Include(x => x.MatType)
                    .ToList();

                dataGridViewProject.DataSource = house;
                dataGridViewProject.RowTemplate.Height = 100;
            }
            catch { }
        }


        private void подсчитатьЗаработнуюПлатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.ShowDialog();
            this.Close();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouse = new WarehouseForm();
            this.Hide();
            warehouse.ShowDialog();
            this.Close();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuth auth = new FormAuth();
            this.Hide();
            auth.ShowDialog();
            this.Close();
        }

        private void отАДоЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            var house = db.House
                .Include(x => x.Employeer)
                .Include(x => x.TypeStructure)
                .Include(x => x.MatType)
                .OrderBy(x => x.Name)
                .ToList();
            dataGridViewProject.DataSource = house;
            dataGridViewProject.RowTemplate.Height = 100;
        }

        private void отЯДоАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            var house = db.House
                .Include(x => x.Employeer)
                .Include(x => x.TypeStructure)
                .Include(x => x.MatType)
                .OrderByDescending(x => x.Name)
                .ToList();
            dataGridViewProject.DataSource = house;
            dataGridViewProject.RowTemplate.Height = 100;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {

            }
            else
            {

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var house = (House)dataGridViewProject.CurrentRow.DataBoundItem;
            if (house != null)
            {
                Db db = new Db();
                db.House.Remove(house);
                db.SaveChanges();

                var houses = db.House
                .Include(x => x.Employeer)
                .Include(x => x.TypeStructure)
                .Include(x => x.MatType)
                .ToList();
                dataGridViewProject.DataSource = house;
                dataGridViewProject.RowTemplate.Height = 100;
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Db db = new Db();

            var text = textBoxSearch.Text;

            var house = db.House
                .Include(x => x.Employeer)
                .Include(x => x.TypeStructure)
                .Include(x => x.MatType)
                .Where(x => x.Name.Contains(text) ||
                x.TypeStructure!.Name.Contains(text) ||
                x.MatType!.Name.Contains(text) ||
                x.Employeer!.Name.Contains(text))
                .ToList();
            dataGridViewProject.DataSource = house;
            dataGridViewProject.RowTemplate.Height = 100;

        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            var hou = (House)dataGridViewProject.CurrentRow.DataBoundItem;
            if (hou != null)
            {
                new MainChange(hou, dataGridViewProject).ShowDialog();
            }
            else {
                MessageBox.Show("Изменение не возможно");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var hou = (House)dataGridViewProject.CurrentRow.DataBoundItem;
            if (hou != null)
            {
                new MainAdd(hou, dataGridViewProject).ShowDialog();
            }
            else
            {
                MessageBox.Show("Добавление не возможно");
            }
        }
    }
}
