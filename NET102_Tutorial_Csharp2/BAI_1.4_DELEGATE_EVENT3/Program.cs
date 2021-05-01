using System;
using System.Text;

namespace BAI_1._4_DELEGATE_EVENT3
{
    class Program
    {
        /*
      * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
      */
        #region EventHandler bổ sung kiến thức có sẵn trong C#
        /*
        * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
        */
        class UserInput
        {
            //public event SuKienNhapSo suKienNhapSo; Cách khai báo phía trên
            public event EventHandler suKienNhapSo1;// Tương đương delegate void ten(object sender, EventArgs args)
            //suKienNhapSo1 để sử dụng chúng ta phải truyền vào 2 tham số
            public void getInputValue()
            {
                do
                {
                    Console.WriteLine("Mời bạn nhập số nguyên 1: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập số nguyên 2: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    suKienNhapSo1?.Invoke(this, new UserInput1(a, b));
                } while (true);
            }
        }


        class UserInput1 : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public UserInput1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        class TinhTong
        {
            public void thiHanh(UserInput userInput)
            {
                //Không được thực hiện phép gán mà phải thực hiện phép toán += hoặc -=
                userInput.suKienNhapSo1 += tinhTong;//Khi sự kiện nhập số xảy ra thi thi hành tính tổng
            }
            // Tương đương delegate void ten(object sender, EventArgs e)
            public void tinhTong(object sender, EventArgs e)
            {
                UserInput1 userInput = (UserInput1)e;//Chuyển e về đối tượng để đọc giá trị truyền vào
                var a = userInput.a;
                var b = userInput.b;
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", a, b, a + b);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phát đi sự kiện
            UserInput userInput = new UserInput();

            //Nhận sự kiện
            TinhTong tinhTong = new TinhTong();
            tinhTong.thiHanh(userInput);

            //Thực thi tác động vào sự kiện
            userInput.getInputValue();
        }
    }
}
