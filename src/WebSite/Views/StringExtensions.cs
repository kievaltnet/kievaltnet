using System;
using System.Linq;
using System.Collections.Generic;

namespace WebSite.Views
{
    public static class StringExtensions
    {
        public static bool IsDefined(this string @this)
        {
            return !String.IsNullOrWhiteSpace(@this);
        }
    }
}