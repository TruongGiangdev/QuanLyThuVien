using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTra
    {
        private string sMaPhieuTra;
        private string sMaPhieuMuon;
        private string sMaNV;
        private string sMaDocGia;
        private string sMaSach;
        private DateTime dNgayTra;
        private string sMaTinhTrang;

        public PhieuTra(string sMaPhieuTra, string sMaPhieuMuon, string sMaNV, 
            string sMaDocGia, string sMaSach, DateTime dNgayTra, string sMaTinhTrang)
        {
            this.sMaPhieuTra = sMaPhieuTra;
            this.sMaPhieuMuon = sMaPhieuMuon;
            this.sMaNV = sMaNV;
            this.sMaDocGia = sMaDocGia;
            this.sMaSach = sMaSach;
            this.dNgayTra = dNgayTra;
            this.sMaTinhTrang = sMaTinhTrang;
        }

        public PhieuTra() { }

        public string SMaPhieuTra
        {
            get { return sMaPhieuTra; }
            set { sMaPhieuTra = value; }
        }

        public string SMaPhieuMuon
        {
            get { return sMaPhieuMuon; }
            set { sMaPhieuMuon = value; }
        }

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }

        public string SMaDocGia
        {
            get { return sMaDocGia; }
            set { sMaDocGia = value; }
        }

        public string SMaSach
        {
            get { return sMaSach; }
            set { sMaSach = value; }
        }

        public DateTime DNgayTra
        {
            get { return dNgayTra; }
            set { dNgayTra = value; }
        }

        public string SMaTinhTrang
        {
            get { return sMaTinhTrang; }
            set { sMaTinhTrang = value; }
        }
    }
}
