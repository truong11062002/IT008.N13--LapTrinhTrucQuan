using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{

    public class BDS
    {
        private string diaDiem;
        private float giaBan;
        private float dienTich;

        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }

        public float GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public float DienTich
        {
            get { return dienTich; }
            set { dienTich = value; }
        }

        public BDS()
        {

        }
        public BDS(string diaDiem, float giaBan, float dienTich)
        {
            this.diaDiem = diaDiem;
            this.giaBan = giaBan;
            this.dienTich = dienTich;
        }

        public virtual void Nhap()
        {

        }

        public virtual void Xuat()
        {

        }
    }

    public class KhuDat : BDS
    {
        private int soLuongKhuDat;

        public int SLKhuDat
        {
            get { return soLuongKhuDat; }
            set { soLuongKhuDat = value; }
        }

        public KhuDat()
        {

        }
        public KhuDat(string diaDiem, float giaBan, float dienTich) : base ( diaDiem, giaBan, dienTich)
        {
            
        }

        public override void Nhap()
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

        public override void Xuat()
        {
            Console.WriteLine("Dia diem la: " + DiaDiem);
            Console.WriteLine("Gia ban la: {0} VND", GiaBan);
            Console.WriteLine("Dien tich la: {0} m2", DienTich);
        }
    }

    public class NhaPho : BDS
    {
        private int namXayDung;
        private int soTang;
        private int soLuongNhaPho;

        public int NamXayDung
        {
            get { return namXayDung; }
            set { namXayDung = value; }
        }

        public int SoTang
        {
            get { return soTang; }
            set { soTang = value; }
        }

        public int SLNhaPho
        {
            get { return soLuongNhaPho; }
            set { soLuongNhaPho = value; }
        }

        public NhaPho()
        {

        }
        
        public NhaPho(string diaDiem, float giaBan, float dienTich, int NamXayDung, int SoTang) : base(diaDiem, giaBan, dienTich)
        {
            this.NamXayDung = NamXayDung;
            this.SoTang = SoTang;
        }


        public override void Nhap()
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
            Console.WriteLine("Dia diem la: " + DiaDiem);
            Console.WriteLine("Gia ban la: {0} VND", GiaBan);
            Console.WriteLine("Dien tich la: {0} m2", DienTich);
            Console.WriteLine("Nam xay dung la: ", NamXayDung);
            Console.WriteLine("So tang la: ", SoTang);
        }
    }

    class ChungCu : BDS
    {
        private int soLuongChungCu;
        private int tang;

        public int SLChungCu
        {
            get { return soLuongChungCu; }
            set { soLuongChungCu = value; }
        }


        public ChungCu()
        {

        }

        public ChungCu(string diaDiem, float giaBan, float dienTich, int tang) : base (diaDiem, giaBan, dienTich)
        {
            this.tang = tang;
        }

        public override void Nhap()
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

            do
            {
                Console.WriteLine("Tang nha: ");
                tang = int.Parse(Console.ReadLine());
            } while (tang <= 0);

        }

        public override void Xuat()
        {
            Console.WriteLine("Dia diem la: " + DiaDiem);
            Console.WriteLine("Gia ban la: {0} VND", GiaBan);
            Console.WriteLine("Dien tich la: {0} m2", DienTich);
            Console.WriteLine("Tang nha: ", tang);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<BDS> listItems = ListBDS();
        }

        private static List<BDS> ListBDS()
        {
            List<BDS> list = new List<BDS>();
            int item;
            Console.WriteLine("-----> Chon loai hinh mong muon <-------");
            Console.WriteLine("1. Khu dat");
            Console.WriteLine("2. Nha pho");
            Console.WriteLine("3. Chung cu");

            item = int.Parse(Console.ReadLine());
            switch (item)
            {
                case 1:
                    // Khu đất
                    Console.WriteLine("Nhap so luong khu dat: ");
                    int numOfLand = int.Parse(Console.ReadLine());
                    while (numOfLand > 0)
                    {
                        KhuDat land = new KhuDat();
                        land.Nhap();
                        list.Add(land);
                        numOfLand--;
                    }
                    break;
                case 2:
                    // Nhà phố
                    Console.WriteLine("Nhap so luong nha pho: ");
                    int numOfHouse = int.Parse(Console.ReadLine());

                    while (numOfHouse > 0)
                    {
                        NhaPho house = new NhaPho();
                        house.Nhap();
                        list.Add(house);
                        numOfHouse--;
                    }
                    break;
                case 3:
                    // Chung cư
                    Console.WriteLine("Nhap so luong chung cu: ");
                    int numOfApartment = int.Parse(Console.ReadLine());

                    while (numOfApartment > 0)
                    {
                        ChungCu apartment = new ChungCu();
                        apartment.Nhap();
                        list.Add(apartment);
                        numOfApartment--;
                    }
                    break;
                default:
                    break;
            }
            return list;
        }
    }
}
