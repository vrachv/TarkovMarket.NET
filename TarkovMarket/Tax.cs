using System;
using System.Collections.Generic;
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
        /// <param name="items"><see cref="List<Item>"/></param>
        public static double Base(List<Item> items)
        {
            double result = 0;
            foreach (var item in items)
            {
                result += Base(item.BasePrice, item.Price);
            }
            return result;
        }

        /// <summary>
        /// Gets tax for Item.
        /// </summary>
        /// <param name="item"><see cref="Item"/></param>
        public static double Base(Item item)
        {
            return Base(item.BasePrice, item.Price);
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
        /// <param name="items"><see cref="List<Item>"/></param>
        public static double WithIntCenter(List<Item> items)
        {
            double result = 0;
            foreach (var item in items)
            {
                result += WithIntCenter(item.BasePrice, item.Price);
            }
            return result;
        }

        /// <summary>
        /// Gets tax for Item with Int Center.
        /// </summary>
        /// <param name="item"><see cref="Item"/></param>
        public static double WithIntCenter(Item item)
        {
            return WithIntCenter(item.BasePrice, item.Price);
        }
    }
}
