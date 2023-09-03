using System;
using System.Collections;

namespace MyApp
{
    // tạo lớp sắp xếp con người
    public class SapXep_TheoTuoi_TangDan : IComparer
    {
        public int Compare(object x, object y)
        {
            // ép kiểu 2 đối tượng
            // khi truyền vào phương thức Compare
            // thành kiểu dữ liệu ConNguoi
            ConNguoi dt1 = (ConNguoi)x;
            ConNguoi dt2 = (ConNguoi)y;

            if (dt1 == null || dt2 == null)
            {
                // ví có thể 2 đối tượng truyền vào không phải ConNguoi
                // ta nên ném ra lỗi để lập trình viên sửa chữa

                throw new InvalidOperationException();
            }
            else
            {
                // khi dữ liệu OK thì ta sẽ đem so sánh
                // ta sẽ return ra 1, hoặc 0, hoặc -1
                if (dt1.tuoi > dt2.tuoi)
                {
                    return 1;
                }
                else if (dt1.tuoi == dt2.tuoi)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}