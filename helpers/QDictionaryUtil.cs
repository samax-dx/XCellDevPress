using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCellDevPress.helpers
{
    public static class QDictionaryUtil
    {
        public static void forEach(this IDictionary<string, object> d, Action<KeyValuePair<string, object>, int> cb)
        {
            foreach (var item in d.Select((x, i) => new { x.Key, x.Value, i })) cb(new KeyValuePair<string, object>(item.Key, item.Value), item.i);
        }
    }
}
