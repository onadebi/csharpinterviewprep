using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grouping.NumberOperations
{
    public class NumberOps
    {
        /// <summary>
        /// Return the maximum product of two numbers within an array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxProductReturn(int[] nums)
        {
            int defaultVal = Int32.MaxValue;
            int length = nums.Length;
            int maxVal = 0;
            if (length < 2)
            {
                return defaultVal;
            }
            int counter = 0;
            for (int i = 0; i < length; i += 1)
            {
                for (int j = i + 1; j < length; j += 1)
                {
                    int tempMax = nums[i] * nums[j];
                    if (maxVal < tempMax)
                    {
                        maxVal = tempMax;
                    }
                    counter += 1;
                }
            }
            return maxVal;
        }
    }
}
