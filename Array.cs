using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial
{
    internal class Array
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //// Khai báo mảng số nguyên có 5 phần tử
            //int[] numbers = new int[5];

            //// Gán giá trị cho các phần tử của mảng
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;

            //// In ra các phần tử của mảng
            //Console.WriteLine("Các phần tử trong mảng:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //// Tính tổng các phần tử trong mảng
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Tổng các phần tử trong mảng: " + sum);





            //string[] danhSachKhach = new string[5];

            //danhSachKhach[0] = "Nguyen Anh Duy";
            //danhSachKhach[1] = "Le Thi Mai";
            //danhSachKhach[2] = "Tran Van An";
            //danhSachKhach[3] = "Pham Thi Hoa";
            //danhSachKhach[4] = "Hoang Van Binh";

            //for (int i = 0; i < danhSachKhach.Length; i++)
            //{
            //    Console.WriteLine("Khách ở phòng " + i + " là: " + danhSachKhach[i]);
            //}



            //int[] danhSachDiem = { 8, 4, 9 };

            //// Vòng lặp chạy từ 0 đến 2 (vì có 3 phần tử)
            //for (int i = 0; i < danhSachDiem.Length; i++)
            //{
            //    // Lấy điểm tại vị trí i ra để kiểm tra
            //    int diemHienTai = danhSachDiem[i];

            //    Console.Write("Môn thứ " + i + " có điểm là " + diemHienTai + ": ");

            //    if(diemHienTai < 5)
            //    {
            //        Console.WriteLine("Phải thi lại");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Qua môn");
            //    }
            //}




            //int[] danhSachDiem = { 4, 7, 9 };

            //// Dùng vòng lặp for để "tặng" mỗi bạn 1 điểm
            //for (int i = 0; i < danhSachDiem.Length; i++)
            //{
            //    // Truy cập trực tiếp vào ngăn thứ i và cộng thêm 1
            //    danhSachDiem[i] = danhSachDiem[i] + 1;
            //    int diemHienTai = danhSachDiem[i];

            //    Console.Write("Môn thứ " + i + " có điểm là " + diemHienTai + ": ");

            //    if (diemHienTai < 5)
            //    {
            //        Console.WriteLine("Phải thi lại");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Qua môn");
            //    }
            //}


            //int[] danhSachDiem = { 8, 4, 9 };

            //Console.WriteLine("--- KIỂM TRA KẾT QUẢ ---");

            //// Với mỗi con "diem" nằm trong "danhSachDiem"
            //foreach (int diem in danhSachDiem)
            //{
            //    if (diem < 5)
            //    {
            //        Console.WriteLine(diem + ": Phải thi lại");
            //    }
            //    else
            //    {
            //        Console.WriteLine(diem + ": Qua môn");
            //    }
            //}
        }   
    }
}
