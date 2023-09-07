namespace kpValko
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            входToolStripMenuItem = new ToolStripMenuItem();
            регистрацияToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Teapot_free_vector_icons_designed_by_Freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 152);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(455, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, входToolStripMenuItem, регистрацияToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 25);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 25;
            label1.Text = "Инструкция для чайников:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(178, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(246, 160);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 200, 255);
            ClientSize = new Size(455, 313);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Помощь";
            Load += Help_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem входToolStripMenuItem;
        private ToolStripMenuItem регистрацияToolStripMenuItem;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}