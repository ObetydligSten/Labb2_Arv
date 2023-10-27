using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    public class Dog : Animals
    {
        public string _Color = "";
        public Dog(string name, int age, string habitat, string food, bool isTame, string color) : base(name, age, habitat, food, isTame)
        {
            _Color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Name} says voff . . .");
        }
        public void Attention()
        {
            Console.WriteLine("The dog is looking for attention . . .");
        }
    }
    
}
