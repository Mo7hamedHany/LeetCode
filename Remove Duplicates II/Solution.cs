using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_II
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int p1 = 0;
            int p2 = nums.Length;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count <= 2)
                {
                    nums[p1] = nums[i];
                    p1++;
                }
            }

            return p1;
        }
    }
}
