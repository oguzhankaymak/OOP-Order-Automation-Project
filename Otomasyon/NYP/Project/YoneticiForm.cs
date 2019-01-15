using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }

        UrunlerListesi liste = new UrunlerListesi();           // Urunlerin tutuldugu liste

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            yoneticiIlkGirisAyar();

            urunleriCek();
        }

        private void yoneticiIlkGirisAyar()                  // Yonetici formu yuklenir yuklenmez sadece urunler listesi
        {                                                    // gorunecek sekilde panellerin ayarlanmasi yapiliyor.                       
            panelUrunEkleGuncelle.Visible = false;
            panelBtnSil.Visible = false;
            panelBtnGuncelle1.Visible = false;
            panelOnay.Visible = false;
            panelAdet2.Visible = false;
            panelBtnGuncelle2.Visible = false;
            panelMusteriTakip.Visible = false;
        }

        private void urunleriCek()                           // Textteki urunler textten tek tek okunup urunler listesine
        {                                                    // ve dataGridViewe ekleniyor.
            dataListe.Rows.Clear();
            liste.Urunler.Clear();

            string urunlerAdres = @"D:/urunler.txt";

            if (!File.Exists(urunlerAdres))
                return;

            StreamReader read = new StreamReader(urunlerAdres, Encoding.Default);
            string deger = read.ReadLine();
            string[] parcalar;

            while (deger != null)
            {
                parcalar = deger.ToString().Split('-');

                string isim = parcalar[0];
                decimal fiyat = Convert.ToDecimal(parcalar[1]);
                double agirlik = Convert.ToDouble(parcalar[2]);
                int adet = Convert.ToInt32(parcalar[3]);

                Urun urun = new Urun(isim, fiyat, agirlik, adet);

                liste.UrunEkle(urun);

                tabloyaUrunEkle(urun);

                deger = read.ReadLine();
            }

            read.Close();
        }

        private void btnUrunler_Click(object sender, EventArgs e)       // Urunler butonuna tıklandığı zaman 
        {                                                               // sadece urunler listesi gorunuyor.            
            panelUrunEkleGuncelle.Visible = false;
            panelBtnSil.Visible = false;
            panelBtnGuncelle1.Visible = false;
            panelOnay.Visible = false;
            panelAdet2.Visible = false;
            panelBtnGuncelle2.Visible = false;
            panelUrunler.Visible = true;
            panelMusteriTakip.Visible = false;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)    // Urun ekleme paneli acilip digerleri kapaniyor.
        {
            panelUrunEkleGuncelleTemizle();
            label8.Text = "";

            panelUrunler.Visible = false;
            panelBtnSil.Visible = false;
            panelBtnGuncelle1.Visible = false;
            panelOnay.Visible = false;
            panelAdet2.Visible = false;
            panelBtnGuncelle2.Visible = false;
            panelUrunEkleGuncelle.Visible = true;
            panelMusteriTakip.Visible = false;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)       // Urun bilgileri girilip ekleye basildigi zaman
        {                                                              // gerekli kontroller dahilinde urun ekleniyor.
            if (txtIsim.Text == "")                                                      
                MessageBox.Show("Ürün ismi boş bırakılamaz!");              
                                                                                                     
            else if (txtFiyat.Text == "")
                MessageBox.Show("Ürün fiyatı boş bırakılamaz!");

            else if (txtAgirlik.Text == "")
                MessageBox.Show("Ürün ağırlığı boş bırakılamaz!");

            else if (numAdet.Value <= 0)
                MessageBox.Show("Ürün adedi boş bırakılamaz!");

            else
            {
                string isim = txtIsim.Text;
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
                double agirlik = Convert.ToDouble(txtAgirlik.Text);

                int kontrol = 0;

                foreach (Urun urun1 in liste.Urunler)      // Eklenmeye calisan urunle ayni isim ve ayni fiyatta
                {                                          // olan baska bir urunun olup olmadigi kontrol ediliyor.           
                    if (urun1.Isim.Equals(isim) && urun1.Fiyat.Equals(fiyat))
                    {
                        urun1.Adet += Convert.ToInt32(numAdet.Value);    // Eger varsa secilen adet kadar o urunun
                        kontrol = 1;                                     // stoguna ekleniyor ve kontrol 1'e esitleniyor.                         
                        break;
                    }
                }

                if (kontrol == 1)                          // Kontrol 1'e esitse urunun stogu arttigindan          
                {                                          // text dosyasi guncelleniyor ve dataGridView guncelleniyor 
                    dosyayiGuncelle();                     
                    urunleriCek();
                    MessageBox.Show("Ürün stoğu arttırıldı!");
                    panelUrunEkleGuncelle.Visible = false;
                    panelUrunler.Visible = true;
                }

                else                                       // Eklenmeye calisan urunle ayni isim ve ayni fiyatta
                {                                          // varolan urun yoksa urun sifirdan ekleniyor.
                    Urun urun = new Urun(isim, fiyat, agirlik, Convert.ToInt32(numAdet.Value));

                    liste.UrunEkle(urun);                  // Urun urunler listesine ekleniyor.
                    dosyayaUrunEkle(urun);                 // Urun text dosyasina ekleniyor.
                    tabloyaUrunEkle(urun);                 // Urun dataGridViewe ekleniyor.     

                    MessageBox.Show("Ürün başarıyla eklendi!");

                    panelUrunEkleGuncelle.Visible = false;
                    panelUrunler.Visible = true;
                }
            }
        }

        private void dosyayaUrunEkle(Urun urun)           // Parametre olarak gelen urun dosyanin sonuna ekleniyor.  
        {
            StreamWriter sw;

            sw = File.AppendText(@"D:\urunler.txt");

            sw.WriteLine(urun.Isim + "-" + urun.Fiyat + "-" + urun.Agirlik + "-" + urun.Adet);

            sw.Close();
        }

        private void dosyayiGuncelle()             // Varolan urunlerden herhangi biri uzerinde herhangi bir degisiklik
        {                                          // gerceklesirse urunler listesi dosyaya bastan yaziliyor.    
            StreamWriter sw = new StreamWriter(@"D:\urunler.txt");

            foreach (Urun urun in liste.Urunler)
            {
                sw.WriteLine(urun.Isim + "-" + urun.Fiyat + "-" + urun.Agirlik + "-" + urun.Adet);
            }

            sw.Close();
        }

        private void tabloyaUrunEkle(Urun urun)    // Parametre olarak gelen urun dataGridViewe ekleniyor.
        {
            dataListe.Rows.Add();

            dataListe.Rows[liste.Urunler.Count - 1].Cells[0].Value = urun.Isim;
            dataListe.Rows[liste.Urunler.Count - 1].Cells[1].Value = urun.Fiyat;
            dataListe.Rows[liste.Urunler.Count - 1].Cells[2].Value = urun.Agirlik;
            dataListe.Rows[liste.Urunler.Count - 1].Cells[3].Value = urun.Adet;
        }

        private void btnUrunSil_Click(object sender, EventArgs e)   // Urun silme paneli acilip digerleri kapaniyor. 
        {                                                              
            panelUrunEkleGuncelle.Visible = false;
            panelBtnGuncelle1.Visible = false;
            panelOnay.Visible = false;
            panelAdet2.Visible = false;
            panelBtnGuncelle2.Visible = false;
            panelUrunler.Visible = true;
            panelBtnSil.Visible = true;
            panelMusteriTakip.Visible = false;
        }

        private void btnSil_Click_1(object sender, EventArgs e)         
        {
            try
            {
                int selectedIndex = dataListe.CurrentCell.RowIndex;

                if (selectedIndex == dataListe.Rows.Count)
                {
                    MessageBox.Show("Listeden ürün seçiniz!");
                    return;
                }

                int stok = Convert.ToInt32(dataListe.Rows[selectedIndex].Cells[3].Value);
                string isim = dataListe.Rows[selectedIndex].Cells[0].Value.ToString();
                decimal fiyat = Convert.ToDecimal(dataListe.Rows[selectedIndex].Cells[1].Value);

                panelUrunler.Visible = false;
                panelBtnSil.Visible = false;

                if (stok > 1)                             // Eger secilip silinmek istenen urunun stogu 1'den fazlaysa
                {                                         // kac adet silmek istedigi soruluyor.
                    panelAdet2.Visible = true;

                    txtIsimFiyat.Text = isim + " - " + fiyat + "₺";
                    lblMevcutStok.Text = " Mevcut Stok:" + stok.ToString();

                    numAdet3.Minimum = 1;
                    numAdet3.Maximum = stok;
                }

                else                                     // Eger secilip silinmek istenen urunun stogu 1'den fazlaysa
                    panelOnay.Visible = true;            // sadece onay isteniyor.

                numAdet3.Value = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Listeden ürün seçiniz!");
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)    // Urunden kac adet silinmek istenildigi secildigi 
        {                                                          // zaman onay paneli aciliyor.          
            panelAdet2.Visible = false;

            panelOnay.Visible = true;
        }

        private void btnEvetSil_Click(object sender, EventArgs e)  // Evet onayi alinirsa...
        {
            try
            {
                int selectedIndex = dataListe.CurrentCell.RowIndex;

                int stok = Convert.ToInt32(dataListe.Rows[selectedIndex].Cells[3].Value);

                int adet = Convert.ToInt32(numAdet3.Value);

                Urun urun = liste.Urunler[selectedIndex];

                urun.Adet -= adet;                 // Secilen adet kadar urunun stogundan dusuluyor

                if (urun.Adet == 0)                // Eger urun stogu 0'a duserse urun listeden siliniyor,             
                {                                  // text dosyasi ve tablo guncelleniyor.         
                    liste.UrunSil(selectedIndex);
                    dosyayiGuncelle();
                    urunleriCek();
                    MessageBox.Show("Ürün silindi!");
                    panelUrunler.Visible = true;
                    panelOnay.Visible = false;
                    return;
                }

                else                               // Eger silindikten sonra urun stogu 0'dan buyukse
                {                                  // text dosyasi ve tablo guncelleniyor. 
                    dosyayiGuncelle();
                    urunleriCek();
                    MessageBox.Show("Ürün stoğu düzenlendi!");
                    panelUrunler.Visible = true;
                    panelOnay.Visible = false;
                    return;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Listeden ürün seçiniz!");
            }
        }

        private void btnHayir_Click(object sender, EventArgs e)   // Onay verilmezse urunler paneline geri donuluyor.
        {
            panelOnay.Visible = false;
            panelUrunler.Visible = true;
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)     // Urun guncelleme paneli acilip 
        {                                                                  // digerleri kapaniyor.   
            panelUrunEkleGuncelle.Visible = false;
            panelBtnSil.Visible = false;
            panelBtnGuncelle2.Visible = false;
            panelAdet2.Visible = false;
            panelUrunler.Visible = true;
            panelBtnGuncelle1.Visible = true;
            panelMusteriTakip.Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)     // Guncellenmek istenen urun secilip guncelle 
        {                                                              // butonuna basildigi zaman...
            try
            {
                int selectedIndex = dataListe.CurrentCell.RowIndex;

                panelUrunEkleGuncelleTemizle();
                label8.Text = "Ürünün Güncel Bilgileri";

                if (selectedIndex == liste.Urunler.Count)
                {
                    MessageBox.Show("Listeden ürün seçiniz!");
                    return;
                }

                Urun urun = liste.Urunler[selectedIndex];

                panelUrunler.Visible = false;
                panelBtnGuncelle1.Visible = false;
                panelUrunEkleGuncelle.Visible = true;
                panelBtnGuncelle2.Visible = true;

                txtIsim.Text = urun.Isim;                             // O urunun guncel bilgileri textBoxlara cekiliyor.              
                txtFiyat.Text = urun.Fiyat.ToString();
                txtAgirlik.Text = urun.Agirlik.ToString();
                numAdet.Value = urun.Adet;
            }
            catch (Exception)
            {
                MessageBox.Show("Listeden ürün seçiniz!");
            }
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)     // Urunun guncel bilgileri girilip 2. guncelle
        {                                                               // butonuna basildigi zaman...
            if (txtIsim.Text == "")
                MessageBox.Show("Ürün ismi boş bırakılamaz!");

            else if (txtFiyat.Text == "")
                MessageBox.Show("Ürün fiyatı boş bırakılamaz!");

            else if (txtAgirlik.Text == "")
                MessageBox.Show("Ürün ağırlığı boş bırakılamaz!");

            else if (numAdet.Value < 0)
                MessageBox.Show("Ürün adedi boş bırakılamaz!");

            else
            {
                if (numAdet.Value == 0)                 // Eger stogu 0 olarak duzenlenirse urun listesinden siliniyor,
                {                                       // text dosyasi guncelleniyor ve tablo guncelleniyor.    
                    liste.UrunSil(dataListe.CurrentCell.RowIndex);
                    dosyayiGuncelle();
                    urunleriCek();
                    MessageBox.Show("Ürün silindi!");
                    panelUrunEkleGuncelleTemizle();
                    panelUrunEkleGuncelle.Visible = false;
                    panelBtnGuncelle2.Visible = false;
                    panelUrunler.Visible = true;
                    return;
                }
                int selectedIndex = dataListe.CurrentCell.RowIndex;
                int index = 0;
                foreach (Urun urun1 in liste.Urunler)   // Eger secilen urunun ismi ve fiyati varolan bir urun ile ayni     
                {                                       // olarak duzenlenirse varolan urunun stoguna ekleniyor.                
                    if (urun1.Isim.Equals(txtIsim.Text.Trim()) && urun1.Fiyat == Convert.ToDecimal(txtFiyat.Text.Trim()))
                    {
                        int adet = Convert.ToInt32(numAdet.Value);

                        if (index == selectedIndex)
                        {
                            urun1.Adet = adet;
                        }

                        else
                        {
                            urun1.Adet += adet;
                            liste.UrunSil(selectedIndex);
                        }

                        MessageBox.Show("Ürün stoğu düzenlendi!");

                        dosyayiGuncelle();
                        urunleriCek();

                        panelUrunEkleGuncelle.Visible = false;
                        panelBtnGuncelle2.Visible = false;
                        panelUrunler.Visible = true;
                        return;
                    }

                    index++;
                }

                Urun urun = liste.Urunler[selectedIndex];    // Eger ayni olarak duzenlenmezse girilen bilgiler   
                                                             // o urunun yeni bilgileri olur.        
                urun.Isim = txtIsim.Text;
                urun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                urun.Agirlik = Convert.ToDouble(txtAgirlik.Text);
                urun.Adet = Convert.ToInt32(numAdet.Value);

                MessageBox.Show("Ürün bilgileri güncellendi!");

                dosyayiGuncelle();                      // Text dosyasi ve dataGridView guncellenir.
                urunleriCek();

                panelUrunEkleGuncelle.Visible = false;
                panelBtnGuncelle2.Visible = false;
                panelUrunler.Visible = true;
            }
        }

        private void btnMusteriTakip_Click(object sender, EventArgs e)    // Sadece musteri takip paneli acilir.
        {                                               
            panelMusteriTakip.Visible = true;

            panelUrunler.Visible = false;
            panelUrunEkleGuncelle.Visible = false;
            panelBtnSil.Visible = false;
            panelBtnGuncelle2.Visible = false;
            panelAdet2.Visible = false;
            panelBtnGuncelle1.Visible = false;
            

            dataMusteriTakip.Rows.Clear();                      

            List<String> musteriIsimleri = musteriIsimlerDon();      // musteri.txt dosyasindan musteri isimleri aliniyor.

            int urunSayisi = 0;
            foreach (String musteriIsmi in musteriIsimleri)
            {
                string musteriAdres = @"D:/" + musteriIsmi + ".txt";  

                if (!File.Exists(musteriAdres))             // Her bir musterinin ismiyle olusturulmus  
                    continue;                               // dosya varsa aciliyor ve musterinin yaptigi gecmis                          
                                                            // siparisler dataGridViewe ekleniyor.
                StreamReader read = new StreamReader(musteriAdres, Encoding.Default);
                string deger = read.ReadLine();
                string[] parcalar;
                

                while (deger != null)
                {
                    parcalar = deger.ToString().Split('-');

                    string urunIsmi = parcalar[0];
                    decimal tutar = Convert.ToDecimal(parcalar[1]);
                    int adet = Convert.ToInt32(parcalar[3]);
                    
                    dataMusteriTakip.Rows.Add();

                    dataMusteriTakip.Rows[urunSayisi].Cells[0].Value = musteriIsmi;
                    dataMusteriTakip.Rows[urunSayisi].Cells[1].Value = urunIsmi + " - " + adet.ToString() + " Adet";
                    dataMusteriTakip.Rows[urunSayisi].Cells[2].Value = (tutar * adet + tutar * adet * 0.18m).ToString() + "₺";

                    urunSayisi++;

                    deger = read.ReadLine();
                }

                read.Close();
            }
        }

        private List<String> musteriIsimlerDon()        // musteri.txt dosyasindaki musteri isimleri donuluyor.
        {
            List<String> musteriIsimleri = new List<String>();

            string musteriler = @"D:/musteri.txt";
            
            StreamReader read = new StreamReader(musteriler, Encoding.Default);
            string deger = read.ReadLine();
            string[] parcalar;

            while (deger != null)
            {
                parcalar = deger.ToString().Split('-');

                string isim = parcalar[0];

                musteriIsimleri.Add(isim);

                deger = read.ReadLine();
            }

            read.Close();

            return musteriIsimleri;
        }

        private void btnCikis_Click(object sender, EventArgs e)     // Cikisa basildigi zaman giris formu aciliyor.
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void panelUrunEkleGuncelleTemizle() 
        {
            label8.Text = "";
            txtIsim.Text = "";
            txtFiyat.Text = "";
            txtAgirlik.Text = "";
            numAdet.Value = 0;
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)      // Urun ekleme panelinde fiyat 
        {                                                                       // kismina harf girisi engelleniyor.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAgirlik_KeyPress(object sender, KeyPressEventArgs e)   // Urun ekleme panelinde agirlik      
        {                                                                      // kismina harf girisi engelleniyor.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}