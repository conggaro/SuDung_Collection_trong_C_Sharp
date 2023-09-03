using System;

namespace MyApp
{
    // tạo kiểu dữ liệu enum
    public enum GioiTinh
    {
        Male,                   // nam giới
        Female,                 // nữ giới
        Other                   // khác
    }

    public class ConNguoi
    {
        public string ho_ten {  get; set; }
        public int tuoi { get; set; }
        public GioiTinh gioi_tinh { get; set; }


        // hàm khởi tạo không tham số
        public ConNguoi()
        {
            ho_ten = string.Empty;
            tuoi = 0;
            gioi_tinh = GioiTinh.Other;
        }


        // ghi đè phương thức ToString()
        public override string ToString()
        {
            return $"[{ho_ten}, {tuoi}, {gioi_tinh}]";
        }
    }
}
