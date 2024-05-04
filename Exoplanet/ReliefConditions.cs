using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exoplanet
{
   public class ReliefConditions
    {
        private int[] conditions;

        public ReliefConditions(int size)
        {
            Random rand = new Random();
            conditions = new int[size];
            for (int i = 0; i < conditions.Length; i++)
            {
                conditions[i] = rand.Next(-100, 101);
            }
        }

        public int CountLandPoints()
        {
            return conditions.Count(x => x > 0);
        }

        public int FindDeepestPointIndex()
        {
            return Array.IndexOf(conditions, conditions.Min()) + 1;
        }

        public int FindHighestPointIndex()
        {
            return Array.IndexOf(conditions, conditions.Max()) + 1;
        }

        public int CountUnderSeaLevel()
        {
            return conditions.Count(x => x < 0);
        }

        public int CountAboveSeaLevel()
        {
            return conditions.Count(x => x > 0);
        }
    }

}
