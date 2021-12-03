using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.Other
{
    class MonHoc
    {
        int maMonHoc;
        string tenMonHoc;
        int soTinChi;
        string loaiMonHoc;
        int gioiHanSinhVien;
        int soLuongDangKi;
        string tenGiangVien;
        int thoiGianDay;
        public int MaMonHoc
        {
            get => maMonHoc;
            set => maMonHoc = value;
        }
        public string TenMonHoc
        {
            get => tenMonHoc;
            set => tenMonHoc = value;
        }
        public int SoTinChi
        {
            get => soTinChi;
            set => soTinChi = value;
        }
        public string LoaiMonHoc
        {
            get => loaiMonHoc;
            set => loaiMonHoc = value;
        }
        public int GioiHanSinhVien
        {
            get => gioiHanSinhVien;
            set => gioiHanSinhVien = value;
        }
        public int SoLuongDangKi
        {
            get => soLuongDangKi;
            set => soLuongDangKi = value;
        }
        public string TenGiangVien
        {
            get => tenGiangVien;
            set => tenGiangVien = value;
        }
        public int ThoiGianDay
        {
            get => thoiGianDay;
            set => thoiGianDay = value;
        }

        public MonHoc(int maMonHoc, string tenMonHoc, int soTinChi, string loaiMonHoc, int gioiHanSinhVien,
                      int soLuongDangKi, string tenGiangVien, int thoiGianDay)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.soTinChi = soTinChi;
            this.loaiMonHoc = loaiMonHoc;
            this.gioiHanSinhVien = gioiHanSinhVien;
            this.soLuongDangKi = soLuongDangKi;
            this.tenGiangVien = tenGiangVien;
            this.thoiGianDay = thoiGianDay;
        }
        public MonHoc(MonHoc monhoc) : this(monhoc.maMonHoc, monhoc.tenMonHoc, monhoc.soTinChi,
                                       monhoc.loaiMonHoc, monhoc.gioiHanSinhVien, monhoc.soLuongDangKi,
                                       monhoc.tenGiangVien, monhoc.thoiGianDay)
        {
        }
        public MonHoc()
        {
            maMonHoc = 1;
            tenMonHoc = "";
            soTinChi = 0;
            loaiMonHoc = "";
            gioiHanSinhVien = 0;
            soLuongDangKi = 0;
            tenGiangVien = "";
            thoiGianDay = 0;
        }
    }
}
