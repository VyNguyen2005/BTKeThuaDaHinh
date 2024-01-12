using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham quanly = new QuanLySanPham();
            quanly.Nhap();
            quanly.InDanhSachSP();

            Console.ReadLine();
        }
    }
}
