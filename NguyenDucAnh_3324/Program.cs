namespace NguyenDucAnh_3324
{
    internal class Program
    {
            static void Main(string[] args)
            {
                QuanLyNhanVien ql =
                    new QuanLyNhanVien();

                int menu;

                do
                {
                    Console.WriteLine(
                        "\nQUAN LY NHAN VIEN" +
                        "\n0: Thoat" +
                        "\n1: Nhap 1 - khong doi" +
                        "\n2: Nhap 2 - co doi" +
                        "\n3: Xuat" +
                        "\n4: Tong quy luong" +
                        "\n5: Tim NV may man" +
                        "\n6: Tinh tien thuong" +
                        "\n7: Xoa NV co ThucLinh < 9000" +
                        "\n8: Xuat danh sach sau khi xoa");

                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 0:
                            break;

                        case 1:
                            ql.Nhap1();
                            break;

                        case 2:
                            ql.Nhap2();
                            break;

                        case 3:
                            ql.Xuat();
                            break;

                        case 4:
                            ql.TongQuyLuong();
                            break;

                        case 5:
                            ql.TimNVMayMan();
                            break;

                        case 6:
                            ql.TinhTienThuong();
                            break;

                        case 7:
                            ql.Xoa();
                            break;

                        case 8:
                            Console.WriteLine(
                                "Danh sach sau khi xoa:");

                            ql.Xuat();
                            break;

                        default:
                            Console.WriteLine(
                                "Chi nhap tu 0 - 8");
                            break;
                    }

                } while (menu != 0);

                Console.ReadLine();
            }
        }
    }
