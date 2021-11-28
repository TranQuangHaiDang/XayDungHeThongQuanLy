using System;
using System.Collections.Generic;
using System.Text;
using BaiTapCuoiKi.Other;
using BaiTapCuoiKi.People;

namespace BaiTapCuoiKi.Manager
{
    class QuanLiSinhVien
    {
        private List<SinhVien> ListSv = null;
        public QuanLiSinhVien()
        {
            ListSv = new List<SinhVien>();
        }
        private int GenerateID()
        {
            int max = 1;
            if (ListSv != null && ListSv.Count > 0)
            {
                max = ListSv[0].MaSoSinhVien;
                foreach (SinhVien sv in ListSv)
                {
                    if (max < sv.MaSoSinhVien)
                    {
                        max = sv.MaSoSinhVien;
                    }
                }
                max++;
            }
            return max;
        }
        public int Studentnumber()
        {
            int Count = 0;
            if (ListSv != null)
            {
                Count = ListSv.Count;
            }
            return Count;
        }
        public void add()
        {
            SinhVien student = new SinhVien();
            student.MaSoSinhVien = GenerateID();
            Console.Write("Nhap ho: ");
            do
            {
                student.Ho = Console.ReadLine();
            } while (student.Ho == "");
            Console.Write("Nhap ten: ");
            do
            {
                student.Ten = Console.ReadLine();
            } while (student.Ten == "");
            Console.Write("Nhap ngay sinh(dd-mm-yyyy): ");
            student.NgaySinh = Console.ReadLine();
            Console.Write("Nhap gioi tinh (Nam hoac Nu): ");
            do
            {
                student.GioiTinh = Console.ReadLine();
            } while (student.GioiTinh != "Nam" && student.GioiTinh != "Nu");
            Console.Write("Nhap nganh hoc: ");
            student.NganhHoc = Console.ReadLine();
            Console.Write("Nhap SDT: ");
            student.SoDT = Console.ReadLine();
            ListSv.Add(student);
            Console.Write("Nhap lua chon tiep theo: ");
        }
        public void Display(List<SinhVien> ListSv)
        {
            Console.WriteLine("{0, -10} {1, -10} {2, -10}{3, -15} {4, -15} {5, -15} {6, -10}",
                "MSSV", "Ho", "Ten", "Ngaysinh", "Gioi tinh", "Nganhhoc", "SDT");

            if (ListSv != null && ListSv.Count > 0)
            {
                foreach (SinhVien student in ListSv)
                {
                    Console.WriteLine("{0, -10} {1, -10} {2, -10}{3, -15} {4, -15} {5, -15} {6, -10}",
                            student.MaSoSinhVien, student.Ho, student.Ten, student.NgaySinh, student.GioiTinh, student.NganhHoc, student.SoDT);
                }
            }
            Console.Write("Nhap lua chon tiep theo: ");
        }
        public SinhVien FindID(int MaSoSinhVien)
        {
            SinhVien searchResult = null;
            if (ListSv!= null && ListSv.Count>0)
            {
                foreach(SinhVien sv in ListSv)
                {
                    if (sv.MaSoSinhVien==MaSoSinhVien)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
        public bool XoaID(int MaSoSinhVien)
        {
            bool IsDelete = false;
            SinhVien sv = FindID(MaSoSinhVien);
            if (sv!=null)
            {
                IsDelete = ListSv.Remove(sv);
            }
            return IsDelete;
        }
        public List<SinhVien> getListSv()
        {
            return ListSv;
        }
    }
}
