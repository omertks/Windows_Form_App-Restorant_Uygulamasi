using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restorant_Uygulamasi
{
    public partial class Fiyat_Liste : Form
    {
        public Fiyat_Liste()
        {
            InitializeComponent();
        }

        private void Fiyat_Liste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restorantDataSet1.Yemekler' table. You can move, or remove it, as needed.
            this.yemeklerTableAdapter.Fill(this.restorantDataSet1.Yemekler);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                dataGridView1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                textBox5.Enabled = true;
                button1.Enabled = true;
                label5.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Lütfen Fiyatını Değiştireceğiniz ürünü Seçiniz!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Kategori = "Update Yemekler Set Kategori=@kategori where id=@id";
                SqlCommand cmd = new SqlCommand(Yeni_Kategori, con);
                cmd.Parameters.AddWithValue("@kategori", textBox5.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kategori Bilgisi Güncellenmiştir!");
                con.Close();
                this.yemeklerTableAdapter.Fill(this.restorantDataSet1.Yemekler);

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                dataGridView1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                textBox5.Enabled = false;
                button6.Enabled = false;
                label5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Yeni Kategori Bilgisini Giriniz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text!="")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Fiyat = "Update Yemekler Set Fiyat=@fiyat where id=@id";
                SqlCommand cmd = new SqlCommand(Yeni_Fiyat, con);
                cmd.Parameters.AddWithValue("@fiyat", textBox5.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fiyat Bilgisi Güncellenmiştir!");
                con.Close();
                this.yemeklerTableAdapter.Fill(this.restorantDataSet1.Yemekler);

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                dataGridView1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                textBox5.Enabled = false;
                button1.Enabled = false;
                label5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Yeni Fiyat Bilgisini Giriniz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                dataGridView1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                textBox5.Enabled = true;
                button5.Enabled = true;
                label5.Enabled = true;

            }
            else
            {
                MessageBox.Show("Lütfen Adını Değiştireceğiniz ürünü Seçiniz!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                dataGridView1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                textBox5.Enabled = true;
                button6.Enabled = true;
                label5.Enabled = true;

            }
            else
            {
                MessageBox.Show("Lütfen Kategorisini Değiştireceğiniz ürünü Seçiniz!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Ad = "Update Yemekler Set Ad=@ad where id=@id";
                SqlCommand cmd = new SqlCommand(Yeni_Ad, con);
                cmd.Parameters.AddWithValue("@ad", textBox5.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ad Bilgisi Güncellenmiştir!");
                con.Close();
                this.yemeklerTableAdapter.Fill(this.restorantDataSet1.Yemekler);

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                dataGridView1.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                textBox5.Enabled = false;
                button5.Enabled = false;
                label5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Yeni Ad Bilgisini Giriniz!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!=""&&textBox1.Text=="")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Yemek = "Insert Into Yemekler(Kategori,Ad,Fiyat) Values(@kategori,@ad,@fiyat)";
                SqlCommand cmd = new SqlCommand(Yeni_Yemek, con);
                cmd.Parameters.AddWithValue("@kategori", textBox2.Text);
                cmd.Parameters.AddWithValue("@ad", textBox3.Text);
                cmd.Parameters.AddWithValue("@fiyat", textBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yemek Başarılı Bir Şekilde Eklenmiştir!");
                this.yemeklerTableAdapter.Fill(this.restorantDataSet1.Yemekler);
            }
            else if (textBox1.Text!="")
            {
                textBox1.Text = "";
                MessageBox.Show("Lütfen Tekrar Ekle Butuonuna Basınız!");
            }
            else
            {
                MessageBox.Show("Lütfen id hariç boş alan bırakmayınız!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Sil = "Delete Yemekler Where id=@id";
                SqlCommand cmd = new SqlCommand(Sil, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yemek Başarılı Bir Şekilde Silinmiştir!");
                this.yemeklerTableAdapter.Fill(this.restorantDataSet1.Yemekler);


            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü Seçiniz!");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label6.Enabled = true;
        }
    }
}
