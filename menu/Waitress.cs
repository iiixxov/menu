namespace Composite
{
    public class Waitress
    {
        MenuComponent menus;

        public Waitress(MenuComponent menus)
        {
            this.menus = menus;
        }

        public void printMenu(List<Menu> iterator)
        {
            foreach (var menuItem in iterator)
            {
                Console.WriteLine(menuItem.getName() + ", ");
                Console.WriteLine(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
            }
        }

        public void printMenu()
        {
            foreach (var menuItem in menus.getChilds())
            {
                menuItem.print();
            }
        }
    }
}