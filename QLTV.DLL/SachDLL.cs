using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using QLTV.Entity;

namespace QLTV.DLL
{
   public class SachDLL
    {
        SachDAL obj = new SachDAL();

        public List<Sach> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }

        public bool insertData(Sach data)
        {
            return obj.insertData(data);
        }

        public bool updateData(Sach data)
        {
            return obj.updateData(data);
        }
        public bool deleteData(String id)
        {
            return obj.deleteData(id);
        }
    }
}
