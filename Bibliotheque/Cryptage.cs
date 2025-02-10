using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Bibliotheque
{
    public class Cryptage
    {
        // utiliser un algorithme de chiffrement AES pour chiffrer un fichier
        public static void EncryptFile(string filePath, string key)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(32, ' '));  // ensure longueur de la clé est de 32 octets
                    aesAlg.IV = new byte[16];  // initialisation du vecteur de 16 octets

                    // creation du flux de chiffrement
                    using (FileStream fsEncrypt = new FileStream(filePath + ".enc", FileMode.Create))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(fsEncrypt, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsInput = new FileStream(filePath, FileMode.Open))
                            {
                                fsInput.CopyTo(csEncrypt);
                            }
                        }
                    }
                }

                MessageBox.Show("Le chiffrement a réussi!", "Succese", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s’est produite pendant le processus de chiffrement: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // utilizing AES decryption algorithm
        public static void DecryptFile(string filePath, string key)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(32, ' '));  // ensure longueur de la clé est de 32 octets
                    aesAlg.IV = new byte[16];  // initialisation du vecteur de 16 octets

                    // creation du flux de déchiffrement
                    using (FileStream fsDecrypt = new FileStream(filePath.Replace(".enc", "_decrypted.json"), FileMode.Create))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(fsDecrypt, aesAlg.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsInput = new FileStream(filePath, FileMode.Open))
                            {
                                fsInput.CopyTo(csDecrypt);
                            }
                        }
                    }
                }

                MessageBox.Show("Le fichier a été déchiffré avec succès！", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s’est produite lors du processus de décryptage: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
