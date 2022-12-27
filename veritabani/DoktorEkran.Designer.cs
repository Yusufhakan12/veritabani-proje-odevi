namespace veritabani
{
    partial class DoktorEkran
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
            this.ReceteNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceteTarih = new System.Windows.Forms.DateTimePicker();
            this.Kullanim = new System.Windows.Forms.TextBox();
            this.ilacAdet = new System.Windows.Forms.TextBox();
            this.ilackod = new System.Windows.Forms.TextBox();
            this.ilacdata = new System.Windows.Forms.DataGridView();
            this.yazdır = new System.Windows.Forms.Button();
            this.ilaclar = new System.Windows.Forms.Button();
            this.tahlilkod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tahlildata = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.hastakod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.randevulistesi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ilacdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahlildata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevulistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(314, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReceteNo
            // 
            this.ReceteNo.Location = new System.Drawing.Point(460, 185);
            this.ReceteNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReceteNo.Name = "ReceteNo";
            this.ReceteNo.Size = new System.Drawing.Size(114, 27);
            this.ReceteNo.TabIndex = 1;
            this.ReceteNo.TextChanged += new System.EventHandler(this.ReceteNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(361, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(326, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanım:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(327, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "İlaç Adet:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(328, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "İlaç Kod:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ReceteTarih
            // 
            this.ReceteTarih.Location = new System.Drawing.Point(460, 427);
            this.ReceteTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReceteTarih.Name = "ReceteTarih";
            this.ReceteTarih.Size = new System.Drawing.Size(142, 27);
            this.ReceteTarih.TabIndex = 6;
            this.ReceteTarih.ValueChanged += new System.EventHandler(this.DoktorTarih_ValueChanged);
            // 
            // Kullanim
            // 
            this.Kullanim.Location = new System.Drawing.Point(460, 359);
            this.Kullanim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Kullanim.Name = "Kullanim";
            this.Kullanim.Size = new System.Drawing.Size(114, 27);
            this.Kullanim.TabIndex = 7;
            this.Kullanim.TextChanged += new System.EventHandler(this.Kullanim_TextChanged);
            // 
            // ilacAdet
            // 
            this.ilacAdet.Location = new System.Drawing.Point(460, 306);
            this.ilacAdet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ilacAdet.Name = "ilacAdet";
            this.ilacAdet.Size = new System.Drawing.Size(114, 27);
            this.ilacAdet.TabIndex = 8;
            this.ilacAdet.TextChanged += new System.EventHandler(this.ilacAdet_TextChanged);
            // 
            // ilackod
            // 
            this.ilackod.Location = new System.Drawing.Point(460, 241);
            this.ilackod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ilackod.Name = "ilackod";
            this.ilackod.Size = new System.Drawing.Size(114, 27);
            this.ilackod.TabIndex = 9;
            this.ilackod.TextChanged += new System.EventHandler(this.ilac_TextChanged);
            // 
            // ilacdata
            // 
            this.ilacdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilacdata.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ilacdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilacdata.GridColor = System.Drawing.SystemColors.Menu;
            this.ilacdata.Location = new System.Drawing.Point(635, 94);
            this.ilacdata.Name = "ilacdata";
            this.ilacdata.RowHeadersWidth = 51;
            this.ilacdata.RowTemplate.Height = 29;
            this.ilacdata.Size = new System.Drawing.Size(232, 392);
            this.ilacdata.TabIndex = 11;
            // 
            // yazdır
            // 
            this.yazdır.BackColor = System.Drawing.SystemColors.Highlight;
            this.yazdır.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yazdır.ForeColor = System.Drawing.SystemColors.Window;
            this.yazdır.Location = new System.Drawing.Point(407, 524);
            this.yazdır.Name = "yazdır";
            this.yazdır.Size = new System.Drawing.Size(149, 60);
            this.yazdır.TabIndex = 12;
            this.yazdır.Text = "Yazdır";
            this.yazdır.UseVisualStyleBackColor = false;
            this.yazdır.Click += new System.EventHandler(this.yazdır_Click);
            // 
            // ilaclar
            // 
            this.ilaclar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ilaclar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ilaclar.ForeColor = System.Drawing.SystemColors.Window;
            this.ilaclar.Location = new System.Drawing.Point(679, 524);
            this.ilaclar.Name = "ilaclar";
            this.ilaclar.Size = new System.Drawing.Size(142, 60);
            this.ilaclar.TabIndex = 13;
            this.ilaclar.Text = "İlaçlar";
            this.ilaclar.UseVisualStyleBackColor = false;
            this.ilaclar.Click += new System.EventHandler(this.ilaclar_Click);
            // 
            // tahlilkod
            // 
            this.tahlilkod.Location = new System.Drawing.Point(1193, 238);
            this.tahlilkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tahlilkod.Name = "tahlilkod";
            this.tahlilkod.Size = new System.Drawing.Size(114, 27);
            this.tahlilkod.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1193, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tahlil Kod";
            // 
            // tahlildata
            // 
            this.tahlildata.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.tahlildata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tahlildata.GridColor = System.Drawing.SystemColors.Menu;
            this.tahlildata.Location = new System.Drawing.Point(897, 94);
            this.tahlildata.Name = "tahlildata";
            this.tahlildata.RowHeadersWidth = 51;
            this.tahlildata.RowTemplate.Height = 29;
            this.tahlildata.Size = new System.Drawing.Size(236, 392);
            this.tahlildata.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(949, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 60);
            this.button2.TabIndex = 20;
            this.button2.Text = "Tahliller";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hastakod
            // 
            this.hastakod.Location = new System.Drawing.Point(460, 132);
            this.hastakod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hastakod.Name = "hastakod";
            this.hastakod.Size = new System.Drawing.Size(114, 27);
            this.hastakod.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(314, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hastakod:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // randevulistesi
            // 
            this.randevulistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevulistesi.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.randevulistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevulistesi.GridColor = System.Drawing.SystemColors.Menu;
            this.randevulistesi.Location = new System.Drawing.Point(12, 94);
            this.randevulistesi.Name = "randevulistesi";
            this.randevulistesi.RowHeadersWidth = 51;
            this.randevulistesi.RowTemplate.Height = 29;
            this.randevulistesi.Size = new System.Drawing.Size(271, 392);
            this.randevulistesi.TabIndex = 26;
            this.randevulistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevulistesi_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(1193, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 60);
            this.button1.TabIndex = 27;
            this.button1.Text = "Tahlil İste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DoktorEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.randevulistesi);
            this.Controls.Add(this.hastakod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tahlilkod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tahlildata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ilaclar);
            this.Controls.Add(this.yazdır);
            this.Controls.Add(this.ilacdata);
            this.Controls.Add(this.ilackod);
            this.Controls.Add(this.ilacAdet);
            this.Controls.Add(this.Kullanim);
            this.Controls.Add(this.ReceteTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReceteNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoktorEkran";
            this.Text = "DoktorEkran";
            this.Load += new System.EventHandler(this.DoktorEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilacdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahlildata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevulistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox ReceteNo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker ReceteTarih;
        private TextBox Kullanim;
        private TextBox ilacAdet;
        private TextBox ilackod;
        private DataGridView ilacdata;
        private Button yazdır;
        private Button ilaclar;
        private TextBox tahlilkod;
        private Label label6;
        private DataGridView tahlildata;
        private Button button2;
        private TextBox hastakod;
        private Label label7;
        private DataGridView randevulistesi;
        private Button button1;
    }
}