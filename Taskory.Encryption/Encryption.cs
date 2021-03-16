using System.Security.Cryptography;
using System.Text;

namespace Taskory.Encryption
{
    public class Encryption
    {
        public static string UsingMD5(string plaintext)
        {
            using (var md5 = MD5.Create())
            {
                byte[] passwordBytes = Encoding.ASCII.GetBytes(plaintext);
                byte[] hash = md5.ComputeHash(passwordBytes);
                var stringBuilder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                    stringBuilder.Append(hash[i].ToString("X"));
                return stringBuilder.ToString();
            }
        }
    }
}
