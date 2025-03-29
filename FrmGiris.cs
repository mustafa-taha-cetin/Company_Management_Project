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

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");
        //SQL bağlantısı

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giris = new SqlCommand("Select * From Tbl_Admin Where Kullanici_Ad=@p1 and Kullanici_Sifre=@p2 and KUllanici_Ip=@p3",baglanti);
            giris.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            giris.Parameters.AddWithValue("@p2", txtSifre.Text);
            giris.Parameters.AddWithValue("@p3", txtIp.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi");
                txtIp.Text = "";
                txtKullaniciAd.Text = "";
                txtSifre.Text = "";
            }

            baglanti.Close();
        }
    }
}
