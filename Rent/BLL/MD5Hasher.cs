using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MD5Hasher
    {
        public static string GetHash(string value)
        {
            MD5 hasher = MD5.Create();
            byte[] hash = hasher.ComputeHash(Encoding.Unicode.GetBytes(value));

            string hashed = "";
            foreach (byte b in hash)
            {
                hashed += b.ToString("x2");
            }

            return hashed;
        }
    }
}
