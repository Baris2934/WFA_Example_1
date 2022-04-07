using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Example_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIslem1_Click(object sender, EventArgs e)
        {
            // 1 den 1000 e kadar olan sayıları (1000 dahil) ListBox'a ekleyin..
           
            
            lstSonuc.Items.Clear();

            for(int i = 1; i <= 1000; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnIslem2_Click(object sender, EventArgs e)
        {
            // 1000'den 1'e kadar olan sayıları (1 dahil) ListBox'a ekleyin..
           
            
            lstSonuc.Items.Clear();

            for(int i = 1000; i >= 1; i--)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            // 1'den 1000'e kadar olan çift sayıları listeleyin (1000 dahil)..


            lstSonuc.Items.Clear();

            for(int i = 2; i <= 1000; i+=2)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnAlfabe_Click(object sender, EventArgs e)
        {
            // A'dan Z'ye kadar olan harflerin kendileriyle birlikte yanlarına Ascii kodlarını yazarak ListBox'a ekleyin (sadece büyük harfler)..

            lstSonuc.Items.Clear();

            for (char c = 'A'; c <='Z'; c++)
            {
                lstSonuc.Items.Add($"{c}'nin Ascii kodu => {Convert.ToInt32(c)}");
            }

        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            // 1-100 arasındaki sayıların (100 dahil) toplamını döngü ile bulup sonucu MessageBox ile gösterin..

            int toplam = 0;

            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }

            MessageBox.Show(toplam.ToString());
        }

        private void btnCarpim_Click(object sender, EventArgs e)
        {
            // ListBox'ta bir çarpım tablosu şeması ekleyin..
            /*
            1x1=1
            1x10=10
            -----------
            2x1=2
            2x2=4
            2x10=20
            ---------

             */

            lstSonuc.Items.Clear();

            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    lstSonuc.Items.Add($"{i}x{j}={i * j}");
                }

                lstSonuc.Items.Add("-----------------");
            }

        }

        private void btnIslem3_Click(object sender, EventArgs e)
        {
            // 1 ile 100 arasındaki (100 dahil) çift sayıların toplamı ile tek sayıların toplamının farkları kaçtır, MessageBox'ta gösterilsin..

            int ciftlerinToplami = 0, teklerinToplami = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) ciftlerinToplami += i;
                else teklerinToplami += i;
            }

            int sonuc = ciftlerinToplami - teklerinToplami;

            MessageBox.Show(sonuc.ToString());
        }

        private void btnYillar_Click(object sender, EventArgs e)
        {
            // 1945 ile günümüz  arasındaki yıllar ListBox'a eklensin ancak 1990 ve 1992 yılları eklenmesin..

            lstSonuc.Items.Clear();

            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992) lstSonuc.Items.Add(i);
            }
        }
    }
}
