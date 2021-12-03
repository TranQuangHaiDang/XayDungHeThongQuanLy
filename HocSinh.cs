using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.People
{
    public class HocSinh : Person
    {
        int soBaoDanh;
        string truongTHPT;
        string khoiThi;
        string nganh;
        int diemThi;
        int khuVuc;
        double diemUuTien;
        string dienTuyenSinh;
        public int SoBaoDanh
        {
            get => soBaoDanh;
            set => soBaoDanh = value;
        }
        public string TruongTHPT
        {
            get => truongTHPT;
            set => truongTHPT = value;
        }
        public string KhoiThi
        {
            get => khoiThi;
            set => khoiThi = value;
        }
        public string Nganh
        {
            get => nganh;
            set => nganh = value;
        }
        public int DiemThi
        {
            get => diemThi;
            set => diemThi = value;
        }
        public int KhuVuc
        {
            get => khuVuc;
            set => khuVuc = value;
        }
        public double DiemUuTien
        {
            get => diemUuTien;
            set => diemUuTien = value;
        }
        public string DienTuyenSinh
        {
            get => dienTuyenSinh;
            set => dienTuyenSinh = value;
        }
        public HocSinh(int soBaoDanh, string truongTHPT, string khoiThi, string nganh, int diemThi,
                       int khuVuc, double diemUuTien, string dienTuyenSinh, string ho, string ten,
                       string ngaySinh, string gioiTinh, string soDT, string diaChi)
        {
            this.soBaoDanh = soBaoDanh;
            this.truongTHPT = truongTHPT;
            this.khoiThi = khoiThi;
            this.nganh = nganh;
            this.diemThi = diemThi;
            this.khuVuc = khuVuc;
            this.diemUuTien = diemUuTien;
            this.dienTuyenSinh = dienTuyenSinh;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDT = soDT;
            DiaChi = diaChi;
        }
        public HocSinh(HocSinh hocsinh) : this(hocsinh.soBaoDanh, hocsinh.truongTHPT, hocsinh.khoiThi,
                                          hocsinh.nganh, hocsinh.diemThi, hocsinh.khuVuc, hocsinh.diemUuTien,
                                          hocsinh.dienTuyenSinh, hocsinh.Ho, hocsinh.Ten,
                                          hocsinh.NgaySinh, hocsinh.GioiTinh, hocsinh.SoDT, hocsinh.DiaChi)
        {
        }
        public HocSinh()
        {
            soBaoDanh = 0;
            truongTHPT = "";
            khoiThi = "";
            nganh = "";
            diemThi = 0;
            khuVuc = 0;
            diemUuTien = 0;
            dienTuyenSinh = "";
            Ho = "";
            Ten = "";
            NgaySinh = "";
            GioiTinh = "";
            DiaChi = "";
            SoDT = "";
        }
    }
}
