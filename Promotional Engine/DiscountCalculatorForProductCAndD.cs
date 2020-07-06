using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionalEngine
{
    public class DiscountCalculatorForProductCAndD : DiscountCalculator
    {
        private readonly int ComboPriceForCandD = 30;
        public override int GetPriceFor(IList<Product> products)
        {
            var cProducts = products.Where(x => x.Name.ToUpper() == "C");
            var dProducts = products.Where(x => x.Name.ToUpper() == "D");

            var comboCount = 0;
            var otherPrice = 0;

            if (!cProducts.Any() && !dProducts.Any())
            {
                return 0;
            }

            if (cProducts.Count() < dProducts.Count())
            {
                comboCount = cProducts.Count();
                otherPrice = GetPrice(dProducts.Count() - comboCount, dProducts.First());
            }
            else
            {
                comboCount = dProducts.Count();
                otherPrice = GetPrice(cProducts.Count() - comboCount, cProducts.First());
            };

            var comboPriceForCandD = comboCount * ComboPriceForCandD;
            return comboPriceForCandD + otherPrice;
        }

        private int GetPrice(int itemCount, Product product)
        {
            return itemCount * product.Price;
        }
    }
}
