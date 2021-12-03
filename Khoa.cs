using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.Other
{
    class Khoa
    {
        int MaKhoa;
        int TenKhoa;

        public int MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public int TenKhoa1 { get => TenKhoa; set => TenKhoa = value; }

        public Khoa(int maKhoa, int tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }

        public Khoa()
        {
        }
    }
}
