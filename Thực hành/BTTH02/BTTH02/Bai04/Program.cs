using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class PhanSo
    {
        private int tu, mau;
        public int tuSo
        {
            get { return tu; }
            set { tu = value; }
        }
        public int mauSo
        {
            get { return mau; }
            set { mau = value; }
        }

        public float this[string idx]
        {
            get
            {
                return 1.0f;
            }
            set
            {
                System.Console.Write(idx + " = " + value);
            }
        }
        public void NhapPhanSo()
        {
            Console.WriteLine("Tu so = ");
            this.tuSo = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Mau so = ");
                this.mauSo = int.Parse(Console.ReadLine());
            } while (mauSo == 0);
        }

        public void InPhanSo()
        {
            Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }

        public PhanSo Cong2PhanSo(PhanSo p1, PhanSo p2)
        {
            PhanSo result = new PhanSo();
            result = p1 + p2;
            return result;
        }

        public PhanSo Hieu2PhanSo(PhanSo p1, PhanSo p2)
        {
            PhanSo result = new PhanSo();
            result = p1 - p2;
            return result;
        }

        public PhanSo Nhan2PhanSo(PhanSo p1, PhanSo p2)
        {
            PhanSo result = new PhanSo();
            result = p1 * p2;
            return result;
        }

        public PhanSo Chia2PhanSo(PhanSo p1, PhanSo p2)
        {
            PhanSo result = new PhanSo();
            result = p1 / p2;
            return result;
        }

        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            PhanSo phanSoKQ = new PhanSo();
            phanSoKQ.tuSo = p1.tuSo * p2.mauSo + p1.mauSo * p2.tuSo;
            phanSoKQ.mauSo = p1.mauSo * p2.mauSo;
            return phanSoKQ;
        }

        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo phanSoKQ = new PhanSo();
            phanSoKQ.tuSo = p1.tuSo * p2.mauSo - p1.mauSo * p2.tuSo;
            phanSoKQ.mauSo = p1.mauSo * p2.mauSo;
            return phanSoKQ;
        }

        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo phanSoKQ = new PhanSo();
            phanSoKQ.tuSo = p1.tuSo * p2.tuSo;
            phanSoKQ.mauSo = p1.mauSo * p2.mauSo;
            return phanSoKQ;
        }

        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo phanSoKQ = new PhanSo();
            phanSoKQ.tuSo = p1.tuSo * p2.mauSo;
            phanSoKQ.mauSo = p1.mauSo * p2.tuSo;
            return phanSoKQ;
        }
        public static bool operator >(PhanSo p1, PhanSo p2)
        {
            return (float)p1.tuSo / (float)p1.mauSo > (float)p2.tuSo / (float)p2.mauSo;
        }
        public static bool operator <(PhanSo p1, PhanSo p2)
        {
            return (float)p1.tuSo / (float)p1.mauSo < (float)p2.tuSo / (float)p2.mauSo;
        }
        public PhanSo RutGonPhanSo()
        {
            PhanSo RutGon = new PhanSo();

            int uoc = ucln(tuSo, mauSo);

            if (uoc != 0)
            {
                RutGon.tuSo = tuSo / uoc;
                RutGon.mauSo = mauSo / uoc;
            }

            else
            {
                RutGon.tuSo = tuSo;
                RutGon.mauSo = mauSo;
            }

            return RutGon;
        }

        public int ucln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // Nếu phân số 1 > phân số 2 return true, ngược lại return false
        public bool SoSanh(PhanSo p)
        {
            return (float)tuSo / (float)mauSo > (float)p.tuSo / (float)p.mauSo;
        }
    }

    public class DayPhanSo
    {
        PhanSo[] ps;
        int n;
        public void Nhap()
        {
            Console.WriteLine("Nhap so luong phan so: ");
            n = int.Parse(Console.ReadLine());

            ps = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                ps[i] = new PhanSo();
                Console.WriteLine("Phan so thu {0}", i + 1);

                ps[i].NhapPhanSo();
                ps[i] = ps[i].RutGonPhanSo();
            }
        }

        public void Xuat()
        {

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Phan so thu {0}", i + 1);
                ps[i].InPhanSo();
            }
        }

        public void HoanViPhanSo(ref PhanSo a,ref PhanSo b)
        {
            PhanSo temp;
            temp = a;
            a = b;
            b = temp;
        }
        public void SapXepTangDan()
        {
            
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (ps[i] > ps[j]) // Nếu phân số trước đầu lớn hơn phân số sau
                    {
                        // Thực hiện hoán vị 2 phân số
                        HoanViPhanSo(ref ps[i],ref ps[j]);
                    }
                }
            }
        }

        public void TongLonNhat()
        {
            PhanSo max = ps[0];
            for (int i = 0; i < n; i++)
            {
                if (ps[i].SoSanh(max))
                {
                    max = ps[i];
                }
            }
            max.InPhanSo();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo();
            PhanSo p3 = new PhanSo();

            // Tổng/Hiệu/Tích/Thương của 2 phân số

            Console.WriteLine("Nhap phan so 1: ");
            p1.NhapPhanSo();
            Console.WriteLine("Nhap phan so 2: ");
            p2.NhapPhanSo();

            p3 = p3.Cong2PhanSo(p1, p2);
            Console.WriteLine("Tong 2 phan so la: ");
            p3.InPhanSo();
            p3 = p3.Hieu2PhanSo(p1, p2);
            Console.WriteLine("Hieu 2 phan so la: ");
            p3.InPhanSo();
            p3 = p3.Nhan2PhanSo(p1, p2);
            Console.WriteLine("Nhan 2 phan so la: ");
            p3.InPhanSo();
            p3 = p3.Chia2PhanSo(p1, p2);
            Console.WriteLine("Thuong 2 phan so la: ");
            p3.InPhanSo();


            DayPhanSo a = new DayPhanSo();
            a.Nhap();
            // Câu 2: Sắp xếp phân số tăng dần
            a.SapXepTangDan();
            

            // Câu 1: Phân số lớn nhất
            Console.WriteLine("Phan so lon nhat la: ");
            a.TongLonNhat();

            a.Xuat();
            Console.ReadKey();
        }
    }
}
