using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        private static int noofpositions;

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            noofpositions = comboBox1.SelectedIndex;
            String content = text.Text;
            Char[] temp = content.ToCharArray();
            List<Char> plaintext = new List<char>();
            for (int n = 0; n < temp.Length; n++)
            {
                plaintext.Add(Check.checkDigitDecrypt(temp[n], noofpositions));
            }

            String finalplaintext = "";
            foreach (Char l in plaintext)
            {
                Console.WriteLine(l);
               
                finalplaintext += l;
            }
            

            bool exists = FileHandling.fileExists(@"..\..\Resource\decrypted.txt");
            if (exists == true)
            {
                File.WriteAllText(@"..\..\Resource\decrypted.txt", String.Empty);
                    FileHandling.WriteToFile(@"..\..\Resource\decrypted.txt", finalplaintext);
            }
            else
            {
                    FileHandling.WriteToFile(@"..\..\Resource\decrypted.txt", finalplaintext);
            }
            this.Hide();
            DecryptedText win = new DecryptedText();
            win.Show();
        }

        private void Decrypt_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
