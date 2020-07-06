using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionalEngine
{
    public class DiscountCalculatorForProductA : DiscountCalculator
    {
        private const int DiscountComboCount = 3;
        private const int DiscountPriceForCombo = 130;
        public override int GetPriceFor(IList<Product> products)
        {
            var aProducts = products.Where(x => x.Name.ToUpper() == "A");
            if (!aProducts.Any()) return 0;

            var productPrice = aProducts.FirstOrDefault().Price;

            return ((aProducts.Count() / DiscountComboCount) * DiscountPriceForCombo)
                + (aProducts.Count() % DiscountComboCount) * productPrice;
        }
    }
}
