using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungThueXe
{
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
}
