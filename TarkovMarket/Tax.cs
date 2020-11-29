using System;
using System.Collections.Generic;
using System.Linq;
using TarkovMarket.Models;

namespace TarkovMarket
{
    public static class Tax
    {
        /// <summary>
        /// Gets tax for Item.
        /// </summary>
        /// <param name="basePrice">Item base price.</param>
        /// <param name="price">Item price.</param>
        public static double Base(double basePrice, double price)
        {
            var p0 = Math.Log10(basePrice / price);
            var pr = Math.Log10(price / basePrice);
            const double ti = 0.05;
            const double tr = 0.05;

            return price >= basePrice
                ? Math.Round(basePrice * ti * Math.Pow(4, p0) + price * tr * Math.Pow(4, Math.Pow(Math.Abs(pr), 1.08)))
                : Math.Round(basePrice * ti * Math.Pow(4, Math.Pow(Math.Abs(p0), 1.08)) + price * tr * Math.Pow(4, pr));
        }

        /// <summary>
        /// Gets tax for Items.
        /// </summary>
        /// <param name="items">List of items.</param>
        public static double Base(List<Item> items)
        {
            return items.Sum(item => Base(item.BasePrice, item.Price));
        }

        /// <summary>Obsolete.</summary>
        [Obsolete("This overload is deprecated, please use Item.Tax instead.")]
        public static double Base(Item item)
        {
            return item.Tax;
        }

        /// <summary>
        /// Gets tax for Item with Int Center.
        /// </summary>
        /// <param name="basePrice">Item base price.</param>
        /// <param name="price">Item price.</param>
        public static double WithIntCenter(double basePrice, double price)
        {
            return Math.Round(Base(basePrice, price) * (1 + (double)-30 / 100));
        }

        /// <summary>
        /// Gets tax for Items with Int Center.
        /// </summary>
        /// <param name="items">List of items.</param>
        public static double WithIntCenter(List<Item> items)
        {
            return items.Sum(item => WithIntCenter(item.BasePrice, item.Price));
        }

        /// <summary>Obsolete.</summary>
        [Obsolete("This overload is deprecated, please use Item.TaxWithIntCenter instead.")]
        public static double WithIntCenter(Item item)
        {
            return item.TaxWithIntCenter;
        }
    }
}
