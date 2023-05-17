using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Services
    {
        List<SinhVien> list = new List<SinhVien>();

        
        public void Nhap()
        {
            
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                list.Add(sv);
            }
            Console.Write("ban co muon nhap tiep khong (y/n): ");
            string s = Console.ReadLine();
            if (s == "y")
            {
                Nhap();
            }

        }
        public void Xuat()
        {
            foreach (SinhVien sv in list)
            {
                sv.XuatSV();
            }
        }
        public void TimKiem()
        {
            Console.Write("Nhap ma sinh vien can tim: ");
            string maSV = Console.ReadLine();
            foreach (SinhVien sv in list)
            {
                if (sv.MaSV == maSV)
                {
                   sv.XuatSV();
                }
            }
        }


        //sửa sinh viên theo mã sinh viên
        public void Sua()
        {
            Console.Write("Nhap ma sinh vien can sua: ");
            string maSV = Console.ReadLine();
            foreach (SinhVien sv in list)
            {
                if (sv.MaSV == maSV)
                {
                   sv.NhapSV();
                }
            }
        }
        //xóa sinh viên theo mã sinh viên
        public void Xoa()
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string maSV = Console.ReadLine();
            foreach (SinhVien sv in list)
            {
                if (sv.MaSV == maSV)
                {
                    list.Remove(sv);
                    break;
                }
            }
        }
        //tìm kiếm sinh viên theo tên
        public void TimKiemTheoTen()
        {
            Console.Write("Nhap ten sinh vien can tim: ");
            string ten = Console.ReadLine();
            foreach (SinhVien sv in list)
            {
                if (sv.Ten == ten)
                {
                   sv.XuatSV();
                }
            }
        }
        //tìm kiếm sinh viên theo mã
        public void TimKiemTheoMa()
        {
            Console.Write("Nhap ma sinh vien can tim: ");
            string maSV = Console.ReadLine();
            foreach (SinhVien sv in list)
            {
                if (sv.MaSV == maSV)
                {
                   sv.XuatSV();
                }
            }
        }
        //xuat 5 sinh vien co diem trung binh tu 8.5 tro len
        public void Xuat5SVCoDiemTB8_5Den9()
        {
            int dtbt=0;
            foreach (SinhVien sv in list)
            {
                if (sv.DiemTB >= 8.5)
                {
                    dtbt++;
                   sv.XuatSV();
                }
                if (dtbt == 5)
                {
                    break;
                }
            }
        }
        //xuat 5 sinh vien co diem trung binh <5
        public void Xuat5SVCoDiemTBDuoi5()
        {
            int dtbt = 0;
            foreach (SinhVien sv in list)
            {
                if (sv.DiemTB <= 5)
                {
                    dtbt++;
                   sv.XuatSV();
                }
                if (dtbt == 5)
                {
                    break;
                }
            }
        }
        //xuat sinh vien hoc lai khi diem trung binh <5
        public void XuatSVHocLai()
        {
            foreach (SinhVien sv in list)
            {
                if (sv.DiemTB < 5)
                {
                   sv.XuatSV();
                }
            }
        }
        //xuat sinh vien co diem trung binh cao nhat, neu nhieu b bang diem nhau thi xuat tat ca
        public void XuatSVCoDiemTBMax()
        {
            double max = list.Max(x => x.DiemTB);
            foreach (SinhVien sv in list)
            {
                if (sv.DiemTB == max)
                {
                   sv.XuatSV();
                }
            }
        }
        //sap xep theo diem tu thap den cao
        public void SapXepTheoDiem()
        {
            list.Sort((x, y) => x.DiemTB.CompareTo(y.DiemTB));
            foreach (SinhVien sv in list)
            {
               sv.XuatSV();
            }
        }



    }
}
