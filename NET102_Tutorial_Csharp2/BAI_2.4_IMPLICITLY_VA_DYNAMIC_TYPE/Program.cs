﻿using System;
using System.Text;

namespace BAI_2._4_IMPLICITLY_VA_DYNAMIC_TYPE
{
    class Program
    {

        /*
         * Phần 1: Implicitly,Dynamic
         *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
         *             ❑Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                       ❑Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                       ❑Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
                    1.2 Công thức:
                        var varialble_name = value;
                    1.3 Hạn chế:
                       + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                       + Không thể khởi tạo giá trị là null.
                       + Biến phải được khởi tạo giá trị khi nó được khai báo 
                       + Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống        nhau
                       + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo     không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.
         
                    2.1 Dynamic
                        Kiểu động - ngầm định - khai báo với từ khóa dynamic, thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy (khác với kiểu ngầm định var kiểu xác định ngay        thời điểm biên dịch)
         */

        //var temp = 15; Không thẻ khai báo bên ngoài method
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;

            #region Phần 1: Implicitly 
            //1. Khai báo
            var a = 50; // Implicitly typed
            int b = 50; // Explicitly typed
            var c = true;//Và còn có thể nhận được rất nhiều kiểu dữ liệu khác nhau nữa như Class, Interface, Array, List......

            //2. Các hạn chế khi khai báo và xảy ra lỗi

            //2.0 Không thể khởi tạo giá trị là null
            //var temp1 = null;

            //2.1 Biến phải được khởi tạo giá trị khi nó được khai báo
            //var temp2;

            //2.2 Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống nhau
            //var d = 3;
            //d = "Fpoly";

            //2.3 Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.
            //Không cho phép:
            //var arrData = {10, 7, 8};
            var arrData = new int[]{10, 7, 8};

            #endregion

            #region Dynamic 

            //1. Khai báo các kiểu dữ liệu nó có thể nhận cũng như vảr
            dynamic x1;
            dynamic x = 50;
            dynamic y = 9.6;
            dynamic z = "string";

            //2. Gọi phương thước có tham số sử dụng dynamic
            var student = new
            {
                id ="PH00532",
                name = "Dungna",
                nganhHoc = "UDPM C#1"
            };
            method2(student, student.name);

            #endregion
        }

        //Implicitly Không thể khai báo kiểu var làm tham số truyền vào
        // static void method1(var x, var b)
        // {
        //
        // }

        //dynamic
        static void method2(dynamic temp1, dynamic temp2)
        {
            Console.WriteLine(temp1.id + " " +temp2);//Thời điểm biên dịch không biết các biến temp có thuộc tính abc hay không nhưng nó vẫn biên dịch
        }
    }
}
