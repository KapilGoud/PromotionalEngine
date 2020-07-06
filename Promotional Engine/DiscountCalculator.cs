using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionalEngine
{
    public abstract class DiscountCalculator
    {
        public abstract int GetPriceFor(IList<Product> products);
    }
}
