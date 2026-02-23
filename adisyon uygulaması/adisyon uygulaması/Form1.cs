using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Asagidaki gibi Kullanici girişi ve Sifre girildiğinde Giris butonuna basildiginda
//yeni bir form açılacak ve bu formda bir Adisyon Uygulamasi olacaktır.(Ornek
//programda Kullanici Girisi Ozan, Sifre Zonguldak). 

namespace adisyon_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Bu metod form üzerindeki tüm bileşenleri (button, textbox, listbox vb.) oluşturur ve ekrana yerleştirir.
        }

        private void button1_Click(object sender, EventArgs e)
        {

          string kullaniciadi = textBox1.Text;
          string sifre = textBox2.Text;

            if(kullaniciadi == "e" && sifre == "1")
            {

                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre");

            }




        }
    }
}
