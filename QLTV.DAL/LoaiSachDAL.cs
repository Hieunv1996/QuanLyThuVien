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
    public class LoaiSachDAL: SqlDataProvider
    {
        public List<LoaiSach> getAll(string Top, string Where, string Order)
        {
            List<LoaiSach> lst = new List<LoaiSach>();
            string selectQuery = "select ";
            if (Top.Length != 0)
            {
                selectQuery += "Top " + Top;
            }
            selectQuery += "* ";
            selectQuery += "from tb_LoaiSach ";
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
                    LoaiSach obj = new LoaiSach();
                    obj.LoaiSachIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public bool insertData(LoaiSach data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_LoaiSach (maLoaiSach, tenLoaiSach, moTa) VALUES('{0}',N'{1}',N'{2}')",data.MaLoaiSach,data.TenLoaiSach,data.MoTa);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(LoaiSach data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_LoaiSach SET tenLoaiSach = N'{0}', moTa = N'{1}' where maLoaiSach = '{2}'",data.TenLoaiSach,data.MoTa,data.MaLoaiSach);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData(string id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_LoaiSach where maLoaiSach = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
    }
}
