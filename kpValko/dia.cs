using kpValko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace kpValko
{
    public partial class dia : Form
    {
        private SoundPlayer player; // переменная для проигрывания звука
        public dia()
        {
            InitializeComponent();
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Escape) button1_Click(button1, null); };
            player = new SoundPlayer(); // создаем экземпляр проигрывателя звука
            player.SoundLocation = ".\\melody.wav"; // указываем путь к файлу со звуком
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dia_Load(object sender, EventArgs e)
        {
            diagram();
            Thread soundThread = new Thread(new ThreadStart(PlaySound)); // создаем поток для проигрывания звука
            soundThread.Start(); // запускаем поток
        }
        private void PlaySound()
        {
            player.Play(); // воспроизводим звук
        }

        private void diagram()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var cars = db.Cars.ToList();

                // Считаем количество машин в наличии и нет в наличии
                int available = 0;
                int notAvailable = 0;
                foreach (Car c in cars)
                {
                    if (c.state == "в наличии")
                    {
                        available++;
                    }
                    else if (c.state == "нет в наличии")
                    {
                        notAvailable++;
                    }
                }

                // Получаем общее количество машин
                var total = available + notAvailable;

                // Рассчитываем процентное соотношение машин в наличии и нет в наличии
                double availablePercent = (double)available / total * 100;
                double notAvailablePercent = (double)notAvailable / total * 100;

                // Создаем круговую диаграмму
                chart1.Series["Availability"].IsValueShownAsLabel = true;
                chart1.Series["Availability"].Points.AddXY("В наличии", Math.Round(availablePercent, 2));
                chart1.Series["Availability"].Points.AddXY("Нет в наличии", Math.Round(notAvailablePercent, 2));
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}