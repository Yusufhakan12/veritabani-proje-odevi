namespace veritabani
{
    partial class PersonelCikar
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
            this.PersonelSil = new System.Windows.Forms.Button();
            this.PersonelSilinecekKod = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelSil
            // 
            this.PersonelSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PersonelSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelSil.ForeColor = System.Drawing.SystemColors.Window;
            this.PersonelSil.Location = new System.Drawing.Point(969, 151);
            this.PersonelSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelSil.Name = "PersonelSil";
            this.PersonelSil.Size = new System.Drawing.Size(148, 66);
            this.PersonelSil.TabIndex = 79;
            this.PersonelSil.Text = "Sil";
            this.PersonelSil.UseVisualStyleBackColor = false;
            this.PersonelSil.Click += new System.EventHandler(this.PersonelSil_Click);
            // 
            // PersonelSilinecekKod
            // 
            this.PersonelSilinecekKod.Location = new System.Drawing.Point(969, 68);
            this.PersonelSilinecekKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelSilinecekKod.Name = "PersonelSilinecekKod";
            this.PersonelSilinecekKod.Size = new System.Drawing.Size(148, 27);
            this.PersonelSilinecekKod.TabIndex = 78;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(763, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(224, 25);
            this.label19.TabIndex = 77;
            this.label19.Text = "Silinecek personel kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(24, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(705, 545);
            this.dataGridView1.TabIndex = 76;
            // 
            // PersonelCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 600);
            this.Controls.Add(this.PersonelSil);
            this.Controls.Add(this.PersonelSilinecekKod);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonelCikar";
            this.Text = "PersonelCikar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PersonelSil;
        private TextBox PersonelSilinecekKod;
        private Label label19;
        private DataGridView dataGridView1;
    }
}