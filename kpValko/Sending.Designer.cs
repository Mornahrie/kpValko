namespace kpValko
{
    partial class Sending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sending));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            orderId = new DataGridViewTextBoxColumn();
            userID = new DataGridViewTextBoxColumn();
            carID = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 107, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(13, 379);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(149, 27);
            button1.TabIndex = 18;
            button1.Text = "Назад";
            toolTip1.SetToolTip(button1, "Нажмите, чтобы вернуться на предыдущую вкладку");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderId, userID, carID, data, state });
            dataGridView1.Location = new Point(56, 12);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 249);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // orderId
            // 
            orderId.HeaderText = "Номер заказа";
            orderId.Name = "orderId";
            orderId.ReadOnly = true;
            // 
            // userID
            // 
            userID.HeaderText = "Номер пользователя";
            userID.Name = "userID";
            userID.ReadOnly = true;
            // 
            // carID
            // 
            carID.HeaderText = "Номер машины";
            carID.Name = "carID";
            carID.ReadOnly = true;
            // 
            // data
            // 
            data.HeaderText = "Дата заказа";
            data.Name = "data";
            data.ReadOnly = true;
            // 
            // state
            // 
            state.HeaderText = "Статус";
            state.Name = "state";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(98, 67, 93);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(487, 379);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(149, 27);
            button3.TabIndex = 34;
            button3.Text = "Отправить";
            toolTip1.SetToolTip(button3, "Нажмите, чтобы отправить уведомление\r\nо выполнении заказа пользователю");
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 303);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 35;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 107, 201);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(165, 267);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 36;
            button4.Text = "Заказы";
            toolTip1.SetToolTip(button4, "Нажмите, чтобы увидеть выполненные заказы");
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(98, 67, 93);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(403, 267);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(90, 27);
            button5.TabIndex = 37;
            button5.Text = "Предзаказы";
            toolTip1.SetToolTip(button5, "Нажмите, чтобы увидеть выполненные предзаказы");
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 354);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 38;
            // 
            // Sending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 200, 255);
            ClientSize = new Size(649, 418);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Sending";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отправка";
            Load += Sending_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderId;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn carID;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn state;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Label label2;
        private ToolTip toolTip1;
    }
}