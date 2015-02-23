using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");


            RealEstateProperty property1 = new RealEstateProperty();
            property1.Location = "Dee Why";
            property1.Price = 100000;

            RealEstateProperty property2 = new RealEstateProperty();
            property2.Location = "Manly";
            property2.Price = 200000;


            property1.Print();
            property2.Print();

            Console.ReadLine();

        }
    }

    public class RealEstateProperty
    {
        public string Location;
        public int Price;

        public RealEstateProperty()
        {
            this.Location = "Default";
            this.Price = 0;
        }

        public void Print()
        {
            Console.WriteLine("Property Location " + this.Location);
            Console.WriteLine("Property Price " + this.Price);
            Console.WriteLine();
        }

    }



}
