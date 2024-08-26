using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungThueXe
{
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
}
