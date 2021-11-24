using System;
using System.Collections.Generic;


namespace FreeCell
{
// TODO Unsure why this is a class on its own, maybe as a sub class in cards? I think it would be best just to have this as part of the initialation of the card class.
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
