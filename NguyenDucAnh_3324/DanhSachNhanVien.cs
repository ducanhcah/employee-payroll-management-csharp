using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenDucAnh_3324
{
    internal class DanhSachNhanVien
    {
        Dictionary<string, NhanVien> ds =
            new Dictionary<string, NhanVien>();

        // Nhap theo doi tuong
        public void Nhap1()
        {
            while (true)
            {
                Console.WriteLine(
                    "Nhap 0: Thoat   F: Full Time   T: Thoi Vu");

                char option = char.Parse(Console.ReadLine());

                if (option == '0')
                    break;

                else if (option == 'F')
                {
                    NhanVien x = new NhanVienFullTime();

                    x.Nhap();

                    ds.Add(x.MaNV, x);
                }

                else if (option == 'T')
                {
                    NhanVien x = new NhanVienThoiVu();

                    x.Nhap();

                    ds.Add(x.MaNV, x);
                }

                else
                {
                    Console.WriteLine(
                        "Chi nhap 0 hoac F hoac T");
                }
            }
        }

        // Nhap theo ham khoi tao co doi
        public void Nhap2()
        {
            NhanVienFullTime x1 =
                new NhanVienFullTime(
                    "NV01",
                    "Nguyen Van A",
                    "111111111",
                    DateTime.Parse("1/1/2015"),
                    2,
                    5000);

            ds.Add("NV01", x1);

            NhanVienFullTime x2 =
                new NhanVienFullTime(
                    "NV02",
                    "Nguyen Van B",
                    "222222222",
                    DateTime.Parse("2/2/2024"),
                    1.5f,
                    6000);

            ds.Add("NV02", x2);

            NhanVienThoiVu x3 =
                new NhanVienThoiVu(
                    "NV03",
                    "Nguyen Van C",
                    "333333333",
                    DateTime.Parse("3/3/2010"),
                    7000);

            ds.Add("NV03", x3);

            NhanVienThoiVu x4 =
                new NhanVienThoiVu(
                    "NV04",
                    "Nguyen Van D",
                    "444444444",
                    DateTime.Parse("4/4/2023"),
                    5000);

            ds.Add("NV04", x4);

            Console.WriteLine("Nhap 2 thanh cong");
        }

        // Xuat
        public void Xuat()
        {
            foreach (NhanVien x in ds.Values)
                x.Xuat();
        }

        // Tong quy luong
        public double TongQuyLuong()
        {
            double tong = 0;

            foreach (NhanVien x in ds.Values)
                tong = tong + x.ThucLinh();

            return tong;
        }

        // Tim nhan vien may man
        public NhanVien TimNVMayMan()
        {
            Console.WriteLine("Nhap ma NV may man can tim:");

            string maTim = Console.ReadLine();

            if (ds.ContainsKey(maTim))
            {
                Console.WriteLine(
                    "Co nhan vien may man, thong tin:");

                ds[maTim].Xuat();

                return ds[maTim];
            }

            Console.WriteLine("Khong tim thay nhan vien");

            return null;
        }

        // Xoa nhan vien co ThucLinh < 9000
        public Dictionary<string, NhanVien> Xoa()
        {
            List<string> dsXoa = new List<string>();

            foreach (NhanVien x in ds.Values)
            {
                if (x.ThucLinh() < 9000)
                {
                    dsXoa.Add(x.MaNV);
                }
            }

            foreach (string ma in dsXoa)
            {
                ds.Remove(ma);
            }

            Console.WriteLine(
                "Da xoa nhung nhan vien co ThucLinh < 9000");

            return ds;
        }
    }
}