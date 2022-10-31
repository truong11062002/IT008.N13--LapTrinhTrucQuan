using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class KhuDat : BatDongSan
    {
        private int _soluongkhudat;

        public int SLKhuDat
        {
            get { return _soluongkhudat; }
            set { _soluongkhudat = value; }
        }

        public KhuDat()
        {

        }
        public KhuDat(string DiaDiem, float GiaBan, float DienTich) : base(DiaDiem, GiaBan, DienTich)
        {
            
        }

        public override void Nhap()
        {
            base.Nhap();

        }
        public override void Xuat()
        {
            base.Xuat();
        }

        public override int LoaiHinh()
        {
            return 1;
        }

        public override int getNamXD()
        {
            return base.getNamXD();
        }
    }
}
