using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Animal
    {
        string name;
        bool gender;
        int weight;
        Species species;

        public Animal(string name, bool gender, int weight, Species species)
        {
            this.name = name;
            this.gender = gender;
            this.weight = weight;
            this.species = species;
        }

        public string Name { get => name; }
        public bool Gender { get => gender; }
        public int Weight { get => weight; }
        internal Species Species { get => species; }
    }
}
