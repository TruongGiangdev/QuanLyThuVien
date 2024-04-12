using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string sMaNV;
        private string sTenNV;
        private bool bGioiTinh;
        private string sDiaChi;
        private string sDT;
        private DateTime dNgaySinh;
        private string sMaChucVu;

        public NhanVien() { }

        public NhanVien(string sMaNV, string sTenNV, bool bGioiTinh, string sDiaChi, string sDT, DateTime dNgaySinh, string sMaChucVu)
        {
            this.sMaNV = sMaNV;
            this.sTenNV = sTenNV;
            this.bGioiTinh = bGioiTinh;
            this.sDiaChi = sDiaChi;
            this.sDT = sDT;
            this.dNgaySinh = dNgaySinh;
            this.sMaChucVu = sMaChucVu;
        }

        public string SMaNV 
        { 
            get {  return sMaNV; } 
            set { sMaNV = value; }
        }

        public string STenNV
        {
            get { return sTenNV; }
            set { sTenNV = value; }
        }

        public bool BGioiTinh
        {
            get { return bGioiTinh; }
            set {  bGioiTinh = value;}
        }

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }    
        }

        public DateTime DNgaySinh
        {
            get { return dNgaySinh; }
            set { dNgaySinh = value; }
        }

        public string SMaChucVu
        {
            get { return sMaChucVu; }
            set { sMaChucVu = value;}
        }
    }
}
