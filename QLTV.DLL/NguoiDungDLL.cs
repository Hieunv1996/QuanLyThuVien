using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAL;

namespace QLTV.DLL
{
    public class NguoiDungDLL
    {
        NguoiDungDAL obj = new NguoiDungDAL();
        public bool getLogin(String u, String p)
        {
            return obj.getLogin(u, p);
        }
    }
}
