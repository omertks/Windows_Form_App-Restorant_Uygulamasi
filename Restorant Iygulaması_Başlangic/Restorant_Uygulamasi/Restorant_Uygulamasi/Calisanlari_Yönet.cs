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
    public partial class Calisanlari_Yönet : Form
    {
        public Calisanlari_Yönet()
        {
            InitializeComponent();
        }

        private void Calisanlari_Yönet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restorantDataSet1.Calisanlar' table. You can move, or remove it, as needed.
            this.calisanlarTableAdapter.Fill(this.restorantDataSet1.Calisanlar);
            // TODO: This line of code loads data into the 'restorantDataSet.Calisanlar' table. You can move, or remove it, as needed.
            this.calisanlarTableAdapter.Fill(this.restorantDataSet1.Calisanlar);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!=""&&textBox3.Text!="")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Ekle = "Insert Into Calisanlar (Kullanici_Adi,Sifre) Values (@kullaniciadi,@sifre)";
                SqlCommand cmd = new SqlCommand(Ekle, con);
                cmd.Parameters.AddWithValue("@kullaniciadi", textBox2.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            this.calisanlarTableAdapter.Fill(this.restorantDataSet1.Calisanlar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Sil = "Delete Calisanlar Where id =@id";
                SqlCommand cmd = new SqlCommand(Sil, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Lütfen İd Kısmını Boş Bırakmayınız!");
            }
            this.calisanlarTableAdapter.Fill(this.restorantDataSet1.Calisanlar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Ad = "Update Calisanlar Set Kullanici_Adi=@Ad where id=@id";
                SqlCommand cmd = new SqlCommand(Yeni_Ad, con);
                cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Kullanıcı Adınız Hazırlanmıştır!");
                con.Close();
                this.calisanlarTableAdapter.Fill(this.restorantDataSet1.Calisanlar);
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Kullanıcı adını değiştireceğiniz kişinin üzerine tıklayınız!");
            }
            else if (textBox2.Text=="")
            {
                MessageBox.Show("Kullanıcı adını değiştireceğiniz kişinin yeni kullanıcı adını giriniz!");
            }
            else
            {
                MessageBox.Show("Beklenmedik bir hata oluştu lütfen tekrar deneyiniz!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Yeni_Sifre = "Update Calisanlar Set Sifre=@Sifre where id=@id";
                SqlCommand cmd = new SqlCommand(Yeni_Sifre, con);
                cmd.Parameters.AddWithValue("@Sifre", textBox3.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Şifreniz Hazırlanmıştır!");
                con.Close();
                this.calisanlarTableAdapter.Fill(this.restorantDataSet1.Calisanlar);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı adını değiştireceğiniz kişinin üzerine tıklayınız!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Şifresini değiştireceğiniz kişinin yeni şifresini giriniz!");
            }
            else
            {
                MessageBox.Show("Beklenmedik bir hata oluştu lütfen tekrar deneyiniz!");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
