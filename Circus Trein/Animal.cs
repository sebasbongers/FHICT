using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public enum AnimalFood { Meat, Plants }
    public enum AnimalSize { Small, Medium, Large }

    class Animal
    {
        
        private int AnimalSizeNum;
        public AnimalFood Food { get; set; }
        public AnimalSize Size { get; set; }

        public Animal(AnimalFood animalFood, AnimalSize animalSize)
        {
            Food = animalFood;
            Size = animalSize;

            if(Size == AnimalSize.Large)
            {
                AnimalSizeNum = 5;
            }
            else if(Size == AnimalSize.Medium)
            {
                AnimalSizeNum = 3;
            }
            else
            {
                AnimalSizeNum = 1;
            }
        }

        public int getSizeNum()
        {
            return AnimalSizeNum;
        }

        public override string ToString()
        {
            return Food.ToString() + ", " + Size.ToString();
        }
    }
}
