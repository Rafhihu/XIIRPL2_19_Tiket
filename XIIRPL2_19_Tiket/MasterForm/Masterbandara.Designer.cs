﻿namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Masterbandara
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtkodeIATA = new TextBox();
            txtNegara = new ComboBox();
            txtNama = new TextBox();
            txtKota = new TextBox();
            txtAlamat = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtJmlTerminal = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(117, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(739, 219);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(216, 31);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 1;
            label1.Text = "Master Bandara ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(216, 79);
            label2.Name = "label2";
            label2.Size = new Size(318, 17);
            label2.TabIndex = 2;
            label2.Text = "Semua Bandara yang terdaftar akan muncul kesini ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(216, 373);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 3;
            label3.Text = "Nama: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(216, 430);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 4;
            label4.Text = "Kode TA: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(216, 476);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 5;
            label5.Text = "Kota:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(216, 525);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 6;
            label6.Text = "Negara:";
            // 
            // txtkodeIATA
            // 
            txtkodeIATA.Location = new Point(286, 429);
            txtkodeIATA.Multiline = true;
            txtkodeIATA.Name = "txtkodeIATA";
            txtkodeIATA.Size = new Size(234, 34);
            txtkodeIATA.TabIndex = 9;
            txtkodeIATA.TextChanged += textBox3_TextChanged;
            // 
            // txtNegara
            // 
            txtNegara.DisplayMember = "aLAMAK";
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(286, 524);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(234, 23);
            txtNegara.TabIndex = 10;
            txtNegara.ValueMember = "aLAMAK";
            txtNegara.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(286, 372);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(234, 34);
            txtNama.TabIndex = 11;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(286, 474);
            txtKota.Multiline = true;
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(234, 34);
            txtKota.TabIndex = 12;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(609, 425);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(247, 117);
            txtAlamat.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(545, 372);
            label7.Name = "label7";
            label7.Size = new Size(113, 17);
            label7.TabIndex = 13;
            label7.Text = "Jumlah Terminal: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(545, 429);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 15;
            label8.Text = "Alamat: ";
            label8.Click += label8_Click;
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(664, 373);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(157, 23);
            txtJmlTerminal.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(631, 577);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 17;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(746, 577);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 18;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // Masterbandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 638);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtJmlTerminal);
            Controls.Add(label8);
            Controls.Add(txtAlamat);
            Controls.Add(label7);
            Controls.Add(txtKota);
            Controls.Add(txtNama);
            Controls.Add(txtNegara);
            Controls.Add(txtkodeIATA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Masterbandara";
            Text = "Masterbandara";
            Load += Masterbandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtkodeIATA;
        private ComboBox txtNegara;
        private TextBox txtNama;
        private TextBox txtKota;
        private TextBox txtAlamat;
        private Label label7;
        private Label label8;
        private NumericUpDown txtJmlTerminal;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}