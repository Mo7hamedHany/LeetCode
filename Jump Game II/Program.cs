namespace Jump_Game_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 2, 3, 1, 1, 4 };
            int result = solution.Jump(nums);
            Console.WriteLine(result); 
        }
    }
}
