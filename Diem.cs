using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.Other
{
    class Diem
    {
        int diemCuoiKi;
        int diemQuaTrinh;
        int diemTrungBinh;
        string diemChu;
        public int DiemCuoiKi
        {
            get => diemCuoiKi;
            set => diemCuoiKi = value;
        }
        public int DiemQuaTrinh
        {
            get => diemQuaTrinh;
            set => diemQuaTrinh = value;
        }
        public int DiemTrungBinh
        {
            get => diemTrungBinh;
            set => diemTrungBinh = value;
        }
        public string DiemChu
        {
            get => diemChu;
            set => diemChu = value;
        }
        public Diem(int diemCuoiKi, int diemQuaTrinh, int diemTrungBinh, string diemChu)
        {
            this.diemCuoiKi = diemCuoiKi;
            this.diemQuaTrinh = diemQuaTrinh;
            this.diemTrungBinh = diemTrungBinh;
            this.diemChu = diemChu;
        }
        public Diem(Diem diem) : this(diem.diemCuoiKi, diem.diemQuaTrinh, diem.diemTrungBinh, diem.diemChu)
        {
        }
        public Diem()
        {
            diemCuoiKi = 0;
            DiemQuaTrinh = 0;
            diemTrungBinh = 0;
            diemChu = "";
        }
    }
}
