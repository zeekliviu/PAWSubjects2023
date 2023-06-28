using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub9PAW
{
    public abstract class Helpers
    {
        public static string ArrayToString(int[] arr)
        {
            var sb = new StringBuilder();
            foreach (var item in arr)
            {
                sb.Append(item.ToString());
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
