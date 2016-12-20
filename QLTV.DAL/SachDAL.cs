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
    public class SachDAL : SqlDataProvider
    {
        public List<Sach> getAll(string Top, string Where, string Order)
        {
            List<Sach> lst = new List<Sach>();
            string selectQuery = "select ";
            if (Top.Length != 0)
            {
                selectQuery += "Top " + Top;
            }
            selectQuery += "* ";
            selectQuery += "from tb_Sach ";
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
                    Sach obj = new Sach();
                    obj.SachIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public bool insertData(Sach data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_Sach(maSach, tieuDe, giaBia, tacGia, namXuatBan, soLuongTon, maLoaiSach) VALUES('{0}',N'{1}','{2}',N'{3}','{4}','{5}','{6}')", data.MaSach, data.TieuDe, data.GiaBia, data.TacGia, data.NamXuatBan, data.SoLuongTon, data.MaLoaiSach);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(Sach data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_Sach SET tieuDe = N'{0}', giaBia = '{1}', tacGia = N'{2}', namXuatBan = '{3}', soLuongTon = '{4}', maLoaiSach = '{5}' where maSach = '{6}'", data.TieuDe, data.GiaBia, data.TacGia, data.NamXuatBan, data.SoLuongTon, data.MaLoaiSach, data.MaSach);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData (String id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_Sach where maSach = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
    }
}
