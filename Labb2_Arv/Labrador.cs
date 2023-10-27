using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    public class Labrador : Dog
    {
        public bool _Happy = true;
        public Labrador(string name, int age, string habitat, string food, bool isTame, string color, bool happy) 
            : base(name, age, habitat, food, isTame, color)
        {
            _Happy = happy;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The labrador {_Name} says voff . . .");
        }
        public void TailChase()
        {
            Console.WriteLine("The labrador is chasing its own tail . . .");
        }
    }
}
