using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._3_PARTIAL_CLASS_METHOD
{
    public partial class ClassA
    {
        public string variableC { get; set; }
        public int variableD { get; set; }

        public void method2()
        {
            Console.WriteLine("Dây là method 2");
        }

        //Class này là nơi triển khai code
       public partial void method3()
        {
            throw new NotImplementedException();
        }
    }
}
