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
    }
}
