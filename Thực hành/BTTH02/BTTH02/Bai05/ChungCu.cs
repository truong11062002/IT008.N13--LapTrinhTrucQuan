using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class ChungCu : BatDongSan
    {
        private int _tang;
        private int _soluongchungcu;

        public int SLChungCu
        {
            get { return _soluongchungcu; }
            set { _soluongchungcu = value; }
        }
        public int Tang
        {
            get { return _tang; }
            set { _tang = value; }
        }

        public ChungCu()
        {

        }
        public ChungCu(string DiaDiem, float GiaBan, float DienTich, int Tang): base(DiaDiem, GiaBan, DienTich)
        {
            this.Tang = Tang;
        }

        public override void Nhap()
        {
            base.Nhap();
            do
            {
                Console.WriteLine("Tang nha: ");
                Tang = int.Parse(Console.ReadLine());
            } while (Tang <= 0);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Tang nha: {0}", Tang);
        }

        public override int LoaiHinh()
        {
            return 3;
        }

        public override int getNamXD()
        {
            return base.getNamXD();
        }
    }
}
