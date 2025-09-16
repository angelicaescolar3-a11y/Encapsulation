using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_05_Applying_Encapsulation_with_User
{
    internal class Bag
    {
        public string brand;
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
        //Method to display bag detials
        public void DisplayBagDetails()
        {
            Console.WriteLine("The Brand " + brand);
            Console.WriteLine("The Price " + price);
        }
    }
}
