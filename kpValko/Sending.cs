using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace kpValko
{
    public partial class Sending : Form
    {
        string mail = "", name = "", message = "";
        int pro = 0;
        public Sending()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) button1_Click(this, null); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker w = new worker();
            w.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)//заказы (должны выводиться ток выполненные
        {
            pro = 1;
            dataGridView1.Rows.Clear(); //очищаем все строки
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Orders.ToList();
                foreach (Order c in orders)
                {
                    if (c.order_state == "выполнен")
                    {
                        dataGridView1.Rows.Add(c.orderID, c.userID, c.carID, c.data, c.order_state);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)//предзаказы
        {
            dataGridView1.Rows.Clear(); //очищаем все строки
            pro = 2;
            using (ApplicationContext db = new ApplicationContext())
            {
                var preorders = db.PreOrders.ToList();
                foreach (PreOrder c in preorders)
                {
                    if (c.state == "выполнен")
                    {
                        dataGridView1.Rows.Add(c.preorderID, c.userID, c.carID, c.data, c.state);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

            int rowIndex = e.RowIndex;
            if (rowIndex >= 0) // проверка на корректный индекс строки
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                int cId = Convert.ToInt32(row.Cells[2].Value);
                int uId = Convert.ToInt32(row.Cells[1].Value);
                using (ApplicationContext db = new ApplicationContext())
                {

                    var cars = db.Cars.ToList();
                    foreach (Car c in cars)
                    {
                        if (c.carID == cId)
                        {
                            label1.Text = $"Марка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel}, Цвет: {c.color}, Статус: {c.state}";
                            var orders = db.Orders.ToList();
                            if (pro == 1)
                            {
                                foreach (Order o in orders)
                                {
                                    if (o.carID == c.carID)
                                    {
                                        if (o.order_state == "выполнен")
                                        {
                                            var us = db.Users.ToList();
                                            foreach (User u in us)
                                            {
                                                if (o.userID == u.userID)
                                                {
                                                    message = $"С радостью уведомляем Вас, что ваш заказ поступил!\nИнфо:\nМарка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel}, Цвет: {c.color}, Статус: {c.state}\n\n\nС нетерпением ждем вас снова! ^^";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (pro == 2)
                            {
                                var preorders = db.PreOrders.ToList();
                                foreach (PreOrder o in preorders)
                                {
                                    if (o.carID == c.carID)
                                    {
                                        if (o.state == "выполнен")
                                        {
                                            var us = db.Users.ToList();
                                            foreach (User u in us)
                                            {
                                                if (o.userID == u.userID)
                                                {
                                                    message = $"С радостью уведомляем Вас, что ваш заказ поступил!\nИнфо:\nМарка: {c.model}, Страна-производитель: {c.country}, \nГод производства: {c.year},  Вид топлива: {c.fuel}, Цвет: {c.color}, Статус: {c.state}\n\n\nС нетерпением ждем вас снова! ^^";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var users = db.Users.ToList();
                    foreach (User u in users)
                    {
                        if (u.userID == uId)
                        {
                            label2.Text = $"Почта: {u.email}";
                            name = u.name;
                            mail = u.email;
                        }
                    }
                }
            }
        }

        static void SendMessage(string userName, string adressTo, string messageSubject, string messageText)
        {
            try
            {
                string from = @"kpvalko@mail.ru"; // адреса отправителя
                string pass = "4SzEtgqe2ir4t7WPSsLw"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = messageSubject; // тема
                mess.Body = messageText; // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru"; //smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю
                mess.To.Remove(mess.To[0]);
                mess.To.Add(from); //для сообщения на свой адрес
                mess.Subject = "Отправлено сообщение";
                mess.Body = "Пользователю " + userName + " отправлено сообщение";
                client.Send(mess); // отправка себе
                mess.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userName = name; //имя пользователя
            string adressTo = mail; //адрес пользователя
            string messageSubject = "";
            if (pro == 1)
            {
                messageSubject = "Заказ"; //тема
            }
            else if (pro == 2)
            {
                messageSubject = "Предзаказ"; //тема
            }
            string messageText = message; //текст
            SendMessage(userName, adressTo, messageSubject, messageText);
            MessageBox.Show("Уведомление успешно отправлено!");
        }

        private void Sending_Load(object sender, EventArgs e)
        {

        }
    }
}
