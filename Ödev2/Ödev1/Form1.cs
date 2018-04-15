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
    public partial class Form1 : Form
    {
        int MAX_TEXTBOX_COUNT = 7;
        public Form1()
        {
            InitializeComponent();
            basamakSayisiKontrol();
        }

        private void basamakSayisi_ValueChanged(object sender, EventArgs e)
        {
            int basamakSayisiInt = (int)basamakSayisi.Value;
            basamakSayisiKontrol();
            int[] dizi = rastgeleSayiDizisiUret(basamakSayisiInt,false);
            for(int i = 1; i < basamakSayisiInt; i++)
            {
                TextBox basamak = (TextBox)Controls["basamak" + i];
                basamak.Text = dizi[i-1].ToString();
            }
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
        
    }
}
