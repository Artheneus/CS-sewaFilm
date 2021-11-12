
namespace Latihan2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gB_DatFilm = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bkn_member = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.member = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_proses = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hs_Akhr = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Denda = new System.Windows.Forms.TextBox();
            this.txt_terlambat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.txt_Dskn = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_bykBrg = new System.Windows.Forms.TextBox();
            this.txt_tarif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gB_DatFilm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_DatFilm
            // 
            this.gB_DatFilm.Controls.Add(this.dateTimePicker2);
            this.gB_DatFilm.Controls.Add(this.dateTimePicker1);
            this.gB_DatFilm.Controls.Add(this.label5);
            this.gB_DatFilm.Controls.Add(this.label4);
            this.gB_DatFilm.Controls.Add(this.label3);
            this.gB_DatFilm.Controls.Add(this.label2);
            this.gB_DatFilm.Controls.Add(this.bkn_member);
            this.gB_DatFilm.Controls.Add(this.comboBox1);
            this.gB_DatFilm.Controls.Add(this.member);
            this.gB_DatFilm.Controls.Add(this.listBox1);
            this.gB_DatFilm.Controls.Add(this.label1);
            this.gB_DatFilm.Location = new System.Drawing.Point(23, 12);
            this.gB_DatFilm.Name = "gB_DatFilm";
            this.gB_DatFilm.Size = new System.Drawing.Size(595, 277);
            this.gB_DatFilm.TabIndex = 0;
            this.gB_DatFilm.TabStop = false;
            this.gB_DatFilm.Text = "Data Film";
            this.gB_DatFilm.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(407, 234);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tgl Kembali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tgl Jatuh Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jenis Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daftar Film";
            // 
            // bkn_member
            // 
            this.bkn_member.AutoSize = true;
            this.bkn_member.Location = new System.Drawing.Point(141, 235);
            this.bkn_member.Name = "bkn_member";
            this.bkn_member.Size = new System.Drawing.Size(106, 19);
            this.bkn_member.TabIndex = 4;
            this.bkn_member.TabStop = true;
            this.bkn_member.Text = "Bukan Member";
            this.bkn_member.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Comedy",
            "Sci-Fi"});
            this.comboBox1.Location = new System.Drawing.Point(114, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // member
            // 
            this.member.AutoSize = true;
            this.member.Location = new System.Drawing.Point(141, 210);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(70, 19);
            this.member.TabIndex = 2;
            this.member.TabStop = true;
            this.member.Text = "Member";
            this.member.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(114, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(456, 124);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Film";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_proses);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Sewa";
            // 
            // btn_proses
            // 
            this.btn_proses.Location = new System.Drawing.Point(418, 31);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(152, 158);
            this.btn_proses.TabIndex = 13;
            this.btn_proses.Text = "Proses";
            this.btn_proses.UseVisualStyleBackColor = true;
            this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hs_Akhr);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_Denda);
            this.groupBox3.Controls.Add(this.txt_terlambat);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(212, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 167);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // hs_Akhr
            // 
            this.hs_Akhr.AutoSize = true;
            this.hs_Akhr.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hs_Akhr.Location = new System.Drawing.Point(52, 94);
            this.hs_Akhr.Name = "hs_Akhr";
            this.hs_Akhr.Size = new System.Drawing.Size(73, 32);
            this.hs_Akhr.TabIndex = 18;
            this.hs_Akhr.Text = "Tarif";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Hari";
            // 
            // txt_Denda
            // 
            this.txt_Denda.Location = new System.Drawing.Point(87, 45);
            this.txt_Denda.Name = "txt_Denda";
            this.txt_Denda.Size = new System.Drawing.Size(100, 23);
            this.txt_Denda.TabIndex = 20;
            // 
            // txt_terlambat
            // 
            this.txt_terlambat.Location = new System.Drawing.Point(87, 16);
            this.txt_terlambat.Name = "txt_terlambat";
            this.txt_terlambat.Size = new System.Drawing.Size(36, 23);
            this.txt_terlambat.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Denda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Terlambat";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_subTotal);
            this.groupBox2.Controls.Add(this.txt_Dskn);
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Controls.Add(this.txt_bykBrg);
            this.groupBox2.Controls.Add(this.txt_tarif);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 167);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Location = new System.Drawing.Point(94, 132);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.Size = new System.Drawing.Size(100, 23);
            this.txt_subTotal.TabIndex = 17;
            // 
            // txt_Dskn
            // 
            this.txt_Dskn.Location = new System.Drawing.Point(94, 103);
            this.txt_Dskn.Name = "txt_Dskn";
            this.txt_Dskn.Size = new System.Drawing.Size(100, 23);
            this.txt_Dskn.TabIndex = 16;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(94, 74);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 23);
            this.txt_total.TabIndex = 15;
            // 
            // txt_bykBrg
            // 
            this.txt_bykBrg.Location = new System.Drawing.Point(94, 45);
            this.txt_bykBrg.Name = "txt_bykBrg";
            this.txt_bykBrg.Size = new System.Drawing.Size(100, 23);
            this.txt_bykBrg.TabIndex = 14;
            // 
            // txt_tarif
            // 
            this.txt_tarif.Location = new System.Drawing.Point(94, 16);
            this.txt_tarif.Name = "txt_tarif";
            this.txt_tarif.Size = new System.Drawing.Size(100, 23);
            this.txt_tarif.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sub. Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Diskon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tarif";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB_DatFilm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gB_DatFilm.ResumeLayout(false);
            this.gB_DatFilm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_DatFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bkn_member;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton member;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.TextBox txt_Dskn;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_bykBrg;
        private System.Windows.Forms.TextBox txt_tarif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hs_Akhr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Denda;
        private System.Windows.Forms.TextBox txt_terlambat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_proses;
    }
}

