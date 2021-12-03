using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCuoiKi.Other
{
    class KhoaHoc
    {
        string tenKhoaHoc;
        string maKhoaHoc;
        string nienKhoa;
        int namNhapHoc;
        string chuongTrinhDaoTao;
        public string TenKhoaHoc
        {
            get => tenKhoaHoc;
            set => tenKhoaHoc = value;
        }
        public string MaKhoaHoc
        {
            get => maKhoaHoc;
            set => maKhoaHoc = value;
        }
        public string NienKhoa
        {
            get => nienKhoa;
            set => nienKhoa = value;
        }
        public int NamNhapHoc
        {
            get => namNhapHoc;
            set => namNhapHoc = value;
        }
        public string ChuongTrinhDaoTao
        {
            get => chuongTrinhDaoTao;
            set => chuongTrinhDaoTao = value;
        }

        public KhoaHoc(string tenKhoaHoc, string maKhoaHoc, string nienKhoa, int namNhapHoc,
                       string chuongTrinhDaoTao)
        {
            this.tenKhoaHoc = tenKhoaHoc;
            this.maKhoaHoc = maKhoaHoc;
            this.nienKhoa = nienKhoa;
            this.namNhapHoc = namNhapHoc;
            this.chuongTrinhDaoTao = chuongTrinhDaoTao;
        }
        public KhoaHoc(KhoaHoc khoahoc) : this(khoahoc.tenKhoaHoc, khoahoc.maKhoaHoc, khoahoc.nienKhoa,
                                         khoahoc.namNhapHoc, khoahoc.chuongTrinhDaoTao)
        {
        }
        public KhoaHoc()
        {
            tenKhoaHoc = "";
            maKhoaHoc = "";
            nienKhoa = "";
            namNhapHoc = 0;
            chuongTrinhDaoTao = "";
        }
    }
}
