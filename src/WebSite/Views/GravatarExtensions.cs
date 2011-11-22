using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WebSite.Views
{
    public static class GravatarExtensions
    {
        public static string ToGravatarLink(this string email, int size)
        {            
            return string.Format("http://www.gravatar.com/avatar/{0}?s={1}", ToMd5(email), size);
        }

        private static string ToMd5(string input)
        {
            using (var crypter = System.Security.Cryptography.MD5.Create())
            {
                var hash = crypter.ComputeHash(Encoding.Default.GetBytes(input));
                // To HEX
                return String.Join("", hash.Select(byt => byt.ToString("x2")));
            }
        }
    }
}