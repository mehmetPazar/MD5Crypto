using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static byte[] ByteDonustur(string deger)
        {
            char[] arrayChar = deger.ToCharArray();
            byte[] arrayByte = new byte[arrayChar.Length];

            for (int i = 0; i < arrayByte.Length - 1; i++)
            {
                arrayByte[i] = Convert.ToByte(arrayChar[i]);
            }

            return arrayByte;
        }
        private void Kripto_string_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deger = ByteDonustur(Encryption.Text.ToString());
            byte[] sonuc = md5.ComputeHash(deger);

            Kripto.Text = BitConverter.ToString(sonuc);
            
        }
    }
}
