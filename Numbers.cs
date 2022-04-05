using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int a, int b)
        {
            return getMin(a, b);
        }
        public int FindMinimum(int a, int b, float c)
        {
            return getMin(a, b, (int)c);
        }
        public int FindMaximum(int a, int b)
        {
            return getMax(a, b);
        }
        public int FindMaximum(int a, int b, float c)
        {
            return getMax(a, b, (int)c);
        }
        private static int getMax(params int[] arr)
        {
            return arr.ToList().OrderBy(x => x).Last();
        }
        private static int getMin(params int[] arr)
        {
            return arr.ToList().OrderBy(x => x).First();
        }
    }
}
