using System;
using System.Collections;

namespace MyApp
{
    public class SapXep_TangDan_Theo_Tuoi : IComparer
    {
        // triển khai phương thức Compare
        public int Compare(object x, object y)
        {
            // chuyển kiểu của 2 đối tượng
            // về kiểu ConNguoi
            ConNguoi dt1 = (ConNguoi)x;
            ConNguoi dt2 = (ConNguoi)y;

            // kiểm tra khác null
            if (dt1 == null || dt2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
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
