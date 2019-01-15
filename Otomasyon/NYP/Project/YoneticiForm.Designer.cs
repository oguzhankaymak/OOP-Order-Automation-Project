namespace Project
{
    partial class YoneticiForm
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
            this.panelOnay = new System.Windows.Forms.Panel();
            this.btnHayirSilme = new System.Windows.Forms.Button();
            this.btnEvetSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.panelBtnGuncelle1 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panelBtnSil = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.panelUrunler = new System.Windows.Forms.Panel();
            this.dataListe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdet = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numAdet2 = new System.Windows.Forms.NumericUpDown();
            this.panelBtnGuncelle2 = new System.Windows.Forms.Panel();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.panelUrunEkleGuncelle = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.panelAdet2 = new System.Windows.Forms.Panel();
            this.txtIsimFiyat = new System.Windows.Forms.TextBox();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.numAdet3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dataMusteriTakip = new System.Windows.Forms.DataGridView();
            this.panelMusteriTakip = new System.Windows.Forms.Panel();
            this.btnMusteriTakip = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOnay.SuspendLayout();
            this.panelBtnGuncelle1.SuspendLayout();
            this.panelBtnSil.SuspendLayout();
            this.panelUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListe)).BeginInit();
            this.panelAdet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet2)).BeginInit();
            this.panelBtnGuncelle2.SuspendLayout();
            this.panelUrunEkleGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.panelAdet2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusteriTakip)).BeginInit();
            this.panelMusteriTakip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOnay
            // 
            this.panelOnay.Controls.Add(this.btnHayirSilme);
            this.panelOnay.Controls.Add(this.btnEvetSil);
            this.panelOnay.Controls.Add(this.label5);
            this.panelOnay.Location = new System.Drawing.Point(-1, 237);
            this.panelOnay.Name = "panelOnay";
            this.panelOnay.Size = new System.Drawing.Size(767, 126);
            this.panelOnay.TabIndex = 11;
            // 
            // btnHayirSilme
            // 
            this.btnHayirSilme.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHayirSilme.Location = new System.Drawing.Point(346, 62);
            this.btnHayirSilme.Name = "btnHayirSilme";
            this.btnHayirSilme.Size = new System.Drawing.Size(88, 33);
            this.btnHayirSilme.TabIndex = 1;
            this.btnHayirSilme.Text = "Hayır";
            this.btnHayirSilme.UseVisualStyleBackColor = true;
            this.btnHayirSilme.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // btnEvetSil
            // 
            this.btnEvetSil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvetSil.Location = new System.Drawing.Point(238, 62);
            this.btnEvetSil.Name = "btnEvetSil";
            this.btnEvetSil.Size = new System.Drawing.Size(86, 33);
            this.btnEvetSil.TabIndex = 1;
            this.btnEvetSil.Text = "Evet";
            this.btnEvetSil.UseVisualStyleBackColor = true;
            this.btnEvetSil.Click += new System.EventHandler(this.btnEvetSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(206, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürünü silmek istediğinizden emin misiniz?";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(259, -1);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(110, 36);
            this.btnUrunGuncelle.TabIndex = 16;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(174, -1);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(88, 36);
            this.btnUrunSil.TabIndex = 15;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(92, -1);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(88, 36);
            this.btnUrunEkle.TabIndex = 14;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(-1, -1);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(96, 36);
            this.btnUrunler.TabIndex = 12;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // panelBtnGuncelle1
            // 
            this.panelBtnGuncelle1.Controls.Add(this.btnGuncelle);
            this.panelBtnGuncelle1.Location = new System.Drawing.Point(12, 562);
            this.panelBtnGuncelle1.Name = "panelBtnGuncelle1";
            this.panelBtnGuncelle1.Size = new System.Drawing.Size(632, 39);
            this.panelBtnGuncelle1.TabIndex = 19;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(23, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(593, 32);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Seçilini Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // panelBtnSil
            // 
            this.panelBtnSil.Controls.Add(this.btnSil);
            this.panelBtnSil.Location = new System.Drawing.Point(15, 557);
            this.panelBtnSil.Name = "panelBtnSil";
            this.panelBtnSil.Size = new System.Drawing.Size(632, 40);
            this.panelBtnSil.TabIndex = 18;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(20, 8);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(593, 32);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Seçili Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // panelUrunler
            // 
            this.panelUrunler.Controls.Add(this.dataListe);
            this.panelUrunler.Controls.Add(this.panelAdet);
            this.panelUrunler.Location = new System.Drawing.Point(35, 45);
            this.panelUrunler.Name = "panelUrunler";
            this.panelUrunler.Size = new System.Drawing.Size(623, 511);
            this.panelUrunler.TabIndex = 17;
            // 
            // dataListe
            // 
            this.dataListe.AllowUserToAddRows = false;
            this.dataListe.AllowUserToDeleteRows = false;
            this.dataListe.AllowUserToResizeColumns = false;
            this.dataListe.AllowUserToResizeRows = false;
            this.dataListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataListe.Location = new System.Drawing.Point(0, 9);
            this.dataListe.MultiSelect = false;
            this.dataListe.Name = "dataListe";
            this.dataListe.ReadOnly = true;
            this.dataListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListe.Size = new System.Drawing.Size(593, 505);
            this.dataListe.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Ürün İsmi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Ürün Fiyatı (₺)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Ürün Ağırlığı (g)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ürün Adedi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panelAdet
            // 
            this.panelAdet.Controls.Add(this.label6);
            this.panelAdet.Controls.Add(this.numAdet2);
            this.panelAdet.Location = new System.Drawing.Point(-33, 192);
            this.panelAdet.Name = "panelAdet";
            this.panelAdet.Size = new System.Drawing.Size(761, 126);
            this.panelAdet.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(228, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kaç adet silmek istiyorsunuz?";
            // 
            // numAdet2
            // 
            this.numAdet2.Location = new System.Drawing.Point(267, 75);
            this.numAdet2.Name = "numAdet2";
            this.numAdet2.Size = new System.Drawing.Size(120, 20);
            this.numAdet2.TabIndex = 0;
            // 
            // panelBtnGuncelle2
            // 
            this.panelBtnGuncelle2.Controls.Add(this.btnGuncelle2);
            this.panelBtnGuncelle2.Location = new System.Drawing.Point(2, 382);
            this.panelBtnGuncelle2.Name = "panelBtnGuncelle2";
            this.panelBtnGuncelle2.Size = new System.Drawing.Size(816, 120);
            this.panelBtnGuncelle2.TabIndex = 21;
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle2.Location = new System.Drawing.Point(227, 5);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(213, 37);
            this.btnGuncelle2.TabIndex = 0;
            this.btnGuncelle2.Text = "Ürünü Güncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // panelUrunEkleGuncelle
            // 
            this.panelUrunEkleGuncelle.Controls.Add(this.label8);
            this.panelUrunEkleGuncelle.Controls.Add(this.label4);
            this.panelUrunEkleGuncelle.Controls.Add(this.numAdet);
            this.panelUrunEkleGuncelle.Controls.Add(this.btnEkle);
            this.panelUrunEkleGuncelle.Controls.Add(this.label3);
            this.panelUrunEkleGuncelle.Controls.Add(this.label2);
            this.panelUrunEkleGuncelle.Controls.Add(this.label1);
            this.panelUrunEkleGuncelle.Controls.Add(this.txtAgirlik);
            this.panelUrunEkleGuncelle.Controls.Add(this.txtFiyat);
            this.panelUrunEkleGuncelle.Controls.Add(this.txtIsim);
            this.panelUrunEkleGuncelle.Location = new System.Drawing.Point(12, 75);
            this.panelUrunEkleGuncelle.Name = "panelUrunEkleGuncelle";
            this.panelUrunEkleGuncelle.Size = new System.Drawing.Size(714, 417);
            this.panelUrunEkleGuncelle.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11F);
            this.label8.Location = new System.Drawing.Point(231, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(214, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün adedi";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(330, 242);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(100, 20);
            this.numAdet.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(217, 312);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(213, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ürünü Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(214, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Ağırlığı (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(214, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Fiyatı (₺)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(214, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün İsmi";
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(330, 188);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(100, 20);
            this.txtAgirlik.TabIndex = 3;
            this.txtAgirlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgirlik_KeyPress);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(330, 137);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 2;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(330, 88);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // panelAdet2
            // 
            this.panelAdet2.Controls.Add(this.txtIsimFiyat);
            this.panelAdet2.Controls.Add(this.lblMevcutStok);
            this.panelAdet2.Controls.Add(this.btnTamam);
            this.panelAdet2.Controls.Add(this.numAdet3);
            this.panelAdet2.Controls.Add(this.label7);
            this.panelAdet2.Location = new System.Drawing.Point(-1, 78);
            this.panelAdet2.Name = "panelAdet2";
            this.panelAdet2.Size = new System.Drawing.Size(776, 298);
            this.panelAdet2.TabIndex = 20;
            // 
            // txtIsimFiyat
            // 
            this.txtIsimFiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsimFiyat.Location = new System.Drawing.Point(249, 95);
            this.txtIsimFiyat.Name = "txtIsimFiyat";
            this.txtIsimFiyat.ReadOnly = true;
            this.txtIsimFiyat.Size = new System.Drawing.Size(141, 22);
            this.txtIsimFiyat.TabIndex = 4;
            this.txtIsimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMevcutStok.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutStok.Location = new System.Drawing.Point(257, 133);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(0, 18);
            this.lblMevcutStok.TabIndex = 3;
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(260, 246);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(120, 26);
            this.btnTamam.TabIndex = 2;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // numAdet3
            // 
            this.numAdet3.Location = new System.Drawing.Point(260, 209);
            this.numAdet3.Name = "numAdet3";
            this.numAdet3.Size = new System.Drawing.Size(120, 20);
            this.numAdet3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(231, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kaç adet silmek istiyorsunuz?";
            // 
            // dataMusteriTakip
            // 
            this.dataMusteriTakip.AllowUserToAddRows = false;
            this.dataMusteriTakip.AllowUserToDeleteRows = false;
            this.dataMusteriTakip.AllowUserToOrderColumns = true;
            this.dataMusteriTakip.AllowUserToResizeColumns = false;
            this.dataMusteriTakip.AllowUserToResizeRows = false;
            this.dataMusteriTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusteriTakip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataMusteriTakip.Location = new System.Drawing.Point(0, 16);
            this.dataMusteriTakip.Name = "dataMusteriTakip";
            this.dataMusteriTakip.ReadOnly = true;
            this.dataMusteriTakip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMusteriTakip.Size = new System.Drawing.Size(593, 502);
            this.dataMusteriTakip.TabIndex = 22;
            // 
            // panelMusteriTakip
            // 
            this.panelMusteriTakip.Controls.Add(this.dataMusteriTakip);
            this.panelMusteriTakip.Location = new System.Drawing.Point(35, 38);
            this.panelMusteriTakip.Name = "panelMusteriTakip";
            this.panelMusteriTakip.Size = new System.Drawing.Size(857, 563);
            this.panelMusteriTakip.TabIndex = 23;
            // 
            // btnMusteriTakip
            // 
            this.btnMusteriTakip.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnMusteriTakip.Location = new System.Drawing.Point(366, -1);
            this.btnMusteriTakip.Name = "btnMusteriTakip";
            this.btnMusteriTakip.Size = new System.Drawing.Size(110, 36);
            this.btnMusteriTakip.TabIndex = 22;
            this.btnMusteriTakip.Text = "Müşteri Takip";
            this.btnMusteriTakip.UseVisualStyleBackColor = true;
            this.btnMusteriTakip.Click += new System.EventHandler(this.btnMusteriTakip_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(468, -1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(109, 36);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kullanıcı Adı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ürün İsim - Adet";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 175;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Alışveriş Tutarı ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 225;
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 611);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.panelBtnGuncelle1);
            this.Controls.Add(this.panelMusteriTakip);
            this.Controls.Add(this.btnMusteriTakip);
            this.Controls.Add(this.panelBtnGuncelle2);
            this.Controls.Add(this.panelAdet2);
            this.Controls.Add(this.panelUrunler);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.panelUrunEkleGuncelle);
            this.Controls.Add(this.panelOnay);
            this.Controls.Add(this.panelBtnSil);
            this.Name = "YoneticiForm";
            this.Text = "YoneticiForm";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.panelOnay.ResumeLayout(false);
            this.panelOnay.PerformLayout();
            this.panelBtnGuncelle1.ResumeLayout(false);
            this.panelBtnSil.ResumeLayout(false);
            this.panelUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListe)).EndInit();
            this.panelAdet.ResumeLayout(false);
            this.panelAdet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet2)).EndInit();
            this.panelBtnGuncelle2.ResumeLayout(false);
            this.panelUrunEkleGuncelle.ResumeLayout(false);
            this.panelUrunEkleGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.panelAdet2.ResumeLayout(false);
            this.panelAdet2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusteriTakip)).EndInit();
            this.panelMusteriTakip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOnay;
        private System.Windows.Forms.Button btnHayirSilme;
        private System.Windows.Forms.Button btnEvetSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Panel panelBtnGuncelle1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panelBtnSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panelUrunler;
        private System.Windows.Forms.DataGridView dataListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panelAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAdet2;
        private System.Windows.Forms.Panel panelBtnGuncelle2;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.Panel panelUrunEkleGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Panel panelAdet2;
        private System.Windows.Forms.TextBox txtIsimFiyat;
        private System.Windows.Forms.Label lblMevcutStok;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.NumericUpDown numAdet3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMusteriTakip;
        private System.Windows.Forms.DataGridView dataMusteriTakip;
        private System.Windows.Forms.Button btnMusteriTakip;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}