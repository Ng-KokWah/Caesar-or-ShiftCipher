using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Encrypt win = new Encrypt();
            win.Show();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Decrypt win = new Decrypt();
            win.Show();
        }
    }
}
