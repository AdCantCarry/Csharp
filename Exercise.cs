using System;

namespace C__tutorial
{
    internal class Exercise
    {
        // Hàm tính giá bán
        public static double TinhGiaBan(double giaGoc, double chietKhau)
        {
            return giaGoc * (1 - chietKhau);
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] brands = { "Acer Nitro 5", "Macbook M2", "Dell XPS" };
            int[] inventory = { 10, 0, 3 };
            double[] discount = { 0.1, 0.15, 0.2 };

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("DANH SÁCH SẢN PHẨM TRONG KHO:");
                for (int i = 0; i < brands.Length; i++)
                {
                    string tinhTrang = (inventory[i] > 0) ? "CÒN HÀNG" : "HẾT HÀNG";
                    Console.WriteLine($"{i + 1}. {brands[i]} - {tinhTrang} ({inventory[i]} máy)");
                }

                Console.Write("\nNhập số thứ tự (1-3) để mua, hoặc gõ 'thoat' để dừng: ");
                string input = Console.ReadLine();

                // 1. Kiểm tra lệnh thoát
                if (input.ToLower() == "thoat")
                {
                    Console.WriteLine("Cảm ơn Duy đã sử dụng hệ thống. Tạm biệt!");
                    break;
                }

                // 2. Chuyển đổi đầu vào sang số
                if (int.TryParse(input, out int choiceNumber))
                {
                    int choice = choiceNumber - 1; // Khớp với index mảng

                    // 3. Kiểm tra số thứ tự có hợp lệ không (1-3)
                    if (choice >= 0 && choice < brands.Length)
                    {
                        // 4. Kiểm tra còn hàng không
                        if (inventory[choice] > 0)
                        {
                            double giaGoc = 0;
                            switch (choice)
                            {
                                case 0: giaGoc = 20000000; break;
                                case 1: giaGoc = 35000000; break;
                                case 2: giaGoc = 30000000; break;
                            }

                            // Tính toán và in kết quả
                            double giaCuoi = TinhGiaBan(giaGoc, discount[choice]);

                            Console.WriteLine($"\nBạn đã chọn mua: {brands[choice]}");
                            Console.WriteLine($"   Giá gốc: {giaGoc:N0} VND");
                            Console.WriteLine($"   Chiết khấu: {discount[choice] * 100}%");
                            Console.WriteLine($"   Số tiền cần thanh toán: {giaCuoi:N0} VND");

                            // Trừ tồn kho
                            inventory[choice]--;
                            Console.WriteLine($"   Số lượng còn lại: {inventory[choice]} máy.");
                        }
                        else
                        {
                            Console.WriteLine($"\nXin lỗi máy {brands[choice]} hiện đang HẾT HÀNG!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nLựa chọn không hợp lệ (Chỉ nhập từ 1 đến 3).");
                    }
                }
                else
                {
                    Console.WriteLine("\nVui lòng nhập số hoặc chữ 'thoat'.");
                }
            }
        }
    }
}