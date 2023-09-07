using kpValko;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
using static kpValko.Catalog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;

namespace kpValko
{
    public partial class Catalog : Form
    {
        int ccId;

        public Catalog()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) главнаяToolStripMenuItem_Click(this, null); };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gifIntro_Click(object sender, EventArgs e)
        {

        }
        // Определение enum
        public enum CarModel
        {
        }
        public enum CarCountry
        {

        }
        public enum CarState
        {

        }
        private async void Catalog_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
            try
            {
                int Id = Get.Value;
                if (Id == 0)
                {
                    button2.Hide();
                }

                gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");//интро
                gifIntro.Location = new Point(520, 210);
                gifIntro.Size = Size;
                gifIntro.BringToFront();
                dataGridView1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                comboBox1.Hide();
                comboBox2.Hide();
                comboBox3.Hide();

                await Task.Delay(3000);

                gifIntro.Hide();
                label2.Show();
                label3.Show();
                label4.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();

                dataGridView1.Show();

                using (ApplicationContext db = new ApplicationContext())
                {
                    var cars = db.Cars.ToList();
                    foreach (Car c in cars)
                    {
                        dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                    }
                }
                using (ApplicationContext db = new ApplicationContext())//енам по модели
                {
                    var cars = db.Cars.ToList();
                    // Получаем неповторяющиеся значения моделей
                    var carModels = cars.Select(c => c.model).Distinct().ToArray();
                    // Добавление неповторяющихся моделей из базы данных в enum
                    foreach (var model in carModels)
                    {
                        if (!Enum.IsDefined(typeof(CarModel), model))
                        {
                            Enum.TryParse(model, out CarModel carModel);
                            if (carModel != default(CarModel))
                            {
                                EnumExtensions.AddEnumValue(typeof(CarModel), model, carModel);
                            }
                        }
                    }
                    // Добавляем значения enum CarModel в combobox1
                    for (int i = 0; i < carModels.Length; i++)
                    {
                        comboBox1.Items.Insert(i, carModels[i]);
                    }
                }

                using (ApplicationContext db = new ApplicationContext())//енам по стране
                {
                    var cars = db.Cars.ToList();
                    // Получаем неповторяющиеся значения моделей
                    var carCountries = cars.Select(c => c.country).Distinct().ToArray();
                    // Добавление неповторяющихся моделей из базы данных в enum
                    foreach (var country in carCountries)
                    {
                        if (!Enum.IsDefined(typeof(CarCountry), country))
                        {
                            Enum.TryParse(country, out CarCountry carC);
                            if (carC != default(CarCountry))
                            {
                                EnumExtensions.AddEnumValue(typeof(CarCountry), country, carC);
                            }
                        }
                    }
                    for (int i = 0; i < carCountries.Length; i++)
                    {
                        comboBox2.Items.Insert(i, carCountries[i]);
                    }
                }
                using (ApplicationContext db = new ApplicationContext())//енам по статусу
                {
                    var cars = db.Cars.ToList();
                    // Получаем неповторяющиеся значения моделей
                    var carStates = cars.Select(c => c.state).Distinct().ToArray();
                    // Добавление неповторяющихся моделей из базы данных в enum
                    foreach (var state in carStates)
                    {
                        if (!Enum.IsDefined(typeof(CarState), state))
                        {
                            Enum.TryParse(state, out CarState carS);
                            if (carS != default(CarState))
                            {
                                EnumExtensions.AddEnumValue(typeof(CarState), state, carS);
                            }
                        }
                    }
                    for (int i = 0; i < carStates.Length; i++)
                    {
                        comboBox3.Items.Insert(i, carStates[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voiti v = new Voiti();
            v.Show();
            Close();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            r.Show();
            Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
            Close();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author au = new Author();
            au.Show();
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0) // проверка на корректный индекс строки
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                int cId = Convert.ToInt32(row.Cells[0].Value);
                using (ApplicationContext db = new ApplicationContext())
                {

                    var cars = db.Cars.ToList();
                    foreach (Car c in cars)
                    {
                        if (c.carID == cId)
                        {
                            label1.Text = $"Марка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel}, Цвет: {c.color}, Статус: {c.state}";
                            ccId = c.carID;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//заказать
        {
            try
            {
                if (label1.Text != "")
                {
                    int Id = Get.Value;
                    if (Id != 0)
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var cars = db.Cars.ToList();
                            foreach (Car c in cars)
                            {
                                if (c.carID == ccId)
                                {
                                    if (c.state == "в наличии")
                                    {
                                        if (MessageBox.Show("Вы уверенны, что хотите заказать машину?", "Подтвердить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        {
                                            db.Orders.Add(new Order
                                            {
                                                carID = c.carID,
                                                userID = Id,
                                                data = DateTime.Now.ToString("d"),
                                                order_state = "в процессе"
                                            });
                                            db.SaveChanges();
                                        }
                                    }
                                    else if (c.state == "нет в наличии")
                                    {
                                        if (MessageBox.Show("Машины нет в наличии.\nХотите сделать предзаказ?", "Подтвердить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        {
                                            db.PreOrders.Add(new PreOrder
                                            {
                                                carID = c.carID,
                                                userID = Id,
                                                data = DateTime.Now.ToString("d"),
                                                state = "в процессе"
                                            });
                                            db.SaveChanges();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Id == 0)
                    {
                        throw new Exception("Для того, чтобы заказать машину войдите в аккаунт!");
                    }
                }
                else
                {
                    throw new Exception("Вы не выбрали машину!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void SearchM(string searchModel)
        {
            using (ApplicationContext db = new ApplicationContext()) // заменить на имя вашего контекста
            {
                var cars = db.Cars.ToList();
                foreach (Car c in cars)
                {
                    if (c.model == searchModel)
                    {
                        dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                    }
                }
            }
        }

        private void SearchC(string searchCountry)
        {
            using (ApplicationContext db = new ApplicationContext()) // заменить на имя вашего контекста
            {
                var cars = db.Cars.ToList();
                foreach (Car c in cars)
                {
                    if (c.country == searchCountry)
                    {
                        dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                    }
                }
            }
        }
        private void SearchS(string searchState)
        {
            using (ApplicationContext db = new ApplicationContext()) // заменить на имя вашего контекста
            {
                var cars = db.Cars.ToList();
                foreach (Car c in cars)
                {
                    if (c.state == searchState)
                    {
                        dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = comboBox1.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedModel))
            {
                dataGridView1.Rows.Clear(); //очищаем все строки
                SearchM(selectedModel);
            }
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboBox2.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedCountry))
            {
                dataGridView1.Rows.Clear(); //очищаем все строки
                SearchC(selectedCountry);
            }
            comboBox1.Text = "";
            comboBox3.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox3.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedState))
            {
                dataGridView1.Rows.Clear(); //очищаем все строки
                SearchS(selectedState);
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acc acc = new Acc();
            acc.Show();
            Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
