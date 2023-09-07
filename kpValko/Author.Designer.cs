namespace kpValko
{
    partial class Author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            входToolStripMenuItem = new ToolStripMenuItem();
            регистрацияToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.au;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 139);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Да, это я");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 37);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 17;
            label1.Text = "Об авторе:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 92);
            label2.Name = "label2";
            label2.Size = new Size(167, 84);
            label2.TabIndex = 18;
            label2.Text = "МГКЦТ \r\n3-ий курс \r\n52-ТП\r\nВалько Александра\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(358, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, входToolStripMenuItem, регистрацияToolStripMenuItem, помощьToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            менюToolStripMenuItem.Click += менюToolStripMenuItem_Click;
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(143, 22);
            главнаяToolStripMenuItem.Text = "Главная";
            главнаяToolStripMenuItem.Click += главнаяToolStripMenuItem_Click;
            // 
            // входToolStripMenuItem
            // 
            входToolStripMenuItem.Name = "входToolStripMenuItem";
            входToolStripMenuItem.Size = new Size(143, 22);
            входToolStripMenuItem.Text = "Вход";
            входToolStripMenuItem.Click += входToolStripMenuItem_Click;
            // 
            // регистрацияToolStripMenuItem
            // 
            регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            регистрацияToolStripMenuItem.Size = new Size(143, 22);
            регистрацияToolStripMenuItem.Text = "Регистрация";
            регистрацияToolStripMenuItem.Click += регистрацияToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(143, 22);
            помощьToolStripMenuItem.Text = "Помощь";
            помощьToolStripMenuItem.Click += помощьToolStripMenuItem_Click;
            // 
            // Author
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 200, 255);
            ClientSize = new Size(358, 209);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Author";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автор";
            Load += Author_Load;
            Click += Author_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem входToolStripMenuItem;
        private ToolStripMenuItem регистрацияToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
    }
}