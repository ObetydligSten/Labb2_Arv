using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    public class Chihuahua : Dog
    {
        public int _Height = 25;
        public Chihuahua(string name, int age, string habitat, string food, bool isTame, string color, int height)
            : base(name, age, habitat, food, isTame, color)
        {
            _Height = height;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The chihuahua {_Name} says voff in a sharp tone . . .");
        }
        public void HeightCheck()
        {
            Console.WriteLine($"The chihuahua is a small dog, this one has a height of only {_Height} cm.");
        }
    }
}
