using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //đặt encoding để console hiện tiếng Việt chuẩn
            Console.OutputEncoding = Encoding.UTF8;
            //các biến dùng để giải, trong đó có tham số a, b, c của PT
            int a, b, c;
            double delta;
            Console.WriteLine("Giải phương trình bậc 2 aX^2 + bX + c = 0");
            //nếu a != 0 thì không phải là PT bậc 2, nhập lại
            do
            {
                a = InputNumber("Nhập a: ");
                if (a == 0)
                {
                    Console.WriteLine("a phải khác 0!");
                    continue;
                }
                break;
            } while (true);
            b = InputNumber("Nhập b: ");
            c = InputNumber("Nhập c: ");
            //tính Delta để xác định biến của PT
            delta = Math.Pow(b, 2) - 4 *a*c;
            //dùng lệnh if/else để quyết định 3 trường hợp dựa vào delta
            if (delta < 0)
            {
                Console.WriteLine($"Phương trình {a}X^2 - {b}x + {c} = 0 vô nghiệm.");
            } else if (delta == 0)
            {
                Console.WriteLine($"Phương trình {a}X^2 - {b}x + {c} = 0 có nghiệm kép: {((double)-b)/2*a}");
            } else
            {
                Console.WriteLine($"Phương trình {a}X^2 + {b}x + {c} = 0 có 2 nghiệm phân biệt.");
                Console.WriteLine("x1 = {0:0.000}", (-b + Math.Sqrt(delta))/(2*a));
                Console.WriteLine("x2 = {0:0.000}", (-b - Math.Sqrt(delta))/(2*a));
            }
            //ngăn console đóng
            Console.ReadKey();
        }

        /// <summary>
        /// Phương thức kiểm tra đầu vào từ bàn phím, yêu cầu nhập lại nếu không đúng kiểu số nguyên
        /// Nhận 1 string làm thông báo nhập
        /// </summary>
        /// <param name="message">Thông báo nhập</param>
        /// <returns>số đã được kiểm tra</returns>
        static int InputNumber(string message)
        {
            int num;
            Console.Write(message);
            //int.TryParse trả về true nếu chuyển từ string thành công, và false nếu thất bại
            //giá trị nguyên được chuyển sẽ dùng từ khóa out ở tham số 2 để gán vào 1 biến khác
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Phải nhập 1 số nguyên!");
                Console.Write(message);
            }
            return num;
        }
    }
}
