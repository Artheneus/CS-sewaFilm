using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Latihan2
{
    /*Note : Tinggal tambahin Rp. pada setiap text box yang memiliki angka ribuan
      Tambahkan "Jika terdapat value yang null dalam pengisian, maka munculkan pop up pesan
      "Pengisian Data tidak valid, mohon di cek ulang pengisian data sewa"
     */

    public partial class Form1 : Form
    {
        string pilihan, harga;
        double banyak, total, subs, NumberOfDays, denda, akhir;
        CultureInfo negara = new CultureInfo("id-ID");

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilihan = comboBox1.SelectedItem.ToString();
            if (pilihan == "Action")
            {
                listBox1.Items.Clear();
                harga = "Rp 6000";
                listBox1.Items.Add("Pacific Rim");
                listBox1.Items.Add("Aquaman");
                listBox1.Items.Add("Transformer");
                txt_tarif.Text = harga;

            }
            else if (pilihan == "Drama")
            {
                listBox1.Items.Clear();
                harga = "Rp 4000";
                listBox1.Items.Add("Everest");
                listBox1.Items.Add("Life of Pi");
                listBox1.Items.Add("Finest Hour");
                txt_tarif.Text = harga;
            }
            else if (pilihan == "Comedy")
            {
                listBox1.Items.Clear();
                harga = "Rp 5000";
                listBox1.Items.Add("Mr. Bean");
                listBox1.Items.Add("Charlie Chaplin");
                listBox1.Items.Add("Loud House Movie");
                txt_tarif.Text = harga;

            }
            else if (pilihan == "Sci-Fi")
            {
                listBox1.Items.Clear();
                harga = "Rp 4000";
                listBox1.Items.Add("Interstellar");
                listBox1.Items.Add("The Martian");
                listBox1.Items.Add("Lucy");
                txt_tarif.Text = harga;
            }
        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            banyak = double.Parse(txt_bykBrg.Text);

            //menghitung jumlah
            total = double.Parse(txt_tarif.Text, NumberStyles.Currency, negara) * banyak;
            txt_total.Text = total.ToString("C", negara);

            /*txt_total;
            txt_subTotal;*/

            //Mengecek apakah Pembeli memiliki member atau tidak
            txt_Dskn.Clear();
            if (member.Checked == true)
            {
                string value = "";
                bool isChecked = member.Checked;
                if (isChecked)
                    value = member.Text;
                else
                    value = bkn_member.Text;

                if (value == "Member")
                {
                    pilihan = comboBox1.SelectedItem.ToString();
                    if (pilihan == "Action")
                    {
                        txt_Dskn.Text = "Rp 600";
                    }
                    else if (pilihan == "Drama")
                    {
                        txt_Dskn.Text = "Rp 400";
                    }
                    else if (pilihan == "Comedy")
                    {
                        txt_Dskn.Text = "Rp 500";
                    }
                    else
                    {
                        txt_Dskn.Text = "Rp 400";
                    }
                }
            } else
            {
                txt_Dskn.Text = "0";
            }

            //Menghitung jumlah Total setelah diskon
            subs = total - double.Parse(txt_Dskn.Text, NumberStyles.Currency, negara);
            txt_subTotal.Text = subs.ToString("C", negara);

            //Menghitung jumlah hari keterlambatan
            NumberOfDays = (dateTimePicker2.Value - dateTimePicker1.Value).TotalDays;
            txt_terlambat.Text = NumberOfDays.ToString();

            //Menghitung Denda
            denda = NumberOfDays * 1000;
            txt_Denda.Text = denda.ToString("C", negara);

            //Tarif Akhir
            akhir = double.Parse(txt_subTotal.Text, NumberStyles.Currency, negara) + double.Parse(txt_Denda.Text, NumberStyles.Currency, negara);
            hs_Akhr.Text = akhir.ToString("C", negara);
        }
    }
}
