using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.Other
{
    class Nganh
    {
        int maNganh;
        int tenNganh;

        public int MaNganh { get => maNganh; set => maNganh = value; }
        public int TenNganh { get => tenNganh; set => tenNganh = value; }

        public Nganh(int maNganh, int tenNganh)
        {
            this.maNganh = maNganh;
            this.tenNganh = tenNganh;
        }

        public Nganh()
        {
        }
    }
}
