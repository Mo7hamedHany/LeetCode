namespace Remove_Duplicates_II
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var solution = new Solution();  

            int[] nums = new int[] { 0,0,1,1,1,1,2,3,3 };

            int length = solution.RemoveDuplicates(nums);

            Console.WriteLine("New length: " + length);
            Console.WriteLine("Modified array: " + nums);
            Console.ReadKey();
        }
    }
}
