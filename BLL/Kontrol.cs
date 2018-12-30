using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Website
{
    public class Kontrol
    {
         private Kontrol(){}
         public static string getSHA1Hash(string input)
        {
            SHA1 hash = SHA1.Create();
            byte[] data = hash.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();

        }
    }
}