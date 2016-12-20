using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using QLTV.Entity;


namespace QLTV.DLL
{
    public class CTPMDLL
    {
        CTPMDAL obj = new CTPMDAL();
        public List<CTPM> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }
        public bool insertData(CTPM data)
        {
            return obj.insertData(data);
        }
        public bool updateData(CTPM data)
        {
            return obj.updateData(data);
        }
        public bool deleteData(string id)
        {
            return obj.deleteData(id);
        }
        public bool deleteAllData(string id)
        {
            return obj.deleteAllData(id);
        }
    }
}
