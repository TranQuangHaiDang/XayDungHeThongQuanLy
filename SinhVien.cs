using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.People
{
    class SinhVien : Person
    {
        string namNhapHoc;
        string khoaHoc;
        string khoa;
        string nganhHoc;
        string lopSinhVien;
        int maSoSinhVien;
        int diemRenLuyen;
        int diemCTXH;
        public string NamNhapHoc
        {
            get => namNhapHoc;
            set => namNhapHoc = value;
        }
        public string KhoaHoc
        {
            get => khoaHoc;
            set => khoaHoc = value;
        }
        public string Khoa
        {
            get => khoa;
            set => khoa = value;
        }
        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }
        public string LopSinhVien
        {
            get => lopSinhVien;
            set => lopSinhVien = value;
        }
        public int MaSoSinhVien
        {
            get => maSoSinhVien;
            set => maSoSinhVien = value;
        }
        public int DiemRenLuyen
        {
            get => diemRenLuyen;
            set => diemRenLuyen = value;
        }
        public int DiemCTXH
        {
            get => diemCTXH;
            set => diemCTXH = value;
        }
        public SinhVien(string namNhapHoc, string khoaHoc, string khoa, string nganhHoc,
                        string lopSinhVien, int maSoSinhVien, int diemRenLuyen, int diemCTXH,
                        string ho, string ten, string ngaySinh, string gioiTinh, string diaChi, string soDT)
        {
            this.namNhapHoc = namNhapHoc;
            this.khoaHoc = khoaHoc;
            this.khoa = khoa;
            this.nganhHoc = nganhHoc;
            this.lopSinhVien = lopSinhVien;
            this.maSoSinhVien = maSoSinhVien;
            this.diemRenLuyen = diemRenLuyen;
            this.diemCTXH = diemCTXH;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;
        }
        public SinhVien(SinhVien sinhvien) : this(sinhvien.namNhapHoc, sinhvien.khoaHoc, sinhvien.khoa,
                                             sinhvien.nganhHoc, sinhvien.lopSinhVien, sinhvien.maSoSinhVien,
                                             sinhvien.diemRenLuyen, sinhvien.diemCTXH, sinhvien.Ho,
                                             sinhvien.Ten, sinhvien.NgaySinh, sinhvien.GioiTinh, sinhvien.SoDT,
                                             sinhvien.DiaChi)
        {
        }
        public SinhVien()
        {
            namNhapHoc = "";
            khoaHoc = "";
            khoa = "";
            nganhHoc = "";
            lopSinhVien = "";
            maSoSinhVien = 0;
            diemRenLuyen = 0;
            diemCTXH = 0;
            Ho = "";
            Ten = "";
            NgaySinh = "";
            GioiTinh = "";
            DiaChi = "";
            SoDT = "";
        }
    }
}
