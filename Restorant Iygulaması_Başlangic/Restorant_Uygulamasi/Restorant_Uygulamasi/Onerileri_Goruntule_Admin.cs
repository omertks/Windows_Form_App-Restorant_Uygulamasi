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
    public partial class Onerileri_Goruntule_Admin : Form
    {
        public Onerileri_Goruntule_Admin()
        {
            InitializeComponent();
        }

        private void Onerileri_Goruntule_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restorantDataSet1.Oneriler' table. You can move, or remove it, as needed.
            this.onerilerTableAdapter.Fill(this.restorantDataSet1.Oneriler);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                SqlDataReader dr;
                string Goruntule = "select * from Oneriler where id=@id";
                SqlCommand cmd = new SqlCommand(Goruntule, con);
                cmd.Parameters.AddWithValue("@id", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    richTextBox3.Text = dr["Aciklama"].ToString();
                }
                dr.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Görüntülemek İstediğiniz Öneriyi Seçiniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Server = DESKTOP-CS0PE9S; Initial Catalog = Restorant;Integrated Security=SSPI");
                con.Open();
                string Sil = "Delete Oneriler where id=@id";
                SqlCommand cmd = new SqlCommand(Sil, con);
                cmd.Parameters.AddWithValue("@id", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                this.onerilerTableAdapter.Fill(this.restorantDataSet1.Oneriler);
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Öneriyi Seçiniz!");
            }
        }
    }
}