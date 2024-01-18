using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymInterface
{
    class Finder
    {
        /// <summary>
        /// provide object with maximum value from maximum measurement
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IValueProvider FindMaxMax(List<IValueProvider> list)
        {
            if (list.Count == 0)
                return null;    // leere Liste

            int idxMax = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetValue() > list[idxMax].GetValue())
                    idxMax = i;
            }
            return list[idxMax];
        }

        /// <summary>
        /// provide object with maximum value from minimum measurement
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IValueProvider FindMaxMin(List<IValueProvider> list)
        {
            if (list.Count == 0)
                return null;    // leere Liste

            int idxMax = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetValue() < list[idxMax].GetValue())
                    idxMax = i;
            }
            return list[idxMax];
        }
    }
}
