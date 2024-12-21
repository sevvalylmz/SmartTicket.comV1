﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartTicket.comV1
{
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=.\SQLEXPRESS;Initial Catalog=SmarTicket;Integrated Security=True");

        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            string sorgu = " select * from Tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) 
            {
                FlmListesi arac = new FlmListesi();
                arac.lblFilmAdi.Text= oku["ADI"].ToString();
                arac.pictureBox3.ImageLocation = oku["AFIS"].ToString();
                arac.lblIdNo.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void textAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Filmler Where ADI LIKE '%" + textAramaYap.Text + "%'collate Turkish_CI_AS ORDER BY ADI ASC", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                FlmListesi arac = new FlmListesi();
                arac.lblFilmAdi.Text = oku["ADI"].ToString();
                arac.pictureBox3.ImageLocation = oku["AFIS"].ToString();
                arac.lblIdNo.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
