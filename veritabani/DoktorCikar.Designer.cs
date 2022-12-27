namespace veritabani
{
    partial class DoktorCikar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DoktorSil = new System.Windows.Forms.Button();
            this.DoktorSilinecekKod = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(705, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // DoktorSil
            // 
            this.DoktorSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DoktorSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoktorSil.ForeColor = System.Drawing.SystemColors.Window;
            this.DoktorSil.Location = new System.Drawing.Point(959, 151);
            this.DoktorSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorSil.Name = "DoktorSil";
            this.DoktorSil.Size = new System.Drawing.Size(148, 65);
            this.DoktorSil.TabIndex = 75;
            this.DoktorSil.Text = "Sil";
            this.DoktorSil.UseVisualStyleBackColor = false;
            this.DoktorSil.Click += new System.EventHandler(this.DoktorSil_Click);
            // 
            // DoktorSilinecekKod
            // 
            this.DoktorSilinecekKod.Location = new System.Drawing.Point(959, 68);
            this.DoktorSilinecekKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoktorSilinecekKod.Name = "DoktorSilinecekKod";
            this.DoktorSilinecekKod.Size = new System.Drawing.Size(148, 27);
            this.DoktorSilinecekKod.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(753, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 25);
            this.label19.TabIndex = 73;
            this.label19.Text = "Silinecek doktor kodu";
            // 
            // DoktorCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 600);
            this.Controls.Add(this.DoktorSil);
            this.Controls.Add(this.DoktorSilinecekKod);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoktorCikar";
            this.Text = "DoktorCikar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button DoktorSil;
        private TextBox DoktorSilinecekKod;
        private Label label19;
    }
}