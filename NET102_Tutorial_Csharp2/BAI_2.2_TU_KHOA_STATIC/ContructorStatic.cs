using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_TU_KHOA_STATIC
{
    class ContructorStatic
    {
        // static constructor
        static ContructorStatic()
        {
            Console.WriteLine("Static constructor called");
        }
        // instance constructor
        public ContructorStatic()
        {
            Console.WriteLine("Instance constructor called");
        }

    }
}
