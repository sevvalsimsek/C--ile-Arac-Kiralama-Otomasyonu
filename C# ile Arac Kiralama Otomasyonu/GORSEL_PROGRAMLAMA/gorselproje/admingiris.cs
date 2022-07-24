using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselproje
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e) 
        {   
            String kullaniciadi = textbox1_KullaniciAdi.Text;   //kutu içine girilecek olan değerler belirtildi
            string sifre = textbox2_Sifre.Text;


            if(kullaniciadi == "sevval" && sifre == "beykoz")  
                                                               
            {
                    MessageBox.Show("Hoş Geldiniz.. \nYönlendirme sayfasına aktarılıyorsunuz");  /*burada kullanıcı şifreyi doğru girdiğinde hoş geldiniz çıktısı doğru girilmediği 
                                                                    taktirde kullanıcı adı veya şifre boş bırakılamaz mesajı veren kodları yazdım.*/

                yönlendirme arc = new yönlendirme();    // kullanıcı doğru giriş yaptıktan sonra ekrana yönlendirme sayfası çağrıldı.
                arc.Show();
                this.Hide();                            // açılan pencereler üst üste binmesin diye bu kodu yazdım.


            }
            else if(kullaniciadi == "" || sifre == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz");
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı..\n Lütfen tekrar deneyin..");
                textbox1_KullaniciAdi.Text = "";
                textbox2_Sifre.Text = "";
                textbox1_KullaniciAdi.Focus();
            }


            //if (kullaniciadi == "")
            //{
            //    MessageBox.Show("kullanıcı adı boş bırakılamaz");
            //}
            //if (sifre == "")
            //{
            //    MessageBox.Show(" şifre boş bırakılamaz");
            //}

            //if(kullaniciadi=="sevval" && sifre=="beykoz")
            //{
            //    MessageBox.Show("hoş geldiniz..");
            //}
            //else
            //{
            //    MessageBox.Show("kullanıcı adı veya şifre hatalı..\n Lütfen tekrar deneyin..");
            //    textbox1_KullaniciAdi.Text = "";
            //    textbox2_Sifre.Text = "";
            //    textbox1_KullaniciAdi.Focus();
            //}





            //yönlendirme arc = new yönlendirme();
            //arc.Show();
            //this.Hide();

        }

        private void btnTemizle_Click(object sender, EventArgs e)    //giriş yapılırken yanlış bilgi girilmesine karşın bir temizleme butonu oluşturuldu girilen veriler silindi.
        {
            textbox1_KullaniciAdi.Text = "";
            textbox2_Sifre.Text = "";
            textbox1_KullaniciAdi.Focus();
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lütfen yöneticiniz ile iletişime geçiniz..");
        }

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Yellow;
        }

        private void btnGiris_MouseMove(object sender, MouseEventArgs e)
        {
            btnGiris.BackColor = Color.White;
        }

        private void btnTemizle_MouseHover(object sender, EventArgs e)
        {
            btnTemizle.BackColor = Color.Yellow;
        }

        private void btnTemizle_MouseMove(object sender, MouseEventArgs e)
        {
            btnTemizle.BackColor = Color.White;
        }
    }
}
