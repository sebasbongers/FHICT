using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    class Wagon
    {
        public int RoomLeft { get; set; }   
        private readonly List<Animal> _animals = new List<Animal>();

        public Wagon()
        {
            RoomLeft = 10;
        }

        public bool AddAnimal(Animal animal)
        {
            if (RoomLeft >= animal.getSizeNum() && checkCompatibility(animal))
            {
                _animals.Add(animal);
                RoomLeft -= animal.getSizeNum();
                return true;
            }
            else
            {
                return false;
            } 
        }

        private bool checkCompatibility(Animal animal)
        {
            foreach(Animal wagonAnimal in _animals)
            {
                if(wagonAnimal.Food == AnimalFood.Meat)
                {  
                    if(wagonAnimal.getSizeNum() >= animal.getSizeNum() || animal.Food == AnimalFood.Meat)
                    {
                        return false;
                    }
                }

                if(animal.Food == AnimalFood.Meat)
                {
                    if(wagonAnimal.getSizeNum() > animal.getSizeNum())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string animalString = "Wagon: "; 
            foreach (Animal animal in this._animals)
            {
                animalString += animal + "; ";
            }
            return animalString;
        }
    }
}
