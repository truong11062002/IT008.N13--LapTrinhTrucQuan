using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public class File : Item
    {
        private long size;

        public File(string name, DateTime lastWriteTime, long size) : base(name, lastWriteTime)
        {
            this.size = size;
        }

        public override void Display()
        {
            Console.WriteLine("{0}\t{1}\t{2}", lastWriteTime, size, name);
        }
    }
}
