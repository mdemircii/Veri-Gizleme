using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1

{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }
        private void buttonResim_ekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog orjinal_resim_ac = new OpenFileDialog();
            orjinal_resim_ac.Filter = "Image Files (*.bmp, *.tiff) | *.bmp; *.tiff";
            orjinal_resim_ac.InitialDirectory = @"C:\Users\Mertcan PC\Desktop";

            if (orjinal_resim_ac.ShowDialog() == DialogResult.OK)
            {
                textBoxDosya_Yolu.Text = orjinal_resim_ac.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Resim Boyutumuzu aşması durumunda uygun boyuta gelmesini sağlıyoruz.
                pictureBox1.ImageLocation = textBoxDosya_Yolu.Text;

            }
        }
        private void buttonSifreli_Resim_Ekle_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty; //Textboxları temizliyoruz.
            OpenFileDialog sifreli_resim_ac = new OpenFileDialog();
            sifreli_resim_ac.Filter = "Image Files (*.bmp, *.tiff) | *.bmp; *.tiff";
            sifreli_resim_ac.InitialDirectory = @"C:\Users\Mertcan PC\Desktop";

            if (sifreli_resim_ac.ShowDialog() == DialogResult.OK)
            {
                textBoxSifreli_Dosya_Yolu.Text = sifreli_resim_ac.FileName.ToString();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Resim Boyutumuzu aşması durumunda sığdırıyoruz.
                pictureBox2.ImageLocation = textBoxSifreli_Dosya_Yolu.Text;

            }

        }

        private void button_Encode_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklü Değildir.");
                Application.Exit();

            }
            else
            { 

                Bitmap img = new Bitmap(textBoxDosya_Yolu.Text);



                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {

                        Color pixel = img.GetPixel(i, j);
                        if (i < 1 && j < textBox2.TextLength) // Gönderilecek maksimum text uzunluğu
                        {
                            Console.WriteLine("R = [" + i + " ][" + j + " ] = " + pixel.R);
                            Console.WriteLine("G = [" + i + " ][" + j + " ] = " + pixel.G);
                            Console.WriteLine("B = [" + i + " ][" + j + " ] = " + pixel.B);

                            char mesaj = Convert.ToChar(textBox2.Text.Substring(j, 1)); // Gönderilen verimiz ASCII formatına dönüştürülüyor.
                            int deger = Convert.ToInt32(mesaj);
                            if (deger > 255)
                            {
                                deger = 0;  // Şifreli bir dosyanın üzerine şifre yazmak istediğimizde

                            }
                            Console.WriteLine(" mesaj: " + mesaj + " value :" + deger);

                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, deger)); // Blue renk kanalı kullanıldı.

                        }

                        if (i == img.Width - 1 && j == img.Height - 1)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBox2.TextLength));

                        }
                    }

                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.Filter = "Image Files (*.bmp, *.tiff) | *.bmp; *.tiff";
                dosyakaydet.InitialDirectory = @"C:\Users\Mertcan PC\Desktop";

                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    textBoxDosya_Yolu.Text = dosyakaydet.FileName.ToString();

                    pictureBox1.ImageLocation = textBoxDosya_Yolu.Text;

                    img.Save(textBoxDosya_Yolu.Text);

                }
            }


        }
            private void button_decode_Click_1(object sender, EventArgs e)
            {

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Resim Yüklü Değildir.");
                Application.Exit();

            }

            Bitmap img2= new Bitmap(textBoxSifreli_Dosya_Yolu.Text);
                string sifreli_veri = "";

                Color son_piksel = img2.GetPixel(img2.Width - 1, img2.Height - 1);
                int mesaj_uzunlugu = son_piksel.B;

                for (int i = 0; i < img2.Width; i++)
                {
                    for (int j = 0; j < img2.Height; j++)
                    {

                        Color pixel = img2.GetPixel(i, j);
                        if (i < 1 && j < mesaj_uzunlugu) // Gönderilecek maksimum text uzunluğu
                        {

                            int deger = pixel.B;
                            char c = Convert.ToChar(deger);
                            string mesaj = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                            sifreli_veri = sifreli_veri + mesaj;

                        }
                    }

                }


                textBox2.Text = sifreli_veri;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                textBox2.Text = String.Empty; //Textboxları temizliyoruz.

            }

            private void button2_Click(object sender, EventArgs e)
            {
                pictureBox1.Image = null; //Resimi temizliyoruz.
                textBoxDosya_Yolu.Text = String.Empty; //Textboxları temizliyoruz.

            }

            private void button3_Click(object sender, EventArgs e)
            {
                pictureBox2.Image = null; //Resimi temizliyoruz.
                textBoxSifreli_Dosya_Yolu.Text = String.Empty; //Textboxları temizliyoruz.
            }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
  
    }
    }
