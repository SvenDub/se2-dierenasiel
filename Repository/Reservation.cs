using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Data;
using Repository.Logic;

namespace Repository
{
    public class Reservation
    {
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        private AnimalShelterRepository repo;

        public Reservation(IAnimalShelterContext context)
        {
            this.repo = new AnimalShelterRepository(context);
            this.Animals = this.repo.GetAllAnimals();
        }

        public void NewCat(string name, Gender gender, string badHabits)
        {
            Cat cat = new Cat(name, gender, badHabits);
            this.Animals.Add(cat);
            this.SaveAnimal(cat);
        }
        
        public void NewDog(string name, Gender gender)
        {
            Dog dog = new Dog(name, gender);
            this.Animals.Add(dog);
            this.SaveAnimal(dog);
        }

        public void SaveAnimal(Animal animal)
        {
            this.repo.SaveAnimal(animal);
        }
    }
}
