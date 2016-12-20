using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.Entity;
using QLTV.DAL;


namespace QLTV.DLL
{
    public class DocGiaDLL
    {
        DocGiaDAL obj = new DocGiaDAL();
        public List<DocGia> getAll(String t, String w, String o)
        {
            return obj.getAll(t, w, o);
        }
        public bool insertData(DocGia data)
        {
            return obj.insertData(data);
        }
        public bool updateData(DocGia data)
        {
            return obj.updateData(data);
        }
        public bool deleteData(string id)
        {
            return obj.deleteData(id);
        }
    }
}
