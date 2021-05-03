using System;
using System.Text;

namespace BAI_2._2_TU_KHOA_STATIC
{
    class Program
    {
        #region PHẦN 1:  Từ khóa Static
        /*
         * Thông thường các thuộc tính, phương thức sẽ có các đặc điểm sau:
         *      - Chỉ có thể sử dụng sau khi khởi tạo đối tượng.
                - Dữ liệu thuộc về riêng mỗi đối tượng (xét cùng 1 thuộc tính thì các đối tượng khác nhau thì thuộc tính đó sẽ mang các giá trị khác nhau).
                - Được gọi thông qua tên của đối tượng
           ĐÔI LÚC BÀI TOÁN ĐƯA RA MUỐN 1 THUỘC TÍNH NÀO ĐÓ ĐƯỢC DÙNG CHUNG CHO MỌI ĐỐI TƯỢNG VÀ CHỈ ĐƯỢC CẤP PHÁT TRONG VÙNG NHỚ DUY NHẤT => TỪ ĐÓ KHÁI NIỆM STATIC RA ĐỜI.
        
           ĐẶC ĐIỂM STATIC:
               - Được khởi tạo 1 lần duy nhất ngay khi biên dịch chương trình.
               - Có thể dùng chung cho mọi đối tượng.
               - Được gọi thông qua tên lớp.
               - Được huỷ khi kết thúc chương trình.
          
           CÓ 4 LOẠI STATIC:
               - Biến tĩnh (static variable).
               - Phương thức tĩnh (static method).
               - Lớp tĩnh (static class).
               - Phương thức khởi tạo tĩnh (static constructor).  
         */


        #endregion

        #region PHẦN 2: Biến Static
        /*
         * - Một biến dùng chung cho mọi đối tượng thuộc lớp.
           - Nó được khởi tạo vùng nhớ 1 lần duy nhất ngay khi chương trình được nạp vào bộ nhớ để thực thi và huỷ khi kết thúc chương trình.
         * <phạm vi truy cập> static <kiểu dữ liệu> <tên biến> = <giá trị khởi tạo>;
         */
        public static int Count = 0;

        public Program()
        {
            Count++;
        }

        public  void bienStatic()
        {
            Program program1 = new Program();
            Console.WriteLine("Số lần khởi tạo: " + Count);
            Program program2 = new Program();
            Console.WriteLine("Số lần khởi tạo: " + Count);
            Program program3 = new Program();
            Console.WriteLine("Số lần khởi tạo: " + Count);
        }

        #endregion

        #region PHẦN 3: Phương thức static
        /*
         * Phương thức tĩnh
         * <phạm vi truy cập> static <kiểu trả về> <tên phương thức>           
           {
           
           // line code
           
           }

            
        Hàm tĩnh được sử dụng với 2 mục đích chính:           
           - Hàm tĩnh là 1 hàm dùng chung của lớp. Được gọi thông qua tên lớp và không cần khởi tạo bất kỳ đối tượng nào, từ đó tránh việc lãng phí bộ nhớ.
           - Hỗ trợ trong việc viết các hàm tiện ích để sử dụng lại.
           - Về sử dụng thì bạn thao tác hoàn toàn giống 1 phương thức bình thường chỉ cần lưu ý là phải gọi phương thức này thông qua tên lớp.
         */


        #endregion

        #region PHẦN 4: Class static
        /*        
         <phạm vi truy cập> static class <tên lớp>
            {

             // Các thành phần của 1 class đối tượng

            }
        Lớp tĩnh có các đặc điểm
           + Chỉ chứa các thành phần tĩnh (biến tĩnh, phương thức tĩnh).
           + Không thể khai báo, khởi tạo 1 đối tượng thuộc lớp tĩnh.
           Với 2 đặc điểm trên có thể thấy lớp tĩnh thường được dùng với mục đích khai báo 1 lớp tiện ích chứa các hàm tiện ích hoặc hằng số vì:           
               - Ràng buộc các thành phần bên trong lớp phải là static.
               - Không cho phép tạo ra các đối tượng dư thừa làm lãng phí bộ nhớ.
               - Mọi thứ đều được truy cập thông qua tên lớp.
        Trong C# có rất nhiều lớp tiện ích sử dụng lớp tĩnh, phương thức tĩnh để khai báo. Ví dụ điển hình đó là lớp Math.
         */


        #endregion

        #region PHẦN 5: Contrcutor Static
        /*
         * Không được phép khai báo phạm vi truy cập. Nếu cố tình làm điều này C# sẽ báo lỗi khi biên dịch.
         * Constructor tĩnh sẽ được gọi 1 lần duy nhất khi chương trình được nạp vào bộ nhớ để thực thi như là 1 cách để ta thiết lập một số thông số theo ý muốn trước khi có bất kỳ đối tượng nào được tạo ra.
           Constructor tĩnh cũng giống phương thức tĩnh nên không thể gọi các thuộc tính không phải static.
         * static <tên lớp>()           
           {
           
           // nội dung của constructor
           
           }
         */


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;

            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable
        }
    }
}
