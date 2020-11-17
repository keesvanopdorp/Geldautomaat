using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace geldautomaat_shared
{
    public class Functions
    {
        public string MakeHash(string Password)
        {
            HashAlgorithm Algorithm = SHA256.Create();
            byte[] Bytes = Algorithm.ComputeHash(Encoding.UTF8.GetBytes(Password));
            StringBuilder Builder = new StringBuilder();
            foreach (byte b in Bytes)
            {
                Builder.Append(b.ToString("X2"));
            }
            return Builder.ToString();
        }
    }
}
