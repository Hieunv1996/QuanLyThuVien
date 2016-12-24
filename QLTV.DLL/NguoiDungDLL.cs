using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;
using QLTV.Entity;

namespace QLTV.DLL
{
    public class NguoiDungDLL
    {
        NguoiDungDAL obj = new NguoiDungDAL();
        public bool getLogin(String u, String p)
        {
            return obj.getLogin(u, p);
        }
        public bool updateData(NguoiDung data)
        {
            return obj.updateData(data);
        }
    }
    
}
