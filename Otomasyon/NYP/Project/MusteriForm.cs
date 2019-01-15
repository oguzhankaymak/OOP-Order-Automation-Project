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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }


        public static decimal sepet_toplam_fiyat=0;
        public static decimal sepetVergiliFiyat=0;
        public static int sepetToplamAgirlik = 0;


        private void MusteriView_Load(object sender, EventArgs e)
        {
            urunlerListesiYukle();
            gecmisAlisverisYukle();
            txtKullaniciAdim.Text = Giris.giris_isim;
            txtSifrem.Text = Giris.giris_sifre;
        }

        public void urunlerListesiYukle() //Urun listesini ilgili dosyadan çekerek datagride yazıyor
        {
            StreamReader oku = new StreamReader(@"D:\urunler.txt");
            string satir = oku.ReadLine();

            while (satir != null)
            {
                string[] urun = satir.ToString().Split('-');
                dataGridUrunler.Rows.Add(urun[0].ToString(), urun[1], urun[2], urun[3]);
                satir = oku.ReadLine();
            }
            oku.Close();
        }   
       
        private void btnSepeteGit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (dataGridUrunler.SelectedRows.Count > 0)
            {
                dataGridUrunler.Visible = false;
                adet_sec_Panel.Visible = true;
                panelBtnUrunList.Visible = false;
            }

            else
                MessageBox.Show("Ürün Seçilmedi!");
        }

        private void siparis_adet_onay_Click(object sender, EventArgs e)
        {
            
            int urun_adet = Convert.ToInt32(siparis_adet_numericUpDown.Value);
            sepete_urun_ekle(urun_adet);
            siparis_adet_numericUpDown.Size.Equals(0);
        }

        public void sepete_urun_ekle(int adet) // Siparis verilirken adet stoktan fazla değilse sepete eklemyi sağlıyor
                                              
        {
            if (adet <= Convert.ToInt32(dataGridUrunler.CurrentRow.Cells[3].Value))
            {
                bool kontrol = false;

                for(int i = 0; i<listViewSepetim.Items.Count; i++) //Eğer sepette aynı üründen varsa tekrar eklemek yerine adeti artıyor
                {       
                    if(dataGridUrunler.CurrentRow.Cells[0].Value.ToString() == listViewSepetim.Items[i].SubItems[0].Text)
                    {
                        listViewSepetim.Items[i].SubItems[3].Text = (adet + Convert.ToInt32(listViewSepetim.Items[0].SubItems[3].Text)).ToString();
                        kontrol = true;
                        break;
                    }
                }

                if (!kontrol) // Sepete ilgili ürün kısımları ekleniyor
                {
                    string urun_adi = dataGridUrunler.CurrentRow.Cells[0].Value.ToString();
                    string urun_fiyatı = dataGridUrunler.CurrentRow.Cells[1].Value.ToString();
                    string urun_agirligi = dataGridUrunler.CurrentRow.Cells[2].Value.ToString();
                    string urun_adedi = adet.ToString();

                    string[] siparis_listesi = { urun_adi, urun_fiyatı, urun_agirligi, urun_adedi };
                    ListViewItem lst = new ListViewItem(siparis_listesi);
                    listViewSepetim.Items.Add(lst);

                }
                //Ürün listesinde adet kadar stok azaltılması sağlanırken sepet fiyatı ekleniyor
                dataGridUrunler.CurrentRow.Cells[3].Value = (Convert.ToInt32(dataGridUrunler.CurrentRow.Cells[3].Value) - adet).ToString();
                sepet_toplam_fiyat += Convert.ToInt32(dataGridUrunler.CurrentRow.Cells[1].Value) * adet;
                lblFiyat.Text = sepet_toplam_fiyat.ToString();
                lblOdemeTutari.Text = lblFiyat.Text;

                MessageBox.Show("Belirttiğiniz Ürün Sepete Eklenmiştir !");
                dataGridUrunler.Visible = true;
                adet_sec_Panel.Visible = false;
                panelBtnUrunList.Visible = true;
            }

            else
                MessageBox.Show("Belirttiğiniz Adette Stok Bulunmuyor !");
            

        }
        //Burda Siparis nesnemizi oluşturup siparisOlustur() metodumuzu tanımlayıp özellikleri dolduruyoruz.
        //Siparis sınıfı ile aggregation ilişkisi olan SiparisDetay nesnesi yaratılıyor. VergiDurumu ve agirlikHesapla metodlarımızı bu metodda kullanıyoruz.
        Siparis s1 = new Siparis();
        public void siparisOlustur()
        {
            s1.SiparisDetay = new SiparisDetayi();
            s1.Tarih = DateTime.Now;
            s1.vergiHesapla(sepet_toplam_fiyat);
            sepetVergiliFiyat = s1.toplamFiyat(sepet_toplam_fiyat);
            if (sepetVergiliFiyat > Convert.ToDecimal(lblFiyat.Text)){
                s1.SiparisDetay.VergiDurumu = true;
            }

            for (int i = 0; i < listViewSepetim.Items.Count; i++)
            {
                double urunAgirlik = Convert.ToDouble(listViewSepetim.Items[i].SubItems[2].Text);
                int urunAdet = Convert.ToInt32(listViewSepetim.Items[i].SubItems[3].Text);
                sepetToplamAgirlik += Convert.ToInt32(s1.agirlikHesapla(urunAgirlik, urunAdet));
                //Sepet toplam ağırlığını Siparis sınıfının içindeki agirlikHesapla() metodu ile hesaplıyoruz. 
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e) //Sepette ürün var ise vergili fiyatı ekleyip odeme ekranina yoneltiyor
        {
            siparisOlustur();//Sipariş detaylarını ve sepetle ilgili detayları almak için yukarıda oluşturduğumuz metodumuzu çağırıyoruz.
            lblOdemeTutari.Text = sepetVergiliFiyat.ToString();
            if (listViewSepetim.Items.Count > 0)
            {
                panelSepettekiBtn.Visible = false;
                panelSepettkiLabel.Visible = false;
                panelOdeme.Visible = true;
                listViewSepetim.Visible = false;
                
            }
            else
                MessageBox.Show("Sepetinizde Ürün Bulunmuyor");
            
        }

        private void btnTemizle_Click(object sender, EventArgs e) // Sepetteki ürün secildiyse ilgili ürünü siliyor 
        {
            if(listViewSepetim.SelectedItems.Count > 0)  
            {
                for(int i=0; i < dataGridUrunler.RowCount -1 ; i++) // Ürün, ürünler listesinde bulunup yeni adet ekleniyor
                {
                    if(listViewSepetim.SelectedItems[0].SubItems[0].Text == dataGridUrunler.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridUrunler.Rows[i].Cells[3].Value = (Convert.ToInt32(dataGridUrunler.Rows[i].Cells[3].Value) + Convert.ToInt32(listViewSepetim.Items[0].SubItems[3].Text)).ToString();
                        
                    }
                }
                //Ürün siliminden dolayı sepet fiyatı düşürülüyor
                sepet_toplam_fiyat  -= Convert.ToInt32(listViewSepetim.SelectedItems[0].SubItems[1].Text) * Convert.ToInt32(listViewSepetim.SelectedItems[0].SubItems[3].Text);
                lblFiyat.Text = sepet_toplam_fiyat.ToString();
                listViewSepetim.Items.RemoveAt(listViewSepetim.FocusedItem.Index);
                dataGridUrunler.Refresh();
                MessageBox.Show("Ürün Silindi!");
            }
            else
                MessageBox.Show("Lütfen Ürün Seçiniz !");
            
        }

        public void alisverisYaz() // Sepetteki urunleri gezerek ilgili kısımları alıp siparis detayı için alıyor.
        {
            string siparisDetay = "";
            StreamWriter yaz = File.AppendText(@"D:\" + Giris.giris_isim + ".txt");

            for (int i = 0; i < listViewSepetim.Items.Count; i++)
            {
                string yazilacakUrun = listViewSepetim.Items[i].SubItems[0].Text.ToString() + "-" + listViewSepetim.Items[i].SubItems[1].Text.ToString() + "-" + listViewSepetim.Items[i].SubItems[2].Text.ToString() + "-" + listViewSepetim.Items[i].SubItems[3].Text.ToString();
                siparisDetay += "Ürün : " + listViewSepetim.Items[i].SubItems[0].Text.ToString() + "  Fiyat : " + listViewSepetim.Items[i].SubItems[1].Text.ToString() + "TL   Adet : " + listViewSepetim.Items[i].SubItems[3].Text.ToString() + Environment.NewLine;
                yaz.WriteLine(yazilacakUrun);
            }
            txtGecmisAlisverisim.Text = siparisDetay.ToString()
            + "Sepet Toplam Ağırlık: " + sepetToplamAgirlik.ToString() + Environment.NewLine
            + "Sepet Toplam Fiyat(KDV DAHİL): " + sepetVergiliFiyat.ToString();
            yaz.Close();
        }

        public void gecmisAlisverisYukle() // Giriş yapan kullanıcının ilgili dosyasına gidip sipariş verilerini çekiyor.
        {
            listViewGecmisAlisverilerim.Items.Clear();
            StreamReader streamReader = new StreamReader(@"D:\" + Giris.giris_isim + ".txt", Encoding.Default);
            string urunSatiri = streamReader.ReadLine();

            while (urunSatiri != null)
            {

                string[] urun = urunSatiri.Split('-');
                ListViewItem lstItem = new ListViewItem(urun);
                listViewGecmisAlisverilerim.Items.Add(lstItem);
                urunSatiri = streamReader.ReadLine();

            }

            streamReader.Close();
            listViewGecmisAlisverilerim.Refresh();
        }

        public void guncelUrunListesiYaz() // Ödeme tamamlandığında ürün listesinde azalan stokları tekrar yazıyoruz
        {
           StreamWriter sw = new StreamWriter(@"D:\urunler.txt");
            
            for(int i = 0; i<dataGridUrunler.Rows.Count -1; i++)
            {
                string urun = dataGridUrunler.Rows[i].Cells[0].Value.ToString() + "-" + dataGridUrunler.Rows[i].Cells[1].Value.ToString() + "-" + dataGridUrunler.Rows[i].Cells[2].Value.ToString() + "-" + dataGridUrunler.Rows[i].Cells[3].Value.ToString();
                sw.WriteLine(urun);
            }
            sw.Close();

        }

        private void btnSepetTemizle_Click(object sender, EventArgs e) // Sepetteki tum urunleri silmeye yariyor
        {
            if (listViewSepetim.Items.Count > 0)
            {
                for(int i =0; i<listViewSepetim.Items.Count; i++)
                {
                    for(int j = 0; j<dataGridUrunler.Rows.Count -1; j++) // İlgili urunleri urun listesinde bulup stok artırıyor
                    {
                        if (listViewSepetim.Items[i].SubItems[0].Text.ToString() == dataGridUrunler.Rows[j].Cells[0].Value.ToString())
                        {
                            dataGridUrunler.Rows[j].Cells[3].Value = (Convert.ToInt32(dataGridUrunler.Rows[j].Cells[3].Value) + Convert.ToInt32(listViewSepetim.Items[i].SubItems[3].Text)).ToString();
                            break;
                        }
                    }
                }

                sepet_toplam_fiyat = 0;
                lblFiyat.Text = sepet_toplam_fiyat.ToString();
                listViewSepetim.Items.Clear();
                MessageBox.Show("Sepet Başarıyla Temizlendi");

            }
            else
                MessageBox.Show("Sepetinizde Ürün Bulunmuyor !");
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnCikisIptal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnCikisOnayla_Click(object sender, EventArgs e)
        {
            Giris g1 = new Giris();
            g1.Show();
            this.Close();
        }

        //Kullanıcı görüşlerini Hesabım sayfasındaki textboxtan alıp kullanıcı ismi ile beraber gorusler.txt adlı dosyaya kaydediyoruz.
        private void btnGorusGonder_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(@"D:\gorusler.txt");
            sw.WriteLine(Giris.giris_isim + ":" + txtGorus.Text + "\n");
            sw.Close();

            MessageBox.Show("Katkı Sağladığınız için Teşekkür Ederiz.");
            txtGorus.Text = "";
        }

        private void btnOnayla_Click(object sender, EventArgs e) // Odeme isleminin onaylanması islemi seçilen odeme tipine gore ilgili classta
        {                                                       // Kosullar saglaniyorsa odeme islemi gerceklesiyor ve ilgili fonksiyonlar cagriliyor.
            if (txtAd.Text == "" || txtAdres.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("Bilgiler Eksik! Ödeme Onaylanmadı.");
            }
            else
            //Seçilen Ödeme tipine göre ilgili sınıftan nesne yaratılıp gerekli doğrulamalar sağlanıyor.
            {
                if (rdBtnNakit.Checked)
                {
                    Nakit n1 = new Nakit();
                    n1.Fiyat=Convert.ToDecimal(lblOdemeTutari.Text);
                    n1.VerilenNakit = Convert.ToDecimal(txtGirNakit.Text);
                    if (n1.Dogrulama())
                    {

                        s1.Durum = true;
                        alisverisYaz();
                        guncelUrunListesiYaz();
                        gecmisAlisverisYukle();
                        listViewSepetim.Items.Clear();
                        txtAdresim.Text = txtAdres.Text;
                        textTemizle();
                        lblFiyat.Text = "0";
                        sepet_toplam_fiyat = 0;
                        sepetVergiliFiyat = 0;


                        panelSepettekiBtn.Visible = true;
                        panelSepettkiLabel.Visible = true;
                        panelOdeme.Visible = false;
                        listViewSepetim.Visible = true;
                        tabControl1.SelectedIndex = 3;
                    }
                }
                if (rdBtnKredi.Checked)
                {
                    KrediKarti k1 = new KrediKarti();
                    k1.Fiyat = Convert.ToDecimal(lblOdemeTutari.Text);
                    k1.Numara = txtKartNo.Text;
                    k1.Cvv = Convert.ToInt32(txtCvv.Text);
                    k1.SonAy = Convert.ToInt32(numAy.Value);
                    k1.SonYıl = Convert.ToInt32(numYil.Value);
                    if (k1.Dogrulama())
                    {
                        s1.Durum = true;
                        alisverisYaz();
                        guncelUrunListesiYaz();
                        gecmisAlisverisYukle();
                        listViewSepetim.Items.Clear();
                        txtAdresim.Text = txtAdres.Text;
                        textTemizle();
                        lblFiyat.Text = "0";
                        sepet_toplam_fiyat = 0;
                        sepetVergiliFiyat = 0;

                        panelSepettekiBtn.Visible = true;
                        panelSepettkiLabel.Visible = true;
                        panelOdeme.Visible = false;
                        listViewSepetim.Visible = true;
                        tabControl1.SelectedIndex = 3;

                    }
                }
                if (rdBtnCek.Checked)
                {
                    Cek c1 = new Cek();
                    c1.Fiyat = Convert.ToDecimal(lblOdemeTutari.Text);
                    c1.BankID = txtBankID.Text;
                    c1.Isim = txtIsim.Text;
                    if (c1.Dogrulama())
                    {
                        s1.Durum = true;
                        alisverisYaz();
                        guncelUrunListesiYaz();
                        gecmisAlisverisYukle();
                        listViewSepetim.Items.Clear();
                        txtAdresim.Text = txtAdres.Text;
                        textTemizle();
                        lblFiyat.Text = "0";
                        sepet_toplam_fiyat = 0;
                        sepetVergiliFiyat = 0;

                        panelSepettekiBtn.Visible = true;
                        panelSepettkiLabel.Visible = true;
                        panelOdeme.Visible = false;
                        listViewSepetim.Visible = true;
                        tabControl1.SelectedIndex = 3;
                    }
                }
            }
        }

        public void textTemizle()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtSoyad.Text = "";
            txtKartNo.Text = "";
            txtBankID.Text = "";
            txtCvv.Text = "";
            txtGirNakit.Text = "";
        }

        private void rdBtnNakit_CheckedChanged(object sender, EventArgs e)
        {
            panelNakit.Visible = true;
            panelKrediKarti.Visible = false;
            panelCek.Visible = false;
        }

        private void rdBtnKredi_CheckedChanged(object sender, EventArgs e)
        {
            panelKrediKarti.Visible = true;
            panelCek.Visible = false;
            panelNakit.Visible = false;
        }

        private void rdBtnCek_CheckedChanged(object sender, EventArgs e)
        {
            panelCek.Visible = true;
            panelKrediKarti.Visible = false;
            panelNakit.Visible = false;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar);
        }

        private void txtGirNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsSymbol(e.KeyChar);

        }

        private void txtIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar);
        }

        private void txtCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void geri_git_btn_Click(object sender, EventArgs e)
        {
            dataGridUrunler.Visible = true;
            adet_sec_Panel.Visible = false;
            panelBtnUrunList.Visible = true;
        }

        private void btnSepeteGitOdemeEkran_Click(object sender, EventArgs e)
        {
            panelSepettekiBtn.Visible = true;
            panelSepettkiLabel.Visible = true;
            panelOdeme.Visible = false;
            listViewSepetim.Visible = true;
            textTemizle();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            panelOdeme.Visible = false;
            listViewSepetim.Visible = true;
            panelSepettekiBtn.Visible = true;
            panelSepettkiLabel.Visible = true;
        }
    }
}
