namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sonucLbl = new System.Windows.Forms.Label();
            this.sonucBtn = new System.Windows.Forms.Button();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.cikarBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxIslem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sayi2Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sayi1Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arttir = new System.Windows.Forms.RadioButton();
            this.azalt = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sonucLbl);
            this.panel1.Controls.Add(this.sonucBtn);
            this.panel1.Controls.Add(this.temizleBtn);
            this.panel1.Controls.Add(this.cikarBtn);
            this.panel1.Controls.Add(this.ekleBtn);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.textBoxIslem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 252);
            this.panel1.TabIndex = 0;
            // 
            // sonucLbl
            // 
            this.sonucLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sonucLbl.Location = new System.Drawing.Point(0, 226);
            this.sonucLbl.Name = "sonucLbl";
            this.sonucLbl.Size = new System.Drawing.Size(288, 24);
            this.sonucLbl.TabIndex = 5;
            this.sonucLbl.Text = "Sonuç:";
            // 
            // sonucBtn
            // 
            this.sonucBtn.Location = new System.Drawing.Point(196, 139);
            this.sonucBtn.Name = "sonucBtn";
            this.sonucBtn.Size = new System.Drawing.Size(75, 23);
            this.sonucBtn.TabIndex = 4;
            this.sonucBtn.Text = "sonuc";
            this.sonucBtn.UseVisualStyleBackColor = true;
            this.sonucBtn.Click += new System.EventHandler(this.sonucBtn_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.Location = new System.Drawing.Point(196, 110);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(75, 23);
            this.temizleBtn.TabIndex = 4;
            this.temizleBtn.Text = "temizle";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // cikarBtn
            // 
            this.cikarBtn.Location = new System.Drawing.Point(196, 81);
            this.cikarBtn.Name = "cikarBtn";
            this.cikarBtn.Size = new System.Drawing.Size(75, 23);
            this.cikarBtn.TabIndex = 4;
            this.cikarBtn.Text = "çıkar>>";
            this.cikarBtn.UseVisualStyleBackColor = true;
            this.cikarBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(196, 52);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 23);
            this.ekleBtn.TabIndex = 4;
            this.ekleBtn.Text = "<<ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 147);
            this.listBox1.TabIndex = 3;
            // 
            // textBoxIslem
            // 
            this.textBoxIslem.Location = new System.Drawing.Point(90, 26);
            this.textBoxIslem.Name = "textBoxIslem";
            this.textBoxIslem.Size = new System.Drawing.Size(100, 20);
            this.textBoxIslem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlem=";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel 2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sayi2Txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.sayi1Txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 77);
            this.panel2.TabIndex = 0;
            // 
            // sayi2Txt
            // 
            this.sayi2Txt.Location = new System.Drawing.Point(214, 35);
            this.sayi2Txt.Name = "sayi2Txt";
            this.sayi2Txt.Size = new System.Drawing.Size(57, 20);
            this.sayi2Txt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sayı 2:";
            // 
            // sayi1Txt
            // 
            this.sayi1Txt.Location = new System.Drawing.Point(59, 38);
            this.sayi1Txt.Name = "sayi1Txt";
            this.sayi1Txt.Size = new System.Drawing.Size(57, 20);
            this.sayi1Txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sayı 1:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Panel 1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.comboLabel);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(355, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 239);
            this.panel3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboLabel
            // 
            this.comboLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboLabel.Location = new System.Drawing.Point(0, 213);
            this.comboLabel.Name = "comboLabel";
            this.comboLabel.Size = new System.Drawing.Size(165, 24);
            this.comboLabel.TabIndex = 5;
            this.comboLabel.Text = "Sonuç:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "sonuc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "çıkar>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "<<ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Panel 3";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.azalt);
            this.panel4.Controls.Add(this.arttir);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(323, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 102);
            this.panel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Panel 4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arttir
            // 
            this.arttir.AutoSize = true;
            this.arttir.Location = new System.Drawing.Point(3, 36);
            this.arttir.Name = "arttir";
            this.arttir.Size = new System.Drawing.Size(46, 17);
            this.arttir.TabIndex = 3;
            this.arttir.TabStop = true;
            this.arttir.Text = "Arttır";
            this.arttir.UseVisualStyleBackColor = true;
            // 
            // azalt
            // 
            this.azalt.AutoSize = true;
            this.azalt.Location = new System.Drawing.Point(183, 34);
            this.azalt.Name = "azalt";
            this.azalt.Size = new System.Drawing.Size(48, 17);
            this.azalt.TabIndex = 3;
            this.azalt.TabStop = true;
            this.azalt.Text = "Azalt";
            this.azalt.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(229, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(83, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Başlat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 401);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sonucBtn;
        private System.Windows.Forms.Button temizleBtn;
        private System.Windows.Forms.Button cikarBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxIslem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sayi2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sayi1Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sonucLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label comboLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton azalt;
        private System.Windows.Forms.RadioButton arttir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
    }
}

