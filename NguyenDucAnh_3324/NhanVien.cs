using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDucAnh_3324
{
    internal abstract class NhanVien
    {
        string maNV;
        string hoTen;
        string soCMND;
        DateTime ngayVaoLam;

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string soCMND,
            DateTime ngayVaoLam)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.SoCMND = soCMND;
            this.NgayVaoLam = ngayVaoLam;
        }

        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string SoCMND
        {
            get => soCMND;
            set => soCMND = value;
        }

        public DateTime NgayVaoLam
        {
            get => ngayVaoLam;
            set => ngayVaoLam = value;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();

            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.WriteLine("Nhap so CMND: ");
            SoCMND = Console.ReadLine();

            Console.WriteLine("Nhap ngay vao lam: ");
            NgayVaoLam = DateTime.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("--------- -------- Ma NV: " + MaNV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("So CMND: " + SoCMND);
            Console.WriteLine(String.Format(
                "Ngay vao lam: {0:dd/MM/yyyy}", NgayVaoLam));
        }

        public abstract int TinhThamNien();

        public abstract double ThucLinh();
    }
}
