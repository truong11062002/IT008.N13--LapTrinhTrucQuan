using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public class Folder : Item
    {
        public Folder(string name, DateTime lastWriteTime) : base(name, lastWriteTime)
        {
        }

        public override void Display()
        {
            Console.WriteLine("{0}\t{1}\t{2}", lastWriteTime, "<DIR>", name);
        }
    }
}
