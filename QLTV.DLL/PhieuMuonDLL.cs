using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using QLTV.Entity;


namespace QLTV.DLL
{
    public class PhieuMuonDLL
    {
        PhieuMuonDAL obj = new PhieuMuonDAL();
        public List<PhieuMuon> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }

        public bool insertData(PhieuMuon data)
        {
            return obj.insertData(data);
        }
        public bool updateData(PhieuMuon data)
        {
            return obj.updateData(data);
        }
        public bool deleteData(string id)
        {
            return obj.deleteData(id);
        }
    }
}
