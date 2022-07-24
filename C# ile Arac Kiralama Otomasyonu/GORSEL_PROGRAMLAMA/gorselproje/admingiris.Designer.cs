
namespace gorselproje
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox1_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textbox2_Sifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(348, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(348, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE*";
            // 
            // textbox1_KullaniciAdi
            // 
            this.textbox1_KullaniciAdi.BackColor = System.Drawing.SystemColors.Info;
            this.textbox1_KullaniciAdi.Location = new System.Drawing.Point(459, 17);
            this.textbox1_KullaniciAdi.Name = "textbox1_KullaniciAdi";
            this.textbox1_KullaniciAdi.Size = new System.Drawing.Size(174, 23);
            this.textbox1_KullaniciAdi.TabIndex = 2;
            // 
            // textbox2_Sifre
            // 
            this.textbox2_Sifre.BackColor = System.Drawing.SystemColors.Info;
            this.textbox2_Sifre.Location = new System.Drawing.Point(459, 78);
            this.textbox2_Sifre.Name = "textbox2_Sifre";
            this.textbox2_Sifre.PasswordChar = '*';
            this.textbox2_Sifre.Size = new System.Drawing.Size(174, 23);
            this.textbox2_Sifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.Purple;
            this.btnGiris.Location = new System.Drawing.Point(355, 133);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(124, 58);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            this.btnGiris.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            this.btnGiris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGiris_MouseMove);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTemizle.ForeColor = System.Drawing.Color.Purple;
            this.btnTemizle.Location = new System.Drawing.Point(515, 133);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(118, 58);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            this.btnTemizle.MouseHover += new System.EventHandler(this.btnTemizle_MouseHover);
            this.btnTemizle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTemizle_MouseMove);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(541, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(651, 220);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.textbox2_Sifre);
            this.Controls.Add(this.textbox1_KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox1_KullaniciAdi;
        private System.Windows.Forms.TextBox textbox2_Sifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

