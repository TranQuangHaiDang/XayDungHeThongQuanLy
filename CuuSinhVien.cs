using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.People
{
    class CuuSinhVien : SinhVien
    {
        string namTotNghiep;
        public string NamTotNghiep
        {
            get => namTotNghiep;
            set => namTotNghiep = value;
        }
        public CuuSinhVien(string namTotNghiep, string namNhapHoc, string khoaHoc, string khoa,
                           int maSoSinhVien, string nganhHoc, string lopSinhVien, int diemRenLuyen,
                           int diemCTXH, string ho, string ten, string ngaySinh, string gioiTinh,
                           string diaChi, string soDT)
        {
            this.namTotNghiep = namTotNghiep;
            NamNhapHoc = namNhapHoc;
            KhoaHoc = khoaHoc;
            Khoa = khoa;
            MaSoSinhVien = maSoSinhVien;
            NganhHoc = nganhHoc;
            LopSinhVien = lopSinhVien;
            DiemRenLuyen = diemRenLuyen;
            DiemCTXH = diemCTXH;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;
        }

        public CuuSinhVien(CuuSinhVien cuusinhvien) : this(cuusinhvien.NamNhapHoc, cuusinhvien.namTotNghiep,
                                                      cuusinhvien.KhoaHoc, cuusinhvien.Khoa, cuusinhvien.MaSoSinhVien,
                                                      cuusinhvien.NganhHoc, cuusinhvien.LopSinhVien, cuusinhvien.DiemRenLuyen,
                                                      cuusinhvien.DiemCTXH, cuusinhvien.Ho, cuusinhvien.Ten, cuusinhvien.NgaySinh,
                                                      cuusinhvien.GioiTinh, cuusinhvien.SoDT, cuusinhvien.DiaChi)
        {
        }
        public CuuSinhVien()
        {
            namTotNghiep = "";
            NamNhapHoc = "";
            KhoaHoc = "";
            Khoa = "";
            MaSoSinhVien = 0;
            NganhHoc = "";
            LopSinhVien = "";
            DiemCTXH = 0;
            DiemRenLuyen = 0;
            Ho = "";
            Ten = "";
            NgaySinh = "";
            GioiTinh = "";
            DiaChi = "";
            SoDT = "";
        }
    }
}
