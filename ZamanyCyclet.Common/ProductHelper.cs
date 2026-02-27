using System;
using System.Text;

namespace ZamanyCyclet.Common
{
    public class ProductHelper
    {

        /// <summary>
        /// Logic to check if the transaction results in a profit.
        /// </summary>
        public static bool IsProfitable(decimal salePrice, decimal purchasePrice)
        {
            return salePrice > purchasePrice;
        }

        /// <summary>
        /// Calculates the absolute profit value.
        /// </summary>
        public static decimal CalculateProfit(decimal salePrice, decimal purchasePrice)
        {
            return salePrice - purchasePrice;
        }

        /// <summary>
        /// Calculates Markup percentage based on Purchase Price.
        /// </summary>
        public static decimal CalculateMarkupPercent(decimal salePrice, decimal purchasePrice)
        {
            if (purchasePrice <= 0) return 0;
            return ((salePrice - purchasePrice) / purchasePrice) * 100;
        }

        /// <summary>
        /// Calculates Margin percentage based on Sale Price.
        /// </summary>
        public static decimal CalculateMarginPercent(decimal salePrice, decimal purchasePrice)
        {
            if (salePrice <= 0) return 0;
            return ((salePrice - purchasePrice) / salePrice) * 100;
        }
    }
}