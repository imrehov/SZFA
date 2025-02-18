using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Cage
    {
        Animal[] animals;

        public Cage(int num)
        {
            this.animals = new Animal[num];
        }

        public int AnimalCount { get => animals.Length; }

        public bool Add(Animal animal)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i])
                {
                    
                }
            }
            return false;
        }
    }
}
