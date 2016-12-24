using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLTV.Entity;

namespace QLTV.DAL
{
    public class NguoiDungDAL : SqlDataProvider
    {
        public bool getLogin(String u, String p)
        {
            bool check = false;
            String query = String.Format("Select count(*) from tb_NguoiDung where taiKhoan = '{0}' and matKhau = '{1}'",u,p);
            try
            {
                openConnection();
                int row = (int)ExecuteScalar(query);
                if(row > 0)
                {
                    check = true;
                }
                closeConnection();
            }
            catch
            {
            }
            return check;
        }
        public bool updateData(NguoiDung data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_NguoiDUng SET matKhau = '{0}' where taiKhoan = '{1}'", data.MatKhau, data.TaiKhoan);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
    }
}
