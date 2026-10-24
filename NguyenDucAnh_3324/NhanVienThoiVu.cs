using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDucAnh_3324
{
    internal class NhanVienThoiVu : NhanVien, ILUONG
    {
        double mucLuong;

        public NhanVienThoiVu() { }

        public NhanVienThoiVu(string maNV, string hoTen, string soCMND,
            DateTime ngayVaoLam, double mucLuong)
            : base(maNV, hoTen, soCMND, ngayVaoLam)
        {
            this.MucLuong = mucLuong;
        }

        public double MucLuong
        {
            get => mucLuong;
            set => mucLuong = value;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin Nhan Vien Thoi Vu");

            base.Nhap();

            Console.WriteLine("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("Muc luong: " + MucLuong);
            Console.WriteLine("Tham nien: " + TinhThamNien());
            Console.WriteLine("Phu cap: " + TinhPhuCap());
            Console.WriteLine("Thuc linh: " + ThucLinh());
        }

        public override int TinhThamNien()
        {
            return DateTime.Today.Year - NgayVaoLam.Year + 1;
        }

        public double TinhPhuCap()
        {
            return MucLuong * 15 / 100;
        }

        public override double ThucLinh()
        {
            return MucLuong + TinhPhuCap();
        }
    }
}
