using System;

namespace Models
{
    public class Dog : Animal
    {
        private static int dogsAdded = 0;

        public DateTime LastWalk { get; private set; }
        public bool NeedsWalk
        {
            get
            {
                return (DateTime.Today - this.LastWalk).Days > 0;
            }
        }

        public Dog(int id, string name, Gender gender, DateTime lastWalk)
            : base(id, name, gender)
        {
            this.LastWalk = lastWalk;
            Dog.dogsAdded++;

            // The first dogs in the shelter are the most expensive, but dogs
            // should never become cheaper than EUR 50.
            int priceIndex = Math.Max(1, 10 - Dog.dogsAdded);
            this.Price = priceIndex * 50;
        }
        public Dog(string name, Gender gender)
            : this(-1, name, gender, DateTime.Today)
        {
        }

        public override string ToString()
        {
            return base.ToString() +
                $", last walk: {this.LastWalk.ToShortDateString()}";
        }
    }
}
