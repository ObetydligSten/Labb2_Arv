namespace Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals human = new Animals("George", 52, "City", "Pasta", true);
            Bear bear1 = new Bear("Freddy", 30, "Forest", "Fish", false, "Grizzly bear");
            Dog dog1 = new Dog("Pluto", 12, "City", "Dog food", true, "Yellow");
            Dolphin dol1 = new Dolphin("James", 6, "Ocean", "Fish", true, true);
            Labrador lab1 = new Labrador("Lisa", 4, "city", "Dog food", true, "light brown", true);
            Chihuahua chi1 = new Chihuahua("Bani", 7, "City", "Dog food", true, "White", 20);

            human.PrintInfo(); human.PrintStory(); human.MakeSound(); human.Speed();
            Console.WriteLine("------------------------------------"); // För att göra det mer läsbart
            bear1.PrintInfo(); bear1.PrintStory(); bear1.MakeSound(); bear1.Speed(); bear1.Scary();
            Console.WriteLine("------------------------------------");
            dog1.PrintInfo(); dog1.PrintStory(); dog1.MakeSound(); dog1.Speed(); dog1.Attention();
            Console.WriteLine("------------------------------------");
            dol1.PrintInfo(); dol1.PrintStory(); dol1.MakeSound(); dol1.Speed(); dol1.LTP();
            Console.WriteLine("------------------------------------");
            lab1.PrintInfo(); lab1.PrintStory(); lab1.MakeSound(); lab1.Speed(); lab1.Attention(); lab1.TailChase();
            Console.WriteLine("------------------------------------");
            chi1.PrintInfo(); chi1.PrintStory(); chi1.MakeSound(); chi1.Speed(); chi1.Attention(); chi1.HeightCheck();
            Console.ReadKey();
        }
    }
}