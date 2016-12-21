using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class CTPM
    {
        private string maCTPM;
        private string maPM;
        private string maSach;
        private string ngayTra;
        private int tienCoc;

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

        public int TienCoc
        {
            get
            {
                return tienCoc;
            }

            set
            {
                tienCoc = value;
            }
        }
        public void CTPMIDataReader(SqlDataReader dr)
        {
            MaCTPM = dr["MaCTPM"] is DBNull ? string.Empty : dr["MaCTPM"].ToString();
            MaPM = dr["MaPM"] is DBNull ? string.Empty : dr["MaPM"].ToString();
            MaSach = dr["MaSach"] is DBNull ? "" : dr["MaSach"].ToString();
            NgayTra = dr["NgayTra"] is DBNull ? "" : dr["NgayTra"].ToString();
            TienCoc = dr["TienCoc"] is DBNull ? 0 : int.Parse(dr["TienCoc"].ToString());
        }
    }
}
