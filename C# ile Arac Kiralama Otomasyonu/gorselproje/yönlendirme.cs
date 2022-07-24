using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gorselproje
{
    public partial class yönlendirme : Form
    {
        public yönlendirme()
        {
            InitializeComponent();                                      //genel olarak sayfalar arası gezinme için geri tuşu konuldu.
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            Araçlar arc = new Araçlar();
            arc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müsteriler arc = new Müsteriler();
            arc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hizmet arc = new Hizmet();
            arc.Show();
            this.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            totalkayıtlar arc = new totalkayıtlar();
            arc.Show();
            this.Hide();
        }

        private void yönlendirme_Load(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)                     /*Genel olarak butonlara fare ile üstüne gelindiğinde hangi butonda olduğunu belirtmek için
                                                                                         üzerine gelinen alanın renginin kırmızı olması. */
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button4_tumkayıtlar_MouseHover(object sender, EventArgs e)
        {
            button4_tumkayıtlar.BackColor = Color.Red;
        }

        private void button4_tumkayıtlar_MouseMove(object sender, MouseEventArgs e)
        {
            button4_tumkayıtlar.BackColor = Color.White;
        }

        
    }
}
