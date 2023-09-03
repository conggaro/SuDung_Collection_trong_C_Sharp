using System;
using System.Collections;

/*
    bảng băm HashTable
    thì truy cập phần tử bằng Key

    khi sử dụng vòng lặp foreach()
    bạn có thể sử dụng item.Key
    bạn cũng có thể sử dụng item.Value

    CHÚ Ý:
    => bảng băm không thể truy cập phần tử bằng chỉ số Index
*/

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // sử dụng bảng băm
            // nó là HashTable

            // tạo đối tượng bảng băm
            Hashtable dt = new Hashtable();

            // thêm dữ liệu vào bảng băm
            // phải thêm theo cú pháp Key - Value
            dt.Add("Nguoi_01", new ConNguoi() { ho_ten = "Nguyen Van A", tuoi = 20, gioi_tinh = GioiTinh.Male });
            dt.Add("Nguoi_02", new ConNguoi() { ho_ten = "Nguyen Van B", tuoi = 18, gioi_tinh = GioiTinh.Female });
            dt.Add("Nguoi_03", new ConNguoi() { ho_ten = "Nguyen Van C", tuoi = 30, gioi_tinh = GioiTinh.Male });
            dt.Add("Nguoi_04", new ConNguoi() { ho_ten = "Nguyen Van D", tuoi = 46, gioi_tinh = GioiTinh.Male });
            dt.Add("Nguoi_05", new ConNguoi() { ho_ten = "Nguyen Van E", tuoi = 15, gioi_tinh = GioiTinh.Other });

            // in dữ liệu ra màn hình
            // cách 1:
            Console.WriteLine("Cach 1:");

            /*
                vì tôi đã ghi đè phương thức ToString()
                nên HashTable tự động sử dụng ToString() khi tôi truy cập phần tử
                tức là tôi không phải viết dt["Nguoi_01"].ToString()
            */
            Console.WriteLine(dt["Nguoi_01"]);
            Console.WriteLine(dt["Nguoi_02"]);
            Console.WriteLine(dt["Nguoi_03"]);
            Console.WriteLine(dt["Nguoi_04"]);
            Console.WriteLine(dt["Nguoi_05"]);


            // cách 2:
            Console.WriteLine("\nCach 2:");
            foreach (DictionaryEntry item in dt)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}