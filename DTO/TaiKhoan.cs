using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class TaiKhoan
    {
        private string sLoginName;
        private string sMatKhau;
        private bool bQuyenHan;
        private string sMaNV;

        public TaiKhoan() { }

        public TaiKhoan(string sLoginName, string sMatKhau, bool bQuyenHan, string sMaNV)
        {
            this.sLoginName = sLoginName;
            this.sMatKhau = sMatKhau;
            this.bQuyenHan = bQuyenHan;
            this.sMaNV = sMaNV;
        }

        public string SLoginName
        {
            get { return sLoginName; }
            set { sLoginName = value; }
        }
        public string SMatKhau
        {
            get { return sMatKhau; }
            set { sMatKhau = value; }
        }

        public bool BQuyenHan
        {
            get { return bQuyenHan; }
            set { bQuyenHan = value; }
        }
        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
    }
}
