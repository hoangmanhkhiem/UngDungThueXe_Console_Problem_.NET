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
