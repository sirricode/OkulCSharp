namespace Ödev1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.basamakSayisi = new System.Windows.Forms.NumericUpDown();
            this.basamak7 = new System.Windows.Forms.TextBox();
            this.bLabel7 = new System.Windows.Forms.Label();
            this.basamak6 = new System.Windows.Forms.TextBox();
            this.bLabel6 = new System.Windows.Forms.Label();
            this.basamak5 = new System.Windows.Forms.TextBox();
            this.bLabel5 = new System.Windows.Forms.Label();
            this.basamak4 = new System.Windows.Forms.TextBox();
            this.bLabel4 = new System.Windows.Forms.Label();
            this.basamak3 = new System.Windows.Forms.TextBox();
            this.bLabel3 = new System.Windows.Forms.Label();
            this.basamak2 = new System.Windows.Forms.TextBox();
            this.bLabel2 = new System.Windows.Forms.Label();
            this.basamak1 = new System.Windows.Forms.TextBox();
            this.bLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basamakSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basamak Sayısı:";
            // 
            // basamakSayisi
            // 
            this.basamakSayisi.Location = new System.Drawing.Point(135, 12);
            this.basamakSayisi.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.basamakSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.basamakSayisi.Name = "basamakSayisi";
            this.basamakSayisi.Size = new System.Drawing.Size(46, 20);
            this.basamakSayisi.TabIndex = 1;
            this.basamakSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.basamakSayisi.ValueChanged += new System.EventHandler(this.basamakSayisi_ValueChanged);
            // 
            // basamak7
            // 
            this.basamak7.Location = new System.Drawing.Point(16, 48);
            this.basamak7.MaxLength = 1;
            this.basamak7.Name = "basamak7";
            this.basamak7.Size = new System.Drawing.Size(26, 20);
            this.basamak7.TabIndex = 2;
            // 
            // bLabel7
            // 
            this.bLabel7.BackColor = System.Drawing.Color.Yellow;
            this.bLabel7.Location = new System.Drawing.Point(16, 69);
            this.bLabel7.Name = "bLabel7";
            this.bLabel7.Size = new System.Drawing.Size(26, 10);
            this.bLabel7.TabIndex = 3;
            // 
            // basamak6
            // 
            this.basamak6.Location = new System.Drawing.Point(48, 48);
            this.basamak6.MaxLength = 1;
            this.basamak6.Name = "basamak6";
            this.basamak6.Size = new System.Drawing.Size(26, 20);
            this.basamak6.TabIndex = 2;
            // 
            // bLabel6
            // 
            this.bLabel6.BackColor = System.Drawing.Color.Yellow;
            this.bLabel6.Location = new System.Drawing.Point(48, 69);
            this.bLabel6.Name = "bLabel6";
            this.bLabel6.Size = new System.Drawing.Size(26, 10);
            this.bLabel6.TabIndex = 3;
            // 
            // basamak5
            // 
            this.basamak5.Location = new System.Drawing.Point(80, 48);
            this.basamak5.MaxLength = 1;
            this.basamak5.Name = "basamak5";
            this.basamak5.Size = new System.Drawing.Size(26, 20);
            this.basamak5.TabIndex = 2;
            // 
            // bLabel5
            // 
            this.bLabel5.BackColor = System.Drawing.Color.Yellow;
            this.bLabel5.Location = new System.Drawing.Point(80, 69);
            this.bLabel5.Name = "bLabel5";
            this.bLabel5.Size = new System.Drawing.Size(26, 10);
            this.bLabel5.TabIndex = 3;
            // 
            // basamak4
            // 
            this.basamak4.Location = new System.Drawing.Point(112, 48);
            this.basamak4.MaxLength = 1;
            this.basamak4.Name = "basamak4";
            this.basamak4.Size = new System.Drawing.Size(26, 20);
            this.basamak4.TabIndex = 2;
            // 
            // bLabel4
            // 
            this.bLabel4.BackColor = System.Drawing.Color.Yellow;
            this.bLabel4.Location = new System.Drawing.Point(112, 69);
            this.bLabel4.Name = "bLabel4";
            this.bLabel4.Size = new System.Drawing.Size(26, 10);
            this.bLabel4.TabIndex = 3;
            // 
            // basamak3
            // 
            this.basamak3.Location = new System.Drawing.Point(144, 48);
            this.basamak3.MaxLength = 1;
            this.basamak3.Name = "basamak3";
            this.basamak3.Size = new System.Drawing.Size(26, 20);
            this.basamak3.TabIndex = 2;
            // 
            // bLabel3
            // 
            this.bLabel3.BackColor = System.Drawing.Color.Yellow;
            this.bLabel3.Location = new System.Drawing.Point(144, 69);
            this.bLabel3.Name = "bLabel3";
            this.bLabel3.Size = new System.Drawing.Size(26, 10);
            this.bLabel3.TabIndex = 3;
            // 
            // basamak2
            // 
            this.basamak2.Location = new System.Drawing.Point(176, 48);
            this.basamak2.MaxLength = 1;
            this.basamak2.Name = "basamak2";
            this.basamak2.Size = new System.Drawing.Size(26, 20);
            this.basamak2.TabIndex = 2;
            // 
            // bLabel2
            // 
            this.bLabel2.BackColor = System.Drawing.Color.Yellow;
            this.bLabel2.Location = new System.Drawing.Point(176, 69);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(26, 10);
            this.bLabel2.TabIndex = 3;
            // 
            // basamak1
            // 
            this.basamak1.Location = new System.Drawing.Point(208, 48);
            this.basamak1.MaxLength = 1;
            this.basamak1.Name = "basamak1";
            this.basamak1.Size = new System.Drawing.Size(26, 20);
            this.basamak1.TabIndex = 2;
            // 
            // bLabel1
            // 
            this.bLabel1.BackColor = System.Drawing.Color.Yellow;
            this.bLabel1.Location = new System.Drawing.Point(208, 69);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(26, 10);
            this.bLabel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLabel1);
            this.Controls.Add(this.bLabel2);
            this.Controls.Add(this.bLabel3);
            this.Controls.Add(this.bLabel4);
            this.Controls.Add(this.bLabel5);
            this.Controls.Add(this.bLabel6);
            this.Controls.Add(this.bLabel7);
            this.Controls.Add(this.basamak1);
            this.Controls.Add(this.basamak2);
            this.Controls.Add(this.basamak3);
            this.Controls.Add(this.basamak4);
            this.Controls.Add(this.basamak5);
            this.Controls.Add(this.basamak6);
            this.Controls.Add(this.basamak7);
            this.Controls.Add(this.basamakSayisi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.basamakSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown basamakSayisi;
        private System.Windows.Forms.TextBox basamak7;
        private System.Windows.Forms.Label bLabel7;
        private System.Windows.Forms.TextBox basamak6;
        private System.Windows.Forms.Label bLabel6;
        private System.Windows.Forms.TextBox basamak5;
        private System.Windows.Forms.Label bLabel5;
        private System.Windows.Forms.TextBox basamak4;
        private System.Windows.Forms.Label bLabel4;
        private System.Windows.Forms.TextBox basamak3;
        private System.Windows.Forms.Label bLabel3;
        private System.Windows.Forms.TextBox basamak2;
        private System.Windows.Forms.Label bLabel2;
        private System.Windows.Forms.TextBox basamak1;
        private System.Windows.Forms.Label bLabel1;
    }
}

