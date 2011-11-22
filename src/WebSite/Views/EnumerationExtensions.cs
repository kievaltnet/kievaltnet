using System;
using System.Linq;
using System.Collections.Generic;

namespace WebSite.Views
{
    public static class EnumerationExtensions
    {
        public static IEnumerable<IEnumerable<T>> EachThree<T>(this IEnumerable<T> @this)
        {
            var current = new List<T>();
            foreach (var t in @this)
            {
                current.Add(t);
                if (current.Count == 3)
                {
                    yield return current.ToList();
                    current = new List<T>();
                }
            }
            if (current.Count != 0)
            {
                yield return current.ToList();
            }
        }
    }
}