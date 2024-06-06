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
using Microsoft.EntityFrameworkCore;

namespace tipoDiplom.Forms
{
    public partial class MainAdd : Form
    {
        House house;
        DataGridView dataGridViewProject;
        string photoFilePath;
        public MainAdd(House houses, DataGridView dataGridViewProject)
        {
            this.dataGridViewProject = dataGridViewProject;
            this.house = houses;
            InitializeComponent();

            Db db = new Db();

            comboBoxRes.DataSource = db.Employeers.ToArray();
            comboBoxMat.DataSource = db.MatType.ToArray();
            comboBoxType.DataSource = db.TypeStructures.ToArray();

            comboBoxRes.SelectedItem = house.Employeer;
            comboBoxMat.SelectedItem = house.MatType;
            comboBoxType.SelectedItem = house.TypeStructure;
        }

        public int Id { get; set; } //id этого элемента
        string pathForFile = null;
        private void button3_Click_1(object sender, EventArgs e)
        {
            Db db = new Db();
            //добавляем нужную нам картинку
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pathForFile = openFileDialog.FileName;
            }
        }
        
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBoxMat.SelectedItem == null)
            {
                return;
            }
            if (comboBoxRes.SelectedItem == null)
            {
                return;
            }
            if (comboBoxType.SelectedItem == null)
            {
                return;
            }

            Db db = new Db();

            var res = db.Employeers.Where(x => x.Id == ((Employeers)comboBoxRes.SelectedItem).Id).FirstOrDefault();
            var mat = db.MatType.Where(x => x.Id == ((MatType)comboBoxMat.SelectedItem).Id).FirstOrDefault();
            var type = db.TypeStructures.Where(x => x.Id == ((TypeStructure)comboBoxType.SelectedItem).Id).FirstOrDefault();

            try
            {
                if (pictureBox1 != null)
                {
                    var houses = new House()
                    {
                        Image = File.ReadAllBytes(pathForFile),
                        Name = textBoxName.Text,
                        Description = textBoxDesc.Text,
                        Employeer = res,
                        MatType = mat,
                        TypeStructure = type,
                        FloorAmount = int.Parse(textBoxFloor.Text),
                        FlatAmount = int.Parse(textBoxFlat.Text),
                    };
                    db.House.Add(houses);
                    db.SaveChanges();
                }
                else
                {
                    var houses = new House()
                    {   Image = null,
                        Name = textBoxName.Text,
                        Description = textBoxDesc.Text,
                        Employeer = res,
                        MatType = mat,
                        TypeStructure = type,
                        FloorAmount = int.Parse(textBoxFloor.Text),
                        FlatAmount = int.Parse(textBoxFlat.Text),
                    };
                    db.House.Add(houses);
                    db.SaveChanges();
                }
            
            var house = db.House
                .Include(x => x.Employeer)
                .Include(x => x.MatType)
                .Include(x => x.TypeStructure)
                .ToList();

            dataGridViewProject.DataSource = house;
            dataGridViewProject.RowTemplate.Height = 100;

            MessageBox.Show("Успешное добавление");

            dataGridViewProject.Refresh();
            }
            catch { MessageBox.Show("Проверьте данные"); }
        }
    }
}
