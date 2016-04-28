using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reservor
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public DateTime ReservedAt { get; private set; }

        public Reservor(int id, string name, DateTime reservedAt)
        {
            this.Id = id;
            this.Name = name;
            this.ReservedAt = reservedAt;
        }
        public Reservor(string name, DateTime reservedAt)
            : this(-1, name, reservedAt)
        {
        }
    }
}
