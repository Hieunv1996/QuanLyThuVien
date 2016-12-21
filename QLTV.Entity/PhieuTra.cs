using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class PhieuTra
    {
        private string maPhieuTra;
        private string maDocGia;
        private string ngayTra;
        private int thanhTien;

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

        public string MaDocGia
        {
            get
            {
                return maDocGia;
            }

            set
            {
                maDocGia = value;
            }
        }

        public string NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
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
        public void PhieuTraIDataReader(SqlDataReader dr)
        {
            maPhieuTra = dr["maPT"] is DBNull ? string.Empty : dr["maPT"].ToString();
            MaDocGia = dr["MaDocGia"] is DBNull ? string.Empty : dr["MaDocGia"].ToString();
            NgayTra = dr["NgayTra"] is DBNull ? "" : dr["NgayTra"].ToString();
            ThanhTien = dr["ThanhTien"] is DBNull ? 0 : int.Parse(dr["ThanhTien"].ToString());
        }
    }
}
