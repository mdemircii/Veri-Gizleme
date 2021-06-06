
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonResim_ekle = new System.Windows.Forms.Button();
            this.button_Encode = new System.Windows.Forms.Button();
            this.button_decode = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDosya_Yolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSifreli_Dosya_Yolu = new System.Windows.Forms.TextBox();
            this.buttonSifreli_Resim_Ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResim_ekle
            // 
            this.buttonResim_ekle.Location = new System.Drawing.Point(45, 313);
            this.buttonResim_ekle.Name = "buttonResim_ekle";
            this.buttonResim_ekle.Size = new System.Drawing.Size(122, 23);
            this.buttonResim_ekle.TabIndex = 1;
            this.buttonResim_ekle.Text = "Resim Aç";
            this.buttonResim_ekle.UseVisualStyleBackColor = true;
            this.buttonResim_ekle.Click += new System.EventHandler(this.buttonResim_ekle_Click);
            // 
            // button_Encode
            // 
            this.button_Encode.Location = new System.Drawing.Point(49, 408);
            this.button_Encode.Name = "button_Encode";
            this.button_Encode.Size = new System.Drawing.Size(122, 23);
            this.button_Encode.TabIndex = 2;
            this.button_Encode.Text = "Encode";
            this.button_Encode.UseVisualStyleBackColor = true;
            this.button_Encode.Click += new System.EventHandler(this.button_Encode_Click);
            // 
            // button_decode
            // 
            this.button_decode.Location = new System.Drawing.Point(201, 408);
            this.button_decode.Name = "button_decode";
            this.button_decode.Size = new System.Drawing.Size(122, 23);
            this.button_decode.TabIndex = 3;
            this.button_decode.Text = "Decode";
            this.button_decode.UseVisualStyleBackColor = true;
            this.button_decode.Click += new System.EventHandler(this.button_decode_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(46, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mesajınızı Giriniz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mesajı Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Resimi Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(45, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 197);
            this.panel1.TabIndex = 11;
            // 
            // textBoxDosya_Yolu
            // 
            this.textBoxDosya_Yolu.Location = new System.Drawing.Point(149, 273);
            this.textBoxDosya_Yolu.Name = "textBoxDosya_Yolu";
            this.textBoxDosya_Yolu.Size = new System.Drawing.Size(154, 20);
            this.textBoxDosya_Yolu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(42, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Orjinal Resim Dosyası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(401, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şifreli Resim Dosyası";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(404, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 197);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 190);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Resimi Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxSifreli_Dosya_Yolu
            // 
            this.textBoxSifreli_Dosya_Yolu.Location = new System.Drawing.Point(511, 273);
            this.textBoxSifreli_Dosya_Yolu.Name = "textBoxSifreli_Dosya_Yolu";
            this.textBoxSifreli_Dosya_Yolu.Size = new System.Drawing.Size(151, 20);
            this.textBoxSifreli_Dosya_Yolu.TabIndex = 15;
            // 
            // buttonSifreli_Resim_Ekle
            // 
            this.buttonSifreli_Resim_Ekle.Location = new System.Drawing.Point(404, 313);
            this.buttonSifreli_Resim_Ekle.Name = "buttonSifreli_Resim_Ekle";
            this.buttonSifreli_Resim_Ekle.Size = new System.Drawing.Size(122, 23);
            this.buttonSifreli_Resim_Ekle.TabIndex = 14;
            this.buttonSifreli_Resim_Ekle.Text = "Resim Aç";
            this.buttonSifreli_Resim_Ekle.UseVisualStyleBackColor = true;
            this.buttonSifreli_Resim_Ekle.Click += new System.EventHandler(this.buttonSifreli_Resim_Ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(401, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dosya Yolu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(46, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dosya Yolu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxSifreli_Dosya_Yolu);
            this.Controls.Add(this.buttonSifreli_Resim_Ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxDosya_Yolu);
            this.Controls.Add(this.button_decode);
            this.Controls.Add(this.button_Encode);
            this.Controls.Add(this.buttonResim_ekle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Veri Gizleme Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonResim_ekle;
        private System.Windows.Forms.Button button_Encode;
        private System.Windows.Forms.Button button_decode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDosya_Yolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSifreli_Dosya_Yolu;
        private System.Windows.Forms.Button buttonSifreli_Resim_Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

