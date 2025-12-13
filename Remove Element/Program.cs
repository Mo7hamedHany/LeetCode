using Remove_Element1;
namespace Remove_Element
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            Solution solution = new Solution();
            int k = solution.RemoveElements(nums, val);
            Console.WriteLine($"New length: {k}");
            Console.WriteLine("Modified array: " + string.Join(", ", nums.Take(k)));
        }
    }
}
