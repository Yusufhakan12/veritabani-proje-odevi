namespace veritabani
{
    partial class PersonelGuncelle
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
            this.PersonelGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonelListele = new System.Windows.Forms.Button();
            this.PersonelKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelKaydet = new System.Windows.Forms.Button();
            this.PersonelDogumYeri = new System.Windows.Forms.ComboBox();
            this.PersonelDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.PersonelMedeni = new System.Windows.Forms.ComboBox();
            this.PersonelAnneAd = new System.Windows.Forms.TextBox();
            this.PersonelBabaAd = new System.Windows.Forms.TextBox();
            this.PersonelCinsiyet = new System.Windows.Forms.ComboBox();
            this.PersonelKimlik = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PersonelAdres = new System.Windows.Forms.TextBox();
            this.PersonelTelefon = new System.Windows.Forms.TextBox();
            this.PersonelMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonelSoyad = new System.Windows.Forms.TextBox();
            this.PersonelAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personelgunil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelGridView1
            // 
            this.PersonelGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonelGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PersonelGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelGridView1.Location = new System.Drawing.Point(33, 79);
            this.PersonelGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelGridView1.Name = "PersonelGridView1";
            this.PersonelGridView1.RowHeadersWidth = 51;
            this.PersonelGridView1.RowTemplate.Height = 25;
            this.PersonelGridView1.Size = new System.Drawing.Size(1370, 164);
            this.PersonelGridView1.TabIndex = 111;
            // 
            // PersonelListele
            // 
            this.PersonelListele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PersonelListele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelListele.Location = new System.Drawing.Point(648, 16);
            this.PersonelListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelListele.Name = "PersonelListele";
            this.PersonelListele.Size = new System.Drawing.Size(121, 55);
            this.PersonelListele.TabIndex = 110;
            this.PersonelListele.Text = "Listele";
            this.PersonelListele.UseVisualStyleBackColor = false;
            this.PersonelListele.Click += new System.EventHandler(this.PersonelListele_Click);
            // 
            // PersonelKod
            // 
            this.PersonelKod.Location = new System.Drawing.Point(161, 496);
            this.PersonelKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelKod.Name = "PersonelKod";
            this.PersonelKod.Size = new System.Drawing.Size(114, 27);
            this.PersonelKod.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 141;
            this.label1.Text = "Personel Kod:";
            // 
            // PersonelKaydet
            // 
            this.PersonelKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.PersonelKaydet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelKaydet.Location = new System.Drawing.Point(1227, 665);
            this.PersonelKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelKaydet.Name = "PersonelKaydet";
            this.PersonelKaydet.Size = new System.Drawing.Size(176, 88);
            this.PersonelKaydet.TabIndex = 140;
            this.PersonelKaydet.Text = "Kaydet";
            this.PersonelKaydet.UseVisualStyleBackColor = false;
            this.PersonelKaydet.Click += new System.EventHandler(this.PersonelKaydet_Click);
            // 
            // PersonelDogumYeri
            // 
            this.PersonelDogumYeri.FormattingEnabled = true;
            this.PersonelDogumYeri.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.PersonelDogumYeri.Location = new System.Drawing.Point(970, 739);
            this.PersonelDogumYeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelDogumYeri.Name = "PersonelDogumYeri";
            this.PersonelDogumYeri.Size = new System.Drawing.Size(138, 28);
            this.PersonelDogumYeri.TabIndex = 139;
            // 
            // PersonelDogumTarihi
            // 
            this.PersonelDogumTarihi.Location = new System.Drawing.Point(970, 691);
            this.PersonelDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelDogumTarihi.Name = "PersonelDogumTarihi";
            this.PersonelDogumTarihi.Size = new System.Drawing.Size(138, 27);
            this.PersonelDogumTarihi.TabIndex = 137;
            // 
            // PersonelMedeni
            // 
            this.PersonelMedeni.FormattingEnabled = true;
            this.PersonelMedeni.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.PersonelMedeni.Location = new System.Drawing.Point(970, 617);
            this.PersonelMedeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelMedeni.Name = "PersonelMedeni";
            this.PersonelMedeni.Size = new System.Drawing.Size(138, 28);
            this.PersonelMedeni.TabIndex = 136;
            // 
            // PersonelAnneAd
            // 
            this.PersonelAnneAd.Location = new System.Drawing.Point(970, 496);
            this.PersonelAnneAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelAnneAd.Name = "PersonelAnneAd";
            this.PersonelAnneAd.Size = new System.Drawing.Size(138, 27);
            this.PersonelAnneAd.TabIndex = 135;
            // 
            // PersonelBabaAd
            // 
            this.PersonelBabaAd.Location = new System.Drawing.Point(970, 563);
            this.PersonelBabaAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelBabaAd.Name = "PersonelBabaAd";
            this.PersonelBabaAd.Size = new System.Drawing.Size(138, 27);
            this.PersonelBabaAd.TabIndex = 134;
            // 
            // PersonelCinsiyet
            // 
            this.PersonelCinsiyet.DisplayMember = "Erkek";
            this.PersonelCinsiyet.FormattingEnabled = true;
            this.PersonelCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.PersonelCinsiyet.Location = new System.Drawing.Point(970, 435);
            this.PersonelCinsiyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelCinsiyet.Name = "PersonelCinsiyet";
            this.PersonelCinsiyet.Size = new System.Drawing.Size(138, 28);
            this.PersonelCinsiyet.TabIndex = 133;
            // 
            // PersonelKimlik
            // 
            this.PersonelKimlik.Location = new System.Drawing.Point(970, 371);
            this.PersonelKimlik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelKimlik.Name = "PersonelKimlik";
            this.PersonelKimlik.Size = new System.Drawing.Size(137, 27);
            this.PersonelKimlik.TabIndex = 132;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(849, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 25);
            this.label17.TabIndex = 130;
            this.label17.Text = "Kimlik No:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(857, 433);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 25);
            this.label16.TabIndex = 129;
            this.label16.Text = "Cinsiyet:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(849, 495);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 128;
            this.label15.Text = "Anne Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(849, 561);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 25);
            this.label14.TabIndex = 127;
            this.label14.Text = "Baba Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(817, 621);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 25);
            this.label13.TabIndex = 126;
            this.label13.Text = "Medeni Durum:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(822, 691);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 125;
            this.label12.Text = "Doğum Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(832, 743);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 124;
            this.label11.Text = "Doğum yeri:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(963, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 123;
            this.label9.Text = "Kişisel Bilgiler";
            // 
            // PersonelAdres
            // 
            this.PersonelAdres.Location = new System.Drawing.Point(525, 369);
            this.PersonelAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelAdres.Name = "PersonelAdres";
            this.PersonelAdres.Size = new System.Drawing.Size(138, 27);
            this.PersonelAdres.TabIndex = 122;
            // 
            // PersonelTelefon
            // 
            this.PersonelTelefon.Location = new System.Drawing.Point(525, 424);
            this.PersonelTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelTelefon.Name = "PersonelTelefon";
            this.PersonelTelefon.Size = new System.Drawing.Size(138, 27);
            this.PersonelTelefon.TabIndex = 121;
            // 
            // PersonelMail
            // 
            this.PersonelMail.Location = new System.Drawing.Point(525, 491);
            this.PersonelMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelMail.Name = "PersonelMail";
            this.PersonelMail.Size = new System.Drawing.Size(138, 27);
            this.PersonelMail.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(458, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 119;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(433, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 118;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(446, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 117;
            this.label5.Text = "Adres:";
            // 
            // PersonelSoyad
            // 
            this.PersonelSoyad.Location = new System.Drawing.Point(161, 424);
            this.PersonelSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelSoyad.Name = "PersonelSoyad";
            this.PersonelSoyad.Size = new System.Drawing.Size(114, 27);
            this.PersonelSoyad.TabIndex = 116;
            // 
            // PersonelAd
            // 
            this.PersonelAd.Location = new System.Drawing.Point(161, 364);
            this.PersonelAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelAd.Name = "PersonelAd";
            this.PersonelAd.Size = new System.Drawing.Size(114, 27);
            this.PersonelAd.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(495, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 114;
            this.label4.Text = "İletişim Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 112;
            this.label3.Text = "Ad:";
            // 
            // personelgunil
            // 
            this.personelgunil.FormattingEnabled = true;
            this.personelgunil.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.personelgunil.Location = new System.Drawing.Point(525, 537);
            this.personelgunil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personelgunil.Name = "personelgunil";
            this.personelgunil.Size = new System.Drawing.Size(138, 28);
            this.personelgunil.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(485, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 25);
            this.label10.TabIndex = 143;
            this.label10.Text = "İl:";
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 824);
            this.Controls.Add(this.personelgunil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PersonelKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonelKaydet);
            this.Controls.Add(this.PersonelDogumYeri);
            this.Controls.Add(this.PersonelDogumTarihi);
            this.Controls.Add(this.PersonelMedeni);
            this.Controls.Add(this.PersonelAnneAd);
            this.Controls.Add(this.PersonelBabaAd);
            this.Controls.Add(this.PersonelCinsiyet);
            this.Controls.Add(this.PersonelKimlik);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PersonelAdres);
            this.Controls.Add(this.PersonelTelefon);
            this.Controls.Add(this.PersonelMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PersonelSoyad);
            this.Controls.Add(this.PersonelAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonelGridView1);
            this.Controls.Add(this.PersonelListele);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonelGuncelle";
            this.Text = "PersonelGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.PersonelGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView PersonelGridView1;
        private Button PersonelListele;
        private TextBox PersonelKod;
        private Label label1;
        private Button PersonelKaydet;
        private ComboBox PersonelDogumYeri;
        private DateTimePicker PersonelDogumTarihi;
        private ComboBox PersonelMedeni;
        private TextBox PersonelAnneAd;
        private TextBox PersonelBabaAd;
        private ComboBox PersonelCinsiyet;
        private TextBox PersonelKimlik;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox PersonelAdres;
        private TextBox PersonelTelefon;
        private TextBox PersonelMail;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox PersonelSoyad;
        private TextBox PersonelAd;
        private Label label4;
        private Label label2;
        private Label label3;
        private ComboBox personelgunil;
        private Label label10;
    }
}