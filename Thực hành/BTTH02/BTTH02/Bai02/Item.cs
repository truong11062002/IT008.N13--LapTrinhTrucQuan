using System;

namespace Bai02
{
    public abstract class Item
    {
        protected string name;
        protected DateTime lastWriteTime;

        public Item(string name, DateTime lastWriteTime)
        {
            this.name = name;
            this.lastWriteTime = lastWriteTime;
        }

        public abstract void Display();
    }
}
