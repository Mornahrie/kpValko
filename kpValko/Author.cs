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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) главнаяToolStripMenuItem_Click(главнаяToolStripMenuItem_Click, null); };
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

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Author_Load(object sender, EventArgs e)
        {

        }
    }
}
