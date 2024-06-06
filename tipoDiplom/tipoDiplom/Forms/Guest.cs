using System.Net;
using tipoDiplom.Forms;
using tipoDiplom.Data;
using tipoDiplom.Properties.DataSources;
using tipoDiplom.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace tipoDiplom
{
    public partial class Guest : Form
    {
        public Guest()
        {

            InitializeComponent();
            toolStripMenuItem2.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void àâòîðèçîâàòüñÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuth auth = new FormAuth();
            this.Hide();
            auth.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Guest_Load(object sender, EventArgs e)
        {

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

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            try
            {
                var house = db.House
                    .Include(x => x.Employeer)
                    .Include(x => x.TypeStructure)
                    .Include(x => x.MatType)
                    .Where(x => x.TypeStructureId == 3)
                    .ToList();
                dataGridViewProject.DataSource = house;
                dataGridViewProject.RowTemplate.Height = 100;
            }
            catch { }
        }

        private void buttonOnly_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            try
            {
                var house = db.House
                    .Include(x => x.Employeer)
                    .Include(x => x.TypeStructure)
                    .Include(x => x.MatType)
                    .Where(x => x.TypeStructureId == 2)
                    .ToList();
                dataGridViewProject.DataSource = house;
                dataGridViewProject.RowTemplate.Height = 100;
            }
            catch { }
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            try
            {
                var house = db.House
                    .Include(x => x.Employeer)
                    .Include(x => x.TypeStructure)
                    .Include(x => x.MatType)
                    .Where(x => x.TypeStructureId == 1)
                    .ToList();
                dataGridViewProject.DataSource = house;
                dataGridViewProject.RowTemplate.Height = 100;
            }
            catch { }
        }
    }
}
