using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class NhaPho:BatDongSan
    {
        private int _namXD;
        private int SoTang;
        private int _soluongnhapho;
        public int SLNhaPho
        {
            get { return _soluongnhapho; }
            set { _soluongnhapho = value; }
        }

        public int NamXayDung
        {
            get { return _namXD; }
            set { _namXD = value; }
        }
        public NhaPho()
        {

        }
        public NhaPho(string DiaDiem, float GiaBan, float DienTich, int NamXayDung, int SoTang): base(DiaDiem, GiaBan, DienTich)
        {
            this.NamXayDung = NamXayDung;
            this.SoTang = SoTang;
        }

        public override void Nhap()
        {
            base.Nhap();

            do
            {
                Console.WriteLine("Nhap nam xay dung: ");
                NamXayDung = int.Parse(Console.ReadLine());
            } while (NamXayDung <= 0);

            do
            {
                Console.WriteLine("Nhap so tang: ");
                SoTang = int.Parse(Console.ReadLine());
            } while (SoTang <= 0);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Nam xay dung la: {0}", NamXayDung);
            Console.WriteLine("So tang la: {0}", SoTang);
        }

        public override int LoaiHinh()
        {
            return 2;
        }

        public override int getNamXD()
        {
            return NamXayDung;
        }
    }
}
