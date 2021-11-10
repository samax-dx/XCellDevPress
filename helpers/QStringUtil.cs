using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCellDevPress.helpers
{
    public static class QStringUtil
    {
        public static string UpdateCharAt(this string s, int i, Func<char, char> getCNew)
        {
            var chars = s.ToCharArray();
            chars[i] = getCNew(chars[i]);
            return new string(chars);
        }
        public static string UpdateCharAt(this string s, int i, char cNew)
        {
            var chars = s.ToCharArray();
            chars[i] = cNew;
            return new string(chars);
        }
    }
}
