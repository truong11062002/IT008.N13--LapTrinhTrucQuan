using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BatDongSan> listItem = DanhSachBDS();
            // Show danh sách
            ShowListSearch(listItem);

            // Tổng giá bán 3 loại
            CalcPrice(listItem);

            // Show tất cả danh sách BDS
            ShowDanhSachBDS(listItem);

            // Danh sách tìm kiếm theo yêu cầu
            SearchRequirement(listItem);
        }

        public static List<BatDongSan> DanhSachBDS()
        {
            List<BatDongSan> listBDS = new List<BatDongSan>();
            int item;
            do
            {
                Console.WriteLine("-----> Chon loai hinh muon mo rong <-------");
                Console.WriteLine("1. Khu dat");
                Console.WriteLine("2. Nha pho");
                Console.WriteLine("3. Chung cu");
                Console.WriteLine("4. Exit");
                item = int.Parse(Console.ReadLine());
                switch (item)
                {
                    case 1:
                        // Khu đất
                        Console.WriteLine("Nhap so luong khu dat: ");
                        int numOfLand = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numOfLand; i++)
                        {
                            Console.WriteLine("Nhap khu dat thu {0}", i + 1);
                            KhuDat land = new KhuDat();
                            land.Nhap();
                            listBDS.Add(land);
                        }
                        break;
                    case 2:
                        // Nhà phố
                        Console.WriteLine("Nhap so luong nha pho: ");
                        int numOfHouse = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numOfHouse; i++)
                        {
                            Console.WriteLine("Nhap nha pho thu {0}", i + 1);
                            NhaPho house = new NhaPho();
                            house.Nhap();
                            listBDS.Add(house);
                        }
                        break;
                    case 3:
                        // Chung cư
                        Console.WriteLine("Nhap so luong chung cu: ");
                        int numOfApartment = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numOfApartment; i++)
                        {
                            Console.WriteLine("Nhap chung cu thu {0}", i + 1);
                            ChungCu apartment = new ChungCu();
                            apartment.Nhap();
                            listBDS.Add(apartment);
                        }
                        break;
                    default:
                        break;
                }
            } while (item != 4);
            return listBDS;
        }

        public static void ShowDanhSachBDS(List<BatDongSan> listBDS)
        {
            Console.WriteLine("Danh sach moi vua nhap la: ");

            foreach (BatDongSan congty in listBDS)
            {
                congty.Xuat();
                Console.WriteLine("");
            }
        }

        private static void CalcPrice(List<BatDongSan> listBDS)
        {
            float TongGiaBanKhuDat = 0;
            float TongGiaBanNhaPho = 0;
            float TongGiaBanChungCu = 0;

            foreach (BatDongSan BDS in listBDS)
            {
                if (BDS.LoaiHinh() == 1)
                {
                    TongGiaBanKhuDat += BDS.GiaBan;
                }

                if (BDS.LoaiHinh() == 2)
                {
                    TongGiaBanNhaPho += BDS.GiaBan;
                }

                if (BDS.LoaiHinh() == 3)
                {
                    TongGiaBanChungCu += BDS.GiaBan;
                }
            }

            Console.WriteLine("Tong gia ban cua khu dat la: " + TongGiaBanKhuDat + " VND");
            Console.WriteLine("Tong gia ban cua nha pho la: " + TongGiaBanNhaPho + " VND");
            Console.WriteLine("Tong gia ban cua chung cu la: " + TongGiaBanChungCu + " VND");
            Console.WriteLine("");
        }

        private static void ShowListSearch(List<BatDongSan> listBDS)
        {
            foreach (BatDongSan BDS in listBDS)
            {
                if (BDS.LoaiHinh() == 1 && BDS.DienTich > 100)
                {
                    BDS.Xuat();
                }

                if (BDS.LoaiHinh() == 2 && BDS.DienTich > 60 && BDS.getNamXD() >= 2019)
                {
                    BDS.Xuat();
                }
            }
        }

        private static void SearchRequirement(List<BatDongSan> listBDS)
        {
            Console.WriteLine("Nhap dia diem can tim kiem: ");
            string _diadiem = Console.ReadLine();
            Console.WriteLine("Nhap gia ban can tim kiem: ");
            int _giaban = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich can tim kiem: ");
            int _dientich = int.Parse(Console.ReadLine());

            Console.WriteLine("Danh sach thong tin bat dong san thoa man yeu cau");

            int count;


            count = 0;
            foreach (BatDongSan BDS in listBDS)
            {
                if (BDS.DiaDiem.ToUpper() == _diadiem.ToUpper() && BDS.GiaBan <= _giaban && BDS.DienTich >= _dientich)
                {
                    BDS.Xuat();
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Khong tim thay thong tin bat dong san da yeu cau!");
            }

        }
    }
}
