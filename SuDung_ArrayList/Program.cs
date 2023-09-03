using System;
using System.Collections;

// khi tạo đối tượng có kiểu ArrayList
// thì nó sẽ phải sử dụng thư viện System.Collections

// ArrayList thì truy xuất phần tử bằng chỉ số index

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // tạo đối tượng
            // có kiểu ArrayList
            ArrayList dt = new ArrayList();

            // thêm 3 phần tử vào trong ArrayList
            dt.Add(
                new ConNguoi {
                    ho_ten = "Nguyen Van A",
                    tuoi = 19,
                    gioi_tinh = GioiTinh.Male,
                    dia_chi = "Ha Noi"
                }
            );

            dt.Add(
                new ConNguoi
                {
                    ho_ten = "Nguyen Thi B",
                    tuoi = 40,
                    gioi_tinh = GioiTinh.Female,
                    dia_chi = "Hai Phong"
                }
            );

            dt.Add(
                new ConNguoi
                {
                    ho_ten = "Nguyen Van C",
                    tuoi = 30,
                    gioi_tinh = GioiTinh.Other,
                    dia_chi = "TP. Ho Chi Minh"
                }
            );

            // in ra danh sách con người
            Console.WriteLine("--------------- DANH SACH CON NGUOI ---------------");
            foreach (ConNguoi item in dt)
            {
                Console.WriteLine(item.ToString());
            }

            /*
                nếu bạn muốn sắp xếp ArrayList
                thì bạn phải tạo 1 lớp mới
                lớp đó sẽ kế thừa interface IComparer
                sau đó sẽ phải triển khai phương thức int Compare(object? x, object? y)
            */

            // Comparer nghĩa là bộ sắp xếp

            // in ra danh sách đã được sắp xếp
            Console.WriteLine();
            Console.WriteLine("------------ SAP XEP THEO TUOI TANG DAN -----------");
            dt.Sort(new SapXep_TheoTuoi_TangDan());

            foreach (ConNguoi item in dt)
            {
                Console.WriteLine(item.ToString());
            }



            /*
                nếu bạn muốn lấy cái dt
                đem gán cho 1 đối tượng khác
                thì nó sẽ xảy ra hiện tượng tham chiếu đến 1 vùng nhớ
                nếu bạn sửa trong đối tượng 2
                thì cái đối tượng dt cũng bị sửa luôn
                vì là tham chiếu mà
            */
            ArrayList dt2 = dt;         // đây là tham chiếu



            /*
                nếu bạn hỏi có cách nào để không bị tham chiếu không
                thì câu trả lời là có
                chúng ta sẽ sử dụng hàm khởi tạo sao chép
                lúc này
                vùng nhớ của đối tượng clone và dt sẽ là 2 vùng nhớ riêng biệt
                sẽ không xảy ra hiện tượng tham chiếu
            */

            // đây là xin cấp phát 1 vùng nhớ mới luôn
            // như này sẽ không xảy ra hiện tượng tham chiếu
            // nếu bạn sửa dữ liệu họ tên trong clone
            // thì dt sẽ không bị sửa
            // vì không phải tham chiếu đó!
            ArrayList clone = new ArrayList(dt);
        }
    }
}