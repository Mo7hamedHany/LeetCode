using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndString
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }
            int minPrice = prices[0];
            int maxPrice = prices[1];
            int maxProfit = 0;

            if (maxProfit - minPrice >= maxProfit)
            {
                maxProfit = maxPrice - minPrice;
            }

            foreach (var price in prices)
                {
                    if (price < minPrice)
                    {
                        minPrice = price;
                    }

                if (price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
