using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tipoDiplom.Data;
using tipoDiplom.Models;

namespace tipoDiplom.Forms
{
    public partial class WareAdd : Form
    {
        DataGridView dataGridViewProject;

        public WareAdd(DataGridView dataGridViewProject)
        {
            this.dataGridViewProject = dataGridViewProject;

            InitializeComponent();

            var db = new Db();
            comboBoxType.DataSource = db.MatType.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Db db = new Db();

                var type = db.MatType.Where(x => x.Id == ((MatType)comboBoxType.SelectedItem).Id).FirstOrDefault();

                var ware = new Warehouse()
                {
                    MatType = type,
                    MatAmount = textBoxKol.Text,
                    MatCountBuy = double.Parse(textBoxNuy.Text),
                    MatCountSell = double.Parse(textBoxSell.Text),

                };
                db.Warehouse.Add(ware);
                db.SaveChanges();

                var war = db.Warehouse
                    .Include(x=>x.MatType)
                    .ToList();
                dataGridViewProject.DataSource = war;
                dataGridViewProject.RowTemplate.Height = 50;
            }
            catch { MessageBox.Show("Проверьте введённые данные!"); }
            

        }
    }
}
