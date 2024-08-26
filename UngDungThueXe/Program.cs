using System;
using System.Collections.Generic;
//Bài 1_2:  Tạo ứng dụng trên Console như sau để quản lý thuê xe:
//Một gia đình làm dịch vụ cho thuê xe ô tô cần quản lý việc cho thuê xe. Gia đình có 2 loại xe: Xe du lịch và xe tải. 
//Thông tin thuê xe bao gồm: Họ tên người thuê, số giờ thuê. 
//Tiền thuê xe du lịch được tính như sau: 250.000đ cho giờ đầu và 70.000đ cho các giờ tiếp theo.
//Tiền thuê xe tải được tính như sau: 220.000đ cho giờ đầu và 85.000đ cho các giờ tiếp theo.
//Viết chương trình thực hiện các yêu cầu:
//Nhập danh sách thông tin thuê xe (bao gồm cả xe tải và xe du lịch)
//In ra màn hình tất cả thông tin thuê xe bao gồm: họ tên người thuê, số giờ thuê, thành tiền

namespace UngDungThueXe
{
    class XeDuLich
    {
        private int soluong;
        private int dongiagiodau;
        private int dongiagiotieptheo;

        public XeDuLich()
        {
            soluong = 10;
            dongiagiodau = 250000;
            dongiagiotieptheo = 70000;
        }

        public int getSoLuong()
        {
            return soluong;
        }

        public void setSoLuong(int soluong)
        {
            this.soluong = soluong;
        }

        public int getDonGiaGioDau()
        {
            return dongiagiodau;
        }

        public int getDonGiaGioTiepTheo()
        {
            return dongiagiotieptheo;
        }
    }

    class XeTai
    {
        private int soluong;
        private int dongiagiodau;
        private int dongiagiotieptheo;

        public XeTai()
        {
            soluong = 10;
            dongiagiodau = 220000;
            dongiagiotieptheo = 85000;
        }

        public int getSoLuong()
        {
            return soluong;
        }

        public void setSoLuong(int soluong)
        {
            this.soluong = soluong;
        }

        public int getDonGiaGioDau()
        {
            return dongiagiodau;
        }

        public int getDonGiaGioTiepTheo()
        {
            return dongiagiotieptheo;
        }
    }

    class Customer
    {
        private string hoten;
        private int sogiothuexetai;
        private int soluongthuexetai;
        private int sogiothuedulich;
        private int soluongthuexedulich;
        private int thanhtien;
        public Customer()
        {
            hoten = "";
            sogiothuedulich = 0;
            soluongthuexedulich = 0;
            sogiothuexetai = 0;
            soluongthuexetai = 0;
            thanhtien = 0;
        }

        public Customer(string hoten, int sogiothuexetai, int soluongthuexetai, int sogiothuedulich, int soluongthuexedulich)
        {
            this.hoten = hoten;
            this.sogiothuexetai = sogiothuexetai;
            this.soluongthuexetai = soluongthuexetai;
            this.sogiothuedulich = sogiothuedulich;
            this.soluongthuexedulich = soluongthuexedulich;
            thanhtien = 0;
        }

        public void Nhap()
        {
            nhaplai:
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            try
            {
                Console.Write("Nhap so gio thue xe tai: ");
                sogiothuexetai = int.Parse(Console.ReadLine());
                if (sogiothuexetai < 0)
                    throw new Exception("So gio thue xe tai phai lon hon 0");
                Console.Write("Nhap so luong thue xe tai: ");
                soluongthuexetai = int.Parse(Console.ReadLine());
                if (soluongthuexetai < 0)
                    throw new Exception("So luong thue xe tai phai lon hon 0");
                Console.Write("Nhap so gio thue xe du lich: ");
                sogiothuedulich = int.Parse(Console.ReadLine());
                if (sogiothuedulich < 0)
                    throw new Exception("So gio thue xe du lich phai lon hon 0");
                Console.Write("Nhap so luong thue xe du lich: ");
                soluongthuexedulich = int.Parse(Console.ReadLine());
                if (soluongthuexedulich < 0)
                    throw new Exception("So luong thue xe du lich phai lon hon 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto nhaplai;
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("So gio thue xe tai: " + sogiothuexetai);
            Console.WriteLine("So luong thue xe tai: " + soluongthuexetai);
            Console.WriteLine("So gio thue xe du lich: " + sogiothuedulich);
            Console.WriteLine("So luong thue xe du lich: " + soluongthuexedulich);
            Console.WriteLine("Thanh tien: " + thanhtien);
        }

        public int soGioThueXeTai()
        {
            return sogiothuexetai;
        }

        public int soLuongThueXeTai()
        {
            return soluongthuexetai;
        }

        public int soGioThueXeDuLich()
        {
            return sogiothuedulich;
        }

        public int soLuongThueXeDuLich()
        {
            return soluongthuexedulich;
        }

        public string getHoTen()
        {
            return hoten;
        }

        public int getThanhTien()
        {
            return thanhtien;
        }

        public void setThanhTien(int thanhtien)
        {
            this.thanhtien = thanhtien;
        }
    }

    class UDThueXe
    {
        private XeDuLich XeDuLich;
        private XeTai XeTai;
        private List<Customer> list;

        public UDThueXe()
        {
            list = new List<Customer>();
            XeDuLich = new XeDuLich();
            XeTai = new XeTai();
        }

        public bool check_available_xetai_xedulich(int slxeTai, int slxeDulich)
        {
            if (XeDuLich.getSoLuong() - slxeDulich >= 0 && XeTai.getSoLuong() - slxeTai >= 0)
                return true;
            return false;
        }

        public int tinhtien_2xe(int sogiothuexetai, int soluongthuexetai, int sogiothuedulich, int soluongthuexedulich)
        {
            return XeDuLich.getDonGiaGioDau() * sogiothuedulich + XeDuLich.getDonGiaGioTiepTheo() * (sogiothuedulich - 1) + XeTai.getDonGiaGioDau() * sogiothuexetai + XeTai.getDonGiaGioTiepTheo() * (sogiothuexetai - 1);
        }

        public void Nhap()
        {
            Console.Write("Nhap so nguoi thue: ");
            int n = int.Parse(Console.ReadLine());
            int slxetai = XeTai.getSoLuong();
            int slxedulich = XeDuLich.getSoLuong();
            for (int i = 0; i < n; i++)
            {
                Customer c = new Customer();
                Console.WriteLine("=====================================");
                c.Nhap();
                Console.WriteLine("=====================================");
                if (check_available_xetai_xedulich(c.soLuongThueXeTai(), c.soLuongThueXeDuLich()))
                {
                    XeDuLich.setSoLuong(slxedulich - c.soLuongThueXeDuLich());
                    XeTai.setSoLuong(slxetai - c.soLuongThueXeTai());
                    c.setThanhTien(tinhtien_2xe(c.soGioThueXeTai(), c.soLuongThueXeTai(), c.soGioThueXeDuLich(), c.soLuongThueXeDuLich()));
                    list.Add(c);
                }
                else
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Khong du xe de cho thue");
                    Console.WriteLine("So xe tai con lai: " + XeTai.getSoLuong());
                    Console.WriteLine("So xe du lich con lai: " + XeDuLich.getSoLuong());
                    Console.WriteLine("Nhap lai thong tin");
                    Console.WriteLine("=====================================");
                    i--;
                }
            }
        }

        public void Xuat()
        {
            foreach (Customer c in list)
            {
                Console.WriteLine("=====================================");
                c.Xuat();
                Console.WriteLine("=====================================");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UDThueXe udthuexe = new UDThueXe();
            udthuexe.Nhap();
            udthuexe.Xuat();
            Console.ReadKey();
        }
    }
}
