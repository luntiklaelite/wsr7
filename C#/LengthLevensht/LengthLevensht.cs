using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthLevensht
{
    public class LengthLevensht
    {
        int[,] ints;
        string first, second;

        public LengthLevensht(string first, string second)
        {
            if(first == null || second == null)
            {
                ints = new int[1, 1];
                ints[0, 0] = 6;
                return;
            }
            this.first = first;
            this.second = second;
            ints = new int[first.Length + 1, second.Length + 1];
            for(int i = 0; i < ints.GetLength(0); i++)
            {
                ints[i, 0] = i;
            }
            for (int i = 0; i < ints.GetLength(1); i++)
            {
                ints[0, i] = i;
            }
            pullMassive();
        }
        
        private int getMinimum(int i1, int i2, int i3)
        {
            return Math.Min(Math.Min(i1, i2), i3);
        }
        
        public int[,] getInts()
        {
            return ints;
        }

        public int getItog()
        {
            return ints[ints.GetLength(0)-1, ints.GetLength(1)-1];
        }

        private void pullMassive()
        {
            int[] index = new int[2];
            index[0] = 1;
            index[1] = 1;
            foreach (char c1 in first)
            {
                foreach(char c2 in second)
                {
                    ints[index[0], index[1]] = getMinimum(ints[index[0] - 1, index[1]] + 1 , ints[index[0], index[1] - 1] + 1, (c1 == c2 ? 0 : 1) + ints[index[0]-1, index[1] - 1]);
                    index[1]++;
                }
                index[1] = 1;
                index[0]++;
            }
        }
    }
}
