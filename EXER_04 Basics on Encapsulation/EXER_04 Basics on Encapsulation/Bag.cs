using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_04_Basics_on_Encapsulation
{
    internal class Bag
    {
        private string brand;
        public int price;

        //Set properties for the fields
        public string Brand
        {
            get {  return brand; }
            set { brand = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //Method to display bag Details
        public void DisplayBagDetails()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price: " + price);
        }
    }
}
