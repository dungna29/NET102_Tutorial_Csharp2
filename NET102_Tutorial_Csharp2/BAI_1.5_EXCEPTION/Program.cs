﻿using System;
using System.IO;
using System.Text;

namespace BAI_1._5_EXCEPTION
{
    class Program
    {
        #region EXCEPTION - Xử lý ngoại lệ
        /*
         * ❑ Exception là các vấn đề phát sinh trong quá trình thực hiện chương trình như: không đọc được tập tin, kiểu dữ liệu sai…
           ❑ Các exception được sinh ra bởi .NET framework CLR hoặc lập trình viên
           ❑ Xử lý ngoại lệ trong C# được xây dựng chủ yếu trên bốn từ khoá try, catch, finally và throw
                               try
                               {                              
                                    //Các câu lệnh
                               }
                               catch (Exception a)
                               {
                                     //Phần code để xử lý lỗi hoặc đơn giản chỉ là show ra lỗi
                                                            
                               }
                               finally
                               {
                                    //Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho, dù có hay không một exception đươc ném hoặc không được ném.
                               }
            Một số Exception class thường gặp:
                - Exception [Lớp cơ bản của mọi ngoại lệ.]          
                - SystemException [Lớp cơ bản của mọi ngoại lệ phát ra tại thời điểm chạy của chương trình.]           
                - IndexOutOfRangeException [Được ném ra tại thời điểm chạy khi truy cập vào một phần tử của mảng với chỉ số không đúng.]           
                - NullReferenceException [Ném ra tại thời điểm chạy khi một đối tượng null được tham chiếu.]
                - AccessViolationException [Ném ra tại thời điểm chạy khi tham chiếu vào vùng bộ nhớ không hợp lệ.]
                - InvalidOperationException [Ném ra bởi phương thức khi ở trạng thái không hợp lệ.]           
                - ArgumentException [Lớp cơ bản cho các ngoại lệ liên quan tới đối số (Argument).]
                - ArgumentNullException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức mà không cho phép thông số null truyền vào.]
                - ArgumentOutOfRangeException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức khi một đối số không thuộc phạm vi cho phép truyền vào nó.]
                - ExternalException [Lớp cơ bản cho các ngoại lệ xẩy ra hoặc đến từ môi trường bên ngoài.]
                - COMException [Lớp này mở rộng từ ExternalException, ngoại lệ đóng gói thông tin COM.]
                - SEHException [Lớp này mở rộng từ ExternalException, nó tóm lược các ngoại lệ từ Win32.]
         */

        //Ví dụ 1: Đối với số nguyên chia cho 0 sẽ gây phát sinh lỗi
        public static void ViDu1()
        {
            
            int a = 5, b = 0, c;
            c = a / b;//System.DivideByZeroException: 'Attempted to divide by zero.'
            Console.WriteLine(c);
        }

        //Ví dụ 2:Sử dụng Try Catch sẽ giúp chương trình tiếp tục thực thi không bị kết thúc đột ngột (Crash)
        public static void ViDu2()
        {

            try
            {
                int a = 5, b = 0, c;
                c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                /*
                 * 1. Trong chương trình khi phát sinh 1 lỗi xảy ra thì sẽ phát sinh đối tượng Exception hoặc lớp kế thừa từ lớp này. Lớp này giúp hiển thị các thông tin về lỗi giúp xử lý các bước tiếp theo.
                    - e.Message : Thông tin về lỗi
                    - e.StackTrace: Truy vết của lỗi nằm ở đâu
                    - e.GetType().Name: Thông tin lỗi của lớp nào
                    ..... Hãy khám phá thêm trong quá trình học
                 */

                Console.WriteLine("Phép chia có lỗi");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);//Có thể gọi thằng lớp đó thay cho Exception
            }

            Console.WriteLine("Kết thúc ví dụ 2");
        }

        // Ví dụ 3:  Sử dụng Finally - 
        public static void ViDu3()
        {
            string path = @"D:\1.txt";
            StreamReader sr = new StreamReader(path);
            try
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Đọc file xảy ra lỗi");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
            }
            finally
            {
                //Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho, dù có hay không một exception đươc ném hoặc không được ném.
                Console.WriteLine("Finally: ");
                if (sr!= null)
                {
                    sr.Close();
                }
            }
           
            Console.WriteLine("Kết thúc ví dụ 4");
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ViDu3();
        }
    }
}
