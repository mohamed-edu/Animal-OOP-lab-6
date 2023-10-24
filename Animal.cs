using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_OOP
{
    public abstract class Animal
    {
        public bool HasTail { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Leg { get; set; }

        public int Age { get; set; }

        public void domestic()
        {
            Console.WriteLine("is a dometic animal");
        }
        
        public abstract void makeSound();

        public virtual void printinfo()
        {
            Console.WriteLine("Animal name: " + Name) ;
            Console.WriteLine("Animal tail status: " + HasTail);
            Console.WriteLine(Name + " " + "color:" + " " + Color);
            Console.WriteLine(Name +" " + "has" +" " + Leg +" " + "legs");
            Console.WriteLine(Name +" " + "age is: "+ Age);
           
        }
       
    }
}
