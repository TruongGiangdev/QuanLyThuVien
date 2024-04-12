using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyenHan
    {
        private bool bMaQuyen;
        private string sTenQuyen;

        public QuyenHan() { }

        public QuyenHan(bool bMaQuyen, string sTenQuyen)
        {
            this.bMaQuyen = bMaQuyen;
            this.sTenQuyen = sTenQuyen;
        }

        public bool BMaQuyen
        {
            get { return bMaQuyen; }
            set { bMaQuyen = value; }   
        }            

        public string STenQuyen
        {
            get { return sTenQuyen; }   
            set { sTenQuyen = value; }
        }
    }
}
