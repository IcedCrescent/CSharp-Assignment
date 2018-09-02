using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Kiểm tra số hoàn hảo");
            Console.WriteLine("2. Tìm BCNN của 2 số");
            Console.WriteLine("3. Tìm số fibonacci ở vị trí thứ n");
            Console.WriteLine("Khác. Thoát");
            int choice;
            do
            {
                Console.Write("> ");
            } while (!int.TryParse(Console.ReadLine(), out choice));
            switch (choice)
            {
                case 1:
                    Console.Write("Nhập số cần kiểm tra: ");
                    int num = 0;
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Environment.Exit(1);
                    }
                    Console.WriteLine("{0} là số hoàn hảo", IsPerfectNumber(num) ? "" : "Không");
                    break;
                case 2:
                    int num1, num2;
                    Console.Write("Số thứ nhất: ");
                    if (!int.TryParse(Console.ReadLine(), out num1))
                        Environment.Exit(1);
                    Console.Write("Số thứ hai: ");
                    if (!int.TryParse(Console.ReadLine(), out num2))
                        Environment.Exit(1);
                    Console.WriteLine($"Bội chung nhỏ nhất của {num1} và {num2} là {LCM(num1, num2)}");
                    break;
                case 3:
                    Console.Write("Vị trí: ");
                    int pos;
                    if (!int.TryParse(Console.ReadLine(), out pos))
                        Environment.Exit(1);
                    Console.WriteLine($"Số Fibonacci ở vị trí thứ {pos} là {FibonacciAt(pos)}");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Kiểm tra xem số nhập vào có phải là số hoàn hảo
        /// </summary>
        /// <param name="num">Số cần kiểm tra</param>
        /// <returns>true nếu là số hoàn hảo</returns>
        static bool IsPerfectNumber(long num)
        {
            //số hoàn hảo lẻ có thể không tồn tại, nếu có thì nó vượt quá ngưỡng của kiểu long
            if (num % 2 == 1)
                return false;
            long sum = 1; //ước chung
            long i = 2;
            while (i * i < num) //cho tới khi i <= sqrt(num)
            {
                if (num % i == 0)
                {
                    sum += i;
                    sum += num / i;
                }
                i++;
            }
            if (i * i == num) //số chính phương, sqrt(num) được cộng 2 lần
                sum -= i;
            return sum == num;
        }

        /// <summary>
        /// Bội chung nhỏ nhất của 2 số
        /// </summary>
        /// <param name="a">Số thứ nhất</param>
        /// <param name="b">Số thứ 2</param>
        /// <returns>Bội chung của 2 số</returns>
        static int LCM(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            return (a * b) / GCD(a, b);
        }

        /// <summary>
        /// ƯCLN của 2 số, quăng exception nếu 1 trong 2 số nhỏ hơn 0
        /// </summary>
        /// <param name="a">số thứ nhất</param>
        /// <param name="b">số thứ hai</param>
        /// <returns>Ước chung lớn nhất của 2 số</returns>
        static int GCD(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException("a hoặc b nhỏ hơn 0");
            int remainder = 0;
            do
            {
                remainder = a % b;
                a = b;
                b = remainder;
            } while (b != 0);
            return a;
        }

        static int FibonacciAt(int position)
        {
            if (position <= 0)
                throw new ArgumentException("Vị trí không thể nhỏ hơn 0");
            if (position == 1 || position == 2)
                return 1;
            int prev_prev = 1;
            int prev = 1;
            int fib = 0;
            for (int i = 3; i <= position; i++)
            {
                fib = prev_prev + prev;
                prev_prev = prev;
                prev = fib;
            }
            return fib;
        }
    }
}
