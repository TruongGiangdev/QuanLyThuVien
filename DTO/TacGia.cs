using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        private string sMaTG;
        private string sTenTG;
        private bool bGioiTinh;

        public TacGia(string sMaTG, string sTenTG, bool bGioiTinh)
        {
            this.sMaTG = sMaTG;
            this.sTenTG = sTenTG;
            this.bGioiTinh = bGioiTinh;
        }

        public TacGia() { }

        public string SMaTG { get => sMaTG; set => sMaTG = value; }
        public string STenTG { get => sTenTG; set => sTenTG = value; }
        public bool BGioiTinh { get => bGioiTinh; set => bGioiTinh = value;  }
    }
}
