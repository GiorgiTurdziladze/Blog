using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Blog.BLL.Helpers
{
    public static class Md5Hash
    {
        public static string CalculateMd5Hash(string input)
        {
            var md5Hasher = MD5.Create();
            var data = md5Hasher.ComputeHash(Encoding.ASCII.GetBytes(input));
            return BitConverter.ToString(data).Replace("-", string.Empty);
        }
    }
}
