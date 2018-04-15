using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class AnaForm : Form
    {
        int MAX_TEXTBOX_COUNT = 7;
        int[] basamakDizi;
        bool oyunBasladi = false;
        int hakSayisi = 0;
        int kalanSure = 0;
        int bilinenBasamakSayisi = 0;

        public AnaForm()
        {
            InitializeComponent();
            basamakSayisiKontrol();
            basamakDizi = rastgeleSayiDizisiUret((int)basamakSayisi.Value, true);
        }

        private void basamakSayisi_ValueChanged(object sender, EventArgs e)
        {
            basamakDizi = rastgeleSayiDizisiUret((int)basamakSayisi.Value, true);
            basamakSayisiKontrol();
        }
        private void basamakSayisiKontrol()
        {
            int currentActiveTextbox = (int)basamakSayisi.Value;
            for (int i = 1; i <= MAX_TEXTBOX_COUNT; i++)
            {
                if (i > currentActiveTextbox)
                {
                    Controls["basamak" + i].Enabled = false;
                    Controls["bLabel" + i].Enabled = false;
                }
                else
                {
                    Controls["basamak" + i].Enabled = true;
                    Controls["bLabel" + i].Enabled = true;
                }
            }
        }
        private void basamakDegerKontrol(int basamakId,int[] sayilar)
        {
            TextBox basamak = (TextBox)Controls["basamak" + basamakId];
            bool dizideVar=false;
            bool dogruYerde = false;
            if (sayilar[basamakId - 1] == int.Parse(basamak.Text)) dogruYerde = true;
            else
            {
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] == int.Parse(basamak.Text)) dizideVar = true;
                }
            }
            if (dogruYerde) Controls["bLabel" + basamakId].BackColor = Color.Blue;
            else if(dizideVar) Controls["bLabel" + basamakId].BackColor = Color.Red;

    
        }
        private int[] rastgeleSayiDizisiUret(int basamakSayisi,bool tekrarli)
        {
            Random r = new Random();
            int basamak = 0;
            int[] donecekDizi=new int[basamakSayisi];
            for (; basamak < basamakSayisi; basamak++)
            {
                if (tekrarli) { donecekDizi[basamak] = (int)Math.Abs(r.NextDouble() * 10); }
                else
                {
                    bool flag = true;
                    int sayi=-1;
                    while (flag)
                    {
                        flag = false;
                        sayi= (int)Math.Abs(r.NextDouble() * 10);
                        for (int i = 0; i < basamak; i++) {
                            if (sayi == donecekDizi[i]) flag = true;
                        }
                    }
                    donecekDizi[basamak] = sayi;
                }
            }
            return donecekDizi;
        }

        private void basamak_TextChanged(object sender, EventArgs e)
        {
            
            TextBox tb = (TextBox)sender;
            if (!oyunBasladi)
            {
                tb.Clear();
                return;
            }
            int basamakId = int.Parse(tb.Name.Substring(7));
            if (tb.Text != "")
            {
                hakSayisi--;
                hakSayisiLbl.Text = hakSayisi.ToString();
                basamakDegerKontrol(basamakId, basamakDizi);
                bilinenBasamakSayisi = 0;
                for (int i = 1; i <= basamakDizi.Length; i++)
                {
                    if (Controls["bLabel" + (i)].BackColor == Color.Blue) bilinenBasamakSayisi++;
                }
                if (bilinenBasamakSayisi == basamakDizi.Length)
                {
                    sureSayac.Stop();
                    MessageBox.Show("Tebrikler, Bildiniz.");
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Devam etmek istiyor musunuz?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No) Application.Exit();
                    else if (dr == DialogResult.Yes) yeniOyun();
                }
            }
            else Controls["bLabel"+basamakId].BackColor = Color.Yellow;
        }

        private void baslaBtn_Click(object sender, EventArgs e)
        {
            int basamakSayisiInt = (int)basamakSayisi.Value;
            basamakDizi = rastgeleSayiDizisiUret(basamakSayisiInt, true);
            Button b = (Button)sender;
            if (oyunBasladi)
            {
                b.Text = "Başla";
                oyunBasladi = false;
                sureSayac.Stop();
            }
            else
            {
                b.Text = "Durdur";
                sureSayac.Start();
                oyunBasladi = true;
                basamakDizi = rastgeleSayiDizisiUret((int)basamakSayisi.Value, true);

                hakSayisi = (int)hakSayisiUpDown.Value;
                kalanSure = (int)hakSuresiUpDown.Value;
                hakSayisiLbl.Text = hakSayisi.ToString();
                kalanSureLbl.Text = kalanSure.ToString();
            }

        }

        private void sureSayac_Tick(object sender, EventArgs e)
        {
            if (kalanSure == 0)
            {
                hakSayisi--;
                hakSayisiLbl.Text = hakSayisi.ToString();
                kalanSure= (int)hakSuresiUpDown.Value;
            }
            if (hakSayisi == 0)
            {
                string cevapString = "";
                foreach (var numara in basamakDizi)
                    cevapString += numara.ToString();
                sureSayac.Stop();
                MessageBox.Show("Hakkınız Dolmuştur.\n Cevap:"+cevapString+" olacaktı.");
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Devam etmek istiyor musunuz?","",MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) Application.Exit();
                else if (dr == DialogResult.Yes) yeniOyun();
    
            }
            kalanSure--;
            kalanSureLbl.Text = kalanSure.ToString();
        }
        private void yeniOyun()
        {
            oyunBasladi = false;
            baslaBtn.Text= "Başla";
            for (int i = 1; i <= 7; i++)
            {
                TextBox tb = (TextBox)Controls["basamak" + i];
                tb.Clear();
                Controls["bLabel" + i].BackColor = Color.Yellow;
                kalanSure = 0;
                kalanSureLbl.Text = "";
                hakSayisiLbl.Text = "";
            }
        }
    }
}
