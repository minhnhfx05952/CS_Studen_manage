using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SinhVien:Person
    {
        //property
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        //constructor
        public SinhVien()
        {
        }
        public SinhVien(string Ho, string Ten, string TenDem, string QueQuan, string NamSinh, string maSV, double diemTB):base(Ho,Ten,TenDem,QueQuan,NamSinh)
        {
            this.MaSV = MaSV;
            this.DiemTB = diemTB;
        }

        //method
        public void NhapSV()
        {
            base.Nhap();
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            DiemTB = double.Parse(Console.ReadLine());
        }
        public void XuatSV()
        {
            base.Xuat();
            Console.WriteLine("Ma sinh vien: {0}", MaSV);
            Console.WriteLine("Diem trung binh: {0}", DiemTB);
        }

    }
}
