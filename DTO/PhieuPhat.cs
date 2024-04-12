using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuPhat
    {
        private string sMaPhieuPhat;
        private string sMaPhieuTra;
        private float fTienPhat;
        private string sNoiDung;

        public PhieuPhat(string sMaPhieuPhat, string sMaPhieuTra, float fTienPhat, string sNoiDung)
        {
            this.sMaPhieuPhat = sMaPhieuPhat;
            this.sMaPhieuTra = sMaPhieuTra;
            this.fTienPhat = fTienPhat;
            this.sNoiDung = sNoiDung;
        }

        public PhieuPhat() { }  

        public string SMaPhieuPhat 
        { 
            get { return sMaPhieuPhat; }
            set {  sMaPhieuPhat = value;}
        }

        public string SMaPhieuTra
        {
            get { return sMaPhieuTra; }
            set { sMaPhieuTra = value;}
        }

        public float FTienPhat
        {
            get { return fTienPhat; }
            set { fTienPhat = value;}
        }

        public string SNoiDung
        {
            get { return sNoiDung; }
            set { sNoiDung = value;}
        }
    }
}
