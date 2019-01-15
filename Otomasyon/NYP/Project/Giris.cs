using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public static string giris_isim = "";
        public static string giris_sifre = "";

        private void giris_btn_Click(object sender, EventArgs e)
        {
            if (yonetici_giris_rdnBtn.Checked == true)
                giris_yap(1);

            else if (musteri_rdnBtn.Checked == true)    // Yönetici ve müşteri girişine göre foksiyona değer yollandı.
                giris_yap(2);

            else
                MessageBox.Show("Lütfen Seçenek Seçiniz");  // Eğer radio butona basılmazsa hata verildi.

        }

        public void giris_yap(int sayi) // Bu fonksiyonda gönderilen değer üzerinden hangi dosya açılması amacıyla oluşturuldu.
        {
            if (sayi == 1)
            {
                StreamReader read = new StreamReader(@"D:\yonetici.txt", Encoding.Default);
                string deger = read.ReadLine();                   //Fonksiyona gönderilen değer 1 ise yonetici dosyası açıldı.

                if (dosya_okuma(read, deger))      //Açılan yönetici dosyası yeni bir fonksiyona yollandı ve fonsiyondan true donerse form açılması sağlandı
                {
                    YoneticiForm yoneticiForm = new YoneticiForm();
                    this.Hide();
                    yoneticiForm.Show();

                }

                else
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");   //Fonksiyondan false donerse hata verildi.

                read.Close();
            }
            //Aynı işlemler fonksiyona 2 yollanırsa musteri uzerinden gerçekleşecek.
            else if (sayi == 2)
            {
                try
                {
                    StreamReader read = new StreamReader(@"D:\musteri.txt", Encoding.Default);
                    string deger = read.ReadLine();

                    if (dosya_okuma(read, deger))
                    {
                        MusteriForm musteri = new MusteriForm();
                        this.Hide();
                        musteri.Show();

                    }

                    else
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");

                    read.Close();
                }
                catch
                {
                    MessageBox.Show("Kayıt Bulunamadı");
                }
            }

            
        }

        public bool dosya_okuma(StreamReader read, string deger)
        {

            //Gönderilen dosyayı satır satır okundu ve split methodu ile '-' işaretine göre bölündü 
            while (deger != null)         // Bölündükten sonra her satır oluşturulan listeye atıldı 0. eleman kullanıcı adı 1. eleman şifremiz oldu
            {                                   // Kullanıcı adı ve şifre girilen bilgilerle uyuşuyorsa true döndürüldü.
                string[] parcalar;
                parcalar = deger.ToString().Split('-');
                deger = read.ReadLine();

                for (int j = 0; j < 2; j++)
                {
                    if (parcalar[0] == username.Text && (parcalar[1] == password.Text))
                    {
                        giris_isim = parcalar[0].ToString(); //Giriş yapılan kullanıcı adı kaydedildi
                        giris_sifre = parcalar[1].ToString();
                        dosyaBak();  //Dosya bak fonksiyonu ile giriş yapılan isime özel dosya oluşup oluşmadığı kontrol edilecek
                        return true;
                    }
                }
            }
            return false;
        }

        public void dosyaBak()
        {
            if (File.Exists(@"D:\" + giris_isim + ".txt") == false)  // Eğer giriş yapılan isime ozel dosya yok ise oluşturulacak
            {
                FileStream fs = File.Create(@"D:\" + giris_isim + ".txt");
                fs.Close();

            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            panelKayitOl.Visible = true;
            panelGiris.Visible = false;
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            panelKayitOl.Visible = false;
            panelGiris.Visible = true;
        }

        private void btnKayitOlisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar);
        }

        private void btnKayıtOlSoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar);
        }

        private void btnKayıtOnay_Click(object sender, EventArgs e)
        {
            FileStream fil = new FileStream(@"D:\musteri.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fil.Close();
            if (txtKayitOlisim.Text == "" || txtKayıtOlSoyisim.Text == "" || txtKayitOlKA.Text == "" || txtKayitOlSifre.Text == "" || txtKayitOlSifreTekrar.Text == "")
                MessageBox.Show("Kullanıcı Bilgileri Boş Bırakılamaz!");

            else
            {
                if (txtKayitOlSifre.Text != txtKayitOlSifreTekrar.Text)
                    MessageBox.Show("Şifreler Uyuşmuyor!");

                else
                {
                    if (kullaniciAdiKontrol(txtKayitOlKA.Text.ToString()))
                        MessageBox.Show("Bu Kullanici Adı Daha Önce Kullanılmış !");

                    else
                    {
                        StreamWriter sw = File.AppendText(@"D:\musteri.txt");
                        sw.WriteLine(txtKayitOlKA.Text.ToString() + "-" + txtKayitOlSifre.Text.ToString());
                        sw.Close();


                        MessageBox.Show("Başarılı Bir Şekilde Kayıt Oldunuz. Sizi Aramızda Görmek Güzel.");
                        temizle();
                        panelKayitOl.Visible = false;
                        panelGiris.Visible = true;
                    }
                }
            }
        }

        public void temizle()
        {
            txtKayitOlisim.Text = "";
            txtKayitOlKA.Text = "";
            txtKayitOlSifre.Text = "";
            txtKayitOlSifreTekrar.Text = "";
            txtKayıtOlSoyisim.Text = "";
        }

        public bool kullaniciAdiKontrol(string kullaniciAdi)
        {
            StreamReader sr = new StreamReader("D:\\musteri.txt", Encoding.Default);
            string temp = sr.ReadLine();

            while (temp != null)
            {
                string[] ayir;
                ayir = temp.ToString().Split('-');

                if (ayir[0].ToString() == kullaniciAdi)
                {
                    sr.Close();
                    return true;
                }

                temp = sr.ReadLine();

            }
            sr.Close();
            return false;

        }
    }
}
