using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.Entity;
using QLTV.DAL;
namespace QLTV.DLL
{
    public class LoaiSachDLL
    {
        LoaiSachDAL obj = new LoaiSachDAL();
        public List<LoaiSach> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }

        public bool insertData(LoaiSach data)
        {
            return obj.insertData(data);
        }
        public bool updateData(LoaiSach data)
        {
            return obj.updateData(data);
        }
        public bool deleteData(string id)
        {
            return obj.deleteData(id);
        }
    }
}
