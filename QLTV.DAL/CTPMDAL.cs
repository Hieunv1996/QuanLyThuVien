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
    public class CTPMDAL : SqlDataProvider
    {
        public List<CTPM> getAll(string Top, string Where, string Order)
        {
            List<CTPM> lst = new List<CTPM>();
            string selectQuery = "select ";
            if (Top.Length != 0)
            {
                selectQuery += "Top " + Top;
            }
            selectQuery += "* ";
            selectQuery += "from tb_CTPM ";
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
                    CTPM obj = new CTPM();
                    obj.CTPMIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public List<CTPM> getCTPM(String maKH)
        {
            List<CTPM> lst = new List<CTPM>();
            String sql = String.Format("select tb_CTPM.* from tb_CTPM,tb_PhieuMuon where tb_PhieuMuon.maPM = tb_CTPM.maPM and maDocGia = '{0}'", maKH);

            using (SqlCommand cmd = new SqlCommand(sql, openConnection()))
            {
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CTPM obj = new CTPM();
                    obj.CTPMIDataReader(dr);
                    lst.Add(obj);
                }
                dr.Close();
            }
            return lst;
        }

        public bool insertData(CTPM data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_CTPM(maCTPM, maPM, maSach, ngayTra,tienCoc) VALUES('{0}','{1}','{2}','{3}','{4}')",data.MaCTPM,data.MaPM,data.MaSach,data.NgayTra,data.TienCoc);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(CTPM data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_CTPM SET maSach ='{0}', ngayTra ='{1}', tienCoc = {2} where maCTPM = '{3}'",data.MaSach,data.NgayTra,data.TienCoc,data.MaCTPM);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteAllData(string id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_CTPM where maPM = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool deleteData(string id)
        {
            bool check = false;
            String sql = String.Format("DELETE FROM tb_CTPM where maCTPM = '{0}'", id);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }
       
    }
}
