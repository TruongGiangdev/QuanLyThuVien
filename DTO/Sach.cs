using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string sMaSach;
        private string sTenSach;
        private DateTime dNamXB;
        private int iSoLuong;
        private float fGia;
        private string sMaLoai;
        private string sMaTacGia;
        private string sMaNXB;

        public Sach() { }

        public Sach(string sMaSach, string sTenSach, DateTime dNamXB, int iSoLuong, string sMaLoai, string sMaTacGia, float fGia, string sMaNXB)
        {
            this.sMaSach = sMaSach;
            this.sTenSach = sTenSach;
            this.dNamXB = dNamXB;
            this.iSoLuong = iSoLuong;
            this.fGia = fGia;
            this.sMaLoai = sMaLoai;
            this.sMaTacGia = sMaTacGia;
            this.sMaNXB = sMaNXB;
        }

        public string SMaSach
        {
            get { return sMaSach; }
            set { sMaSach = value; }
        }

        public string STenSach
        {
            get { return sTenSach; }
            set { sTenSach = value; }
        }

        public DateTime DNamXB
        {
            get { return dNamXB; }
            set { dNamXB = value; }
        }

        public int ISoLuong
        {
            get { return iSoLuong; }
            set { iSoLuong = value; }
        }

        public float FGia
        {
            get { return fGia; }
            set { fGia = value; }
        }
        
        public string SMaLoai
        {
            get { return sMaLoai; }
            set { sMaLoai = value; }
        }

        public string SMaTacGia
        {
            get { return sMaTacGia; }
            set { sMaTacGia = value; }
        }

        public string SMaNXB
        {
            get { return sMaNXB; }
            set { sMaNXB = value; }
        }


    }
}
