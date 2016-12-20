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
    public class LoaiLoaiSachDAL: SqlDataProvider
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
            String sql = String.Format("INSERT INTO tb_LoaiSach(maLoaiSach, tieuDe, giaBia, tacGia, namXuatBan, soLuongTon, maLoaiLoaiSach) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", data.MaLoaiSach, data.TieuDe, data.GiaBia, data.TacGia, data.NamXuatBan, data.SoLuongTon, data.MaLoaiLoaiSach);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(LoaiSach data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_LoaiSach SET tieuDe = N'{0}', giaBia = '{1}', tacGia = N'{2}', namXuatBan = '{3}', soLuongTon = '{4}', maLoaiLoaiSach = '{5}' where maLoaiSach = '{6}'", data.TieuDe, data.GiaBia, data.TacGia, data.NamXuatBan, data.SoLuongTon, data.MaLoaiLoaiSach, data.MaLoaiSach);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData(String id)
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
