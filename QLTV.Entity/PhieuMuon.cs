using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class PhieuMuon
    {
        private string maPhieuMuon;
        private string maDocGia;
        private string ngayMuon;
        private int thanhTien;

        public string MaPhieuMuon
        {
            get
            {
                return maPhieuMuon;
            }

            set
            {
                maPhieuMuon = value;
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

        public string NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
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
        public void PhieuMuonIDataReader(SqlDataReader dr)
        {
            MaPhieuMuon = dr["MaPhieuMuon"] is DBNull ? string.Empty : dr["MaPhieuMuon"].ToString();
            NgayMuon = dr["NgayMuon"] is DBNull ? string.Empty : dr["NgayMuon"].ToString();
            MaDocGia = dr["MaDocGia"] is DBNull ? "" : dr["MaDocGia"].ToString();
            ThanhTien = dr["ThanhTien"] is DBNull ? 0 : int.Parse(dr["ThanhTien"].ToString());
        }
    }
}
