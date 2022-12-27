
namespace veritabani
{
    partial class HastaSistem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            this.hastaekle = new System.Windows.Forms.Button();
            this.hastacikar = new System.Windows.Forms.Button();
            this.hastaguncelle = new System.Windows.Forms.Button();
            this.HastaAra = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recetedata = new System.Windows.Forms.DataGridView();
            this.tahlildata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahlildata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(1356, 69);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(142, 69);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Listele";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hastaekle
            // 
            this.hastaekle.BackColor = System.Drawing.SystemColors.Highlight;
            this.hastaekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hastaekle.ForeColor = System.Drawing.SystemColors.Window;
            this.hastaekle.Location = new System.Drawing.Point(1356, 147);
            this.hastaekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hastaekle.Name = "hastaekle";
            this.hastaekle.Size = new System.Drawing.Size(142, 69);
            this.hastaekle.TabIndex = 2;
            this.hastaekle.Text = "Ekle";
            this.hastaekle.UseVisualStyleBackColor = false;
            this.hastaekle.Click += new System.EventHandler(this.hastaekle_Click);
            // 
            // hastacikar
            // 
            this.hastacikar.BackColor = System.Drawing.SystemColors.Highlight;
            this.hastacikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hastacikar.ForeColor = System.Drawing.SystemColors.Window;
            this.hastacikar.Location = new System.Drawing.Point(1356, 225);
            this.hastacikar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hastacikar.Name = "hastacikar";
            this.hastacikar.Size = new System.Drawing.Size(142, 69);
            this.hastacikar.TabIndex = 3;
            this.hastacikar.Text = "Çıkar";
            this.hastacikar.UseVisualStyleBackColor = false;
            this.hastacikar.Click += new System.EventHandler(this.hastacikar_Click);
            // 
            // hastaguncelle
            // 
            this.hastaguncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.hastaguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hastaguncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.hastaguncelle.Location = new System.Drawing.Point(1356, 301);
            this.hastaguncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hastaguncelle.Name = "hastaguncelle";
            this.hastaguncelle.Size = new System.Drawing.Size(142, 69);
            this.hastaguncelle.TabIndex = 4;
            this.hastaguncelle.Text = "Güncelle";
            this.hastaguncelle.UseVisualStyleBackColor = false;
            this.hastaguncelle.Click += new System.EventHandler(this.hastaguncelle_Click);
            // 
            // HastaAra
            // 
            this.HastaAra.BackColor = System.Drawing.SystemColors.Highlight;
            this.HastaAra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HastaAra.Location = new System.Drawing.Point(649, 440);
            this.HastaAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HastaAra.Name = "HastaAra";
            this.HastaAra.Size = new System.Drawing.Size(143, 59);
            this.HastaAra.TabIndex = 5;
            this.HastaAra.Text = "ARA";
            this.HastaAra.UseVisualStyleBackColor = false;
            this.HastaAra.Click += new System.EventHandler(this.HastaAra_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.Location = new System.Drawing.Point(27, 517);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1070, 260);
            this.dataGridView2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta kod";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 440);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 27);
            this.textBox1.TabIndex = 8;
            // 
            // recetedata
            // 
            this.recetedata.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.recetedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recetedata.GridColor = System.Drawing.SystemColors.Menu;
            this.recetedata.Location = new System.Drawing.Point(1121, 517);
            this.recetedata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recetedata.Name = "recetedata";
            this.recetedata.RowHeadersWidth = 51;
            this.recetedata.RowTemplate.Height = 25;
            this.recetedata.Size = new System.Drawing.Size(396, 122);
            this.recetedata.TabIndex = 9;
            this.recetedata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recetedata_CellContentClick);
            // 
            // tahlildata
            // 
            this.tahlildata.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.tahlildata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tahlildata.GridColor = System.Drawing.SystemColors.Menu;
            this.tahlildata.Location = new System.Drawing.Point(1121, 666);
            this.tahlildata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tahlildata.Name = "tahlildata";
            this.tahlildata.RowHeadersWidth = 51;
            this.tahlildata.RowTemplate.Height = 25;
            this.tahlildata.Size = new System.Drawing.Size(396, 111);
            this.tahlildata.TabIndex = 10;
            // 
            // HastaSistem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 793);
            this.Controls.Add(this.tahlildata);
            this.Controls.Add(this.recetedata);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.HastaAra);
            this.Controls.Add(this.hastaguncelle);
            this.Controls.Add(this.hastacikar);
            this.Controls.Add(this.hastaekle);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HastaSistem";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahlildata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button hastaekle;
        private System.Windows.Forms.Button hastacikar;
        private System.Windows.Forms.Button hastaguncelle;
        private Button HastaAra;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox textBox1;
        private DataGridView recetedata;
        private DataGridView tahlildata;
    }
}

