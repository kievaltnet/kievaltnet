using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebSite.Extensions {
    public static class StringExtensions {
        public static string ToMd5(this string input) {
            using (var crypter = System.Security.Cryptography.MD5.Create()) {
                return string.Join("", crypter.ComputeHash(Encoding.Default.GetBytes(input)).Select(byt => byt.ToString("x2")));
            }
        }

        public static string SkipExtension(this string input, string extension) {
            return input.Substring(0, input.IndexOf(extension));
        }

        public static string ToGravatarLink(this string input) {
            return string.Format("http://www.gravatar.com/avatar/{0}?s=60", input.ToMd5()); 
        }
    }
}