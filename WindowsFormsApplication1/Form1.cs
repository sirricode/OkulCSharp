using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxIslem.Text == "")
            {
                MessageBox.Show("Geçerli bir değer girin.");
                return;
            }
            listBox1.Items.Add(textBoxIslem.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Bir nesne seçin.");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
        }

        private void sonucBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bir nesne seçin.");
                return;
            }
            switch (listBox1.Items[listBox1.SelectedIndex].ToString().ToLower())
            {
                case "topla":
                    sonucLbl.Text = (Double.Parse(sayi1Txt.Text) + Double.Parse(sayi2Txt.Text)).ToString();
                    break;
                case "çıkar":
                    sonucLbl.Text = (Double.Parse(sayi1Txt.Text) - Double.Parse(sayi2Txt.Text)).ToString();
                    break;
                case "çarp":
                    sonucLbl.Text = (Double.Parse(sayi1Txt.Text) * Double.Parse(sayi2Txt.Text)).ToString();

                    break;
                case "böl":
                    sonucLbl.Text = (Double.Parse(sayi1Txt.Text) / Double.Parse(sayi2Txt.Text)).ToString();
                    break;
                default:
                    sonucLbl.Text = "Hatalı seçim.";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxIslem.Text == "")
            {
                MessageBox.Show("Geçerli bir değer girin.");
                return;
            }
            comboBox1.Items.Add(textBoxIslem.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bir nesne seçin.");
                return;
            }
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bir nesne seçin.");
                return;
            }
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString().ToLower())
            {
                case "topla":
                    comboLabel.Text = (Double.Parse(sayi1Txt.Text) + Double.Parse(sayi2Txt.Text)).ToString();
                    break;
                case "çıkar":
                    comboLabel.Text = (Double.Parse(sayi1Txt.Text) - Double.Parse(sayi2Txt.Text)).ToString();
                    break;
                case "çarp":
                    comboLabel.Text = (Double.Parse(sayi1Txt.Text) * Double.Parse(sayi2Txt.Text)).ToString();

                    break;
                case "böl":
                    comboLabel.Text = (Double.Parse(sayi1Txt.Text) / Double.Parse(sayi2Txt.Text)).ToString();
                    break;
                default:
                    comboLabel.Text = "Hatalı seçim.";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(arttir.Checked)
                progressBar1.Value = progressBar1.Value < 100 ? progressBar1.Value+progressBar1.Step : progressBar1.Value;
            else if(azalt.Checked)
                progressBar1.Value = progressBar1.Value > 0 ? progressBar1.Value - progressBar1.Step : progressBar1.Value;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                button5.Text = "Durdur";
            }
            else
            {
                timer1.Stop();
                button5.Text = "Başla";
            }

        }
    }
}
