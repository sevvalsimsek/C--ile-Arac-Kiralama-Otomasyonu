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
    public partial class Araçlar : Form
    {
        public Araçlar()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server = localhost; user id = root; password=366801;database=otopark"); // verilerimizi çekmek için veritabanımızı baglantı sınıfı ile bağladık.
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;




        private void Form2_Load(object sender, EventArgs e) // veritabanında var olan verilerin gelmesini sağlamak için bir veri ekleme methodu oluşturduk.
        {

            dt_veri_ekleme();

        }

        public void dt_veri_ekleme()
        {
            da = new MySqlDataAdapter("Select * from araclar", baglanti); // bağladığımız veritabanında var olan araclar tablomuzdaki verileri datagridview tablomuza çağırdık.
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "araclar");
            dataGridView1_vericekme.DataSource = ds.Tables["araclar"]; ;
            baglanti.Close();
        }

        private void button1_ekle_Click(object sender, EventArgs e) /* yeni bir veri eklemek için sırası ile komutlar doldurup
                                                                     ekle butonuna basıldığında verileri ekleyen komut oluşturuldu. 
                                                                     Ekle butonuna basıldıktan sonra form içindeki veriler temizlendi*/

        {
            baglanti.Open();
            cmd = new MySqlCommand("insert into araclar(arac_id,arac_plaka,arac_renk,arac_model,arac_yıl) values ('" + textBox5_id.Text + "','" + textBox1_plaka.Text + "','" + textBox2_renk.Text + "','" + textBox3_model.Text + "','" + textBox4_yıl.Text + "')",baglanti);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            dt_veri_ekleme();
            textBox5_id.Text = "";
            textBox1_plaka.Text = "";
            textBox2_renk.Text = "";
            textBox3_model.Text = "";
            textBox4_yıl.Text = "";

            MessageBox.Show("Başarılı Kayıt..");
        }


        private void button3_sil_Click(object sender, EventArgs e)  /*var olan bir kaydı silmek için değere çift tıklanarak 
                                                                     sil butonuna basıldığında verileri silen sistem oluşturuldu. */
        {
            cmd = new MySqlCommand();

            baglanti.Open();
            cmd.Connection = baglanti;

            cmd.CommandText = "delete from araclar where arac_id=" + textBox5_id.Text + "";//araç id si ... olan veriyi siler.
            cmd.ExecuteNonQuery();
            baglanti.Close();

            dt_veri_ekleme();

            MessageBox.Show("Kayıt Silindi..");

        }

        private void button2_guncelle_Click(object sender, EventArgs e) /* değişiklik yapmak istediği veride araç id girinimi zorunlu kılınarak veya seçilen sütun çift tıklanarak diğer verileri değiştirme özelliği yapılır.
                                                                         Veriler güncellendikten sonra ekrana pop up mesajı çıkar ve formdaki kayıtlar silinir*/
        {
            

            cmd = new MySqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update  araclar set arac_plaka='" + textBox1_plaka.Text + "',arac_renk='" + textBox2_renk.Text + "',arac_model='" + textBox3_model.Text + "',arac_yıl='" + textBox4_yıl.Text + "' where arac_id='" + textBox5_id.Text + "'";
            //cmd.CommandText = "update araclar  set arac_plaka='" + textBox1_plaka.Text + "',arac_renk='" + textBox2_renk.Text + "'arac_model='" + textBox3_model.Text + "'arac_yıl='" + textBox4_yıl + "' where arac_id=" + textBox5_id.Text + '";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            dt_veri_ekleme();
            textBox5_id.Text = "";
            textBox1_plaka.Text = "";
            textBox2_renk.Text = "";
            textBox3_model.Text = "";
            textBox4_yıl.Text = "";

            MessageBox.Show("Veriler Güncellendi..");



        }

        private void button1_Click(object sender, EventArgs e)    //araclar sayfasından çıkıp ana sayfaya dönmek için bir geri butonu oluşturduk.
        {
            yönlendirme arc = new yönlendirme();
            arc.Show();
            this.Hide();
        }

        private void dataGridView1_vericekme_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) // datagridview de var olan değerlere çift tıklandığında form ekranına bilgilerin gelmesi sağlandı.
        {
            textBox5_id.Text = dataGridView1_vericekme.CurrentRow.Cells[0].Value.ToString();
            textBox1_plaka.Text = dataGridView1_vericekme.CurrentRow.Cells[1].Value.ToString();
            textBox2_renk.Text = dataGridView1_vericekme.CurrentRow.Cells[2].Value.ToString();
            textBox3_model.Text = dataGridView1_vericekme.CurrentRow.Cells[3].Value.ToString();
            textBox4_yıl.Text = dataGridView1_vericekme.CurrentRow.Cells[4].Value.ToString();

        }

        
    }
}
