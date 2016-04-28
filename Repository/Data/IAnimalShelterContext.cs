﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository.Data
{
    public interface IAnimalShelterContext
    {
        List<Animal> GetAllAnimals();
        void SaveAnimal(Animal animal);
    }
}
