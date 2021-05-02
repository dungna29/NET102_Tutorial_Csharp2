using System;
using System.Text;

namespace BAI_1._5_DINH_NGHIA_EXCEPTION
{
    class Program
    {
        #region Phần 1: Định nghĩa ra 1 EXCEPTION bên trong 1 phương thức

        static void dangKy(string name, int  age)
        {
            if (string.IsNullOrEmpty(name))
            {
                Exception exception = new Exception("Tên không được để null");
                throw exception;
            }

            if (age <18)
            {
                throw new Exception("Tuổi bạn chưa được vào club");
            }

            Console.WriteLine("Chào mừng bạn đến với Club C#: " + name + " " + age);
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangKy("Long",20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
