using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    public class Alumnus
    {
        public Alumnus(string mssv, string hoten, string khoa, string diemTB)
        {
            ID = mssv;
            Name = hoten;
            Branch = khoa;
            Record = float.Parse(diemTB);
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public string Branch { get; set; }

        public float Record { get; set; }
    }
}
