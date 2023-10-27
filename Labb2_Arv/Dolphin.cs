using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{

    public class Dolphin : Animals
    {
        public bool _Juggle = false;
        public Dolphin(string name, int age, string habitat, string food, bool isTame, bool juggle) : base(name, age, habitat, food, isTame)
        {
            _Juggle = juggle;
        }
         public override void MakeSound()
        {
            Console.WriteLine($"{_Name} makes dolphin sounds . . .");
        }

        public void LTP()
        {
            Console.WriteLine("The dolphin is looking to play, can it find a new playmate?");
        }

    }
    
}
