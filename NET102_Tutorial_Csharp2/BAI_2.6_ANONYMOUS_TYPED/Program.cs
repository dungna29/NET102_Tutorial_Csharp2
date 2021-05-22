using System;
using System.Text;

namespace BAI_2._6_ANONYMOUS_TYPED
{
    class Program
    {
        #region ANONYMOUS TYPED
        /*
         * Phần 1:  Định nghĩa:
             * ❑Kiểu ẩn danh (Anonymous Type) cung cấp một cách thuận tiện để đóng gói (encapsulate) một tập các thuộc tính chỉ đọc (read-only properties) vào một đối tượng mà không cần phải xác định rõ ràng loại (type) của nó ngay lúc viết code
             * ❑Cho phép tạo type mới (user-defined) mà không cần xác định tên của nó
               ❑Tạo các type ẩn danh này bằng cách sử dụng toán tử new

           Phần 2: ANONYMOUS METHOD
            ❑Phương thức vô danh (anonymous method) là một phương thức:
               ❖Không cần khai báo tên phương thức khi định nghĩa phương thức
               ❖Có thể khai báo trực tiếp ở chỗ cần dùng, không cần định nghĩa trước
               ❖Đươc dùng như tham số của deleg

            ❑Một số giới hạn Anonymous methods
                ❖Không khái báo được các lệnh goto, break or continue bên trong phương thức
                ❖Không truy cập được các tham số ref hoặc out bên ngoài
                ❖Phải được dùng kết hợp với delegate
         */

        //Khai báo phương thức delegate
        public delegate void Method1(int temp);

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;

            /*
             * Phần 1: Khai báo Anonymous và Anonymous lồng nhau
             */

            var studentUDPM = new
            {
                Id = "PH00532",
                name = "Dungna29",
                trangThai = true
            };
            Console.WriteLine("ID = {0} | Name = {1} Trang Thai = {2}",studentUDPM.Id,studentUDPM.name,studentUDPM.trangThai);
            var studentUDPM2 = new
            {
                Id = "PH00532",
                name = "Dungna29",
                trangThai = true,
                diachi = new
                {
                    sonha = "Nha so 2",
                    quan = "Tây Hồ",
                    thanhPho = "Hà Nội"
                }
            };
            Console.WriteLine("ID = {0} | Name = {1} | Trang Thai = {2} | Đia chỉ = {3}", studentUDPM2.Id, studentUDPM2.name, studentUDPM2.trangThai, studentUDPM2.diachi.sonha);

            /*
             * PHần 2: Phương thức vô danh
             */
            Method1 method1 = delegate(int temp)
            {
                Console.WriteLine("Đây là phương thức vô danh. Giá trị {0}",temp);
            };
            method1(2021);//Gọi đến phương thức vô danh

            int temp1 = 2021;
            Method1 method2 = delegate (int temp)
            {
                temp1 += 10;//Sử dụng biến cục bộ bên ngoài như bình thường
                Console.WriteLine("Đây là phương thức vô danh. Giá trị {0}", temp);
            };
        }
    }
}
