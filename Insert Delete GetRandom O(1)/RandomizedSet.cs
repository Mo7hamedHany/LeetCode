using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Delete_GetRandom_O_1_
{
    public class RandomizedSet
    {

        public RandomizedSet()
        {

        }

        List<object> nums = new List<object>();

        public bool Insert(int val)
        {
            if (nums.Contains(val))
                return false;

            nums.Add(val);

            return true;
        }

        public bool Remove(int val)
        {
            if (!nums.Contains(val))
                return false;

            nums.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            Random rand = new Random();
            int index = rand.Next(0, nums.Count);
            return (int)nums[index];
        }
    }
}
