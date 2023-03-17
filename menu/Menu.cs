using System.Xml.Linq;

namespace Composite
{
    
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        String name;
        String description;

        public Menu(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }
        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }
        public override List<MenuComponent> getChilds()
        {
            return menuComponents;
        }
        public override String getName()
        {
            return name;
        }
        public override String getDescription()
        {
            return description;
        }
        public override void print()
        {
            Console.Write(getName() + ", ");
            Console.WriteLine(getDescription());
            Console.WriteLine("---------------------");

            foreach (MenuComponent menuComponent in menuComponents)
            {
                menuComponent.print();
            }
            Console.Write("\n\n");
        }
    }
}