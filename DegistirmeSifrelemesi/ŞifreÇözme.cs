using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegistirmeSifrelemesi
{
    public partial class ŞifreÇözme : Form
    {
        public ŞifreÇözme()
        {
            InitializeComponent();
        }
        #region şifre çöz
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String metin = textBox1.Text;  //metin
                String sifreliMetin = ""; //şifreli metin
                for (int x = 0; x <= metin.Length - 1; x++) //metin uzunluğu kadar döndür
                {
                    char c = metin[x]; //char ata
                    if (((int)c >= 65 && (int)c < 65 + 26)) //ters işlem
                    {
                        int i = ((int)c) - 65;
                        sifreliMetin += ((char)(97 + ((26 + i - (int)numericUpDown1.Value) % 26))).ToString(); //mod işlemi
                    }
                    else
                    {
                        sifreliMetin += c.ToString();
                    }
                }
               textBox2.Text = sifreliMetin; //yazdır
            }
            catch (Exception) //hata
            {
                MessageBox.Show("Hata", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
