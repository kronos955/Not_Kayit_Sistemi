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

namespace WindowsFormsApp1
{
    public partial class FrmOgretmenGiris : Form
    {
        public FrmOgretmenGiris()
        {
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = LAPTOP-HE1E5UFI; Initial Catalog = DbNotKayit; Integrated Security = True");
        private object durum;


        private void FrmOgretmenGiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", OgretmenNumara.Text);
            komut.Parameters.AddWithValue("@P2", OgretmenAd.Text);
            komut.Parameters.AddWithValue("@P3", OgretmenSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            OgretmenNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            OgretmenAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            OgretmenSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            OgretmenSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            OgretmenSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            OgretmenSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            s1 = Convert.ToDouble(OgretmenSınav1.Text);
            s2 = Convert.ToDouble(OgretmenSınav2.Text);
            s3 = Convert.ToDouble(OgretmenSınav3.Text);

            ortalama = (s1+s2+s3) / 3;
            GenelOrt.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
                durumbilgi.Text = "Geçti!";
            }
            else
            {
                durum = "False";
                durumbilgi.Text = "Kaldı!";
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1, OGRS2=@P2, OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6", baglanti);
            komut.Parameters.AddWithValue("@P1", OgretmenSınav1.Text);
            komut.Parameters.AddWithValue("@P2", OgretmenSınav2.Text);
            komut.Parameters.AddWithValue("@P3", OgretmenSınav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(GenelOrt.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", OgretmenNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);


        }

    }
}
