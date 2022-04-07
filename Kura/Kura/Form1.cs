using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.back;
            this.Icon = Properties.Resources._new;
           

           for (int sayac = 1; sayac <= 100; sayac++)
            {
                lbx_tum.Items.Add(sayac);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
                      
                //Eğer texbox'ta bir yazı varsa ekle butonuna basınca bu değeri ikinci listbox'a ekler
                if (txt_kisi.Text != "")
                {
                    lbx_secilen.Items.Add(txt_kisi.Text); //İkinci listbox'a textboxtaki değeri ekler
                    lbx_tum.Items.Remove(secilmis);//ilk listbox'tan secilen değeri kaldırır
                }
        }

        int secilmis;
        private void btn_sec_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            secilmis = rnd.Next(1, 100);
            //İkinci liste ile seçilen aynı ise işlem yapılmayacak
            if(lbx_secilen.Items.Count!=0)
            {
                int[] secilenler = new int[lbx_secilen.Items.Count];
                for (int i = 0; i < lbx_secilen.Items.Count; i++)
                {
                    if(secilenler[i] != secilmis || secilenler[i] !=Convert.ToInt32(txt_kisi.Text))
                        txt_kisi.Text = secilmis.ToString();
                }
            }

            else txt_kisi.Text = secilmis.ToString();

        }
    }
}
