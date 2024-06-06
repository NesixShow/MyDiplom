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
    public partial class MatAdd : Form
    {
        DataGridView dataGridViewProject;
        public MatAdd(DataGridView dataGridViewProject)
        {
            this.dataGridViewProject = dataGridViewProject;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Db db = new Db();

            var mat = new MatType()
            {
                Name = textBoxName.Text,
            };
            db.MatType.Update(mat);
            db.SaveChanges();

        }
    }
}
