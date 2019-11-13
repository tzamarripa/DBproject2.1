using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject2._1
{
    static class Extensions
    {
        public static string GetNames(this List<Author> authors)
        {
            return GetNames(authors, ", ");
        }

        public static string GetNames(this List<Author> authors, string separator)
        {
            return string.Join(separator, authors.Select(a => a.FriendlyName));
        }
    }
}
