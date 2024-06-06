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
    public partial class WareChange : Form
    {
        Warehouse ware;
        DataGridView dataGridViewProject;

        public WareChange(Warehouse ware , DataGridView dataGridViewProject)
        {   
            this.ware = ware;
            this.dataGridViewProject = dataGridViewProject;

            InitializeComponent();


            textBoxKol.Text = ware.MatAmount;
            textBoxNuy.Text = ware.MatCountBuy.ToString();
            textBoxSell.Text = ware.MatCountSell.ToString();

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

                ware.MatType = type;
                ware.MatAmount = textBoxKol.Text;
                ware.MatCountBuy = double.Parse(textBoxNuy.Text);
                ware.MatCountSell = double.Parse(textBoxSell.Text);
                
                db.Warehouse.Update(ware);
                db.SaveChanges();

                var war = db.Warehouse
                    .Include(x => x.MatType)
                    .ToList();
                dataGridViewProject.DataSource = war;
                dataGridViewProject.RowTemplate.Height = 50;
            }catch { MessageBox.Show("Проверьте введённые данные"); }
        }
    }
}
