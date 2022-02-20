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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Şifreleme sf = new Şifreleme();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ŞifreÇözme sfc = new ŞifreÇözme();
            sfc.Show();
        }
    }
}
