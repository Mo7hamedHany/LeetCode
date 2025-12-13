using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var majority = nums[0];

            foreach(var num in nums)
            {
              if (nums.Count(x => x == num) > nums.Length / 2)
              {
                    majority = num;
                    break;
              }
            }

            return majority;
        }
    }
}
