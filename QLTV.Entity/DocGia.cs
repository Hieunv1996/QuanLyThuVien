using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class DocGia
    {
        private string maDocGia;
        private string tenDocGia;
        private String email;
        private String dienThoai;

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

        public string TenDocGia
        {
            get
            {
                return tenDocGia;
            }

            set
            {
                tenDocGia = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return dienThoai;
            }

            set
            {
                dienThoai = value;
            }
        }
        public void DocGiaIDataReader(SqlDataReader dr)
        {
            MaDocGia = dr["MaDocGia"] is DBNull ? string.Empty : dr["MaDocGia"].ToString();
            TenDocGia = dr["tenDocGia"] is DBNull ? string.Empty : dr["tenDocGia"].ToString();
            Email = dr["Email"] is DBNull ? "" : dr["Email"].ToString();
            DienThoai = dr["DienThoai"] is DBNull ? "" : dr["DienThoai"].ToString();
        }
    }
}
