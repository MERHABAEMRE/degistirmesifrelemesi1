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
    public partial class Şifreleme : Form
    {
        public Şifreleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region şifrele
            try
            {
                String metin = this.textBox1.Text.ToLower();  //metin
                String sifreliMetin = ""; //şifreli metin
                for (int x = 0; x <= metin.Length - 1; x++) //metin uzunluğu kadar döndür
                {
                    char c = metin[x]; //char ata
                    if (((int)c >= 97 && (int)c < 97 + 26)) //asmp harf
                    {
                        int i = ((int)c) - 97;
                        sifreliMetin += ((char)(65 + ((i + (int)this.numericUpDown1.Value) % 26))).ToString(); //mod işlemi
                    }
                    else
                    {
                        sifreliMetin += c.ToString(); //yoksa direkt yaz harfleri
                    }
                }
                this.textBox2.Text = sifreliMetin;
            }
            catch (Exception) //hata
            {
                MessageBox.Show("Hata", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
    }
    #endregion

}
