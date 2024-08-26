using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungThueXe
{
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
}
