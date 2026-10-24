using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDucAnh_3324
{
    internal class QuanLyNhanVien
    {
        DanhSachNhanVien ds;

        public QuanLyNhanVien()
        {
            ds = new DanhSachNhanVien();
        }

        public void TongQuyLuong()
        {
            Console.WriteLine(
                "Tong quy luong = " +
                ds.TongQuyLuong());
        }

        public void TinhTienThuong()
        {
            NhanVien x = ds.TimNVMayMan();

            if (x == null)
                return;

            double tienThuong = 0;

            if (x is NhanVienThoiVu)
            {
                NhanVienThoiVu nv =
                    (NhanVienThoiVu)x;

                if (nv.TinhThamNien() > 10)
                    tienThuong = 2000000;

                else if (nv.TinhThamNien() > 5)
                    tienThuong = 1000000;

                else
                    tienThuong = 200000;
            }

            else if (x is NhanVienFullTime)
            {
                NhanVienFullTime nv =
                    (NhanVienFullTime)x;

                if (nv.TinhThamNien() < 3)
                    tienThuong = 1000000;

                else
                    tienThuong = 200000;
            }

            Console.WriteLine(
                "Tien thuong = " + tienThuong);
        }

        public void Nhap1()
        {
            ds.Nhap1();
        }

        public void Nhap2()
        {
            ds.Nhap2();
        }

        public void Xuat()
        {
            ds.Xuat();
        }

        public void TimNVMayMan()
        {
            ds.TimNVMayMan();
        }

        public void Xoa()
        {
            ds.Xoa();
        }
    }
}