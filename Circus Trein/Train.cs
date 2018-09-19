using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    class Train
    {
        List<Wagon> wagons = new List<Wagon>();

        public List<Wagon> GetWagons(List<Animal> animals)
        {
            foreach(Animal animal in animals)
            {
                bool animalPlaced = false;

                foreach(Wagon wagon in wagons)
                {
                    if (wagon.AddAnimal(animal))
                    {
                        animalPlaced = true;
                    }
                }

                if(animalPlaced == false)
                {
                    Wagon wagon = new Wagon();
                    wagon.AddAnimal(animal);
                    wagons.Add(wagon);
                }
            }
            return wagons;
        }
    }
}
