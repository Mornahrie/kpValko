namespace kpValko
{
    partial class Adding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding));
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label5 = new Label();
            comboBox5 = new ComboBox();
            label6 = new Label();
            comboBox6 = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            button3 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 107, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(41, 252);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(87, 27);
            button1.TabIndex = 17;
            button1.Text = "Назад";
            toolTip1.SetToolTip(button1, "Нажмите на кнопку, чтобы вернуться\r\nна предыдущую вкладку");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(98, 67, 93);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(308, 252);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(87, 27);
            button2.TabIndex = 18;
            button2.Text = "Добавить";
            toolTip1.SetToolTip(button2, "Нажмите, чтобы добавить автомобиль\r\nв базу данных");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aston Martin", "Audi", "BMW", "Citroen", "Fiat", "Ford", "Honda", "Hyundai", "Kia", "Lada", "Lexus", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Peugeot", "Renault", "Skoda", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            comboBox1.Location = new Point(41, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            toolTip1.SetToolTip(comboBox1, "Нажмите на стрелочку, чтобы увидеть\r\nвыпадающий список и кликом мыши\r\nвыберите желаемый пункт");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Англия", "Бразилия", "Германия", "Индия", "Испания", "Италия", "Канада", "Китай", "Мексика", "Россия", "Сша", "Таиланд", "Турция", "Франция", "Чехия", "Южная Корея", "Япония" });
            comboBox2.Location = new Point(41, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 20;
            toolTip1.SetToolTip(comboBox2, "Нажмите на стрелочку, чтобы увидеть\r\nвыпадающий список и кликом мыши\r\nвыберите желаемый пункт\r\n");
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 17);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 21;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 22;
            label2.Text = "Страна";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            comboBox3.Location = new Point(41, 149);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 23;
            toolTip1.SetToolTip(comboBox3, "Нажмите на стрелочку, чтобы увидеть\r\nвыпадающий список и кликом мыши\r\nвыберите желаемый пункт\r\n");
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 17);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 26;
            label4.Text = "Топливо";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "бензин", "дизель", "электричество" });
            comboBox4.Location = new Point(274, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 25;
            toolTip1.SetToolTip(comboBox4, "Нажмите на стрелочку, чтобы увидеть\r\nвыпадающий список и кликом мыши\r\nвыберите желаемый пункт\r\n");
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 73);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 28;
            label5.Text = "Цвет";
            label5.Click += label5_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "алый", "африканская ночь", "бежевый", "белое золото", "белый", "вишневый", "голубой", "желтый", "закат", "зеленый", "красный", "лимонный", "оранжевый", "радужный", "розовое золото", "розовый", "серебристый", "серый", "серый космос", "темно-синий", "фиолетовый космос", "хаки", "цвет Жанны Лайт", "цвет бедра нимфы", "черный" });
            comboBox5.Location = new Point(274, 91);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 27;
            toolTip1.SetToolTip(comboBox5, "Нажмите на стрелочку, чтобы увидеть\r\nвыпадающий список и кликом мыши\r\nвыберите желаемый пункт\r\n");
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 131);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 30;
            label6.Text = "Статус";
            label6.Click += label6_Click;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "в наличии", "нет в наличии" });
            comboBox6.Location = new Point(274, 149);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 31;
            toolTip1.SetToolTip(comboBox6, "Нажмите на стрелочку, чтобы увидеть\r\nвыпадающий список и кликом мыши\r\nвыберите желаемый пункт\r\n");
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 202);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 32;
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 131);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 24;
            label3.Text = "Год";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(98, 67, 93);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(175, 252);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(87, 27);
            button3.TabIndex = 33;
            button3.Text = "Вывести";
            toolTip1.SetToolTip(button3, "Нажмите, чтобы вывести информацию по\r\nвыбранным вами пунктам\r\n");
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Adding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 200, 255);
            ClientSize = new Size(446, 291);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(comboBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Adding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить";
            Load += Adding_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox4;
        private Label label5;
        private ComboBox comboBox5;
        private Label label6;
        private ComboBox comboBox6;
        private Label label7;
        private Label label3;
        private Button button3;
        private ToolTip toolTip1;
    }
}