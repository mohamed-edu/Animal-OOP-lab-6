// namn: mohamed mohamud
// klass: NET23

namespace Animal_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat bisa = new Cat("bisa", "black",5, 4, "lazy");
            bisa.makeSound();
            bisa.printinfo();
            bisa.hate();
            Console.WriteLine();
            Console.WriteLine();

            Dog lizie = new Dog("lizie", "white", 3, 4, " german shepherd");
            lizie.printinfo();
            lizie.makeSound();
            lizie.like();
            Console.WriteLine();
            Console.WriteLine();


            Bird nighty = new Bird("nighty", "beown", 2, 3, "Owl" );
            nighty.printinfo();
            nighty.makeSound();
            nighty.fly();
            Console.WriteLine();
            Console.WriteLine();

            Bulldog ash = new Bulldog("ash", "black", 4, 4, "bulldog", "fearless");
            ash.printinfo();
            ash.makeSound();
            ash.stenght();
            Console.WriteLine();
            Console.WriteLine();


            Chihuahua rolly = new Chihuahua("rolly", "orange", 10, 4, "chihuahua", 17);
            rolly.printinfo();
            rolly.makeSound();
            rolly.funFact();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}