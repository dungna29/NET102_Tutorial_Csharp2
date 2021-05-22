using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_TU_KHOA_STATIC
{
    static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Toán Học";

        static Calculator()
        {
            _resultStorage = 1;
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
            Console.WriteLine(_resultStorage);
        }
    }
}
