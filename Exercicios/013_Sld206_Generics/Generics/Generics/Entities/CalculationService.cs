using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    class CalculationService
    {
        public static T Max<T>(List<T> list) where T : IComparable
        {
            if (list == null || list.Count ==0) throw new ArgumentException("The list can't be empty or nullabe");

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }

            }
            return max;
        }
    }
}
