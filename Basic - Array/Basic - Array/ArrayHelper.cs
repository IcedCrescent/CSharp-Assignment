using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Array
{
    class ArrayHelper
    {
        /// <summary>
        /// Phương thức nhập vào một mảng 1 chiều
        /// </summary>
        /// <returns>1 mảng 1 chiều</returns>
        public static int[] InputArray()
        {
            int n;
            while (true)
            {
                n = InputNumber("Số lượng phần tử trong mảng (0 < n < 10000): ");
                if (n <= 0 || n >= 10000)
                {
                    Console.WriteLine("Vượt quá ngưỡng cho phép!");
                    continue;
                }
                break;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = InputNumber($"[{i}] = ");
            }
            return arr;
        }

        /// <summary>
        /// Xóa vị trí đầu tiên phần tử truyền vào nếu nó tồn tại trong mảng, nếu không tồn tại thì không làm gì
        /// </summary>
        /// <param name="arr">mảng cần xóa phần tử</param>
        /// <param name="value">phần tử muốn xóa</param>
        public static void Remove(ref int[] arr, int value)
        {
            if (!arr.Contains(value))
                return;
            int index = Array.IndexOf(arr, value);
            if (index < 0)
                return;
            else
            {
                RemoveAt(ref arr, index);
            }
        }

        /// <summary>
        /// Xóa phần tử trong mảng theo vị trí, nếu vị trí vượt giới hạn mảng thì không làm gì
        /// </summary>
        /// <param name="arr">Mảng cần xóa phần tử</param>
        /// <param name="index">Vị trí muốn xóa</param>
        public static void RemoveAt(ref int[] arr, int index)
        {
            if (index >= arr.Length)
                return;
            int[] dest = new int[arr.Length - 1];
            if (index > 0)
                Array.Copy(arr, dest, index);
            if (index < arr.Length - 1)
                Array.Copy(arr, index + 1, dest, index, arr.Length - index - 1);
            arr = dest;
        }

        /// <summary>
        /// So sánh 2 mảng với nhau theo tiêu trí độ dài và các phần tử cùng vị trí
        /// </summary>
        /// <param name="first">Mảng thứ nhất</param>
        /// <param name="second">Mảng thứ hai</param>
        /// <returns>True nếu 2 mảng y như nhau</returns>
        public static bool CompareArrays(int[] first, int[] second)
        {
            if (first.Length != second.Length)
                return false;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Phương thức nhập 1 số nguyên có hiển thị thông báo nhập và kiểm tra đầu vào
        /// </summary>
        /// <param name="prompt">Thông báo muốn hiển thị</param>
        /// <returns>Một số nguyên</returns>
        public static int InputNumber(string prompt)
        {
            int num;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Phải nhập số nguyên!");
                Console.Write(prompt);
            }
            return num;
        }

        /// <summary>
        /// Phương thức nhập mảng 2 chiều
        /// </summary>
        /// <returns>1 mảng 2 chiều</returns>
        public static int[,] InputTwoDimenstional()
        {
            int row = InputNumber("Nhập số hàng: ");
            int col = InputNumber("Nhập số cột: ");
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"[{i}, {j}] = ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
        /// <summary>
        /// Phương thức hiển thị mảng 2 chiều
        /// </summary>
        /// <param name="arr">Mảng muốn hiển thị</param>
        public static void PrintTwoDimensional(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine("]");
            }
        }
    }

    /// <summary>
    /// Lớp phụ trách việc sắp xếp ngược, kế thừa từ interface IComparer để dùng trong Array.Sort()
    /// </summary>
    class SortDescending : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
