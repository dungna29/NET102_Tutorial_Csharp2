using System;


namespace BAI_2._8_DocGhiDoiTuong
{
    class Program
    {
        /*
         * Khái niệm serialization
         *
         *Khi tạo ra một object trong chương trình, .NET framework, bạn hầu như không cần quan tâm đến cách thức lưu trữ và quản lý dữ liệu của object đó trong bộ nhớ vì .NET framework thay bạn thực hiện các công việc này.
         *
         *Tuy nhiên, nếu bạn muốn lưu trữ trạng thái của object đó (ví dụ, lưu vào file) để sau này có thể khôi phục lại nó, .NET framework lại không thể trực tiếp làm thay.
         *
         * Quá trình chuyển đổi một object về dạng trung gian để lưu trữ hoặc truyền thông như vậy được gọi là data serialization (tạm dịch là trình tự hóa dữ liệu) Quá trình khôi phục lại object từ dạng trung gian được gọi là deserialization (tạm dịch là giải trình tự hóa)
         *
         *Do môi trường trung gian (truyền thông hoặc lưu trữ) chủ yếu làm việc với hai loại dữ liệu là văn bản và nhị phân (mảng byte), quá trình serialization thực tế có thể xem là chuyển đổi object về một mảng byte, gọi là trình tự hóa nhị phân  (binary serialization), hoặc về một chuỗi văn bản, gọi là trình tự hóa văn bản (text serialization).
         *
         * Serialization thường làm việc cùng với stream để ghi dữ liệu trực tiếp vào luồng, tránh tình trạng phải lưu trữ những chuỗi hoặc mảng byte quá lớn trong bộ nhớ. Tương tự, deserialization thường cũng đọc dữ liệu từ một stream.
         *
         *
         * Lớp BinaryFormatter : biến đổi một object về mảng byte và ghi trực tiếp vào một stream; đọc các byte dữ liệu từ một stream và biến đổi về object. Lớp BinaryFormatter nằm trong không gian tên System.Runtime.Serialization.Formatters.Binary
         *
         * Phương thức thành viên Deserialize() nhận một luồng làm tham số. Phương thức này đọc các byte từ luồng và chuyển đổi thành một object. Bạn cần cast object này về kiểu tương ứng.
         *https://www.mastercode.vn/blog/web-development/bai-9-serialization-nen-tang-lap-trinh-c.57
         */
        static void Main(string[] args)
        {
            StudentService ss = new StudentService();
            string path =
                @"F:\Google Driver Dungna29FPT\8. Demo\Demo C#2\NET102_Tutorial_Csharp2\NET102_Tutorial_Csharp2\BAI_2.8_DocGhiDoiTuong\DataDungna.bin";
            var tempLstStudents = ss.GetFakeLstStudents();
            Console.WriteLine(ss.GhiFile(tempLstStudents,path));
            foreach (var x in ss.DocFile(path))
            {
                Console.WriteLine(x.ToString());
            }
            

        }
    }
}
