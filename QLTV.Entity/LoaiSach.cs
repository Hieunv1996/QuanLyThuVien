using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class LoaiSach
    {
        private string _maLoaiSach;
        private string _tenLoaiSach;
        private string _moTa;

        public string MaLoaiSach
        {
            get
            {
                return _maLoaiSach;
            }

            set
            {
                _maLoaiSach = value;
            }
        }

        public string TenLoaiSach
        {
            get
            {
                return _tenLoaiSach;
            }

            set
            {
                _tenLoaiSach = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _moTa;
            }

            set
            {
                _moTa = value;
            }
        }
        public void LoaiSachIDataReader(SqlDataReader dr)
        {
            MaLoaiSach = dr["maLoaiSach"] is DBNull ? string.Empty : dr["maLoaiSach"].ToString();
            TenLoaiSach = dr["tenLoaiSach"] is DBNull ? string.Empty : dr["tenLoaiSach"].ToString();
            MoTa = dr["moTa"] is DBNull ? "" : dr["moTa"].ToString();
        }
    }
}
