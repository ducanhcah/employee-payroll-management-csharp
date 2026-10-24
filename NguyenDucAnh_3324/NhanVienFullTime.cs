using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDucAnh_3324
{
    internal class NhanVienFullTime : NhanVien, ILUONG
    {
        float heSoLuong;
        float luongCoBan;

        public NhanVienFullTime() { }

        public NhanVienFullTime(string maNV, string hoTen, string soCMND,
            DateTime ngayVaoLam, float heSoLuong, float luongCoBan)
            : base(maNV, hoTen, soCMND, ngayVaoLam)
        {
            this.HeSoLuong = heSoLuong;
            this.LuongCoBan = luongCoBan;
        }

        public float HeSoLuong
        {
            get => heSoLuong;
            set => heSoLuong = value;
        }

        public float LuongCoBan
        {
            get => luongCoBan;
            set => luongCoBan = value;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin Nhan Vien Full Time");

            base.Nhap();

            Console.WriteLine("Nhap he so luong: ");
            HeSoLuong = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap luong co ban: ");
            LuongCoBan = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Luong co ban: " + LuongCoBan);
            Console.WriteLine("Tham nien: " + TinhThamNien());
            Console.WriteLine("Phu cap: " + TinhPhuCap());
            Console.WriteLine("Thuc linh: " + ThucLinh());
        }

        public override int TinhThamNien()
        {
            return DateTime.Today.Year - NgayVaoLam.Year;
        }

        public double TinhPhuCap()
        {
            return LuongCoBan * 5 / 100;
        }

        public override double ThucLinh()
        {
            return HeSoLuong * LuongCoBan + TinhPhuCap();
        }
    }
}