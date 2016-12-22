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
    public class PhieuTraDAL : SqlDataProvider
    {
        public List<PhieuTra> getAll(string Top, string Where, string Order)
        {
            List<PhieuTra> lst = new List<PhieuTra>();
            string selectQuery = "select ";
            if (Top.Length != 0)
            {
                selectQuery += "Top " + Top;
            }
            selectQuery += "* ";
            selectQuery += "from tb_PhieuTra ";
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
                    PhieuTra obj = new PhieuTra();
                    obj.PhieuTraIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public bool insertData(PhieuTra data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_PhieuTra(maPT, maDocGia, ngayTra, thanhTien) VALUES('{0}','{1}','{2}','{3}')",data.MaPhieuTra,data.MaDocGia,data.NgayTra,data.ThanhTien);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(PhieuTra data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_PhieuTra SET maDocGia =''{0}', ngayTra = '{1}', thanhTien = '{2}' where maPT = '{3}'",data.MaDocGia,data.NgayTra,data.ThanhTien,data.MaPhieuTra);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData(string id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_PhieuTra where maPT = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
    }
}
