using System;
using Models;
using NUnit.Framework;

namespace Unit_Test_Animal_Shelter.Animals
{
    [TestFixture]
    public class DogTest
    {
        private Dog dog;

        [SetUp]
        public void TestInitialize()
        {
            this.dog = new Dog("Sgt. Woof", Gender.Male);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreEqual("Sgt. Woof", this.dog.Name);
            Assert.AreEqual(Gender.Male, this.dog.Gender);
            Assert.IsNull(this.dog.ReservedBy);
            Assert.AreEqual(DateTime.Today, this.dog.LastWalk);
            Assert.IsFalse(this.dog.NeedsWalk);
        }

        [Test]
        public void TestReservation()
        {
            Assert.IsNull(this.dog.ReservedBy);
            Assert.IsTrue(this.dog.Reserve("John Doe"));
            Assert.IsNotNull(this.dog.ReservedBy);
            Assert.AreEqual("John Doe", this.dog.ReservedBy.Name);
            Assert.IsFalse(this.dog.Reserve("Jane Doe"));

            Dog d = new Dog("Barker", Gender.Male);
            DateTime reservedAt = new DateTime(2000, 1, 1, 0, 0, 0);
            Assert.IsTrue(d.Reserve(new Reservor("John Doe", reservedAt)));
            Assert.AreEqual("John Doe", d.ReservedBy.Name);
            Assert.AreEqual(reservedAt, d.ReservedBy.ReservedAt);
            Assert.IsFalse(d.Reserve(new Reservor("Jane Doe", reservedAt)));
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
