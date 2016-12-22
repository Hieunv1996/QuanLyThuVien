using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class SachTra
    {
        private string maSach;
        private int phatQuaHan;
        private int phatHuHong;
        private int thanhTien;
        private string maCTPM;

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public int PhatQuaHan
        {
            get
            {
                return phatQuaHan;
            }

            set
            {
                phatQuaHan = value;
            }
        }

        public int PhatHuHong
        {
            get
            {
                return phatHuHong;
            }

            set
            {
                phatHuHong = value;
            }
        }

        public int ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        public string MaCTPM
        {
            get
            {
                return maCTPM;
            }

            set
            {
                maCTPM = value;
            }
        }
    }
}
