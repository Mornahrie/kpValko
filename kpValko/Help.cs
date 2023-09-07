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
using System.Xml;

namespace kpValko
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) главнаяToolStripMenuItem_Click(главнаяToolStripMenuItem_Click, null); };
            richTextBox1.ReadOnly = true;
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

        private void Help_Load(object sender, EventArgs e)
        {
            // Парсим XML файл
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("XMLCat.xml");

            // Получаем текст из XML и выводим его в Label
            XmlNode root = xmlDoc.SelectSingleNode("cat");
            string description = root.SelectSingleNode("description").InnerText;
            richTextBox1.Text = description;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
