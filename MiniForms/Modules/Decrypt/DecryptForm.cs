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
using static MiniForms.Modules.Converter.ConverterForm;

namespace MiniForms.Modules.Decrypt
{
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }
        public class CoreDecryption
        {
            public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
            {
                byte[] decryptedBytes = null;

               
                byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

                using (MemoryStream ms = new MemoryStream())
                {
                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        }
                        decryptedBytes = ms.ToArray();
                    }
                }

                return decryptedBytes;
            }
        }
        public class DecryptionFile
        {
            public void DecryptFile(string fileEncrypted, string password)
            {
                    byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                    byte[] bytesDecrypted = CoreDecryption.AES_Decrypt(bytesToBeDecrypted, passwordBytes);

                    string file = fileEncrypted;
                    File.WriteAllBytes(file, bytesDecrypted);
                
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(@"C:\Users\Max Staals\source\repos\MiniForms\MiniForms\bin\Debug\net6.0-windows\Temp\", "*", SearchOption.AllDirectories);


                DecryptionFile dec = new DecryptionFile();

                string password = tbPassword.Text;

                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i]);

                    dec.DecryptFile(files[i], password);
                }
                MessageBox.Show("Decryption succesvol");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Password klopt niet");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
