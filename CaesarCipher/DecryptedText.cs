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
    public partial class DecryptedText : Form
    {
        public DecryptedText()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 win = new Form1();
            win.Show();
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

        private void DecryptedText_Load(object sender, EventArgs e)
        {
            String[] temp = FileHandling.ReadFromFileEachLine(@"..\..\Resource\decrypted.txt");
            foreach (String n in temp)
            {
                listBox1.Items.Add(n);
            }
        }
    }
}
