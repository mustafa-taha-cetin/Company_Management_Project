using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Personel_Kayit
{
    public partial class FrmIstatistik2 : Form
    {
        public FrmIstatistik2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");
        //SQL bağlantısı

        private void Istatistik_Load(object sender, EventArgs e)
        {

            lblToplamPersonelSayısı.Text = Form1.veri1;
            lblEvliPersonelSayısı.Text = Form1.veri2;
            lblBekarPersonelSayısı.Text = Form1.veri3;
            lblSehirSayi.Text = Form1.veri4;
            lblToplamMaas.Text = Form1.veri5;
            lblOrtalamaMaas.Text = Form1.veri6;


        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            lblToplamPersonelSayısı.Text = Form1.veri1;
            lblEvliPersonelSayısı.Text = Form1.veri2;
            lblBekarPersonelSayısı.Text = Form1.veri3;
            lblSehirSayi.Text = Form1.veri4;
            lblToplamMaas.Text = Form1.veri5;
            lblOrtalamaMaas.Text = Form1.veri6;

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Per_Meslek,Avg(Per_Maas) From Tbl_Personel group by Per_Meslek", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Meslek-Maas"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();
        }
    }
}
