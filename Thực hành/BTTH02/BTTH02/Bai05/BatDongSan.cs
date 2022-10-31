using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class BatDongSan
    {
        private string _diadiem;
        private float _giaban;
        private float _dientich;

        public string DiaDiem
        {
            get { return _diadiem; }
            set { _diadiem = value; }
        }
        public float GiaBan
        {
            get { return _giaban; }
            set { _giaban = value; }
        }
        public float DienTich
        {
            get { return _dientich; }
            set { _dientich = value; }
        }

        public BatDongSan()
        {

        }
        public BatDongSan(string DiaDiem, float GiaBan, float DienTich)
        {
            this.DiaDiem = DiaDiem;
            this.GiaBan = GiaBan;
            this.DienTich = DienTich;
        }
        
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();

            do
            {
                Console.WriteLine("Nhap gia ban: (VND)");
                GiaBan = float.Parse(Console.ReadLine());
            } while (GiaBan < 0);
            do
            {
                Console.WriteLine("Nhap dien tich: (m2)");
                DienTich = float.Parse(Console.ReadLine());
            } while (DienTich <= 0);
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Dia diem la: " + DiaDiem);
            Console.WriteLine("Gia ban la: {0} VND", GiaBan);
            Console.WriteLine("Dien tich la: {0} m2", DienTich);
        }

        public virtual int LoaiHinh()
        {
            return -1;
        }

        public virtual int getNamXD()
        {
            return 0;
        }
    }
}
