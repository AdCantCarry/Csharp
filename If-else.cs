using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class If_else
    {
        static void Main()
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Console.Write("Nhap diem cua ban: ");
        //float diem = float.Parse(Console.ReadLine());

        //if (diem >= 8.5)
        //{
        //    Console.WriteLine("Ket qua: gioi");
        //}
        //else if (diem >= 6.5)
        //{
        //    Console.WriteLine("Ket qua: kha");
        //}
        //else if (diem >= 5)
        //{
        //    Console.WriteLine("Ket qua: trung binh");
        //}
        //else
        //{
        //    Console.WriteLine("Ket qua: hoc lai nha!");
        //}


        //Toan tu
        double diemChuyenCan = 7;
        int soBuoiVang = 2;
        //Console.Write("Nhap diem chuyen can: ");
        //double diemChuyenCan = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Nhap so buoi vang: ");
        //int soBuoiVang = Convert.ToInt32(Console.ReadLine());

        if (diemChuyenCan >= 5 || soBuoiVang <= 3)
        {
            Console.WriteLine("Ban duoc di thi!");
        }
        else
        {
            Console.WriteLine("Ban khong duoc di thi!");
        }
    }
    }
