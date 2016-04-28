using System;
using Models;
using NUnit.Framework;
using Repository;

namespace Unit_Test_Animal_Shelter
{
    [TestFixture]
    public class ReservationTest
    {
        private Reservation reservation;

        [SetUp]
        public void TestInitialize()
        {
            this.reservation = new Reservation(new AnimalShelterMemoryContext());
        }

        [Test]
        public void TestNewCat()
        {
            Assert.AreEqual(0, this.reservation.Animals.Count);
            this.reservation.NewCat("Ms. Meow", Gender.Female, "Scratches couch");
            Assert.AreEqual(1, this.reservation.Animals.Count);
        }

        [Test]
        public void TestNewDog()
        {
            Assert.AreEqual(0, this.reservation.Animals.Count);
            this.reservation.NewDog("Sgt. Woof", Gender.Male);
            Assert.AreEqual(1, this.reservation.Animals.Count);
        }
    }
}
