using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.People
{
    class NhanVienHanhChinh : Person
    {
        string congViec;
        string phongBan;
        int luong;
        int thoiGianLamViec;
        int maNV;
        public int MaNV
        {
            get => maNV;
            set => maNV =  value;
        }
        public string CongViec
        {
            get => congViec;
            set => congViec = value;
        }
        public string PhongBan
        {
            get => phongBan;
            set => phongBan = value;
        }
        public int Luong
        {
            get => luong;
            set => luong = value;
        }
        public int ThoiGianLamViec
        {
            get => thoiGianLamViec;
            set => thoiGianLamViec = value;
        }
        public NhanVienHanhChinh(string congViec, string phongBan, int luong, int thoiGianLamViec,
                                 string ho, string ten, string ngaySinh, string gioiTinh,
                                 string diaChi, string soDT)
        {
            this.congViec = congViec;
            this.phongBan = phongBan;
            this.luong = luong;
            this.thoiGianLamViec = thoiGianLamViec;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;
        }
        public NhanVienHanhChinh(NhanVienHanhChinh nhanvienhanhchinh) : this(nhanvienhanhchinh.congViec, nhanvienhanhchinh.phongBan,
                                                                        nhanvienhanhchinh.luong, nhanvienhanhchinh.thoiGianLamViec,
                                                                        nhanvienhanhchinh.Ho, nhanvienhanhchinh.Ten,
                                                                        nhanvienhanhchinh.NgaySinh, nhanvienhanhchinh.GioiTinh,
                                                                        nhanvienhanhchinh.DiaChi, nhanvienhanhchinh.SoDT)
        {
        }
        public NhanVienHanhChinh()
        {
            congViec = "";
            phongBan = "";
            luong = 0;
            thoiGianLamViec = 0;
            Ho = "";
            Ten = "";
            NgaySinh = "";
            GioiTinh = "";
            DiaChi = "";
            SoDT = "";
        }
    }
}
