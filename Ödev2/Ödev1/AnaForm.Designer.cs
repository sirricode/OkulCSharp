namespace Ödev1
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTekrarsiz = new System.Windows.Forms.RadioButton();
            this.radioTekrarli = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.baslaBtn = new System.Windows.Forms.Button();
            this.hakSayisiUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hakSuresiUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hakSayisiLbl = new System.Windows.Forms.Label();
            this.kalanSureLbl = new System.Windows.Forms.Label();
            this.sureSayac = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.basamakSayisi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hakSayisiUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hakSuresiUpDown)).BeginInit();
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
            this.basamak7.TextChanged += new System.EventHandler(this.basamak_TextChanged);
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
            this.basamak6.TextChanged += new System.EventHandler(this.basamak_TextChanged);
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
            this.basamak5.TextChanged += new System.EventHandler(this.basamak_TextChanged);
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
            this.basamak4.TextChanged += new System.EventHandler(this.basamak_TextChanged);
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
            this.basamak3.TextChanged += new System.EventHandler(this.basamak_TextChanged);
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
            this.basamak2.TextChanged += new System.EventHandler(this.basamak_TextChanged);
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
            this.basamak1.TextChanged += new System.EventHandler(this.basamak_TextChanged);
            // 
            // bLabel1
            // 
            this.bLabel1.BackColor = System.Drawing.Color.Yellow;
            this.bLabel1.Location = new System.Drawing.Point(208, 69);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(26, 10);
            this.bLabel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTekrarsiz);
            this.groupBox1.Controls.Add(this.radioTekrarli);
            this.groupBox1.Location = new System.Drawing.Point(16, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayı Türü";
            // 
            // radioTekrarsiz
            // 
            this.radioTekrarsiz.AutoSize = true;
            this.radioTekrarsiz.Checked = true;
            this.radioTekrarsiz.Location = new System.Drawing.Point(7, 43);
            this.radioTekrarsiz.Name = "radioTekrarsiz";
            this.radioTekrarsiz.Size = new System.Drawing.Size(68, 17);
            this.radioTekrarsiz.TabIndex = 0;
            this.radioTekrarsiz.TabStop = true;
            this.radioTekrarsiz.Text = "Tekrarsız";
            this.radioTekrarsiz.UseVisualStyleBackColor = true;
            // 
            // radioTekrarli
            // 
            this.radioTekrarli.AutoSize = true;
            this.radioTekrarli.Location = new System.Drawing.Point(7, 20);
            this.radioTekrarli.Name = "radioTekrarli";
            this.radioTekrarli.Size = new System.Drawing.Size(60, 17);
            this.radioTekrarli.TabIndex = 0;
            this.radioTekrarli.TabStop = true;
            this.radioTekrarli.Text = "Tekrarlı";
            this.radioTekrarli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hak Sayısı:";
            // 
            // baslaBtn
            // 
            this.baslaBtn.Location = new System.Drawing.Point(19, 233);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(215, 34);
            this.baslaBtn.TabIndex = 6;
            this.baslaBtn.Text = "Başla";
            this.baslaBtn.UseVisualStyleBackColor = true;
            this.baslaBtn.Click += new System.EventHandler(this.baslaBtn_Click);
            // 
            // hakSayisiUpDown
            // 
            this.hakSayisiUpDown.Location = new System.Drawing.Point(176, 166);
            this.hakSayisiUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.hakSayisiUpDown.Name = "hakSayisiUpDown";
            this.hakSayisiUpDown.Size = new System.Drawing.Size(58, 20);
            this.hakSayisiUpDown.TabIndex = 7;
            this.hakSayisiUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hak Süresi:";
            // 
            // hakSuresiUpDown
            // 
            this.hakSuresiUpDown.Location = new System.Drawing.Point(176, 192);
            this.hakSuresiUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hakSuresiUpDown.Name = "hakSuresiUpDown";
            this.hakSuresiUpDown.Size = new System.Drawing.Size(58, 20);
            this.hakSuresiUpDown.TabIndex = 7;
            this.hakSuresiUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalan Hakıınız :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kalan Süreniz :";
            // 
            // hakSayisiLbl
            // 
            this.hakSayisiLbl.AutoSize = true;
            this.hakSayisiLbl.Location = new System.Drawing.Point(103, 91);
            this.hakSayisiLbl.Name = "hakSayisiLbl";
            this.hakSayisiLbl.Size = new System.Drawing.Size(13, 13);
            this.hakSayisiLbl.TabIndex = 9;
            this.hakSayisiLbl.Text = "0";
            // 
            // kalanSureLbl
            // 
            this.kalanSureLbl.AutoSize = true;
            this.kalanSureLbl.Location = new System.Drawing.Point(103, 118);
            this.kalanSureLbl.Name = "kalanSureLbl";
            this.kalanSureLbl.Size = new System.Drawing.Size(13, 13);
            this.kalanSureLbl.TabIndex = 9;
            this.kalanSureLbl.Text = "0";
            // 
            // sureSayac
            // 
            this.sureSayac.Interval = 1000;
            this.sureSayac.Tick += new System.EventHandler(this.sureSayac_Tick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kalanSureLbl);
            this.Controls.Add(this.hakSayisiLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hakSuresiUpDown);
            this.Controls.Add(this.hakSayisiUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baslaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "AnaForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.basamakSayisi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hakSayisiUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hakSuresiUpDown)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTekrarsiz;
        private System.Windows.Forms.RadioButton radioTekrarli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button baslaBtn;
        private System.Windows.Forms.NumericUpDown hakSayisiUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hakSuresiUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hakSayisiLbl;
        private System.Windows.Forms.Label kalanSureLbl;
        private System.Windows.Forms.Timer sureSayac;
    }
}

