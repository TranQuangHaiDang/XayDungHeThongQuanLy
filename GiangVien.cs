using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.People
{
    public class GiangVien : Person
    {
        string khoa;
        int luong;
        string lopDay;
        int maGiangVien;
        public string Khoa
        {
            get => khoa;
            set => khoa = value;
        }
        public int Luong
        {
            get => luong;
            set => luong = value;
        }
        public string LopDay
        {
            get => lopDay;
            set => lopDay = value;
        }
        public int MaGiangVien
        {
            get => maGiangVien;
            set => maGiangVien = value;
        }
        public GiangVien(string khoa, int luong, string lopDay, int maGiangVien, string ho,
                         string ten, string ngaySinh, string gioiTinh, string diaChi, string soDT)
        {
            this.khoa = khoa;
            this.luong = luong;
            this.lopDay = lopDay;
            this.maGiangVien = maGiangVien;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;
        }
        public GiangVien(GiangVien giangvien) : this(giangvien.khoa, giangvien.luong, giangvien.lopDay,
                                                giangvien.maGiangVien, giangvien.Ho, giangvien.Ten,
                                                giangvien.NgaySinh, giangvien.GioiTinh, giangvien.SoDT, giangvien.DiaChi)
        {
        }
        public GiangVien()
        {
            khoa = "";
            luong = 0;
            lopDay = "";
            maGiangVien = 0;
            Ho = "";
            Ten = "";
            NgaySinh = "";
            GioiTinh = "";
            DiaChi = "";
            SoDT = "";
        }
    }

}
