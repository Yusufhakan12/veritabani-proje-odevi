namespace veritabani
{
    partial class RandevuOlustur
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HastaKoduRndv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaBilgileri = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DoktorKodRndv = new System.Windows.Forms.TextBox();
            this.Doktorbilgileri = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TarihRndv = new System.Windows.Forms.DateTimePicker();
            this.RandevuListele = new System.Windows.Forms.Button();
            this.Polikinlikler = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.polikinlikkodrndv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HastaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doktorbilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Polikinlikler)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1024, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poliklinikler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih";
            // 
            // HastaKoduRndv
            // 
            this.HastaKoduRndv.Location = new System.Drawing.Point(197, 550);
            this.HastaKoduRndv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HastaKoduRndv.Name = "HastaKoduRndv";
            this.HastaKoduRndv.Size = new System.Drawing.Size(138, 27);
            this.HastaKoduRndv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta Kodu";
            // 
            // HastaBilgileri
            // 
            this.HastaBilgileri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HastaBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaBilgileri.Location = new System.Drawing.Point(461, 70);
            this.HastaBilgileri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HastaBilgileri.Name = "HastaBilgileri";
            this.HastaBilgileri.RowHeadersWidth = 51;
            this.HastaBilgileri.RowTemplate.Height = 25;
            this.HastaBilgileri.Size = new System.Drawing.Size(364, 450);
            this.HastaBilgileri.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor Kod";
            // 
            // DoktorKodRndv
            // 
            this.DoktorKodRndv.Location = new System.Drawing.Point(197, 664);
            this.DoktorKodRndv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorKodRndv.Name = "DoktorKodRndv";
            this.DoktorKodRndv.Size = new System.Drawing.Size(138, 27);
            this.DoktorKodRndv.TabIndex = 5;
            // 
            // Doktorbilgileri
            // 
            this.Doktorbilgileri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doktorbilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doktorbilgileri.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.Doktorbilgileri.Location = new System.Drawing.Point(12, 70);
            this.Doktorbilgileri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Doktorbilgileri.Name = "Doktorbilgileri";
            this.Doktorbilgileri.RowHeadersWidth = 51;
            this.Doktorbilgileri.RowTemplate.Height = 25;
            this.Doktorbilgileri.Size = new System.Drawing.Size(379, 450);
            this.Doktorbilgileri.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(579, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hasta Bilgiler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(128, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doktor Bilgileri";
            // 
            // TarihRndv
            // 
            this.TarihRndv.Location = new System.Drawing.Point(197, 604);
            this.TarihRndv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TarihRndv.Name = "TarihRndv";
            this.TarihRndv.Size = new System.Drawing.Size(167, 27);
            this.TarihRndv.TabIndex = 15;
            // 
            // RandevuListele
            // 
            this.RandevuListele.BackColor = System.Drawing.SystemColors.Highlight;
            this.RandevuListele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandevuListele.ForeColor = System.Drawing.SystemColors.Window;
            this.RandevuListele.Location = new System.Drawing.Point(434, 668);
            this.RandevuListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RandevuListele.Name = "RandevuListele";
            this.RandevuListele.Size = new System.Drawing.Size(160, 79);
            this.RandevuListele.TabIndex = 16;
            this.RandevuListele.Text = "Kaydet";
            this.RandevuListele.UseVisualStyleBackColor = false;
            this.RandevuListele.Click += new System.EventHandler(this.RandevuListele_Click);
            // 
            // Polikinlikler
            // 
            this.Polikinlikler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Polikinlikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Polikinlikler.Location = new System.Drawing.Point(924, 70);
            this.Polikinlikler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Polikinlikler.Name = "Polikinlikler";
            this.Polikinlikler.RowHeadersWidth = 51;
            this.Polikinlikler.RowTemplate.Height = 25;
            this.Polikinlikler.Size = new System.Drawing.Size(302, 450);
            this.Polikinlikler.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 722);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Poliklinikkod";
            // 
            // polikinlikkodrndv
            // 
            this.polikinlikkodrndv.Location = new System.Drawing.Point(197, 720);
            this.polikinlikkodrndv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.polikinlikkodrndv.Name = "polikinlikkodrndv";
            this.polikinlikkodrndv.Size = new System.Drawing.Size(138, 27);
            this.polikinlikkodrndv.TabIndex = 19;
            // 
            // RandevuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1257, 776);
            this.Controls.Add(this.polikinlikkodrndv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Polikinlikler);
            this.Controls.Add(this.RandevuListele);
            this.Controls.Add(this.TarihRndv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Doktorbilgileri);
            this.Controls.Add(this.HastaBilgileri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastaKoduRndv);
            this.Controls.Add(this.DoktorKodRndv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RandevuOlustur";
            this.Text = "RandevuOlustur";
            ((System.ComponentModel.ISupportInitialize)(this.HastaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doktorbilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Polikinlikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox HastaKoduRndv;
        private Label label1;
        private DataGridView HastaBilgileri;
        private Label label2;
        private TextBox DoktorKodRndv;
        private DataGridView Doktorbilgileri;
        private Label label5;
        private Label label6;
        private DateTimePicker TarihRndv;
        private Button RandevuListele;
        private DataGridView Polikinlikler;
        private Label label7;
        private TextBox polikinlikkodrndv;
    }
}