using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial
{
    internal class Method
    {

        //public static int tinhTong(int a, int b)
        //{
        //    int tong = a + b;
        //    return tong;
        //}
        //static void Main()
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.Write("nhap a: ");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("nhap b: ");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Tong cua " + a + " va " + b + " la: " + tinhTong(a, b));
        //}


        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo mảng 2 chiều (2 tầng, mỗi tầng 3 phòng)
            int[,] trangThaiPhong = {
            { 0, 1, 0 }, // Tầng 0 (0: Trống, 1: Có người)
            { 1, 1, 0 },
            { 1, 1, 1 }
        };

            // GetLength(0) là lấy số hàng, GetLength(1) là lấy số cột
            for (int i = 0; i < trangThaiPhong.GetLength(0); i++)
            {
                for (int j = 0; j < trangThaiPhong.GetLength(1); j++)
                {
                    Console.Write("Tầng " + i + " Phòng " + j + ": " + trangThaiPhong[i, j] + " | ");
                }
                Console.WriteLine(); // Xuống dòng khi hết một tầng
            }
        }
    }
}
