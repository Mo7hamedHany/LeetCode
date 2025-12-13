namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var solution = new Solution();

            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            solution.Rotate(nums, 3);

            Console.WriteLine(string.Join(", ", nums));
            Console.ReadLine();
        }
    }
}
