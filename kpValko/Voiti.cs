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
    public partial class Voiti : Form
    {
        public int ID;
        public Voiti()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) button2_Click(button2, null); };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool access = false;
                using (ApplicationContext db = new ApplicationContext())
                {
                    var users = db.Users.ToList();
                    foreach (User c in users)
                    {
                        if (textBox1.Text == c.login && textBox2.Text == c.password)
                        {
                            access = true;
                            ID = c.userID;
                        }
                    }
                }
                if (textBox1.Text == "admin" && textBox2.Text == "123456")
                {
                    admin a = new admin();
                    a.Show();
                    Close();
                }
                else if (textBox1.Text == "worker" && textBox2.Text == "000002")
                {
                    worker w = new worker();
                    w.Show();
                    Close();
                }
                else if (access == true)
                {
                    Acc ac = new Acc();
                    Get.Value = ID;
                    ac.Show();
                    Close();
                }
                else if (access == false)
                {
                    throw new Exception("Несоответствие логина или пароля, попробуйте снова.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            r.Show();
            Close();
        }

        void Voiti_KeyDown(object sender, KeyEventArgs e)//дописать ифы
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }

        private void Voiti_Load(object sender, EventArgs e)
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

    }
}
