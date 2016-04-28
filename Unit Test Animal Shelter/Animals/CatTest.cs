using System;
using Models;
using NUnit.Framework;

namespace Unit_Test_Animal_Shelter.Animals
{
    [TestFixture]
    public class CatTest
    {
        private Cat cat;

        [SetUp]
        public void TestInitialize()
        {
            this.cat = new Cat("Ms. Meow", Gender.Female, "Scratches couch");
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreEqual("Ms. Meow", this.cat.Name);
            Assert.AreEqual(Gender.Female, this.cat.Gender);
            Assert.IsNull(this.cat.ReservedBy);
            Assert.AreEqual("Scratches couch", this.cat.BadHabits);
        }

        [Test]
        public void TestReservation()
        {
            Assert.IsNull(this.cat.ReservedBy);
            Assert.IsTrue(this.cat.Reserve("John Doe"));
            Assert.IsNotNull(this.cat.ReservedBy);
            Assert.AreEqual("John Doe", this.cat.ReservedBy.Name);
            Assert.IsFalse(this.cat.Reserve("Jane Doe"));

            Cat c = new Cat("Meower", Gender.Female, "None");
            DateTime reservedAt = new DateTime(2000, 1, 1, 0, 0, 0);
            Assert.IsTrue(c.Reserve(new Reservor("John Doe", reservedAt)));
            Assert.AreEqual("John Doe", c.ReservedBy.Name);
            Assert.AreEqual(reservedAt, c.ReservedBy.ReservedAt);
            Assert.IsFalse(c.Reserve(new Reservor("Jane Doe", reservedAt)));
        }


        [Test]
        public void TestReservationTime()
        {
            // TODO: Implement this when interfaces have been explained.
            // We don't yet test the reserved time because it used the current
            // system clock to determine the result. Therefore we cannot check
            // if the values are the same, since two consecutive calls to
            // DateTime.Now are very likely to give different results. There is
            // a way to account for this, but the solution will use interfaces:
            // a concept that is not yet discussed in class. To be implemented.
            Assert.Inconclusive("Implement this when interfaces have been explained");
        }
    }
}
