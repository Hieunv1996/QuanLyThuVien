using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using QLTV.Entity;

namespace QLTV.DLL
{
    public class PhieuTraDLL
    {
        PhieuTraDAL obj = new PhieuTraDAL();
        public List<PhieuTra> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }
        public bool insertData(PhieuTra data)
        {
            return obj.insertData(data);
        }
        public bool updateData(PhieuTra data)
        {
            return obj.updateData(data);
        }
        public bool deleteData(string id)
        {
            return obj.deleteData(id);
        }
    }
}
