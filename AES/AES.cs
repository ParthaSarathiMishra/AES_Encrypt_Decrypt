using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace AES
{
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();
        }

        RijndaelManaged myRijndael;

        protected byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");

            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");

            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            byte[] encrypted;

            // Create an RijndaelManaged object
            // with the specified key and IV.

            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        protected string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold 
            // the decrypted text. 
            string plaintext = null;

            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;
                byte[] decryptedBytes;
                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                MemoryStream encryptedStream = new MemoryStream();                
                CryptoStream decryptStream = new CryptoStream(encryptedStream, decryptor, CryptoStreamMode.Write);

                decryptStream.Write(cipherText, 0, cipherText.Length);
                decryptStream.FlushFinalBlock();
                decryptedBytes = encryptedStream.ToArray();

                plaintext = Encoding.UTF8.GetString(decryptedBytes);
            }

            return plaintext;
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            if(ePlainInTxt.Text == "")
            {
                MessageBox.Show("No Input text specified");
                return;
            }            
            if (eKeyTxt.Text == "")
            {
                MessageBox.Show("No Key specified");
                return;
            }
            if (eIVtxt.Text == "")
            {
                MessageBox.Show("No Initialization Vector specified");
                return;
            }
            myRijndael = new RijndaelManaged();
            myRijndael.Key = Encoding.ASCII.GetBytes(eKeyTxt.Text);
            myRijndael.IV = Encoding.ASCII.GetBytes(eIVtxt.Text);
            myRijndael.Mode = CipherMode.CBC;
            myRijndael.Padding = PaddingMode.PKCS7;
            byte[] encrypted = EncryptStringToBytes(ePlainInTxt.Text, myRijndael.Key, myRijndael.IV);
            enOutTxt.Text = BitConverter.ToString(encrypted).Replace("-", "").ToUpper();
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (dHexInTxt.Text == "")
            {
                MessageBox.Show("No Input text specified");
                return;
            }
            dHexInTxt.Text = dHexInTxt.Text.ToUpper();
            if (!CheckEncHexData(dHexInTxt.Text))
            {
                MessageBox.Show("Input text is not a valid Hex string. Please check again.");
                return;
            }
            if (dKeyTxt.Text == "")
            {
                MessageBox.Show("No Key specified");
                return;
            }
            if (dIVtxt.Text == "")
            {
                MessageBox.Show("No Initialization Vector specified");
                return;
            }
            myRijndael = new RijndaelManaged();
            myRijndael.Key = Encoding.ASCII.GetBytes(dKeyTxt.Text);
            myRijndael.IV = Encoding.ASCII.GetBytes(dIVtxt.Text);
            myRijndael.Mode = CipherMode.CBC;
            myRijndael.Padding = PaddingMode.PKCS7;

            decOutTxt.Text = DecryptStringFromBytes(ToByteArray(dHexInTxt.Text), myRijndael.Key, myRijndael.IV);
        }

        private bool CheckEncHexData(String HexString)
        {
            if ((HexString.Length % 2) != 0)
            {
                return false;
            }

            foreach (char c in HexString)
            {
                bool isHex = (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');

                if(!isHex)
                {
                    return false;
                }
            }
            return true;
        }

        public static byte[] ToByteArray(String HexString)
        {
            int NumberChars = HexString.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
