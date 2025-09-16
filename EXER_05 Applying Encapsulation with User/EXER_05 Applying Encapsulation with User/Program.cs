using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_05_Applying_Encapsulation_with_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the bag from the fields
            Bag bag1 = new Bag();

            //Setting properties using setter method
            Console.Write("Enter the brand of the bag: ");
            bag1.brand = Console.ReadLine();

            Console.Write("Enter the price of the bag: ");
            bag1.price = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Call the method of the bag
            bag1.DisplayBagDetails();

            Console.ReadKey();
        }
    }
}
