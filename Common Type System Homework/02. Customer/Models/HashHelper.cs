using System.Collections.Generic;
using System.Linq;

namespace _02.Customer.Models
{
    public static class HashHelper
    {

        public static int GetHashCode<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3,
        T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            unchecked
            {
                int hash = arg1.GetHashCode();
                hash = 31 * hash + arg2.GetHashCode();
                hash = 31 * hash + arg3.GetHashCode();
                hash = 31 * hash + arg4.GetHashCode();
                hash = 31 * hash + arg5.GetHashCode();
                hash = 31 * hash + arg6.GetHashCode();
                hash = 31 * hash + arg7.GetHashCode();
                return 31 * hash + arg8.GetHashCode();
            }
        }

        public static int GetListHashCode<T>(IEnumerable<T> list)
        {
            unchecked
            {
                return list.Aggregate(0, (current, item) => 31*current + item.GetHashCode());
            }
        }
       
    }
}
