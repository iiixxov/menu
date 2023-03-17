using System.Diagnostics;
using System.Xml.Linq;
using System;

namespace Composite
{

    public class MenuItem : MenuComponent
    {
        String name;
        String description;
        bool vegetarian;
        decimal price;

        public MenuItem(String name,
            String description,
            bool vegetarian,
            decimal price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override String getName()
        {
            return name;
        }

        public override String getDescription()
        {
            return description;
        }

        public override decimal getPrice()
        {
            return price;
        }

        public override bool isVegetarian()
        {
            return vegetarian;
        }

        public override void print()
        {
            Console.Write(" " + getName());
            if (isVegetarian())
            {
                Console.Write(" (v), ");
            }
            Console.WriteLine(getPrice());
            Console.WriteLine(" -- " + getDescription());
        }
    }
}