using System;
using System.IO;
using System.Text;

namespace NETCore.Encrypt.Client
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            byte[] clearBytes = File.ReadAllBytes(@"C:\Users\Antonio\Pictures\image.jpg");

            string encrypted = EncryptProvider.AESEncrypt("antonio", "7c529a69-2a26-4ed6-85da-16beef35db4a");
            string decrypted = EncryptProvider.AESDecrypt(encrypted, "7c529a69-2a26-4ed6-85da-16beef35db4a");

            Console.ReadLine();
            //File.WriteAllBytes(@"C:\Users\Antonio\Pictures\image_dec.jpg", decryptedBytes);
        }
    }
}
