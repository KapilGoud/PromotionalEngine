using NUnit.Framework;
using Promotional_Engine;

namespace Tests
{
    public class CheckoutProcessTest

    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            CheckoutProcess checkoutProcess = new CheckoutProcess();
            var result = checkoutProcess.Add(1,2);
            Assert.AreEqual(3,result);
        }
    }
}