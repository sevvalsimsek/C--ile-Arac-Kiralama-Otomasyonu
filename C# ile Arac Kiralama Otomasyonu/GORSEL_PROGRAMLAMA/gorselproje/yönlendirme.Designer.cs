
namespace gorselproje
{
    partial class yönlendirme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yönlendirme));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4_tumkayıtlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(246, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 116);
            this.button1.TabIndex = 0;
            this.button1.Text = "ARAÇLAR SAYFASINA GİTMEK İÇİN TIKLAYINIZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(481, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 116);
            this.button2.TabIndex = 1;
            this.button2.Text = "MÜŞTERİLER SAYFASINA GİTMEK İÇİN TIKLAYINIZ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 116);
            this.button3.TabIndex = 2;
            this.button3.Text = "HİZMETLER SAYFASINA GİTMEK İÇİN TIKLAYINIZ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button4_tumkayıtlar
            // 
            this.button4_tumkayıtlar.BackColor = System.Drawing.Color.White;
            this.button4_tumkayıtlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button4_tumkayıtlar.Location = new System.Drawing.Point(109, 256);
            this.button4_tumkayıtlar.Name = "button4_tumkayıtlar";
            this.button4_tumkayıtlar.Size = new System.Drawing.Size(438, 53);
            this.button4_tumkayıtlar.TabIndex = 3;
            this.button4_tumkayıtlar.Text = "TÜM KAYITLARI GÖRMEK İÇİN TIKLAYINIZ";
            this.button4_tumkayıtlar.UseVisualStyleBackColor = false;
            this.button4_tumkayıtlar.Click += new System.EventHandler(this.button4_Click);
            this.button4_tumkayıtlar.MouseHover += new System.EventHandler(this.button4_tumkayıtlar_MouseHover);
            this.button4_tumkayıtlar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_tumkayıtlar_MouseMove);
            // 
            // yönlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 376);
            this.Controls.Add(this.button4_tumkayıtlar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "yönlendirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.yönlendirme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4_tumkayıtlar;
    }
}