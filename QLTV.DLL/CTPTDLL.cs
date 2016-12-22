using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using QLTV.Entity;


namespace QLTV.DLL
{
    public class CTPTDLL
    {
        CTPTDAL obj = new CTPTDAL();
        public List<CTPT> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }
        public bool insertData(CTPT data)
        {
            return obj.insertData(data);
        }
        public bool updateData(CTPT data)
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
        public int dateDiff(String d1, String d2)
        {
            return obj.dateDiff(d1, d2);
        }
    }
}
