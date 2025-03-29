using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //Bunu yazmak önemli

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
// ******  Tüm formlarda kullanılacak değişken ****************************************
            public static string veri1;
            public static string veri2;
            public static string veri3;
            public static string veri4;
            public static string veri5;
            public static string veri6;
        


        void temizle()
        {
            txtAd.Text = "";
            mskMaas.Text = "";
            txtMeslek.Text = "";
            txtSoyad.Text = "";
            comboSehir.Text = "";
            rdbEvli.Checked = false;
            rdbBekar.Checked = false;
            lblID.Text = "ID";
            txtAd.Focus();
        }



        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");
        //SQL bağlantısı 


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_Veri_TabaniDataSet.Tbl_Personel);
            
            

            // Toplam personel sayısı değeri----------------------
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader(); // Veri okuyucu görevindedir
            while (dr1.Read())
            {
                lblData1.Text = dr1[0].ToString();
                veri1 = dr1[0].ToString();

            }

            baglanti.Close();



            // Evli Personel Sayısı Değeri----------------------
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where Per_Durum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblData2.Text = dr2[0].ToString();
                veri2 = dr2[0].ToString();

            }

            baglanti.Close();



            // Bekar Personel Sayısı Değeri----------------------
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where Per_Durum = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblData3.Text = dr3[0].ToString();
                veri3 = dr3[0].ToString();

            }

            baglanti.Close();



            // Şehir Sayısı Değeri------------------------------
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select Count(distinct(Per_Sehir)) From Tbl_Personel", baglanti);
            //distinct aynı değeri bir defa döndürdüğü için kullandık
            SqlDataReader d4 = komut4.ExecuteReader();
            while (d4.Read())
            {
                lblData4.Text = d4[0].ToString();
                veri4 = d4[0].ToString();
            }

            baglanti.Close();


            // Toplam Maaş---------------------------------------
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(Per_Maas) From Tbl_Personel", baglanti);
            //sum değerleri toplamak için kullanılıyor
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblData5.Text = dr5[0].ToString();
                veri5 = dr5[0].ToString();
            }

            baglanti.Close();



            // Ortalama Maaş---------------------------------------
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select Avg(Per_Maas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblData6.Text = dr6[0].ToString();
                veri6 = dr6[0].ToString();
            }
            baglanti.Close();



        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_Veri_TabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Per_Ad , Per_Soyad , Per_Sehir , Per_Maas , Per_Meslek , Per_Durum , Per_Id , Per_Maas_Ay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)" , baglanti);
            // bu komutlar önemli yeni datalar eklemek ve kaydetmeye yarar

            komut.Parameters.AddWithValue("@p1" , txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", lblKontrol.Text);
            komut.Parameters.AddWithValue("@p7", lblID.Text);
            komut.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Yeni personel eklendi"); 
        }

        private void rdbEvli_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbEvli.Checked == true)
            {
                lblKontrol.Text = "True";
            }
        }

        private void rdbBekar_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbBekar.Checked == true)
            {
                lblKontrol.Text = "False";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            // iki kere tıklanan kutudaki tüm verileri değiştirebilmemiz için seçer

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblKontrol.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            lblID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void lblKontrol_TextChanged(object sender, EventArgs e)
        {
            if(lblKontrol.Text == "True")
            {
                rdbEvli.Checked= true;
                rdbBekar.Checked= false;
            }
            if(lblKontrol.Text == "False")
            {
                rdbBekar.Checked= true;
                rdbEvli.Checked= false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand KomutSil = new SqlCommand("Delete From Tbl_Personel Where Per_Ad=@k1", baglanti);
            KomutSil.Parameters.AddWithValue("@k1", txtAd.Text);
            KomutSil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set Per_Ad=@a1, Per_Soyad=@a2, Per_Sehir=@a3, Per_Maas=@a4, Per_Durum=@a5, Per_Meslek=@a6 where Per_Id=@a7", baglanti);

            // sona koyduğumuz "where" olmazsa tüm datalar yeni yazılan dataya dönüşür o yüzden dikkat edilmelidir
            
            komutguncelle.Parameters.AddWithValue("@a1" , txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", lblKontrol.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", lblID.Text);

            komutguncelle.ExecuteNonQuery(); // Execute sorguyu çalıştırır

            // yazdığımız bu parça verileri değiştirme ve yenilemek içindir

            baglanti.Close();

            MessageBox.Show("Personel bilgileri güncellenmiştir.");


        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik2 fr = new FrmIstatistik2();
            fr.Show();

        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik frg = new FrmGrafik();
            frg.Show();
        }
    }
}
