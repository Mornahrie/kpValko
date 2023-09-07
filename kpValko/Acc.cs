using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kpValko
{
    public partial class Acc : Form
    {

        public Acc()
        {
            InitializeComponent();
        }

        private void Acc_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label7.Text = "";

            int Id = Get.Value;

            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                foreach (User c in users)
                {
                    if (c.userID == Id)
                    {
                        label7.Text = c.userID.ToString();
                        label1.Text = c.name;
                        label2.Text = c.surname;
                        label3.Text = c.email;
                        label4.Text = c.date_of_birth;
                        label5.Text = c.phone_number;
                    }
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Get.Value = 0;//сброс айди, если выход из акка
            Main m = new Main();
            m.Show();
            Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ChangeInfo chi = new ChangeInfo();
            chi.Show();
            Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            dataGridView1.Rows.Clear();
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");//интро
            gifIntro.Location = new Point(520, 230);
            gifIntro.Size = Size;
            gifIntro.BringToFront();
            dataGridView1.Hide();
            button1.Hide();
            button2.Hide();

            await Task.Delay(3000);

            gifIntro.Hide();
            dataGridView1.Show();
            button1.Show();
            button2.Show();

            using (ApplicationContext db = new ApplicationContext())
            {
                int Id = Get.Value;
                var orders = db.Orders.ToList();
                foreach (Order c in orders)
                {
                    if (c.userID == Id)
                    {
                        dataGridView1.Rows.Add(c.orderID, c.carID, c.data, c.order_state);
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)//предзаказы
        {
            label8.Text = "";
            dataGridView1.Rows.Clear();
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");//интро
            gifIntro.Location = new Point(420, 230);
            gifIntro.Size = Size;
            gifIntro.BringToFront();
            dataGridView1.Hide();
            button1.Hide();
            button2.Hide();

            await Task.Delay(3000);

            gifIntro.Hide();
            dataGridView1.Show();
            button1.Show();
            button2.Show();

            using (ApplicationContext db = new ApplicationContext())
            {
                int Id = Get.Value;
                var preorders = db.PreOrders.ToList();
                foreach (PreOrder c in preorders)
                {
                    if (c.userID == Id)
                    {
                        dataGridView1.Rows.Add(c.preorderID, c.carID, c.data, c.state);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//удалить акк
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                int Id = Get.Value;
                var users = db.Users.ToList();
                if (MessageBox.Show("Вы уверенны, что хотите удалить аккаунт?", "Подтвердить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (User c in users)
                    {
                        if (c.userID == Id)
                        {
                            db.Users.Remove(c);
                            db.SaveChanges();
                            MessageBox.Show("Аккаунт удален.");
                            Main m = new Main();
                            m.Show();
                            Close();
                        }
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)//Выводит ID
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void главнаяToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
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
            label8.Text = "";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0) // проверка на корректный индекс строки
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                int cId = Convert.ToInt32(row.Cells[1].Value);
                using (ApplicationContext db = new ApplicationContext())
                {

                    var cars = db.Cars.ToList();
                    foreach (Car c in cars)
                    {
                        if (c.carID == cId)
                        {
                            label8.Text = $"Марка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel}, Цвет: {c.color}";
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
