using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
