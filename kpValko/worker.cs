using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpValko
{
    public partial class worker : Form
    {
        int orpre, prID, orID, caID;
        public worker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)//авто
        {
            orpre = 3;
            label2.Text = "";
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");//интро
            gifIntro.Location = new Point(450, 260);
            gifIntro.Size = Size;
            gifIntro.BringToFront();
            gifIntro.Show();

            dataGridView1.Hide();
            dataGridView2.Hide();

            dataGridView1.Rows.Clear();

            await Task.Delay(3000);

            gifIntro.Hide();

            dataGridView1.Show();
            comboBox2.Show();
            button6.Show();
            using (ApplicationContext db = new ApplicationContext())
            {
                var cars = db.Cars.ToList();
                foreach (Car c in cars)
                {
                    dataGridView1.Rows.Add(c.carID, c.model, c.country, c.year, c.fuel, c.color, c.state);
                }
            }
        }
        private async void button2_Click(object sender, EventArgs e)//заказы
        {
            label2.Text = "";
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");//интро
            gifIntro.Location = new Point(450, 260);
            gifIntro.Size = Size;
            gifIntro.BringToFront();
            gifIntro.Show();

            dataGridView1.Hide();
            dataGridView2.Hide();

            dataGridView2.Rows.Clear();

            await Task.Delay(3000);

            comboBox2.Hide();
            gifIntro.Hide();
            dataGridView2.Show();
            comboBox1.Show();
            button6.Show();
            orpre = 1;
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Orders.ToList();
                foreach (Order c in orders)
                {
                    dataGridView2.Rows.Add(c.orderID, c.userID, c.carID, c.data, c.order_state);
                }
            }
        }
        private async void button3_Click(object sender, EventArgs e)//предзаказы
        {
            label2.Text = "";
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");//интро
            gifIntro.Location = new Point(450, 260);
            gifIntro.Size = Size;
            gifIntro.BringToFront();
            gifIntro.Show();

            dataGridView1.Hide();
            dataGridView2.Hide();

            dataGridView2.Rows.Clear();

            await Task.Delay(3000);

            comboBox2.Hide();
            gifIntro.Hide();
            dataGridView2.Show();
            comboBox1.Show();
            button6.Show();
            orpre = 2;
            using (ApplicationContext db = new ApplicationContext())
            {
                var preorders = db.PreOrders.ToList();
                foreach (PreOrder c in preorders)
                {
                    dataGridView2.Rows.Add(c.preorderID, c.userID, c.carID, c.data, c.state);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }


        private async void worker_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
            gifIntro.Image = Image.FromFile("ezgif.com-gif-maker (2).gif");
            gifIntro.Location = new Point(450, 260);
            gifIntro.Size = Size;
            gifIntro.BringToFront();

            dataGridView1.Hide();
            dataGridView2.Hide();
            label1.Hide();
            pictureBox1.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            await Task.Delay(3000);

            gifIntro.Hide();
            label1.Show();
            pictureBox1.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
        }

        private void gifIntro_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)//на почту
        {
            Sending s = new Sending();
            s.Show();
            Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//машины
        {
            try
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
                                label2.Text = $"Марка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel},\nЦвет: {c.color}, Статус: {c.state}";
                                caID = c.carID;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)//заказы и предзаказы
        {
            try
            {
                label2.Text = "";
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0) // проверка на корректный индекс строки
                {
                    DataGridViewRow row = dataGridView2.Rows[rowIndex];
                    int oId = Convert.ToInt32(row.Cells[0].Value);
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        if (orpre == 1)
                        {
                            var orders = db.Orders.ToList();
                            foreach (Order c in orders)
                            {
                                if (c.orderID == oId)
                                {
                                    label2.Text = $"Пользователь: {c.userID}, Номер машины: {c.carID},\nДата: {c.data},Статус: {c.order_state}";
                                    orID = c.orderID;
                                }
                            }
                        }
                        else if (orpre == 2)
                        {
                            var pre = db.PreOrders.ToList();
                            foreach (PreOrder c in pre)
                            {
                                if (c.preorderID == oId)
                                {
                                    label2.Text = $"Пользователь: {c.userID}, Номер машины: {c.carID},\nДата: {c.data},Статус: {c.state}";
                                    prID = c.preorderID;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//для заказов и пред
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//для машин
        {

        }

        private void button6_Click(object sender, EventArgs e)//сохранить изменения
        {
            try
            {
                if (label2.Text != "")
                {
                    if (orpre == 1)//заказы
                    {
                        if (comboBox1.Text != "")
                        {
                            using (ApplicationContext db = new ApplicationContext())
                            {
                                var orders = db.Orders.ToList();
                                foreach (Order c in orders)
                                {
                                    if (c.orderID == orID)
                                    {
                                        if (comboBox1.Text != c.order_state)
                                        {
                                            c.order_state = comboBox1.Text;
                                            db.SaveChanges();
                                            MessageBox.Show("Статус был успешно изменен");
                                        }
                                        else throw new Exception("Вы ничего не изменили!");
                                    }
                                }
                            }
                        }
                        else throw new Exception("Вы не выбрали на что изменить!");
                    }
                    else if (orpre == 2)//пред
                    {
                        if (comboBox1.Text != "")
                        {
                            using (ApplicationContext db = new ApplicationContext())
                            {
                                var preorders = db.PreOrders.ToList();
                                foreach (PreOrder c in preorders)
                                {
                                    if (c.preorderID == prID)
                                    {
                                        if (comboBox1.Text != c.state)
                                        {
                                            c.state = comboBox1.Text;
                                            db.SaveChanges();
                                            MessageBox.Show("Статус был успешно изменен");
                                        }
                                        else throw new Exception("Вы ничего не изменили!");
                                    }
                                }
                            }
                        }
                        else throw new Exception("Вы не выбрали на что изменить!");
                    }
                    else if (orpre == 3)//машины
                    {
                        if (comboBox2.Text != "")
                        {
                            using (ApplicationContext db = new ApplicationContext())
                            {
                                var cars = db.Cars.ToList();
                                foreach (Car c in cars)
                                {
                                    if (c.carID == caID)
                                    {
                                        if (comboBox2.Text != c.state)
                                        {
                                            c.state = comboBox2.Text;
                                            db.SaveChanges();
                                            MessageBox.Show("Статус был успешно изменен");
                                        }
                                        else throw new Exception("Вы ничего не изменили!");
                                    }
                                }
                            }
                        }
                        else throw new Exception("Вы не выбрали на что изменить!");
                    }
                }
                else throw new Exception("Вы не выбрали строку для изменения!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
