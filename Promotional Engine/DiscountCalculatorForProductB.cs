using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionalEngine
{
    public class DiscountCalculatorForProductB : DiscountCalculator
    {
        private const int DiscountComboCount = 2;
        private const int DiscountPriceForCombo = 45;
        public override int GetPriceFor(IList<Product> products)
        {
            var bProducts = products.Where(x => x.Name.ToUpper() == "B");
            if (!bProducts.Any()) return 0;

            var productPrice = bProducts.FirstOrDefault().Price;

            return ((bProducts.Count() / DiscountComboCount) * DiscountPriceForCombo)
                + (bProducts.Count() % DiscountComboCount) * productPrice;
        }
    }
}
