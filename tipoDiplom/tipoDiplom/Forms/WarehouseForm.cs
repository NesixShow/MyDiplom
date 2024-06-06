using System;
using System.Collections.Generic;
using System.ComponentModel;
using tipoDiplom.Data;
using tipoDiplom.Properties.DataSources;
using Microsoft.EntityFrameworkCore;
using tipoDiplom.Forms;
using tipoDiplom.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipoDiplom.Forms
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();

            Db db = new Db();
            var warhouse = db.Warehouse
                .Include(x => x.MatType)
                .ToList();
            dataGridViewProject.DataSource = warhouse;
            dataGridViewProject.RowTemplate.Height = 50;
            dataGridViewProject.RowHeadersWidth = 150;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            var warhouse = db.Warehouse
                .Include(x => x.MatType)
                .ToList();
            dataGridViewProject.DataSource = warhouse;
            dataGridViewProject.RowTemplate.Height = 50;
        }

        private void папапаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WareAdd(dataGridViewProject).ShowDialog();
        }

        private void авторизоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Db db = new Db();

            var text = textBoxFind.Text;

            var wart = db.Warehouse
                .Include(x => x.MatType)
                .Where(x => x.MatType!.Name.Contains(text))
                .ToList();
            dataGridViewProject.DataSource = wart;
            dataGridViewProject.RowTemplate.Height = 50;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            var warhouse = db.Warehouse
                .Include(x => x.MatType)
                .OrderBy(x => x.MatType)
                .ToList();
            dataGridViewProject.DataSource = warhouse;
            dataGridViewProject.RowTemplate.Height = 50;
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            var warhouse = db.Warehouse
                .Include(x => x.MatType)
                .OrderByDescending(x => x.MatType)
                .ToList();
            dataGridViewProject.DataSource = warhouse;
            dataGridViewProject.RowTemplate.Height = 50;
        }

        private void удалитьМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var warehouse = (Warehouse)dataGridViewProject.CurrentRow.DataBoundItem;

            if (warehouse != null)
            {
                Db db = new Db();
                db.Warehouse.Remove(warehouse);
                db.SaveChanges();

                var warehouses = db.Warehouse
                    .Include(x => x.MatType)
                    .ToList();
                dataGridViewProject.DataSource = warehouses;
                dataGridViewProject.RowTemplate.Height = 50;
                MessageBox.Show("Данные удалены");
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var ware = (Warehouse)dataGridViewProject.CurrentRow.DataBoundItem;
            if (ware != null)
            {
                new WareChange(ware, dataGridViewProject).ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменение не возможно");
            }
        }

        private void buttonAddT_Click(object sender, EventArgs e)
        {
            new MatAdd(dataGridViewProject).ShowDialog();
        }
    }
}
