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
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int noofpositions = comboBox1.SelectedIndex;
            noofpositions++;
            
            String content = text.Text;
            Char[] temp = content.ToCharArray();
            List<Char> ciphertext = new List<char>();


            for (int n = 0; n < temp.Length; n++)
            {
                ciphertext.Add(Check.checkDigitEncrypt(temp[n], noofpositions));
            }

            String finalplaintext = "";
            foreach (Char l in ciphertext)
            {
                Console.WriteLine(l);
                
                finalplaintext += l;
            }

            bool exists = FileHandling.fileExists(@"..\..\Resource\encrypted.txt");
            if(exists == true)
            {
                File.WriteAllText(@"..\..\Resource\encrypted.txt", String.Empty);
                    FileHandling.WriteToFile(@"..\..\Resource\encrypted.txt", finalplaintext);
                
            }
            else
            {
                    FileHandling.WriteToFile(@"..\..\Resource\encrypted.txt", finalplaintext);
                
            }
            this.Hide();
            EncryptedText dt = new EncryptedText();
            dt.Show();
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {
            for(int i=1; i<=20; i++)
            {
                comboBox1.Items.Add(i);
            }
            
        }
    }
}
