using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    class SinhVien
    {
        private string _mssv;
        private string _hoten;
        private string _chuyennganh;
        private string _gioitinh;
        private string _somon;

        public SinhVien()
        {

        }
        public SinhVien(string mssv, string hoten, string chuyennganh, string gioitinh, string somon)
        {
            _mssv = mssv;
            _hoten = hoten;
            _chuyennganh = chuyennganh;
            _gioitinh = gioitinh;
            _somon = somon;
        }


        public string Mssv { get => _mssv; set => _mssv = value; }
        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Chuyennganh { get => _chuyennganh; set => _chuyennganh = value; }
        public string Gioitinh { get => _gioitinh; set => _gioitinh = value; }
        public string Somon { get => _somon; set => _somon = value; }
    }
}
