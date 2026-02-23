using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adisyon_uygulaması
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("ÜRÜN:", typeof(String));
            dt.Columns.Add("FİYAT:", typeof(int));
            dtGrd.DataSource = dt;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            string su = "SU";
            string fiyat = "10";

            dt.Rows.Add(su,fiyat);
            dtGrd.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string cay = "ÇAY";
            string fiyat = "15";

            dt.Rows.Add(cay, fiyat);
            dtGrd.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string kahve = "KAHVE";
            string fiyat = "25";

            dt.Rows.Add(kahve, fiyat);
            dtGrd.DataSource = dt;

        }

        private void button12_Click(object sender, EventArgs e)
        {


            string kola = "KOLA";
            string fiyat = "5";

            dt.Rows.Add(kola, fiyat);
            dtGrd.DataSource = dt;


        }

        private void button10_Click(object sender, EventArgs e)
        {

            string ayran = "AYRAN";
            string fiyat = "10";

            dt.Rows.Add(ayran, fiyat);
            dtGrd.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string limonata  = "LİMONATA";
            string fiyat = "20";

            dt.Rows.Add(limonata, fiyat);
            dtGrd.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ıhlamur  = "IHLAMUR";
            string fiyat = "15";

            dt.Rows.Add(ıhlamur, fiyat);
            dtGrd.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string salep  = "SALEP";
            string fiyat = "30";

            dt.Rows.Add(salep, fiyat);
            dtGrd.DataSource = dt;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            double toplam = 0;

            foreach (DataGridViewRow row in dtGrd.Rows)  // datagrddeki tüm satırları sırayla dolanır foreach döngüsü
            {
                if (row.Cells[1].Value != null) // Eğer fiyat sütun boş değilse
                {
                    string fiyatStr = row.Cells[1].Value.ToString().Replace(" TL", "").Trim(); // " TL" kısmını sil
                    double fiyat;

                    if (double.TryParse(fiyatStr, out fiyat)) // String'i double'a çevir
                    {
                        toplam += fiyat; // Toplama ekle
                    }
                }
            }

            MessageBox.Show("Toplam Hesap: " + toplam + " TL", "Hesap Kesildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






    
    }
}
