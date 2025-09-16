using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_04_Basics_on_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Bag 
            Bag bag1 = new Bag();

            //Set properties using setter method
            bag1.Brand = "Belinda";
            bag1.price = 300;

            //Call the method of the bag
            bag1.DisplayBagDetails();

            Console.ReadKey();
        }
    }
}
