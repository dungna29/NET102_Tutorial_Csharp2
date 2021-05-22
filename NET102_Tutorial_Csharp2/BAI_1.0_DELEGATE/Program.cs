using System;
using System.Text;

namespace BAI_1._0_DELEGATE
{
    //Khai báo 1 delegate
    public delegate void ShowMessage(string message);
    class Program
    {
        #region Bài về Delegate 
       

        static void Info1(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Khởi tạo null
            Console.WriteLine("========Phần 2: Khởi tạo null========");
            ShowMessage showMessage = null;//Khơi tạo delegate = null
            showMessage = Info1;//Gán
            showMessage("Xin chào các bạn");
            showMessage?.Invoke("Xin chào các bạn");//?Kiểm tra xem delegate có null hay không nếu không mới tham chiếu

            #endregion

            #region Phần 2: Khởi tạo

            Console.WriteLine("========Phần 2: Khởi tạo========");
            ShowMessage showMessage2 = new ShowMessage(Info1);//Tham chiếu đến phương thức Info1
            showMessage2("Chào các bạn POLY học DELEGATE");

            #endregion

            #region Phần 3: C# Multicast Delegates
            /*
               ❖Có thể tham chiếu đến nhiều phương thức tại cùng một thời điểm
               ❖Kiểu tra về của multicast delegate phải là kiểu void
               ❖Dùng toán tử “+” để thêm phương thức vào delegate
             */
            Console.WriteLine("========Phần 3: C# Multicast Delegates========");
            ShowMessage showMessage4 = new ShowMessage(Info1);
            ShowMessage showMessage5 = new ShowMessage(Info2);
            ShowMessage Multicast = showMessage4 + showMessage5;
            // Multicast += showMessage4;
            // Multicast += showMessage5;
            Multicast("Chào mừng Multicast");

            Console.WriteLine("========Trừ trong Delegates========");
            Multicast = Multicast - showMessage4;//Loại bỏ bớt 1 phương thức trong delegate dùng dấu trừ
            //Multicast -= showMessage4;
            Multicast("Chào mừng Multicast");
            #endregion

            #region Phần 4: Delegate Callback
            Console.WriteLine("========Phần 4: Delegate Callback========");
            DelegateCallback delegateCallback = new DelegateCallback(showMes);
            CallBack(delegateCallback);
            #endregion

        }
        #region Phần 4: Delegate Callback

        public delegate void DelegateCallback(string mes);

        public static void showMes(string mes)
        {
            Console.Write("Thông báo:  " + mes);
        }

        public static void CallBack(DelegateCallback delegateCallback)
        {
            Console.WriteLine("Mời nhập thông báo: ");
            var mes = Console.ReadLine();
            delegateCallback(mes);
        }

        #endregion

    }
}
