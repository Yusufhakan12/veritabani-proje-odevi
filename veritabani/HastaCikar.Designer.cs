namespace veritabani
{
    partial class HastaCikar
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
            this.HastaSil = new System.Windows.Forms.Button();
            this.HastaSilinecekKod = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaSil
            // 
            this.HastaSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HastaSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HastaSil.ForeColor = System.Drawing.SystemColors.Window;
            this.HastaSil.Location = new System.Drawing.Point(975, 151);
            this.HastaSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HastaSil.Name = "HastaSil";
            this.HastaSil.Size = new System.Drawing.Size(148, 65);
            this.HastaSil.TabIndex = 79;
            this.HastaSil.Text = "Sil";
            this.HastaSil.UseVisualStyleBackColor = false;
            this.HastaSil.Click += new System.EventHandler(this.HastaSil_Click);
            // 
            // HastaSilinecekKod
            // 
            this.HastaSilinecekKod.Location = new System.Drawing.Point(975, 68);
            this.HastaSilinecekKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HastaSilinecekKod.Name = "HastaSilinecekKod";
            this.HastaSilinecekKod.Size = new System.Drawing.Size(148, 27);
            this.HastaSilinecekKod.TabIndex = 78;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(769, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 25);
            this.label19.TabIndex = 77;
            this.label19.Text = "Silinecek hasta kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(30, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(705, 545);
            this.dataGridView1.TabIndex = 76;
            // 
            // HastaCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 600);
            this.Controls.Add(this.HastaSil);
            this.Controls.Add(this.HastaSilinecekKod);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HastaCikar";
            this.Text = "HastaCikar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HastaSil;
        private TextBox HastaSilinecekKod;
        private Label label19;
        private DataGridView dataGridView1;
    }
}