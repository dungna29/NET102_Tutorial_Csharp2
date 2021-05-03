using System;
using System.Text;

namespace BAI_2._0_PHUONG_THUC_GENERIC
{
    class Program
    {
        /*
         * Phương thức Generic
         *  Dưới đây là một ví dụ về việc khai báo một phương thức chung chung:
         *      - X ở đây là kiểu dữ liệu áp dụng cho phương thức của phương thức có thể dùng các ký tự như A,B,C.....
         *      - Y là kiểu dữ liệu của tham số Y
         *      - Bạn có thêm bao nhiêu tham số tùy ý khi sử dụng đảm bảm truyền đúng kiểu dữ liệu của phương thức và tham số mong muốn

         
           X MyFunction<X, Y>(X x, Y y)
               {
               return x;
               }
         */
        static A MyFunction<A, B>(A x, B y)
        {
            Console.WriteLine("Giá trị của tham số y: " + y);
            return x;
        }
        static A MyFunction1<A, B, C, D>(A x, B y, C c, D d)
        {
            Console.WriteLine("Giá trị của tham số y: " + y);
            return x;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;

            int a = 1;
            string b = "FPT";
            int rs = MyFunction<int, string>(a, b);  // Phương thức trả về kiểu int và tham số b là kiểu string
            Console.WriteLine(rs);

            string d = MyFunction<string, int>(b, a); // Phương thức trả về kiểu string và tham số a là kiểu in do người lập trình định nghĩa
            Console.WriteLine(d);

            double c = 2;
            MyFunction<double, int>(c, a);           // Phương thức trả về kiểu double và tham số a là kiểu in do người lập trình định nghĩa
        }
    }
}
