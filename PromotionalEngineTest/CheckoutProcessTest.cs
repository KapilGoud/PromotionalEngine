using NUnit.Framework;
using PromotionalEngine;
using System.Collections.Generic;

namespace Tests
{
    public class CheckoutProcessTest

    {

        [Test]
        public void TestForProductAWithOneItem()
        {
            var cart = new Cart
            {
                Products = new List<Product> { new Product { Id = 1, Name = "A", Price = 50 }
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(50, result);

        }


        [Test]
        public void TestForProductAWithTwoItem()
        {
            var cart = new Cart
            {
                Products = new List<Product> { new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 }
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(100, result);

        }

        [Test]
        public void TestForProductAWithThreeItem()
        {
            var cart = new Cart
            {
                Products = new List<Product> { new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(130, result);

        }

        [Test]
        public void TestForProductAWith4Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> { new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(180, result);

        }
        [Test]
        public void TestForProductAWith5Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> { new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(230, result);

        }

        [Test]
        public void TestForProductAWith6Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(260, result);

        }
        [Test]
        public void TestForProductAWith7Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(310, result);

        }
        [Test]
        public void TestForProductAandBWith6Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 2, Name = "B", Price = 30 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(290, result);

        }

        [Test]
        public void TestForProductAandB2With6Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(305, result);

        }
        [Test]
        public void TestForProductCItem()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product{Id=3,Name="C",Price=20}
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);
            Assert.AreEqual(20, result);

        }

        [Test]
        public void TestForProductDItem()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product{Id=3,Name="D",Price=15}
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);
            Assert.AreEqual(15, result);

        }
        [Test]
        public void TestForProductCDItem()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product{Id=4,Name="D",Price=15},
                    new Product{Id=3,Name="C",Price=20}
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);
            Assert.AreEqual(30, result);

        }

        [Test]
        public void TestForProductCDItem2()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product{Id=4,Name="D",Price=15},
                    new Product{Id=3,Name="C",Price=20},
                    new Product{Id=3,Name="C",Price=20},
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);
            Assert.AreEqual(50, result);

        }

        [Test]
        public void TestForProductCDItem3()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                    new Product{Id=4,Name="D",Price=15},
                    new Product{Id=4,Name="D",Price=15},
                    new Product{Id=3,Name="C",Price=20},
            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);
            Assert.AreEqual(45, result);

        }
        [Test]
        public void TestForProductABCD2Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product {Id=4,Name="D",Price=15},
                new Product {Id=3,Name="C",Price=20},

            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(280, result);

        }

        [Test]
        public void TestForProductABCDfinal2Item()
        {
            var cart = new Cart
            {
                Products = new List<Product> {
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 1, Name = "A", Price = 50 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product { Id = 2, Name = "B", Price = 30 },
                new Product {Id=4,Name="D",Price=15},
                new Product {Id=3,Name="C",Price=20},

            }
            };

            var checkout = new Checkout();
            var result = checkout.CalculateCartPrice(cart);

            Assert.AreEqual(330, result);

        }

    }
}