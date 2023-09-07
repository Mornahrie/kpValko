using kpValko;
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
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voiti v = new Voiti();
            v.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            r.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalog c = new Catalog();
            c.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author au = new Author();
            au.Show();
            Hide();
        }

        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
            Hide();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
