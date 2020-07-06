﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionalEngine
{
    public class Checkout
    {
        public DiscountCalculatorFactory DiscountCalculatorFactory { get; set; }
        public Checkout()
        {
            DiscountCalculatorFactory = new DiscountCalculatorFactory();
        }
        public double CalculateCartPrice(Cart cart)
        {
            var calForA = DiscountCalculatorFactory.GetDiscountCalculator("A");
            var totalPriceOfProductA = calForA.GetPriceFor(cart.Products);

          

            return totalPriceOfProductA ;
        }

    }
}
