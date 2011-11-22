using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebSite.Extensions 
{
    public static class StringExtensions 
    {
        public static string SkipExtension(this string input, string extension) 
        {
            return input.Substring(0, input.IndexOf(extension));
        }

        public static string ToGravatarLink(this string email) 
        {
            return string.Format("http://www.gravatar.com/avatar/{0}?s=60", email.ToMd5()); 
        }

        private static string ToMd5(this string input)
        {
            using (var crypter = System.Security.Cryptography.MD5.Create())
            {
                var encodedBytes = crypter.ComputeHash(Encoding.Default.GetBytes(input));
                return BitConverter.ToString(encodedBytes);
            }
        }
    }
}