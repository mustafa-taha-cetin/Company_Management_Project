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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");
        //SQL bağlantısı

        private void FrmGrafik_Load(object sender, EventArgs e)
        {

        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            // ------ sehirleri gösteren kod ---------
            baglanti.Open();
            SqlCommand grafik = new SqlCommand("Select Per_Sehir,Count(*) From Tbl_Personel group by Per_Sehir", baglanti);
            SqlDataReader drg = grafik.ExecuteReader();
            while (drg.Read())
            {
                chart1.Series["Sehir"].Points.AddXY(drg[0], drg[1]);
            }
            baglanti.Close();


            // ----- Evli veya bekar -------------------
            baglanti.Open();
            SqlCommand grafik2 = new SqlCommand("Select Per_Durum,Count(*) From Tbl_Personel group by Per_Durum",baglanti);
            SqlDataReader drg2 = grafik2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Evli-Bekar"].Points.AddXY(drg2[0], drg2[1]);
            }
            baglanti.Close();



            //--------- soyadlar ---------
            baglanti.Open();
            SqlCommand grafik3 = new SqlCommand("Select Per_Soyad,Count(*) From Tbl_Personel group by Per_Soyad", baglanti);
            SqlDataReader drg3 = grafik3.ExecuteReader();
            while (drg3.Read())
            {
                chart3.Series["Soyad"].Points.AddXY(drg3[0], drg3[1]);
            }
            baglanti.Close();
        }
    }
}
