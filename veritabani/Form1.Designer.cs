namespace veritabani
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoktorListele = new System.Windows.Forms.Button();
            this.DoktorEkle = new System.Windows.Forms.Button();
            this.DoktorCikar = new System.Windows.Forms.Button();
            this.DoktorGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AranacakDoktor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DoktorListele
            // 
            this.DoktorListele.BackColor = System.Drawing.SystemColors.Highlight;
            this.DoktorListele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoktorListele.Location = new System.Drawing.Point(903, 16);
            this.DoktorListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorListele.Name = "DoktorListele";
            this.DoktorListele.Size = new System.Drawing.Size(160, 79);
            this.DoktorListele.TabIndex = 0;
            this.DoktorListele.Text = "Listele";
            this.DoktorListele.UseMnemonic = false;
            this.DoktorListele.UseVisualStyleBackColor = false;
            this.DoktorListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoktorEkle
            // 
            this.DoktorEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.DoktorEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoktorEkle.Location = new System.Drawing.Point(903, 103);
            this.DoktorEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorEkle.Name = "DoktorEkle";
            this.DoktorEkle.Size = new System.Drawing.Size(160, 72);
            this.DoktorEkle.TabIndex = 1;
            this.DoktorEkle.Text = "Ekle";
            this.DoktorEkle.UseVisualStyleBackColor = false;
            this.DoktorEkle.Click += new System.EventHandler(this.DoktorEkle_Click);
            // 
            // DoktorCikar
            // 
            this.DoktorCikar.BackColor = System.Drawing.SystemColors.Highlight;
            this.DoktorCikar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoktorCikar.Location = new System.Drawing.Point(903, 195);
            this.DoktorCikar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorCikar.Name = "DoktorCikar";
            this.DoktorCikar.Size = new System.Drawing.Size(160, 69);
            this.DoktorCikar.TabIndex = 2;
            this.DoktorCikar.Text = "Çıkar";
            this.DoktorCikar.UseVisualStyleBackColor = false;
            this.DoktorCikar.Click += new System.EventHandler(this.DoktorCikar_Click);
            // 
            // DoktorGuncelle
            // 
            this.DoktorGuncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.DoktorGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoktorGuncelle.Location = new System.Drawing.Point(903, 292);
            this.DoktorGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorGuncelle.Name = "DoktorGuncelle";
            this.DoktorGuncelle.Size = new System.Drawing.Size(160, 72);
            this.DoktorGuncelle.TabIndex = 3;
            this.DoktorGuncelle.Text = "Güncelle";
            this.DoktorGuncelle.UseVisualStyleBackColor = false;
            this.DoktorGuncelle.Click += new System.EventHandler(this.DoktorGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(865, 400);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(688, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AranacakDoktor
            // 
            this.AranacakDoktor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AranacakDoktor.Location = new System.Drawing.Point(551, 436);
            this.AranacakDoktor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AranacakDoktor.Name = "AranacakDoktor";
            this.AranacakDoktor.Size = new System.Drawing.Size(114, 32);
            this.AranacakDoktor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aranacak doktor kodu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.Location = new System.Drawing.Point(14, 493);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1128, 252);
            this.dataGridView2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 743);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AranacakDoktor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoktorGuncelle);
            this.Controls.Add(this.DoktorCikar);
            this.Controls.Add(this.DoktorEkle);
            this.Controls.Add(this.DoktorListele);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoktorListele;
        private Button DoktorEkle;
        private Button DoktorCikar;
        private Button DoktorGuncelle;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox AranacakDoktor;
        private Label label1;
        private DataGridView dataGridView2;
    }
}