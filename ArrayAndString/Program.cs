namespace ArrayAndString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BestTimeToBuyAndSellStock I

            var stockPrices = new int[] { 7, 1, 5, 3, 6, 4 };

            var stockPrices2 = new int[] { 1 };

            var bestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();

            var maxProfit = bestTimeToBuyAndSellStock.MaxProfit(stockPrices2);

            Console.WriteLine($"Maximum Profit: {maxProfit}");

            #endregion
        }
    }
}
