using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circus_Trein
{
    public partial class FormCircusTrein : Form
    {
        public FormCircusTrein()
        {
            InitializeComponent();
        }

        AnimalFood animalFood = AnimalFood.Meat;
        AnimalSize animalSize = AnimalSize.Small;

        List<Animal> animals = new List<Animal>();
        List<Wagon> wagons = new List<Wagon>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal(animalFood, animalSize);
            animals.Add(animal);
            listBoxAnimals.Items.Add(animal);
        }
        
        private void radioBtnMeat_CheckedChanged(object sender, EventArgs e)
        {
            animalFood = AnimalFood.Meat;
        }

        private void radioBtnPlants_CheckedChanged(object sender, EventArgs e)
        {
            animalFood = AnimalFood.Plants;
        }

        private void radioBtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            animalSize = AnimalSize.Small;
        }

        private void radioBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            animalSize = AnimalSize.Medium;
        }

        private void radioBtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            animalSize = AnimalSize.Large;
        }

        private void btnCalculateWagons_Click(object sender, EventArgs e)
        {
            listBoxWagons.Items.Clear();          
            wagons.Clear();

            Train train = new Train();                       

            wagons = train.GetWagons(animals);
            
            foreach(Wagon wagon in wagons)
            {
                listBoxWagons.Items.Add(wagon);
            }

            animals.Clear();
            listBoxAnimals.Items.Clear();
        }
    }
}
