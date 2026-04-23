using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial
{
    internal class loop_for
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Số hiện tại là: " + i);
            //}


            //Console.WriteLine("--- Bắt đầu đếm ---");

            //for (int i = 1; i <= 10; i++)
            //{
            //    // Nếu i là số chẵn, hãy in thêm chữ "Số chẵn"
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " là số chẵn");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + " là số lẻ");
            //    }
            //}

            //Console.WriteLine("--- Kết thúc ---");


            //Console.WriteLine("--- Bắt đầu đếm ---");
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.Write(i + " ");
            //}


            string matKhau = "";

            // Chừng nào mật khẩu chưa đúng là "123", thì cứ bắt nhập hoài
            while (matKhau != "123")
            {
                Console.Write("Nhập mật khẩu để vào hệ thống: ");
                //matKhau = Console.ReadLine();

                if (matKhau != "123")
                {
                    Console.WriteLine("Sai rồi! Nhập lại đi.");
                }
            }

            Console.WriteLine("Chúc mừng! Bạn đã vào được hệ thống.");
        }
    }
}
