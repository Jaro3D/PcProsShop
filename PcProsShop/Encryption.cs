using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;

namespace PcProsShop
{
    internal class Encryption
    {
        /*
         * Creates Aes Inititalisation Vector (IV)
         * IV is requred for Aes encryption and Aes decryption
         * IV can be stored in database
         * Return value: randomly created IV as byte array with length 16
         */
        public static byte[] createIV()
        {
            Aes myAES = Aes.Create();
            return myAES.IV;
        }

        /*
         * Creates Aes Key from a given String.
         * Key is requred for Aes encryption and Aes decryption
         * Key must ALLWAYS remain a secret. Not allowed to be stored in a database.
         * Input password: String from which the key is gernerated
         * Return value: Aes key as byte array with length 32
         */
        public static byte[] createKey(String password)
        {
            byte[] key = null;
            using (SHA256 mysha256 = SHA256.Create())
            {
                key = mysha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
            return key;
        }

        /*
         * Crates SHA - 512 Hash from input String.
         * Purpose is to create Identifier for Account Objects.
         * Input plainText: String from which the Hash is generated.
         * Return value: SHA - 512 Hash formated as Base64 String  
         */
        public static string createHash(String plainText)
        {
            String Base64Hash;
            using (SHA512 mysha512 = SHA512.Create())
            {
                Base64Hash = Convert.ToBase64String(mysha512.ComputeHash(Encoding.UTF8.GetBytes(plainText)));
            }
            return Base64Hash;
        }

        /*
         * Encrypts Account Objects attributes which contain personal data from users.
         * Input plain: Account Object to be encrypted.
         * Input Key: Key used for Aes encryption. Should be created from Account attribute password.
         * Input IV: Initialisation Vector for Aes encryptrion. Should be created randomly.
         * Return value: Account Object with encrypted attributes.
         */
        public static Account encryptAccount(Account plain, byte[] key, byte[] IV)
        {
            Account cipher = new Account();
            cipher.Id = plain.Id;
            cipher.Fname = EncryptStringAes(plain.Fname, key, IV);
            cipher.Lname = EncryptStringAes(plain.Lname, key, IV);
            cipher.Mail = EncryptStringAes(plain.Mail, key, IV);
            cipher.Password = EncryptStringAes(plain.Password, key, IV);
            cipher.City = EncryptStringAes(plain.City, key, IV);
            cipher.Street = EncryptStringAes(plain.Street, key, IV);
            cipher.Zip = EncryptStringAes(plain.Zip, key, IV);
            cipher.IsAdmin = plain.IsAdmin;
            return cipher;
        }

        /*
         * Decrypts Account Objects attributes which contain personal data from users.
         * Input cipher: Encrypted Account object to be decrypted.
         * Input key: Key used for Aes decryption. Must be the same key used when Account cipher was encrypted.
         * Input IV: Initialisation Vector used for Aes decryption. Must be the same IV used when Account cipher was encrypted.
         * Return value: Account Object with decrypted attributes.
         */
        public static Account decryptAccount(Account cipher, byte[] key, byte[] IV)
        {
            Account plain = new Account();
            plain.Id = cipher.Id;
            plain.Fname = DecryptStringAes(cipher.Fname, key, IV);
            plain.Lname = DecryptStringAes(cipher.Lname, key, IV);
            plain.Mail = DecryptStringAes(cipher.Mail, key, IV);
            plain.Password = DecryptStringAes(cipher.Password, key, IV);
            plain.City = DecryptStringAes(cipher.City, key, IV);
            plain.Street = DecryptStringAes(cipher.Street, key, IV);
            plain.Zip = DecryptStringAes(cipher.Zip, key, IV);
            plain.IsAdmin = cipher.IsAdmin;
            return plain;
        }

        /*
         * Encrypts String using Aes.
         * Input plainText: Text to be encrypted
         * Input key: Aes Key used for encryption
         * Input IV: Initialisation Vector used for encryption
         * Returns value: String encrypted with Aes formated as Base64 String
         */
        public static string EncryptStringAes(string plainText, byte[] Key, byte[] IV)
        {
          if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

          
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            String result = Convert.ToBase64String(encrypted);

            return result;
        }
        /*
         * Encrypts String using Aes.
         * Returns String encrypted with Aes formated as Base64 String
         */
        public static string DecryptStringAes(string cipherText, byte[] Key, byte[] IV)
        {
            byte[] encrypted = Convert.FromBase64String(cipherText);
            if (encrypted == null || encrypted.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(encrypted))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            try
                            {
                                plaintext = srDecrypt.ReadToEnd();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.GetType().FullName);
                                Console.WriteLine(e.Message);

                            }
                        }

                    }
                }
            }
            return plaintext;
        }
        /*
         * Fetches connection String from app.config.
         * Input identifier: String containing the name of the requred ConnectionString from app.config
         * Return: ConnectionString fetched from app.config
         */
        public static string getConnectionString(String identififer)
        {
            String conn = "";
            try
            {
                conn = ConfigurationManager.ConnectionStrings[identififer].ConnectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return conn;
        }



    }
}
