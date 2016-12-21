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
        private string maPM;
        private string maDocGia;
        private string ngayMuon;
        private int thanhTien;

        public string MaPM
        {
            get
            {
                return maPM;
            }

            set
            {
                maPM = value;
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
            MaPM = dr["maPM"] is DBNull ? "" : dr["maPM"].ToString();
            MaDocGia = dr["maDocGia"] is DBNull ? "" : dr["maDocGia"].ToString();
            NgayMuon = dr["ngayMuon"] is DBNull ? "" : dr["ngayMuon"].ToString();
            ThanhTien = dr["thanhTien"] is DBNull ? 0 : int.Parse(dr["thanhTien"].ToString());
        }
    }
}
