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


namespace tipoDiplom.Forms
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            Db db = new Db();
            comboBox1.DataSource = db.Posts.ToList();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            
            try
            {
                Db db = new Db();
                var role = db.Posts.Where(x => x.Name == ((Posts)comboBox1.SelectedItem).Name).FirstOrDefault();
                
                if (role!.Name == "Рабочий")
                {
                    double a, b, c, d, f;
                    f = 170; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Бухгалтер")
                {
                    double a, b, c, d, f;
                    f = 190; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Директор")
                {
                    double a, b, c, d, f;
                    f = 300; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Бригадир")
                {
                    double a, b, c, d, f;
                    f = 210; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Электрик")
                {
                    double a, b, c, d, f;
                    f = 210; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Мастер")
                {
                    double a, b, c, d, f;
                    f = 200; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Слесарь")
                {
                    double a, b, c, d, f;
                    f = 180; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Водитель")
                {
                    double a, b, c, d, f;
                    f = 240; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Инженер")
                {
                    double a, b, c, d, f;
                    f = 190; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Администратор")
                {
                    double a, b, c, d, f;
                    f = 180; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }
                else if (role!.Name == "Кладовщик")
                {
                    double a, b, c, d, f;
                    f = 187; /// рублей в час
                    a = double.Parse(tbHour.Text);
                    b = double.Parse(tbDay.Text) * a;
                    c = (f * b); ///Заработная плата без снятия налога
                    d = c - ((c / 100) * 13); ///заработная плата с процентами

                    tbResult.Text = $"Ваша заработная плата без вычета подоходного налога составляет : {c} \r\n" +
                        $"Ваша заработная плата с учётом вычета подоходного налога состовляет : {d}";
                }

            }
            catch { MessageBox.Show("Возможно вы неверно ввели данные"); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
