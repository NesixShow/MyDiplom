using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipoDiplom.Forms
{
    public partial class Choise : Form
    {
        public Choise()
        {
            InitializeComponent();
        }

        private void Choise_Load(object sender, EventArgs e)
        {

        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Hide();
            employee.ShowDialog();
            this.Close();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouse = new WarehouseForm();
            this.Hide();
            warehouse.ShowDialog();
            this.Close();
        }
    }
}
