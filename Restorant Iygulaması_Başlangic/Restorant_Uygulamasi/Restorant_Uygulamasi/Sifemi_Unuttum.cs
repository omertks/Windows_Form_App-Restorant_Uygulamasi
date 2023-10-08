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
    public partial class Sifemi_Unuttum : Form
    {
        public Sifemi_Unuttum()
        {
            InitializeComponent();
        }
        
        public void Sifemi_Unuttum_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
            con.Open();
            string Sifre_Unut_Soru = "SELECT Guvenlik_Sorusu from Admin";
            SqlCommand cmd = new SqlCommand(Sifre_Unut_Soru, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string Guvenlik_Sorusu = dr["Guvenlik_Sorusu"].ToString();
                richTextBox1.Text = Guvenlik_Sorusu;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
            con.Open();
            string Sifre_Unut_Cevap = "SELECT Guvenlik_Sorusu_Cevap from Admin";
            SqlCommand cmd = new SqlCommand(Sifre_Unut_Cevap, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string Guvenlik_Sorusu_Cevap = dr["Guvenlik_Sorusu_Cevap"].ToString();
                string Cevap = richTextBox2.Text;


                if (Cevap == Guvenlik_Sorusu_Cevap)
                {
                    Admin_Sifre_Degistir sifre_degis = new Admin_Sifre_Degistir();
                    sifre_degis.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Son 5 Giriş Hakkınız! ");
                }
                con.Close();
            }
                
        }
    }
}
