using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
namespace gorselproje
{
    public partial class totalkayıtlar : Form
    {
        public totalkayıtlar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server = localhost; user id = root; password=366801;database=otopark"); // verilerimizi çekmek için veritabanımızı baglantı sınıfı ile bağladık.
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;


        private void dataGridView1_hizmetlertotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalkayıtlar_Load(object sender, EventArgs e)  // verilerimizi çağırmak için method oluşturduk.
        {
            dt_veri_ekleme1();
            dt_veri_ekleme2();
            dt_veri_ekleme3();
            dt_veri_aktar_araclar();
            dt_veri_aktar_hizmet();
            dt_veri_aktar_musteri();
        }
        public void dt_veri_aktar_araclar()
        {
            da = new MySqlDataAdapter("select * from araclar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "araclar");
            dataGridView2_araclartotal.DataSource = ds.Tables["araclar"];
            baglanti.Close();

        }
        public void dt_veri_aktar_hizmet()
        {
            da = new MySqlDataAdapter("select * from hizmet", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "hizmet");
            dataGridView2_araclartotal.DataSource = ds.Tables["hizmet"];
            baglanti.Close();

        }
        public void dt_veri_aktar_musteri()
        {
            da = new MySqlDataAdapter("select * from musteriler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteriler");
            dataGridView2_araclartotal.DataSource = ds.Tables["musteriler"];
            baglanti.Close();

        }
        public void dt_veri_ekleme1()                               //araclar tablosundaki tüm veriler datagridview tablosuna çağrıldı.
        {
            da = new MySqlDataAdapter("Select * from araclar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "araclar");
            dataGridView2_araclartotal.DataSource = ds.Tables["araclar"];
            baglanti.Close();
        }
        public void dt_veri_ekleme2()                               //hizmet tablosundaki tüm veriler datagridview tablosuna çağrıldı.
        {
            da = new MySqlDataAdapter("Select * from hizmet", baglanti);   
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "hizmet");
            dataGridView1_hizmetlertotal.DataSource = ds.Tables["hizmet"];
            baglanti.Close();
        }

        public void dt_veri_ekleme3()                               //musteriler tablosundaki tüm veriler datagridview tablosuna çağrıldı.
        {
            da = new MySqlDataAdapter("Select * from araclar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "araclar");
            dataGridView3_musterilertotal.DataSource = ds.Tables["araclar"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)    //ana sayfaya dönmek için geri butonu yapıldı.
        {
            yönlendirme arc = new yönlendirme();
            arc.Show();
            this.Hide();
        }

        private void exceleaktar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap1 = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap1.Sheets[1];
            for (int i = 0; i < dataGridView2_araclartotal.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView2_araclartotal.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView2_araclartotal.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView2_araclartotal.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView2_araclartotal[i, j].Value;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap1 = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap1.Sheets[1];
            for (int i = 0; i < dataGridView3_musterilertotal.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView3_musterilertotal.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView3_musterilertotal.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView3_musterilertotal.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView3_musterilertotal[i, j].Value;
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap1 = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap1.Sheets[1];
            for (int i = 0; i < dataGridView1_hizmetlertotal.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1_hizmetlertotal.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1_hizmetlertotal.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1_hizmetlertotal.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1_hizmetlertotal[i, j].Value;
                }
            }
        }
    }
    
            
            
            
            
}
