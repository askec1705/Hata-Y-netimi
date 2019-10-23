using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hata_Yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int TelefonNumarasi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int TelefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int TelefonNumarasi = Convert.ToInt32(textBox1.Text);
                    MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");

                    // Loglama
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int TelefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch (DivideByZeroException ex) // sıfıra bölünme hatası
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");

                // Loglama
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex) // Index sınırları dışında
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");

                // Loglama
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex) //Format hatası

            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");

                // Loglama
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) // istisnasız en altta bu olacak

            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");

                // Loglama
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                int TelefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatla giriniz\nTelefon Formatı : 02123334455");
            }
            finally
            {
                MessageBox.Show("Bu alan içerisinde yer alan kod blokları her zaman çalışacaktır.");
            }
        }
    }
}