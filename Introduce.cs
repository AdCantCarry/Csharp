using System;

public class Introduce
{
    public static void Main(string[] args)
    {

        //string name = "Nguyen Anh Duy";

        //int age = 22;

        //bool laSinhVien = true;

        //Console.WriteLine(name);

        //Console.WriteLine(age);

        //Console.WriteLine(laSinhVien);



        //Console.WriteLine("Nhap ten cua ban: ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Nhap tuoi: ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Xin chao " + name);
        //Console.WriteLine("Ban " + age + " tuoi");



        Console.Write("Nhap diem thi: ");
        string input = Console.ReadLine();
        double diem = Convert.ToDouble(input); // Chuyển chữ thành số thực

        // Bước tiếp theo: Kiểm tra logic
        bool laDat = (diem >= 5);

        Console.WriteLine("Ket qua dat: " + laDat);
    }
}