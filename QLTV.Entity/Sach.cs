using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Entity
{
    public class Sach
    {
        private string _maSach;
        private string _tieuDe;
        private int _giaBia;
        private string _tacGia;
        private int _namXuatBan;
        private int _soLuongTon;
        private string _maLoaiSach;

        public string MaSach
        {
            get
            {
                return _maSach;
            }

            set
            {
                _maSach = value;
            }
        }

        public string TieuDe
        {
            get
            {
                return _tieuDe;
            }

            set
            {
                _tieuDe = value;
            }
        }

        public int GiaBia
        {
            get
            {
                return _giaBia;
            }

            set
            {
                _giaBia = value;
            }
        }

        public string TacGia
        {
            get
            {
                return _tacGia;
            }

            set
            {
                _tacGia = value;
            }
        }

        public int NamXuatBan
        {
            get
            {
                return _namXuatBan;
            }

            set
            {
                _namXuatBan = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return _soLuongTon;
            }

            set
            {
                _soLuongTon = value;
            }
        }

        public string MaLoaiSach
        {
            get
            {
                return _maLoaiSach;
            }

            set
            {
                _maLoaiSach = value;
            }
        }

        public void SachIDataReader(SqlDataReader dr)
        {
            MaSach = dr["maSach"] is DBNull ? string.Empty : dr["maSach"].ToString();
            TieuDe = dr["tieuDe"] is DBNull ? string.Empty : dr["tieuDe"].ToString();
            GiaBia = dr["giaBia"] is DBNull ? 0 : Int32.Parse(dr["giaBia"].ToString());
            TacGia = dr["tacGia"] is DBNull ? string.Empty : dr["tacGia"].ToString();
            NamXuatBan = dr["namXuatBan"] is DBNull ? 0 : Int32.Parse(dr["namXuatBan"].ToString());
            SoLuongTon = dr["soLuongTon"] is DBNull ? 0 : Int32.Parse(dr["soLuongTon"].ToString());
            MaLoaiSach = dr["maLoaiSach"] is DBNull ? "": dr["maLoaiSach"].ToString();
        }
    }
}
