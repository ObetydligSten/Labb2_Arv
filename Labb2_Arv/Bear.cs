using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    public class Bear : Animals 
    {
        public string _Breed = "Unknown";

        public Bear(string name, int age, string habitat, string food, bool isTame, string breed) : base (name, age, habitat, food, isTame)
        {
            _Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Name} says RAWRR . . .");
        }
        public void Scary()
        {
            Console.WriteLine("The bear looks hungry, maybe you should back away a few steps . . .");
        }
    }
}
