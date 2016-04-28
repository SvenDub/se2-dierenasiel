using System;
using Models;
using NUnit.Framework;

namespace Unit_Test_Animal_Shelter.Animals
{
    [TestFixture]
    public class ReservorTest
    {
        [Test]
        public void TestConstructor()
        {
            DateTime reservedAt = DateTime.Now;
            Reservor reservor = new Reservor("John Doe", reservedAt);
            Assert.AreEqual("John Doe", reservor.Name);
            Assert.AreEqual(reservedAt, reservor.ReservedAt);
        }
    }
}
