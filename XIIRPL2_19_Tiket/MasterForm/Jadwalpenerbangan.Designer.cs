namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Jadwalpenerbangan
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(130, 60);
            label2.Name = "label2";
            label2.Size = new Size(297, 17);
            label2.TabIndex = 22;
            label2.Text = "Semua jadwal penerbangan akan muncul disini ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 21);
            label1.Name = "label1";
            label1.Size = new Size(288, 30);
            label1.TabIndex = 21;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(782, 229);
            dataGridView1.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(195, 424);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(58, 425);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 24;
            label6.Text = "Dari:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 368);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 23;
            label3.Text = "Kode Penerbangan: ";
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(195, 470);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(234, 23);
            comboBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 471);
            label4.Name = "label4";
            label4.Size = new Size(26, 17);
            label4.TabIndex = 27;
            label4.Text = "Ke:";
            label4.Click += label4_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(195, 512);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(234, 23);
            comboBox3.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 513);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 29;
            label5.Text = "Maskapai:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(626, 368);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 23);
            dateTimePicker1.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(482, 368);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 32;
            label7.Text = "Tanggal: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(482, 425);
            label8.Name = "label8";
            label8.Size = new Size(150, 17);
            label8.TabIndex = 33;
            label8.Text = "Waktu Keberangkatan: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(482, 471);
            label9.Name = "label9";
            label9.Size = new Size(138, 17);
            label9.TabIndex = 34;
            label9.Text = "Durasi Penerbangan: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(482, 513);
            label10.Name = "label10";
            label10.Size = new Size(109, 17);
            label10.TabIndex = 35;
            label10.Text = " Harga per Tiket:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(626, 513);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(234, 23);
            numericUpDown1.TabIndex = 36;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(672, 581);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 38;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(557, 581);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 37;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 367);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 34);
            textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(626, 415);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 32);
            textBox2.TabIndex = 40;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(626, 470);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 32);
            textBox3.TabIndex = 41;
            // 
            // Jadwalpenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 631);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Jadwalpenerbangan";
            Text = "Jadwalpenerbangan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}