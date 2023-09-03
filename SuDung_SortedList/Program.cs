using System;
using System.Collections;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // tạo 1 đối tượng SortedList
            // và truyền vào cách sắp xếp
            // theo key
            // cụ thể là sắp xếp tăng dần theo tuổi
            SortedList dt = new SortedList(new SapXep_TangDan_Theo_Tuoi());

            // thêm phần tử vào trong dt
            dt.Add(new ConNguoi() { ho_ten = "Nguyen Van A", tuoi = 22, gioi_tinh = GioiTinh.Male }, "Nguoi_01");
            dt.Add(new ConNguoi() { ho_ten = "Nguyen Thi B", tuoi = 30, gioi_tinh = GioiTinh.Female }, "Nguoi_02");
            dt.Add(new ConNguoi() { ho_ten = "Nguyen Van C", tuoi = 46, gioi_tinh = GioiTinh.Male }, "Nguoi_03");
            dt.Add(new ConNguoi() { ho_ten = "Nguyen Van D", tuoi = 17, gioi_tinh = GioiTinh.Male }, "Nguoi_04");
            dt.Add(new ConNguoi() { ho_ten = "Nguyen Van E", tuoi = 18, gioi_tinh = GioiTinh.Other }, "Nguoi_05");

            // in các phần tử ra màn hình
            foreach (DictionaryEntry item in dt)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}