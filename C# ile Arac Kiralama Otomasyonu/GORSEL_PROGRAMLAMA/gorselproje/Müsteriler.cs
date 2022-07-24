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
    public partial class Müsteriler : Form
    {
        public Müsteriler()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server = localhost; user id = root; password=366801;database=otopark"); // verilerimizi çekmek için veritabanımızı baglantı sınıfı ile bağladık.
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;

        private void button3_sil_Click(object sender, EventArgs e) 
        {                                                           /*var olan bir kaydı silmek için veriye çift tıklayarak veya sadece id kutusuna silmek istenen değer
                                                                    girildikten sonra sil butonuna basıldığında verileri silen sistem oluşturuldu. */
            cmd = new MySqlCommand();

            baglanti.Open();
            cmd.Connection = baglanti;

            cmd.CommandText = "delete from musteriler where musteri_id=" + textBox4_musterino.Text + "";
            cmd.ExecuteNonQuery();
            baglanti.Close();

            dt_veri_ekleme();
            MessageBox.Show("Kayıt Silindi..");
        }

        private void button1_ekle_Click(object sender, EventArgs e) /* yeni bir veri eklemek için sırası ile komutlar doldurup
                                                                     ekle butonuna basıldığında verileri ekleyen komut oluşturuldu.
                                                                       Ekle butonuna basıldıktan sonra form içindeki veriler temizlendi*/
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into musteriler(musteri_id,musteri_ad_soyad,musteri_telefon,musteri_adres) values ('" + textBox4_musterino.Text + "','" + textBox1_adsoyad.Text + "','" + textBox3_telno.Text + "','" + textBox2_adres.Text + "')";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            dt_veri_ekleme();
            textBox4_musterino.Text = "";
            textBox1_adsoyad.Text = "";
            textBox3_telno.Text = "";
            textBox2_adres.Text = "";

            MessageBox.Show("Başarılı Kayıt..");

        }

        private void Müsteriler_Load(object sender, EventArgs e) // veritabanında var olan verilerin gelmesini sağlamak için bir veri ekleme methodu oluşturduk.
        {
            dt_veri_ekleme();


        }
        public void dt_veri_ekleme()                             // bağladığımız veritabanında var olan musteriler tablomuzdaki verileri datagridview tablomuza çağırdık.
        {
            da = new MySqlDataAdapter("Select * from musteriler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteriler");
            dataGridView1_vericekme.DataSource = ds.Tables["musteriler"]; ;
            baglanti.Close();



        }

        private void button1_Click(object sender, EventArgs e) //musteriler sayfasından çıkıp ana sayfaya dönmek için bir geri butonu oluşturduk.
        {
            yönlendirme arc = new yönlendirme();
            arc.Show();
            this.Hide();
        }

        private void button2_guncelle_Click(object sender, EventArgs e) /* değişiklik yapmak istediğimiz veride musteri id girinimi zorunlu kılınarak veya seçilen sütun çift tıklanarak diğer verileri değiştirme özelliği yapılır.
                                                                         Veriler güncellendikten sonra ekrana pop up mesajı çıkar ve formdaki kayıtlar silinir*/
        {
            //cmd = new MySqlCommand();
            //baglanti.Open();
            //cmd.Connection = baglanti;
            //cmd.CommandText = "update  musteriler set musteri_ad_soyad='" + textBox1_adsoyad.Text + "',musteri_adres='" + textBox2_adres.Text + "',musteri_telefon='" + textBox3_telno.Text +"'  where musteri_id='" + textBox4_musterino.Text + "'";

        //cmd.ExecuteNonQuery();
        //baglanti.Close();
        //dt_veri_ekleme();

        cmd = new MySqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update  musteriler set musteri_ad_soyad='" + textBox1_adsoyad.Text + "',musteri_adres='" + textBox2_adres.Text + "',musteri_telefon='" + textBox3_telno.Text + "' where musteri_id='" + textBox4_musterino.Text + "'";
            //cmd.CommandText = "update araclar  set arac_plaka='" + textBox1_plaka.Text + "',arac_renk='" + textBox2_renk.Text + "'arac_model='" + textBox3_model.Text + "'arac_yıl='" + textBox4_yıl + "' where arac_id=" + textBox5_id.Text + '";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            dt_veri_ekleme();
            textBox4_musterino.Text = "";
            textBox1_adsoyad.Text = "";
            textBox2_adres.Text = "";
            textBox3_telno.Text = "";

            MessageBox.Show("Veriler Güncellendi..");



        }

        private void dataGridView1_vericekme_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) // datagridview de var olan değerlere çift tıklandığında form ekranına bilgilerin gelmesi sağlandı.
        {
            textBox4_musterino.Text = dataGridView1_vericekme.CurrentRow.Cells[0].Value.ToString();
            textBox1_adsoyad.Text = dataGridView1_vericekme.CurrentRow.Cells[1].Value.ToString();
            textBox2_adres.Text = dataGridView1_vericekme.CurrentRow.Cells[3].Value.ToString();
            textBox3_telno.Text = dataGridView1_vericekme.CurrentRow.Cells[2].Value.ToString();

        }

        private void dataGridView1_vericekme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
