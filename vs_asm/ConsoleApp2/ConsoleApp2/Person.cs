using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        //property
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string QueQuan { get; set; }
        public string NamSinh { get; set; }
        //constructor
        public Person()
        {
        }
        public Person(string ho, string tenDem, string ten, string queQuan, string namSinh)
        {
            Ho = ho;
            TenDem = tenDem;
            Ten = ten;
            QueQuan = queQuan;
            NamSinh = namSinh;
        }
        //method
        public void Nhap()
        {
            Console.Write("Nhap ho: ");
            Ho = Console.ReadLine();
            Console.Write("Nhap ten dem: ");
            TenDem = Console.ReadLine();
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ho: {0}", Ho);
            Console.WriteLine("Ten dem: {0}", TenDem);
            Console.WriteLine("Ten: {0}", Ten);
            Console.WriteLine("Que quan: {0}", QueQuan);
            Console.WriteLine("Nam sinh: {0}", NamSinh);
        }
        
    }
}
