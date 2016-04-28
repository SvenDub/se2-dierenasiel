using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Data;

namespace Unit_Test_Animal_Shelter
{
    public class AnimalShelterMemoryContext : IAnimalShelterContext
    {
        private List<Animal> animalStore = new List<Animal>();

        public List<Animal> GetAllAnimals()
        {
            // For the memory store, we need to copy the list before returning
            // it. Otherwise, the Reservation class will work on the same array
            // as the one in this class. This gives invalid results as items
            // will be added twice.
            List<Animal> copy = new List<Animal>();
            foreach (Animal a in this.animalStore)
            {
                copy.Add(a);
            }
            return copy;
        }

        public void SaveAnimal(Animal animal)
        {
            this.animalStore.Add(animal);
        }

        public void SaveReservor(Reservor reservor)
        {
            // No need to implement since everything is kept in memory. This
            // implies that the reservors are kept available via the relevant
            // animal instance.
        }
    }
}
