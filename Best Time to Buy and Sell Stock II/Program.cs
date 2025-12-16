namespace Best_Time_to_Buy_and_Sell_Stock_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var solution = new Solution();

             int[] prices = { 7, 1, 5, 3, 6, 4 };

            int maxProfit = solution.MaxProfit(prices);

            Console.WriteLine($"Max Profit: {maxProfit}");

            Console.ReadLine();
        }
    }
}
