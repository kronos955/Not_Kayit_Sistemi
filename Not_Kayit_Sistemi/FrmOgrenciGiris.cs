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
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source = LAPTOP-HE1E5UFI; Initial Catalog = DbNotKayit; Integrated Security = True");
        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {
            
            OgrNumara.Text = numara;
                      

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
         
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                OgrAdSoyad.Text = dr[2].ToString()+ " " + dr[3].ToString();
                OgrSinav1.Text = dr[4].ToString();
                OgrSinav2.Text = dr[5].ToString();
                OgrSinav3.Text = dr[6].ToString();
                OgrOrtalama.Text = dr[7].ToString();
                OgrDurum.Text = dr[8].ToString();
                
            }
            baglanti.Close();

        }

    }
}
