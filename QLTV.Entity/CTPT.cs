using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class CTPT
    {
        private string maCTPT;
        private string maPhieuTra;
        private string maSach;
        private int thanhTien;

        public string MaCTPT
        {
            get
            {
                return maCTPT;
            }

            set
            {
                maCTPT = value;
            }
        }

        public string MaPhieuTra
        {
            get
            {
                return maPhieuTra;
            }

            set
            {
                maPhieuTra = value;
            }
        }

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
        public void CTPTIDataReader(SqlDataReader dr)
        {
            MaCTPT = dr["MaCTPT"] is DBNull ? string.Empty : dr["MaCTPT"].ToString();
            MaPhieuTra = dr["MaPhieuTra"] is DBNull ? string.Empty : dr["MaPhieuTra"].ToString();
            MaSach = dr["MaSach"] is DBNull ? "" : dr["MaSach"].ToString();
            ThanhTien = dr["ThanhTien"] is DBNull ? 0 : int.Parse(dr["thanhTien"].ToString());
        }
    }
}
