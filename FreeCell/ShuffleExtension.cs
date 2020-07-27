using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCell
{
    public static class ShuffleExtension
    {
        public static void Shuffle<T>(this IList<T> list, int seed)
        {
            Random rng = new Random(seed);

            for (int i = 0; i < list.Count - 1; i++)
            {
                int j = 51 - rng.Next() % (52 - i);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}
