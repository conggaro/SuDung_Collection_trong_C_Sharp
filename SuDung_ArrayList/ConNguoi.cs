using System;

namespace MyApp
{
    // tạo ra kiểu dữ liệu giới tính
    public enum GioiTinh
    {
        Male,           // Nam giới
        Female,         // Nữ giới
        Other           // Khác
    }

    public class ConNguoi
    {
        // thuộc tính họ tên
        public string ho_ten {  get; set; }


        // thuộc tính tuổi
        public int tuoi { get; set; }


        // thuộc tính giới tính
        public GioiTinh gioi_tinh { get; set; }


        // thuộc tính địa chỉ
        public string dia_chi { get; set; }


        // hàm khởi tạo không tham số
        public ConNguoi()
        {
            ho_ten = string.Empty;
            tuoi = 0;
            gioi_tinh = GioiTinh.Other;
            dia_chi = string.Empty;
        }


        // ghi đè phương thức ToString()
        public override string ToString()
        {
            return $"[{ho_ten}, {tuoi}, {gioi_tinh}, {dia_chi}]";
        }
    }
}
