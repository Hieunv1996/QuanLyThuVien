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
    public class DocGiaDAL: SqlDataProvider
    {
        public List<DocGia> getAll(string Top, string Where, string Order)
        {
            List<DocGia> lst = new List<DocGia>();
            string selectQuery = "select ";
            if (Top.Length != 0)
            {
                selectQuery += "Top " + Top;
            }
            selectQuery += "* ";
            selectQuery += "from tb_DocGia ";
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
                    DocGia obj = new DocGia();
                    obj.DocGiaIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public bool insertData(DocGia data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_DocGia(maDocGia, tenDocGia, email, dienThoai) VALUES('{0}',N'{1}','{2}','{3}')",data.MaDocGia,data.TenDocGia,data.Email,data.DienThoai);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(DocGia data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_DocGia SET tenDocGia = N'{0}', email ='{1}', dienThoai ='{2}' where maDocGia = '{3}'",data.TenDocGia,data.Email,data.DienThoai,data.MaDocGia);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData(string id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_DocGia where maDocGia = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
    }
}
