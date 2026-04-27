using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial
{
    internal class Exercise
    {
        public static double TinhGiaBan(double giaGoc, double chietKhau)
        {
            return giaGoc * (1 - chietKhau);
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Đưa mảng vào trong Main hoặc để Static ở ngoài class
            string[] brands = { "Acer Nitro 5", "Macbook M2", "Dell XPS" };
            int[] inventory = { 10, 0, 3 }; // Thử cho 1 cái bằng 0
            double[] discount = { 0.1, 0.15, 0.2 };

            // --- BƯỚC 1: IN DANH SÁCH ---
            Console.WriteLine("DANH SÁCH SẢN PHẨM TRONG KHO:");
            for (int i = 0; i < brands.Length; i++)
            {
                string tinhTrang = (inventory[i] > 0) ? "CÒN HÀNG" : "HẾT HÀNG";
                Console.WriteLine($"{i + 1}. {brands[i]} - {tinhTrang} ({inventory[i]} máy)");
            }

            // --- BƯỚC 2: MUA HÀNG ---
            Console.Write("\nNhập số thứ tự máy bạn muốn mua (1-3): ");
            int choice = int.Parse(Console.ReadLine()) - 1; // Trừ 1 để khớp với chỉ số mảng 0, 1, 2

            // Duy hãy thử dùng If-Else hoặc Switch Case để kiểm tra:
            // 1. Nếu choice hợp lệ và còn hàng thì gọi hàm TinhGiaBan.
            // 2. Nếu hết hàng thì báo "Xin lỗi, máy này đã hết".
            // 1. Kiểm tra xem số người dùng nhập có nằm trong danh sách không (tránh lỗi văng app)
            if (choice >= 0 && choice < brands.Length)
            {
                // 2. Kiểm tra xem máy đó còn hàng không
                if (inventory[choice] > 0)
                {
                    // Giả lập giá gốc cho từng loại máy (Duy có thể dùng mảng double[] giaGoc để chuyên nghiệp hơn)
                    double giaGoc = 0;
                    switch (choice)
                    {
                        case 0: giaGoc = 20000000; break; // Acer
                        case 1: giaGoc = 35000000; break; // Macbook
                        case 2: giaGoc = 30000000; break; // Dell
                    }

                    // 3. Gọi hàm TinhGiaBan đã viết ở trên
                    double giaCuoi = TinhGiaBan(giaGoc, discount[choice]);

                    Console.WriteLine($"\nBạn đã chọn mua: {brands[choice]}");
                    Console.WriteLine($"Giá gốc: {giaGoc:N0} VND"); // :N0 để định dạng dấu phẩy phân cách phần nghìn
                    Console.WriteLine($"Chiết khấu: {discount[choice] * 100}%");
                    Console.WriteLine($"Số tiền cần thanh toán: {giaCuoi:N0} VND");

                    // 4. (Nâng cao) Trừ tồn kho sau khi bán thành công
                    inventory[choice]--;
                    Console.WriteLine($"Số lượng còn lại trong kho: {inventory[choice]} máy.");
                }
                else
                {
                    Console.WriteLine($"\nXin lỗi Duy, máy {brands[choice]} hiện đang HẾT HÀNG!");
                }
            }
            else
            {
                Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng chạy lại và nhập từ 1 đến 3.");
            }

            Console.WriteLine("\nCảm ơn bạn đã sử dụng hệ thống!");
        }
    }
}
