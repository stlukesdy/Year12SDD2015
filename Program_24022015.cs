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


            RealEstateProperty property1 = new RealEstateProperty("Dee Why");

            property1.Price = 100000;

            RealEstateProperty property2 = new RealEstateProperty("Manly");

            property2.Price = 200000;




            House house1 = new House();
            house1.HasGarden = true;
            house1.Price = 1000000;

            Flat flat1 = new Flat();
            flat1.HasBalkony = false;
            flat1.Price = 50000;

            //property1.Print();
            //property2.Print();
            //house1.Print();
            //flat1.Print();

            RealEstateProperty[] list = new RealEstateProperty[4];
            list[0] = property1;
            list[1] = property2;
            list[2] = house1;
            list[3] = flat1;

            for (int i = 0; i < list.Length; i++)
            {
                list[i].Print();
            }


            Console.ReadLine();

        }
    }

    public class RealEstateProperty
    {
        protected string Location;
        public int Price;

        public RealEstateProperty() : this("default")
        {
        }

        public RealEstateProperty(string location)
        {
            this.Location = location;
            this.Price = 0;
        }

        public virtual  void Print()
        {
            Console.WriteLine("Property Location " + this.Location);
            Console.WriteLine("Property Price " + this.Price);
            Console.WriteLine();
        }

    }

    public class House : RealEstateProperty
    {
        public bool HasGarden;

        public override void Print()
        {
            Console.WriteLine("House =============");
            Console.WriteLine("Has garden = " + this.HasGarden);
            Console.WriteLine();
        }

    }


    public class Flat : RealEstateProperty
    {
        public bool HasBalkony;
    }


}
