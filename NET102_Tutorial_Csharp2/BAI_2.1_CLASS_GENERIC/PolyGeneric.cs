using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._1_CLASS_GENERIC
{
    class PolyGeneric<T>
    {
        private T[] arrs;//Mảng chưa xác định kiểu dữ liệu

        //Contructor truyền kích thước mảng và khởi tạo
        public PolyGeneric(int Size)
        {
            arrs = new T[Size];
        }

        public T[] Items
        {
            get => arrs;
            set => arrs = value;
        }

        //Lấy giá trị trong mảng ra
        public T GetByIndex(int Index)
        {
            // Nếu index vượt ra khỏi chỉ số phần tử của mảng thì ném ra ngoại lệ
            if (Index < 0 || Index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return arrs[Index];
            }
        }

        //Gán giá trị vào mảng
        public void SetItemValue(int Index, T Value)
        {
            if (Index < 0 || Index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                arrs[Index] = Value;
            }
        }
    }
}
