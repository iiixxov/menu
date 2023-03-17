using System;

namespace Composite
{

    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        public virtual List<MenuComponent> getChilds()
        {
            throw new NotSupportedException();
        }
        public virtual String getName()
        {
            throw new NotSupportedException();
        }
        public virtual String getDescription()
        {
            throw new NotSupportedException();
        }
        public virtual decimal getPrice()
        {
            throw new NotSupportedException();
        }
        public virtual bool isVegetarian()
        {
            throw new NotSupportedException();
        }
        public virtual void print()
        {
            throw new NotSupportedException();
        }
    }
}