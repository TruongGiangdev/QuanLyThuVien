using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuon
    {
        private string sMaPhieuMuon;
        private string sMaDocGia;
        private string sMaNV;
        private string sMaSach;
        private DateTime dNgayMuon;
        private DateTime dNgayHenTra;

        public PhieuMuon() { }

        public PhieuMuon(string sMaPhieuMuon, string sMaDocGia, string sMaNV, 
            string sMaSach, DateTime dNgayMuon, DateTime dNgayHenTra)
        {
            this.sMaPhieuMuon = sMaPhieuMuon;
            this.sMaDocGia = sMaDocGia;
            this.sMaNV = sMaNV;
            this.sMaSach = sMaSach;
            this.dNgayMuon = dNgayMuon;
            this.dNgayHenTra = dNgayHenTra;
        }

        public string SMaPhieuMuon
        {
            get { return sMaPhieuMuon; }
            set {  sMaPhieuMuon = value; }
        }
        public string SMaDocGia
        {
            get { return sMaDocGia;}
            set { sMaDocGia = value;}
        }
        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        public string SMaSach
        {
            get { return sMaSach; }
            set { sMaSach = value; }
        }
        public DateTime DNgayMuon
        {
            get { return dNgayMuon; }
            set { dNgayMuon = value;}
        }
        public DateTime DNgayHenTra
        {
            get { return dNgayHenTra; }
            set { dNgayHenTra = value; }
        }
    }
}
