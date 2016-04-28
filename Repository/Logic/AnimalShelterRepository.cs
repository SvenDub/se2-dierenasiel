using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Data;

namespace Repository.Logic
{
    public class AnimalShelterRepository
    {
        private IAnimalShelterContext context;

        public AnimalShelterRepository(IAnimalShelterContext context)
        {
            this.context = context;
        }

        public List<Animal> GetAllAnimals()
        {
            return this.context.GetAllAnimals();
        }

        public void SaveAnimal(Animal animal)
        {
            this.context.SaveAnimal(animal);
        }
    }
}
