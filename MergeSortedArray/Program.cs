namespace MergeSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            solution.Merge(nums1, m, nums2, n);

            Console.WriteLine(string.Join(", ", nums1));

            Console.ReadKey();
        }
    }
}
