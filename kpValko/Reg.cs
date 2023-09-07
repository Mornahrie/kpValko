using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace kpValko
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) главнаяToolStripMenuItem_Click_1(главнаяToolStripMenuItem_Click_1, null); };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//имя
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//фамилия
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)//почта (нужен шаблон) (уник)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)//логин (уник) (кол-во символов)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//пароль (уник) (кол-во символов)
        {

        }


        private void button1_Click(object sender, EventArgs e)//взаимодействие бд и перекидывание на войти
        {
            try 
            {
                string pattern = @"^(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).\d{4}$";//проверка даты
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

                string email = textBox3.Text;//проверка емэйла
                Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!emailRegex.IsMatch(email))
                {
                    throw new Exception("Некорректная почта!");
                }

                using (ApplicationContext db = new ApplicationContext())
                {
                    bool isEmailUnique = !db.Users.Any(u => u.email == textBox3.Text);
                    if(!isEmailUnique)
                    {
                        throw new Exception("Данная почта уже занята, используйте другую.");
                    }
                    bool isphnUnique = !db.Users.Any(u => u.phone_number == maskedTextBox2.Text);
                    if (!isphnUnique)
                    {
                        throw new Exception("Данная номер телефона уже занят, используйте другой.");
                    }
                    bool isLoginUnique = !db.Users.Any(u => u.login == textBox6.Text);
                    if (!isLoginUnique)
                    {
                        throw new Exception("Данный логин уже занят, используйте другой.");
                    }

                    if (textBox6.Text.Length < 4)
                    {
                        throw new Exception("Длина логина не должна быть меньше 4 символов");
                    }
                    if (textBox6.Text.Length > 16)
                    {
                        throw new Exception("Длина логина не должна превышать 16 символов");
                    }

                    if (textBox7.Text.Length < 4)
                    {
                        throw new Exception("Длина пароля не должна быть меньше 4 символов");
                    }
                    if (textBox7.Text.Length > 16)
                    {
                        throw new Exception("Длина пароля не должна превышать 16 символов");
                    }
                    if (isEmailUnique && isphnUnique && isLoginUnique && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox2.Text != "" && textBox6.Text != "" && textBox7.Text != "" && maskedTextBox2.Text.Length == 18)
                    {
                        db.Users.Add(new User
                        {
                            name = textBox1.Text,
                            surname = textBox2.Text,
                            email = textBox3.Text,
                            date_of_birth = textBox4.Text,
                            phone_number = maskedTextBox2.Text,
                            login = textBox6.Text,
                            password = textBox7.Text
                        });
                        db.SaveChanges();
                        Voiti v = new Voiti();
                        v.Show();
                        Hide();
                    }
                    else throw new Exception("Не все поля заполнены корректно!");
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

        private void Reg_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            textBox3.TabIndex = 2;
            textBox4.TabIndex = 3;
            maskedTextBox2.TabIndex = 4;
            textBox6.TabIndex = 5;
            textBox7.TabIndex = 6;
            button1.TabIndex = 7;
        }

        void Reg_KeyDown(object sender, KeyEventArgs e)//отредачить
        {
           if (e.KeyValue == (char)Keys.Enter)
           {
               button1_Click(button1, null);
           }
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)//др
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)//тел
        {

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

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что введённый символ не цифра и не Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back )
            {
                // Отменяем нажатие клавиши
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
