using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Animal : Products.ISellable
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Reservor ReservedBy { get; private set; }

        public decimal Price { get; protected set; }

        public Animal(int id, string name, Gender gender)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }

        public bool Reserve(Reservor reservor)
        {
            if (this.ReservedBy == null)
            {
                this.ReservedBy = reservor;
                return true;
            }
            return false;
        }

        public bool Reserve(string reservedBy)
        {
            return this.Reserve(new Reservor(reservedBy, DateTime.Now));
        }

        public override string ToString()
        {
            string reservedOrPrice = $"€ {this.Price.ToString("0.00")}";
            if (this.ReservedBy != null)
            {
                reservedOrPrice = $"reserved by {this.ReservedBy.Name}";
            }
            return $"{this.Name}, {this.Gender}, {reservedOrPrice}";
        }
    }
}
