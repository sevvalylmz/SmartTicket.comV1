using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTicket.comV1
{
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=.\SQLEXPRESS;Initial Catalog=SmarTicket;Integrated Security=True");

        private void OyuncuListesi_Load(object sender, EventArgs e)
        {
            try
            {
                // Load player data
                baglanti.Open();
                string sorgu = "select * from Tbl_Oyuncular WHERE ID=@p1";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", lblId.Text);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    lblCinsiyet.Text = oku["CINSIYET"].ToString();
                    lblAdSoyad.Text = oku["ADSOYAD"].ToString(); // Ensure name is displayed
                }
                baglanti.Close();

                // Set gender icon based on database value
                if (lblCinsiyet.Text == "0")
                {
                    pbCinsiyet.ImageLocation = Path.Combine(Application.StartupPath, "resimler", "erkek.png");
                }
                else
                {
                    pbCinsiyet.ImageLocation = Path.Combine(Application.StartupPath, "resimler", "kadın.png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult confirmation = MessageBox.Show(
                "Oyuncu silinsin mi?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                   
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    
                    SqlCommand sil = new SqlCommand("DELETE FROM Tbl_Oyuncular WHERE ID=@p1", baglanti);
                    sil.Parameters.AddWithValue("@p1", lblId.Text);
                    sil.ExecuteNonQuery();

                   
                    MessageBox.Show(
                        lblAdSoyad.Text + " adlı kişiye ait kayıt başarıyla silinmiştir.",
                        "Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    
                    this.Hide();
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show(
                        "Kayıt silinirken bir hata oluştu: " + ex.Message,
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                finally
                {
                    
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }
            else
            {
               
                MessageBox.Show(
                    "Silme işlemi iptal edildi.",
                    "Bilgilendirme",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(lblId.Text); // Ensure lblId contains the player's ID
                FrmOyuncuDuzenle frmDuzenle = new FrmOyuncuDuzenle(ID);
                frmDuzenle.ShowDialog();

                // Optionally, refresh data after editing
                OyuncuListesi_Load(sender, e); // Reload the data to reflect any changes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening edit form: " + ex.Message);
            }
        }

        private void pbCinsiyet_Click(object sender, EventArgs e)
        {

        }
    }
}
