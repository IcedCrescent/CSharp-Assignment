using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Numbers
{
    //1 lớp riêng phụ trách việc xử lí số, tuần theo Single Responsibility Principle
    //các phương thức sử dụng modifier static để có thể gọi thẳng phương thức để sử dụng, không cần tạo đối tượng mới, như lớp Math và Convert
    class NumberUtils
    {
        //Hiển thị tất cả phần phần tử chẵn bằng phép chia dư cho 2
        public static void DisplayEvenElements(int[] arr)
        {
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            //C# 3.5 with method syntax:
            //Console.WriteLine(string.Join(" ", new List<int>(arr.Where(s => s % 2 == 0)).ConvertAll(i => i.ToString()).ToArray()));
            //C# 4.0 with LINQ method syntax:
            //Console.WriteLine(string.Join(" ", arr.Where(s => s % 2 == 0)));
        }


        //hiển thị tất cả các phần tử lẻ từ cuối mảng, lặp từ cuối mảng và kiểm tra chia dư cho 2
        public static void DisplayOddElementsReverse(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //trả về phần tử lớn nhất
        public static int GetMaxElement(int[] arr)
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                if (item >= max)
                    max = item;
            }
            return max;
        }

        //đếm số phần tử lẻ
        public static int CountOddElements(int[] arr)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item % 2 != 0)
                    count++;
            }
            //using LINQ method syntax
            //return arr.Where(s => (s % 2 != 0)).Count();
            return count;
        }

        //Lấy tất cả các số nguyên tố bằng phương thức kiểm tra riêng, nhét vào 1 List mới
        public static List<int> GetPrimeNums(int[] arr)
        {
            List<int> primes = new List<int>();
            foreach (var item in arr)
            {
                if (IsPrime(item))
                    primes.Add(item);
            }
            return primes;
        }

        //Phương thức kiểm tra số nguyên tố, trả về true nếu là số nguyên tố
        private static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            else if (n <= 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;
            int i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }

        //đếm số nguyên tố trong mảng
        public static int CountPrimes(int[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (IsPrime(item))
                    count++;
            }
            //cách 2
            //List<int> primes = GetPrimeNums(arr);
            //foreach (var item in primes)
            //{
            //    count++;
            //}
            //cách ngắn hơn
            return GetPrimeNums(arr).Count;
        }

        //tổng của các số nguyên tố
        public static int SumOfPrimes(int[] arr)
        {
            int sum = 0;
            List<int> primes = GetPrimeNums(arr);
            foreach (var item in primes)
            {
                sum += item;
            }
            //using LINQ method syntax
            //return GetPrimeNums(arr).Sum();
            return sum;
        }

        public static int FindIndex(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return i;
            }
            return -1;
            //Cách dễ hơn
            //return Array.IndexOf(arr, num);
        }


    }
}
