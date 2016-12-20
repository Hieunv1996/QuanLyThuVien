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
    public class PhieuMuonDAL: SqlDataProvider
    {
        public List<PhieuMuon> getAll(string Top, string Where, string Order)
        {
            List<PhieuMuon> lst = new List<PhieuMuon>();
            string selectQuery = "select ";
            if (Top.Length != 0)
            {
                selectQuery += "Top " + Top;
            }
            selectQuery += "* ";
            selectQuery += "from tb_PhieuMuon ";
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
                    PhieuMuon obj = new PhieuMuon();
                    obj.PhieuMuonIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public bool insertData(PhieuMuon data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_PhieuMuon(maPM, maDocGia, ngayMuon, thanhTien) VALUES('{0}','{1}',''{2},'{3}')", data.MaPhieuMuon, data.MaDocGia, data.NgayMuon, data.ThanhTien);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(PhieuMuon data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_PhieuMuon SET maDocGia = '{0}', ngayMuon = '{1}', thanhTien = '{2}' where maPM = '{3}'",data.MaDocGia,data.NgayMuon,data.ThanhTien,data.MaPhieuMuon);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData(string id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_PhieuMuon where maPhieuMuon = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
    }
}
