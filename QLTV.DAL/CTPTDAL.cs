using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.Entity;
using System.Data;
using System.Data.SqlClient;
namespace QLTV.DAL
{
   public  class CTPTDAL: SqlDataProvider
    {
            public List<CTPT> getAll(string Top, string Where, string Order)
            {
                List<CTPT> lst = new List<CTPT>();
                string selectQuery = "select ";
                if (Top.Length != 0)
                {
                    selectQuery += "Top " + Top;
                }
                selectQuery += "* ";
                selectQuery += "from tb_CTPT ";
                if (Where.Length != 0)
                {
                    selectQuery += "Where " + Where;
                }
                if (Order.Length != 0)
                {
                    selectQuery += "Order by " + Order;
                }

                using (SqlCommand cmd = new SqlCommand(selectQuery, openConnection()))
                {
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CTPT obj = new CTPT();
                        obj.CTPTIDataReader(dr);
                        lst.Add(obj);
                    }
                    dr.Close();
                }
                return lst;
            }

            public bool insertData(CTPT data)
            {
                bool check = false;
                String sql = String.Format("INSERT INTO [dbo].[tb_CTPT](maCTPT, maPT, maSach, thanhTien) VALUES('{0}','{1}','{2}','{3}')", data.MaCTPT, data.MaPhieuTra, data.MaSach, data.ThanhTien);
                openConnection();
                int r = ExecuteNonQuery(sql);
                if (r > 0) check = true;
                closeConnection();
                return check;
            }

            public bool updateData(CTPT data)
            {
                bool check = false;
                String sql = String.Format("UPDATE tb_CTPT SET maPT ='{0}', maSach ='{1}', thanhTien ='{2}' where maCTPT ='{3}'",data.MaPhieuTra,data.MaSach,data.ThanhTien,data.MaCTPT);
                openConnection();
                int r = ExecuteNonQuery(sql);
                if (r > 0) check = true;
                closeConnection();
                return check;
            }

            public bool deleteAllData(string id)
            {
                bool check = false;
                String sql = String.Format("DELETE FROM tb_CTPT where maPT = '{0}'", id);
                openConnection();
                int r = ExecuteNonQuery(sql);
                if (r > 0) check = true;
                closeConnection();
                return check;
            }

            public bool deleteData(string id)
            {
                bool check = false;
                String sql = String.Format("DELETE FROM tb_CTPT where maCTPT = '{0}'", id);
                openConnection();
                int r = ExecuteNonQuery(sql);
                if (r > 0) check = true;
                closeConnection();
                return check;
            }
        }
}
