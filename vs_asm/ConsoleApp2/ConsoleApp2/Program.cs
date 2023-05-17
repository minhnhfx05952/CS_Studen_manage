using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class main
    {
        
        static void Main(string[] args)
        {
            Services sv = new Services();

            bt:
            Console.WriteLine("");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach sinh vien");
            Console.WriteLine("3. Sua sinh vien");
            Console.WriteLine("4. Xoa sinh vien");
            Console.WriteLine("5. Tim kiem sinh vien");
            Console.WriteLine("6. Xuat 5 sinh vien co diem trung binh tu 8.5 den 9.0 tro len");
            Console.WriteLine("7. Xuat 5 sinh vien co diem trung binh duoi 5");
            Console.WriteLine("8. Xuat danh sach sinh vien hoc lai khi diem duoi 5");
            Console.WriteLine("9. Xuat sinh vien co diem cao nhat khoi, neu trung diem xuat ra cac ban co diem giong nhau");
            Console.WriteLine("10. Sap xep theo ten hoac diem");
            Console.WriteLine("11. Thoat");
            Console.WriteLine("===================================");
            Console.Write("Ban muon lam bai may (chi nhap so)? ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Them sinh vien");
                    Console.WriteLine("===================================");
                    sv.Nhap();
                    
                    break;
                case 2:
                    Console.WriteLine("Xuat danh sach sinh vien");
                    Console.WriteLine("===================================");
                    sv.Xuat();
                    break;
                case 3:
                    Console.WriteLine("Sua sinh vien");
                    Console.WriteLine("===================================");
                    sv.Sua();
                    break;
                case 4:
                    Console.WriteLine("Xoa sinh vien");
                    Console.WriteLine("===================================");
                    sv.Xoa();
                    break;
                case 5:
                    Console.WriteLine("Tim kiem sinh vien");
                    Console.WriteLine("===================================");
                    sv.TimKiemTheoMa();
                    break;
                case 6:
                    Console.WriteLine("Xuat 5 sinh vien co diem trung binh tu 8.5 den 9.0 tro len");
                    Console.WriteLine("===================================");
                    sv.Xuat5SVCoDiemTB8_5Den9();
                    break;
                case 7:
                    Console.WriteLine("Xuat 5 sinh vien co diem trung binh duoi 5");
                    Console.WriteLine("===================================");
                    sv.Xuat5SVCoDiemTBDuoi5();
                    break;
                case 8:
                    Console.WriteLine("Xuat danh sach sinh vien hoc lai khi diem duoi 5");
                    Console.WriteLine("===================================");
                    sv.XuatSVHocLai();
                    break;
                case 9:
                    Console.WriteLine("Xuat sinh vien co diem cao nhat khoi, neu trung diem xuat ra cac ban co diem giong nhau");
                    Console.WriteLine("===================================");
                    sv.XuatSVCoDiemTBMax();
                    
                    break;
                case 10:
                    Console.WriteLine("Sap xep theo ten hoac diem");
                    Console.WriteLine("===================================");
                    sv.SapXepTheoDiem();
                    break;
                case 11:
                    Console.WriteLine("Thoat");
                    break;
                default:
                    Console.WriteLine("Ban nhap sai, moi nhap lai");
                    goto bt;
            }

        choose:
            {
                Console.WriteLine("chon lai chuc nang");
                Console.WriteLine("===================================");
                Console.Write("Ban muon tiep tuc khong (y/n)? ");
                string choose = Console.ReadLine();
                if (choose == "y")
                {
                    goto bt;
                }
                else if (choose == "n")
                {
                    Console.WriteLine("Cam on ban da su dung chuong trinh");
                }
                else
                {
                    Console.WriteLine("Ban nhap sai, moi nhap lai");
                    goto choose;
                }
            }
            //thêm chức năng
            


        }
    }
    
}
