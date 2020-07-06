using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionalEngine
{
    public class DiscountCalculatorFactory
    {
        public Dictionary<string, DiscountCalculator> DiscountCalculators { get; set; }
        public DiscountCalculatorFactory()
        {
            DiscountCalculators = new Dictionary<string, DiscountCalculator> {
                {"A",new DiscountCalculatorForProductA() },
                
            };
        }

        public DiscountCalculator GetDiscountCalculator(string productName)
        {
            DiscountCalculators.TryGetValue(productName, out DiscountCalculator discountCalculator);
            return discountCalculator;
        }
    }
}
