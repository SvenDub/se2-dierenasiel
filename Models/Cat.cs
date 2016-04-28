using System;
using System.Diagnostics.Contracts;

namespace Models
{
    public class Cat : Animal
    {
        public string BadHabits { get; private set; }

        public Cat(int id, string name, Gender gender, string badHabits)
            : base(id, name, gender)
        {
            this.BadHabits = badHabits;

            // The price of cats is based on the length of the badHabits
            // string. The maximum price for a cat is EUR 350, but it should
            // never become cheaper than EUR 35.
            this.Price = Math.Max(35, 350 - this.BadHabits.Length * 20);
        }
        public Cat(string name, Gender gender, string badHabits)
            : this(-1, name, gender, badHabits)
        {
        }


        public override string ToString()
        {
            return base.ToString() +
                $", bad habits: {this.BadHabits.ToLower()}";
        }
    }
}
