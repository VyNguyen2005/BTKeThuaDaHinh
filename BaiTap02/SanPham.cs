using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class SanPham
    {
        private string _ten;
        private double _giaMua;


        public SanPham()
        {

        }
        public SanPham(string _ten, double _giaMua)
        {
            this._ten = _ten;
            this._giaMua = _giaMua;
        }
        public string Ten
        {
            set { _ten = value; }
            get { return _ten; }
        }
        public double GiaMua
        {
            set
            {
                if (_giaMua >= 0)
                    _giaMua = value;
            }
            get { return _giaMua; }
        }

        public virtual double TinhGiaBan()
        {
            return 0;
        }

        public virtual void InChiTiet()
        {
            Console.WriteLine($"Ten san pham: {_ten}");
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            _ten = Console.ReadLine();
            Console.Write("Nhap gia mua san pham: ");
            _giaMua = double.Parse(Console.ReadLine());
        }
    }

    class Socola : SanPham
    {
        private double _loinhuan;
        public Socola()
        {

        }
        public Socola(double _loinhuan, string _ten, double _giaMua) : base(_ten, _giaMua)
        {
            this._loinhuan = _loinhuan;
        }
        public override double TinhGiaBan()
        {
            _loinhuan = GiaMua * 0.2;
            return GiaMua + _loinhuan;
        }
        public override void InChiTiet()
        {
            base.InChiTiet();
            Console.WriteLine($"Gia ban: {TinhGiaBan()}");
        }
        public override void Nhap()
        {
            base.Nhap();
        }
    }

    class NuocUong : SanPham
    {
        private double _chiPhigiulanh;
        private double _loinhuan;
        public NuocUong()
        {

        }
        public NuocUong(double _chiPhigiulanh, double _loinhuan, string _ten, double _giaMua) : base(_ten, _giaMua)
        {
            this._loinhuan = _loinhuan;
            this._chiPhigiulanh = _chiPhigiulanh;
        }
        public override double TinhGiaBan()
        {
            _loinhuan = GiaMua * 0.15;
            _chiPhigiulanh = GiaMua * 0.1;
            return GiaMua + _loinhuan + _chiPhigiulanh;
        }

        public override void InChiTiet()
        {
            base.InChiTiet();
            Console.WriteLine($"Gia ban: {TinhGiaBan()}");
        }
        public override void Nhap()
        {
            base.Nhap();
        }
    }

    class QuanLySanPham
    {
        private string ten = "Cua hang ban le";
        private SanPham[] DanhSachSP;

        public void Nhap()
        {
            Console.Write("Nhap so luong san pham: ");
            int soluong = int.Parse(Console.ReadLine());

            DanhSachSP = new SanPham[soluong];

            for (int i = 0; i < soluong; i++)
            {
                Console.Write("Nhap loai san pham ( 1 - Socola, 2 - NuocUong): ");
                int loaiSP = int.Parse(Console.ReadLine());

                if (loaiSP == 1)
                {
                    DanhSachSP[i] = new Socola();
                }
                else if (loaiSP == 2)
                {
                    DanhSachSP[i] = new NuocUong();
                }
                DanhSachSP[i].Nhap();
            }
        }
        public void InDanhSachSP()
        {
            Console.WriteLine($"----Danh sach san pham trong {ten}----");
            for (int i = 0; i < DanhSachSP.Length; i++)
            {
                DanhSachSP[i].InChiTiet();
            }
        }
    }
}

