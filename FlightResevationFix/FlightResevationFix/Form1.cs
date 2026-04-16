using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightResevationFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1 .Text = label12.Text;
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int koltukNo = rnd.Next(1, 31);
            char koltukHarf = (char)rnd.Next('A', 'F' + 1);

            string pnr = "";
            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            for (int i = 0; i < 6; i++)
            {
                pnr += karakterler[rnd.Next(karakterler.Length)];
            }







            string bagaj = "";
            string cinsiyet = "";

            if (radioButton3.Checked)
            {
                bagaj = "Kabin Bagajı";
            }
            else if (radioButton4.Checked)
            {
                bagaj = "15 kg Bagaj";
            }
            else if (radioButton5.Checked)
            {
                bagaj = "30 kg Bagaj";
            }

            if (radioButton1.Checked)
            {
                cinsiyet = "Kadın";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "Erkek";
            }

            richTextBox1.Clear();
            richTextBox1.AppendText("****** REZERVASYON ÖZETİ ******\n");
            richTextBox1.AppendText("Ad Soyad: " + textBox1.Text + " " + textBox2.Text + "\n");
            richTextBox1.AppendText("Telefon: " + maskedTextBox1.Text + "\n");
            richTextBox1.AppendText("TC: " + maskedTextBox2.Text + "\n");
            richTextBox1.AppendText("Rota: " + comboBox1.Text + " -> " + comboBox2.Text + "\n");
            richTextBox1.AppendText("Tarih: " + dateTimePicker1.Text + "\n");         
            richTextBox1.AppendText("Bagaj: " + bagaj + "\n");
            richTextBox1.AppendText("Cinsiyet: " + cinsiyet + "\n");
            richTextBox1.AppendText("Koltuk No: " + koltukNo + koltukHarf + "\n");
            richTextBox1.AppendText("PNR Kodu: " + pnr + "\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
