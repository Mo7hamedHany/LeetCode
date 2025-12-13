namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var result = solution.MajorityElement(new int[] { 3, 2, 3 });

            Console.WriteLine(result);
        }
    }
}
