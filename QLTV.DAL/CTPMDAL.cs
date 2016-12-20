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

        public bool insertData(CTPM data)
        {
            bool check = false;
            String sql = String.Format("INSERT INTO tb_CTPM(maCTPM, maPM, maSach, ngayTra) VALUES('{0}','{1}','{2}','{3}')",data.MaCTPM,data.MaPhieuMuon,data.MaSach,data.NgayTra);
            openConnection();
            int r = ExecuteNonQuery(sql);
            if (r > 0) check = true;
            closeConnection();
            return check;
        }

        public bool updateData(CTPM data)
        {
            bool check = false;
            String sql = String.Format("UPDATE tb_CTPM SET maPM = '{0}', maSach ='{1}', ngayTra ='{2}' where maCTPM = '{3}'",data.MaPhieuMuon,data.MaSach,data.NgayTra,data.MaCTPM);
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
