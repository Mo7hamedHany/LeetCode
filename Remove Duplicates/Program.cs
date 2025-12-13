namespace Remove_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            var solution = new Solution();  

            int uniqueCount = solution.RemoveDuplicates(numbers.ToArray());

            Console.WriteLine($"Number of unique elements: {uniqueCount}");
        }
    }
}
