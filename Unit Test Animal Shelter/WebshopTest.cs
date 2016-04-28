using System;
using Models.Products;
using NUnit.Framework;
using Repository;

namespace Unit_Test_Animal_Shelter
{
    [TestFixture]
    public class WebshopTest
    {
        private Webshop webshop;

        [SetUp]
        public void TestInitialize()
        {
            this.webshop = new Webshop();
        }

        [Test]
        public void TestNewProduct()
        {
            Assert.AreEqual(0, this.webshop.Products.Count);
            this.webshop.AddProduct(new Food("Dog food", 10));
            Assert.AreEqual(1, this.webshop.Products.Count);
            Assert.AreEqual("Dog food", this.webshop.Products[0].Name);
            Assert.AreEqual(10, this.webshop.Products[0].Price);
        }
    }
}
