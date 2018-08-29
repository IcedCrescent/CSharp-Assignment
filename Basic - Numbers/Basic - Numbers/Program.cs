using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //đặt chuẩn hiển thị cho cửa số console, nếu không tiếng Việt sẽ bị hiện là dấu ?
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Cho phép nhập n số nguyên (0 <= n <= 100)");
            int[] arr = Input();
            Console.WriteLine("Các phần tử chẵn theo thứ tự nhập: ");
            NumberUtils.DisplayEvenElements(arr);
            Console.WriteLine("Các phần tử lẻ ngược thứ tự nhập:");
            NumberUtils.DisplayOddElementsReverse(arr);
            Console.WriteLine("Tìm phần tử lớn nhất: " + NumberUtils.GetMaxElement(arr));
            Console.WriteLine("Đếm số phần tử lẻ trong mảng: " + NumberUtils.CountOddElements(arr));
            //Console.WriteLine("Lọc số nguyên tố trong mảng: " + string.Join(" ", NumberUtils.GetPrimeNums(arr)));
            List<int> primes = NumberUtils.GetPrimeNums(arr);
            Console.WriteLine("Lọc số nguyên tố trong mảng: ");
            foreach (var item in primes)
            {
                //Dùng Interpolated string ($ trước string) để cho phép hiển thị giá trị biến, kết quả trong string, thay vì phải cộng ngoài
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine($"Đếm các số nguyên tố trong mảng: {NumberUtils.CountPrimes(arr)}");
            Console.WriteLine($"Tổng các số nguyên tố trong mảng: {NumberUtils.SumOfPrimes(arr)}");
            Console.Write("Nhập x để tìm: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine((NumberUtils.FindIndex(arr, x) == -1) ? "Không tìm thấy" : $"Tìm thấy ở vị trí: {(NumberUtils.FindIndex(arr, x) == -1)}");
            Console.ReadKey();
        }

        //phương thức nhập mảng, trả về một mảng int
        static int[] Input()
        {
            int n;
            //kiểm tra đầu vào bằng TryParse, trả về false nếu không đúng kiểu số nhập vào
            do
            {
                Console.Write("Số lượng phần tử của mảng (0 <= n <= 100): ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Không đúng định dạng số, nhập lại!");
                    continue;
                }
                if (n < 0 || n > 100)
                {
                    Console.WriteLine("Qúa ngưỡng cho phép!");
                    continue;
                }
                break;
            } while (true);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử thứ {i}= ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("2. Xuất mảng số nguyên vừa nhập");
            return arr;
        }
    }
}

/*
 * Trả lời 1 số câu hỏi
 * 1. Như C, Java, Javascript,... C# có phân biệt hoa thường
 * 2. Chương trình bắt đầu tại Main(string[] args)
 * 3. Khác với Java, tên file chương trình có thể khác tên lớp
 */

