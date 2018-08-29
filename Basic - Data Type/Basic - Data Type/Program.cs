using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Data_Type
{
    class Program
    {
        public static void Main() //phương thức gọi
        {
            int val1 = 0; //phải được khởi tạo trước
            int val2; //khởi tạo có thể tùy chọn

            Example1(ref val1);
            Console.WriteLine(val1); // val1=1

            Example2(out val2);
            Console.WriteLine(val2); // val2=2
        }

        static void Example1(ref int value) //thay giá trị bằng ref
        {
            value = 1;
        }
        static void Example2(out int value) //thay bằng out
        {
            value = 2; //phải khởi tạo trong phương thức
        }
    }

    /* Output
     1
     2
     */
     
    /*
     * trả lời câu hỏi:
     * Kiểu value (giá trị) được lưu trữ trong vùng nhớ stack, khi thao tác vào biến thì sẽ thay đổi trực tiếp giá trị cho biến đó
     * kiểu value là các loại nguyên thủy như int, double, bool,...
     * kiểu value khi được khởi tạo sẽ gán ngay giá trị mặc định
     * Kiểu reference (tham chiếu) được lưu trữ ở 2 nơi: tham chiếu (giống như con trỏ trong c++) ở stack, và object thực sự ở heap
     * Kiểu tham chiếu là các lại dữ liệu như string, object, array,....
     */ 
}
