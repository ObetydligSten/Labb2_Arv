using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    public class Animals
    {
        public string _Name = "No Name";
        public int _Age = 0;
        public string _Habitat = "All over the world . . . maybe";
        public string _Food = "Eats what it wants";
        public bool _IsTame = false;

        public Animals(string name, int age, string habitat, string food, bool isTame) 
        {
            _Name = name;
            _Age = age;
            _Habitat = habitat;
            _Food = food;
            _IsTame = isTame;
        }

        public void PrintStory()
        {
            Console.WriteLine($"The animals name is {_Name} and is {_Age} years old. " +
                $"\n{_Name} lives in the {_Habitat}. \n{_Name} loves to eat {_Food}");
            if (_IsTame)
            {
                Console.WriteLine($"{_Name} is a tame animal and loves to be petted.");
            }
            else
            {
                Console.WriteLine($"{_Name} is not a tame animal and doesn't like to be petted");
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nNAME : {_Name}\nAGE : {_Age}\nHABITAT : {_Habitat}\nFOOD : {_Food}\nTAME : {_IsTame}\n");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes an unrecognizable sound.");
        }

        public void Speed()
        {
            Console.WriteLine("The animal is as fast as the speed of light");
        }
    }


}
