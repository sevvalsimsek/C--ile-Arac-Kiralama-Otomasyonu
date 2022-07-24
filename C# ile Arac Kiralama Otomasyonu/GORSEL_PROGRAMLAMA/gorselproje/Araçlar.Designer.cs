
namespace gorselproje
{
    partial class Araçlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_plaka = new System.Windows.Forms.TextBox();
            this.textBox2_renk = new System.Windows.Forms.TextBox();
            this.textBox3_model = new System.Windows.Forms.TextBox();
            this.textBox4_yıl = new System.Windows.Forms.TextBox();
            this.button1_ekle = new System.Windows.Forms.Button();
            this.button2_guncelle = new System.Windows.Forms.Button();
            this.button3_sil = new System.Windows.Forms.Button();
            this.dataGridView1_vericekme = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_vericekme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yıl";
            // 
            // textBox1_plaka
            // 
            this.textBox1_plaka.Location = new System.Drawing.Point(222, 44);
            this.textBox1_plaka.Name = "textBox1_plaka";
            this.textBox1_plaka.Size = new System.Drawing.Size(158, 23);
            this.textBox1_plaka.TabIndex = 4;
            // 
            // textBox2_renk
            // 
            this.textBox2_renk.Location = new System.Drawing.Point(222, 98);
            this.textBox2_renk.Name = "textBox2_renk";
            this.textBox2_renk.Size = new System.Drawing.Size(158, 23);
            this.textBox2_renk.TabIndex = 5;
            // 
            // textBox3_model
            // 
            this.textBox3_model.Location = new System.Drawing.Point(222, 135);
            this.textBox3_model.Name = "textBox3_model";
            this.textBox3_model.Size = new System.Drawing.Size(158, 23);
            this.textBox3_model.TabIndex = 6;
            // 
            // textBox4_yıl
            // 
            this.textBox4_yıl.Location = new System.Drawing.Point(222, 176);
            this.textBox4_yıl.Name = "textBox4_yıl";
            this.textBox4_yıl.Size = new System.Drawing.Size(158, 23);
            this.textBox4_yıl.TabIndex = 7;
            // 
            // button1_ekle
            // 
            this.button1_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1_ekle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_ekle.Location = new System.Drawing.Point(416, 84);
            this.button1_ekle.Name = "button1_ekle";
            this.button1_ekle.Size = new System.Drawing.Size(96, 53);
            this.button1_ekle.TabIndex = 8;
            this.button1_ekle.Text = "EKLE";
            this.button1_ekle.UseVisualStyleBackColor = false;
            this.button1_ekle.Click += new System.EventHandler(this.button1_ekle_Click);
            // 
            // button2_guncelle
            // 
            this.button2_guncelle.BackColor = System.Drawing.Color.Yellow;
            this.button2_guncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_guncelle.Location = new System.Drawing.Point(544, 84);
            this.button2_guncelle.Name = "button2_guncelle";
            this.button2_guncelle.Size = new System.Drawing.Size(98, 53);
            this.button2_guncelle.TabIndex = 9;
            this.button2_guncelle.Text = "GÜNCELLE";
            this.button2_guncelle.UseVisualStyleBackColor = false;
            this.button2_guncelle.Click += new System.EventHandler(this.button2_guncelle_Click);
            // 
            // button3_sil
            // 
            this.button3_sil.BackColor = System.Drawing.Color.Red;
            this.button3_sil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3_sil.Location = new System.Drawing.Point(670, 85);
            this.button3_sil.Name = "button3_sil";
            this.button3_sil.Size = new System.Drawing.Size(92, 52);
            this.button3_sil.TabIndex = 10;
            this.button3_sil.Text = "SİL";
            this.button3_sil.UseVisualStyleBackColor = false;
            this.button3_sil.Click += new System.EventHandler(this.button3_sil_Click);
            // 
            // dataGridView1_vericekme
            // 
            this.dataGridView1_vericekme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1_vericekme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_vericekme.Location = new System.Drawing.Point(-3, 224);
            this.dataGridView1_vericekme.Name = "dataGridView1_vericekme";
            this.dataGridView1_vericekme.RowTemplate.Height = 25;
            this.dataGridView1_vericekme.Size = new System.Drawing.Size(803, 227);
            this.dataGridView1_vericekme.TabIndex = 11;
            this.dataGridView1_vericekme.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_vericekme_CellContentDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Araç no";
            // 
            // textBox5_id
            // 
            this.textBox5_id.Location = new System.Drawing.Point(222, 7);
            this.textBox5_id.Name = "textBox5_id";
            this.textBox5_id.Size = new System.Drawing.Size(158, 23);
            this.textBox5_id.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Araçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1_vericekme);
            this.Controls.Add(this.button3_sil);
            this.Controls.Add(this.button2_guncelle);
            this.Controls.Add(this.button1_ekle);
            this.Controls.Add(this.textBox4_yıl);
            this.Controls.Add(this.textBox3_model);
            this.Controls.Add(this.textBox2_renk);
            this.Controls.Add(this.textBox1_plaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Araçlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAÇLAR";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_vericekme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_plaka;
        private System.Windows.Forms.TextBox textBox2_renk;
        private System.Windows.Forms.TextBox textBox3_model;
        private System.Windows.Forms.TextBox textBox4_yıl;
        private System.Windows.Forms.Button button1_ekle;
        private System.Windows.Forms.Button button2_guncelle;
        private System.Windows.Forms.Button button3_sil;
        private System.Windows.Forms.DataGridView dataGridView1_vericekme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5_id;
        private System.Windows.Forms.Button button1;
    }
}