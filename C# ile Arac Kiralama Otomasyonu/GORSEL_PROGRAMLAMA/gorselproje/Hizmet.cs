using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gorselproje
{
    public partial class Hizmet : Form
    {
        public Hizmet()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server = localhost; user id = root; password=366801;database=otopark"); // verilerimizi çekmek için veritabanımızı baglantı sınıfı ile bağladık.
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;
       

        private void button1_Click(object sender, EventArgs e) //araclar sayfasından çıkıp ana sayfaya dönmek için bir geri butonu oluşturduk.
        {
            yönlendirme arc = new yönlendirme();
            arc.Show();
            this.Hide();
        }

        private void button1_ekle_Click(object sender, EventArgs e) /* yeni bir veri eklemek için sırası ile komutlar doldurup
                                                                     ekle butonuna basıldığında verileri ekleyen komut oluşturuldu. 
                                                                     Ekle butonuna basıldıktan sonra form içindeki veriler temizlendi*/
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into hizmet(id,musteri_id,arac_id,abonelik_id,giris_saati,cikis_saati,ucret,abonelik_tipi) values ('" + textBox4_id.Text + "','" + textBox3_musid.Text + "','" + textBox2_aracid.Text + "','" + textBox1_aboneid.Text + "','" + textBox1_gsaat.Text + "','" + textBox2_csaat.Text + "','" + textBox3_ucret.Text + "','" + comboBox1_abonetipi.Text + "')";
            cmd.ExecuteNonQuery();
            baglanti.Close();

            dt_veri_ekleme();
            textBox3_musid.Text = "";
            textBox2_aracid.Text = "";
            textBox1_aboneid.Text = "";
            textBox1_gsaat.Text = "";
            textBox2_csaat.Text = "";
            textBox3_ucret.Text = "";
            comboBox1_abonetipi.Text = "";
            textBox4_id.Text = "";
            dt_veri_ekleme();
            MessageBox.Show("Başarılı Kayıt.."); 
        }

        private void Hizmet_Load(object sender, EventArgs e) // veritabanında var olan verilerin gelmesini sağlamak için bir veri ekleme methodu oluşturduk.
                                                             // islem adında method oluşturarak combobox a veri aktarımı gerçekleştirildi.
        {
            dt_veri_ekleme();
            islem();

        }
        public void dt_veri_ekleme()                        // bağladığımız veritabanında var olan araclar tablomuzdaki verileri datagridview tablomuza çağırdık.
        {
            da = new MySqlDataAdapter("Select * from hizmet", baglanti);
            ds = new DataSet();
            
            baglanti.Open();
            da.Fill(ds, "hizmet");
            dataGridView1_vericekme.DataSource = ds.Tables["hizmet"]; 
            
            baglanti.Close();
        }
        public void islem()                               // veritabanında var olan aylık ve haftalık bilgileri combobax butonumuza bağlandı.
        {
            
            comboBox1_abonetipi.Items.Add("aylık");
            comboBox1_abonetipi.Items.Add("haftalık");
            dataGridView1_vericekme.DataSource = ds.Tables["hizmet"];

        }

        private void button3_sil_Click(object sender, EventArgs e) /*var olan bir kaydı silmek için veriye çift tıklayarak veya sadece id kutusuna silmek istenen değer
                                                                    girildikten sonra sil butonuna basıldığında verileri silen sistem oluşturuldu. */
        {
            cmd = new MySqlCommand();

            baglanti.Open();
            cmd.Connection = baglanti;

            cmd.CommandText = "delete from hizmet where id=" + textBox4_id.Text + "";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            textBox4_id.Text = "";
            textBox3_musid.Text = "";
            textBox2_aracid.Text = "";
            textBox1_aboneid.Text = "";
            textBox1_gsaat.Text = "";
            textBox2_csaat.Text = "";
            textBox3_ucret.Text = "";
            comboBox1_abonetipi.Text = "";
            dt_veri_ekleme();
            MessageBox.Show("Kayıt Silindi..");
        }

        private void button2_guncelle_Click(object sender, EventArgs e) /* değişiklik yapmak istediği veride musteri id girinimi zorunlu kılınarak veya seçilen sütuna çift tıklanarak diğer verileri değiştirme özelliği yapıldı.
                                                                         Veriler güncellendikten sonra formdaki kayıtlar silindi*/
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update  hizmet set id='" + textBox4_id.Text + "',arac_id='" + textBox2_aracid.Text + "',abonelik_id='" + textBox1_aboneid.Text + "',giris_saati='" + textBox1_gsaat.Text + "',cikis_saati='" + textBox2_csaat.Text + "',ucret='" + textBox3_ucret.Text + "',abonelik_tipi='" + comboBox1_abonetipi.Text + "'  where musteri_id='" + textBox3_musid.Text + "'";
            //cmd.CommandText = "update araclar  set arac_plaka='" + textBox1_plaka.Text + "',arac_renk='" + textBox2_renk.Text + "'arac_model='" + textBox3_model.Text + "'arac_yıl='" + textBox4_yıl + "' where arac_id=" + textBox5_id.Text + '";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            dt_veri_ekleme();
            textBox3_musid.Text = "";
            textBox2_aracid.Text = "";
            textBox1_aboneid.Text = "";
            textBox1_gsaat.Text = "";
            textBox2_csaat.Text = "";
            textBox3_ucret.Text = "";
            comboBox1_abonetipi.Text = "";
            textBox4_id.Text = "";
            MessageBox.Show("Veriler Güncellendi..");
        }

        private void comboBox1_abonetipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_vericekme_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) // datagridview de var olan değerlere çift tıklandığında form ekranına bilgilerin gelmesi sağlandı.
        {
            textBox4_id.Text = dataGridView1_vericekme.CurrentRow.Cells[0].Value.ToString();
            textBox3_musid.Text = dataGridView1_vericekme.CurrentRow.Cells[1].Value.ToString();
            textBox2_aracid.Text = dataGridView1_vericekme.CurrentRow.Cells[2].Value.ToString();
            textBox1_aboneid.Text = dataGridView1_vericekme.CurrentRow.Cells[3].Value.ToString();
            textBox1_gsaat.Text = dataGridView1_vericekme.CurrentRow.Cells[4].Value.ToString();
            textBox2_csaat.Text = dataGridView1_vericekme.CurrentRow.Cells[5].Value.ToString();
            textBox3_ucret.Text = dataGridView1_vericekme.CurrentRow.Cells[6].Value.ToString();
            comboBox1_abonetipi.Text = dataGridView1_vericekme.CurrentRow.Cells[7].Value.ToString();
            
            
        }

        private void textBox3_musid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
