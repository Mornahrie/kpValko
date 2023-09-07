using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace kpValko
{
    public partial class admin : Form
    {
        int ccId;
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//диаграмма
        {
            dia d = new dia();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }

        private async void admin_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");
            gifIntro.Location = new Point(540, 260);
            gifIntro.Size = Size;
            gifIntro.BringToFront();

            dataGridView1.Hide();
            label1.Hide();
            pictureBox1.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();

            await Task.Delay(3000);

            gifIntro.Hide();

            dataGridView1.Show();
            label1.Show();
            pictureBox1.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();

            using (ApplicationContext db = new ApplicationContext())
            {
                var cars = db.Cars.ToList();
                foreach (Car c in cars)
                {
                    dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            Close();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author au = new Author();
            au.Show();
            Close();
        }

        private void gifIntro_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//добавить
        {
            Adding adding = new Adding();
            adding.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)//удалить
        {
            try
            {
                if (label2.Text != "")
                {
                    if (MessageBox.Show("Вы уверенны, что хотите удалить машину?", "Подтвердить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var cars = db.Cars.ToList();
                            foreach (Car c in cars)
                            {
                                if (c.carID == ccId)
                                {
                                    db.Cars.Remove(c);
                                    db.SaveChanges();
                                    MessageBox.Show("Машина удалена.");

                                    dataGridView1.Rows.Clear();
                                }
                            }

                            var cars1 = db.Cars.ToList();
                            foreach (Car c in cars1)
                            {
                                dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                            }
                        }
                    }
                }
                else throw new Exception("Вы не выбрали машину.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = "";
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
                            label2.Text = $"Марка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel}, Цвет: {c.color}, Статус: {c.state}";
                            ccId = c.carID;
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)//вывод в эксель
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
