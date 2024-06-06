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
    public partial class MainChange : Form
    {
        House house;
        DataGridView dataGridViewProject;
        string photoFilePath;
        public int Id { get; set; } //id этого элемента
        string pathForFile = null;
        public MainChange(House house, DataGridView dataGridViewProject)
        {
            this.dataGridViewProject = dataGridViewProject;
            this.house = house;
            InitializeComponent();

            textBoxName.Text = house.Name;
            textBoxFloor.Text = house.FloorAmount.ToString();
            textBoxFlat.Text = house.FlatAmount.ToString();
            textBoxDesc.Text = house.Description;


            var db = new Db();

            comboBoxRes.DataSource = db.Employeers.ToArray();
            comboBoxMat.DataSource = db.MatType.ToArray();
            comboBoxType.DataSource = db.TypeStructures.ToArray();

            comboBoxRes.SelectedItem = house.Employeer;
            comboBoxMat.SelectedItem = house.MatType;
            comboBoxType.SelectedItem = house.TypeStructure;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
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
        private void LoadImageFromBytes(byte[] image)
        {
            //один из вариантов загрузки изображения в БД, если там будут храниться именно изображения, а не пути к ним
            using (var stream = new MemoryStream(image))
            {
                pictureBox1.Image = Image.FromStream(stream);
            }
        }
        private void button2_Click(object sender, EventArgs e)
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

            var db = new Db();

            var res = db.Employeers.Where(x => x.Id == ((Employeers)comboBoxRes.SelectedItem).Id).FirstOrDefault();
            var mat = db.MatType.Where(x => x.Id == ((MatType)comboBoxMat.SelectedItem).Id).FirstOrDefault();
            var type = db.TypeStructures.Where(x => x.Id == ((TypeStructure)comboBoxType.SelectedItem).Id).FirstOrDefault();

            try
            {
                if (pictureBox1.Image != null)
                {

                    house.Image = File.ReadAllBytes(pathForFile);
                    house.Name = textBoxName.Text;
                    house.Description = textBoxDesc.Text;
                    house.Employeer = res;
                    house.MatType = mat;
                    house.TypeStructure = type;
                    house.FloorAmount = int.Parse(textBoxFloor.Text);
                    house.FlatAmount = int.Parse(textBoxFlat.Text);

                    db.House.Update(house);
                    db.SaveChanges();
                }
                else
                {
                    house.Image = null;
                    house.Name = textBoxName.Text;
                    house.Description = textBoxDesc.Text;
                    house.Employeer = res;
                    house.MatType = mat;
                    house.TypeStructure = type;
                    house.FloorAmount = int.Parse(textBoxFloor.Text);
                    house.FlatAmount = int.Parse(textBoxFlat.Text);

                    db.House.Update(house);
                    db.SaveChanges();
                }

                var houses = db.House
                    .Include(x => x.Employeer)
                    .Include(x => x.MatType)
                    .Include(x => x.TypeStructure)
                    .ToList();

                dataGridViewProject.DataSource = houses;
                dataGridViewProject.RowTemplate.Height = 100;

                MessageBox.Show("Успешное добавление");

                dataGridViewProject.Refresh();

            }
            catch { MessageBox.Show("Проверьте данные"); }

        }
        public static byte[] getPhoto (string filepath)
        {
            FileStream stream = new FileStream(
                filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();
            return photo;
        }
    }
}
