using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpValko
{
    public partial class ChangeInfo : Form
    {
        
        public ChangeInfo()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) button1_Click(button1, null); };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acc a = new Acc();
            a.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//редакт бд
        {
            try
            {
                int Id = Get.Value;
                if (textBox1.Text != "")
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var users = db.Users.ToList();
                        foreach (User c in users)
                        {
                            if (c.userID == Id)
                            {
                                c.name = textBox1.Text;
                                db.SaveChanges();
                            }
                        }
                    }
                }
                if (textBox2.Text != "")
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var users = db.Users.ToList();
                        foreach (User c in users)
                        {
                            if (c.userID == Id)
                            {
                                c.surname = textBox2.Text;
                                db.SaveChanges();
                            }
                        }
                    }
                }
                if (textBox3.Text != "")
                {
                    string email = textBox3.Text;//проверка емэйла
                    Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                    if (!emailRegex.IsMatch(email))
                    {
                        throw new Exception("Некорректная почта!");
                    }

                    using (ApplicationContext db = new ApplicationContext())
                    {
                        bool isEmailUnique = !db.Users.Any(u => u.email == textBox3.Text);
                        var users = db.Users.ToList();
                        if (isEmailUnique)
                        {
                            foreach (User c in users)
                            {
                                if (c.userID == Id)
                                {
                                     c.email = textBox3.Text;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else throw new Exception("Данный адрес почты уже занят. Введите другую.");
                    }
                }
                if (textBox4.Text != "")
                {
                    string pattern = @"^(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).\d{4}$";
                    Regex regex = new Regex(pattern);
                    if (!regex.IsMatch(textBox4.Text))
                    {
                        throw new Exception("Некорректный формат даты!");
                    }

                    DateTime date = DateTime.ParseExact(textBox4.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                    if (date.Month > 12 || DateTime.DaysInMonth(date.Year, date.Month) < date.Day)
                    {
                        throw new Exception("Некорректная дата!");
                    }


                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var users = db.Users.ToList();
                        foreach (User c in users)
                        {
                            if (c.userID == Id)
                            {
                                c.date_of_birth = textBox4.Text;
                                db.SaveChanges();
                            }
                        }
                    }
                }
                string str = maskedTextBox2.Text;
                if (str != "+375(  )    -  -" && maskedTextBox2.Text.Length == 18)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        bool isphnUnique = !db.Users.Any(u => u.phone_number == maskedTextBox2.Text);
                        if (isphnUnique)
                        {
                            var users = db.Users.ToList();
                            foreach (User c in users)
                            {
                                if (c.userID == Id)
                                {
                                   c.phone_number = maskedTextBox2.Text;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else throw new Exception("Данный номер телефона уже занят. Используйте другой.");
                    }
                }
                if (textBox6.Text != "")
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        bool isLoginUnique = !db.Users.Any(u => u.login == textBox6.Text);
                        if (isLoginUnique)
                        {
                            var users = db.Users.ToList();
                            foreach (User c in users)
                            {
                                if (c.userID == Id)
                                {
                                    c.login = textBox6.Text;
                                    db.SaveChanges();
                                }
                            }
                        }
                        else throw new Exception("Данный логин уже занят. Используйте другой.");
                        if(textBox6.Text.Length < 4)
                        {
                            throw new Exception("Длина логина не должна быть меньше 4 символов");
                        }
                        if (textBox6.Text.Length > 16)
                        {
                            throw new Exception("Длина логина не должна превышать 16 символов");
                        }
                    }
                }
                if (textBox7.Text != "")
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        if (textBox7.Text.Length < 4)
                        {
                            throw new Exception("Длина пароля не должна быть меньше 4 символов");
                        }
                        if (textBox7.Text.Length > 16)
                        {
                            throw new Exception("Длина пароля не должна превышать 16 символов");
                        }
                        var users = db.Users.ToList();
                        foreach (User c in users)
                        {
                            if (c.userID == Id)
                            {
                                c.password = textBox7.Text;
                                db.SaveChanges();
                            }
                        }
                    }
                }
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && str == "+375(  )    -  -" && textBox6.Text == "" && textBox7.Text == "")
                {
                    throw new Exception("Вы не изменили ничего.");
                }
                else
                {
                    var t = Task.Run(async delegate// делегат
                    {
                        await Task.Delay(3000);
                        return 42;
                    });
                    t.Wait();
                    MessageBox.Show("Изменения сохранены!");

                    Acc a = new Acc();
                    a.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button2_Click(button2, null);
            }
        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label6.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label9.Text = "";
            label8.Text = "";

            int Id = Get.Value;

            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                foreach (User c in users)
                {
                    if (c.userID == Id)
                    {
                        label7.Text = c.name;
                        label6.Text = c.surname;
                        label3.Text = c.email;
                        label4.Text = c.date_of_birth;
                        label5.Text = c.phone_number;
                        label9.Text = c.login;
                        label8.Text = c.password;
                    }
                }
            }

            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            textBox3.TabIndex = 2;
            textBox4.TabIndex = 3;
            maskedTextBox2.TabIndex = 4;
            textBox6.TabIndex = 5;
            textBox7.TabIndex = 6;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)//тел
        {

        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что введённый символ не цифра и не Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем нажатие клавиши
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
