using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpValko
{
    public partial class Adding : Form
    {
        public Adding()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) button1_Click(button1, null); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//добавить
        {
            try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "" && comboBox6.Text != "")
                {
                    if (MessageBox.Show("Вы действительно хотите добавить автомобиль?\n", "Подтвердить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sModel = comboBox1.SelectedItem.ToString();
                        string sCountry = comboBox2.SelectedItem.ToString();
                        string sYear = comboBox3.SelectedItem.ToString();
                        string sFuel = comboBox4.SelectedItem.ToString();
                        string sColor = comboBox5.SelectedItem.ToString();
                        string sState = comboBox6.SelectedItem.ToString();

                        using (ApplicationContext db = new ApplicationContext())
                        {
                            db.Cars.Add(new Car
                            {
                                model = sModel,
                                country = sCountry,
                                year = Convert.ToInt32(sYear),
                                fuel = sFuel,
                                color = sColor,
                                state = sState
                            });
                            db.SaveChanges();
                            MessageBox.Show("Машина добавлена!");
                        }
                    }
                }
                else throw new Exception("Не все характеристики выбраны!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Adding_Load(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)//вывод
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)//вывести инфо
        {
            try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "" && comboBox6.Text != "")
                {
                    string sModel = comboBox1.SelectedItem.ToString();
                    string sCountry = comboBox2.SelectedItem.ToString();
                    string sYear = comboBox3.SelectedItem.ToString();
                    string sFuel = comboBox4.SelectedItem.ToString();
                    string sColor = comboBox6.SelectedItem.ToString();
                    string sState = comboBox6.SelectedItem.ToString();
                    label7.Text = $"Марка: {sModel}, Страна-производитель: {sCountry}, \nГод производства: {sYear},  Вид топлива: {sFuel},\n Цвет: {sColor}, Статус: {sState}";
                }
                else throw new Exception("Не все характеристики выбраны!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
