using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[0];
            Console.WriteLine("1. Sinh một mảng chứa 10 phần tử ngẫu nhiên");
            Console.WriteLine("2. Nhập mảng thủ công");
            Console.Write("> ");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        arr = new int[10];
                        Random rand = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            arr[i] = rand.Next(-50, 50);
                        }
                        break;
                    case 2:
                        arr = ArrayHelper.InputArray();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            catch (FormatException)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Mảng: ");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("Xếp tăng dần: ");
            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("Xếp giảm dần: ");
            Array.Sort(arr, new SortDescending());
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("1. Xóa phần tử (vị trí xuất hiện đầu tiên)");
            Console.WriteLine("2. Xóa theo vị trí");
            Console.Write("> ");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Giá trị muốn xóa: ");
                        int value = int.Parse(Console.ReadLine());
                        ArrayHelper.Remove(ref arr, value);
                        break;
                    case 2:
                        Console.Write("Vị trí muốn xóa: ");
                        int index = int.Parse(Console.ReadLine());
                        ArrayHelper.RemoveAt(ref arr, index);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            catch (FormatException)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Mảng sau khi xóa: ");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("Mảng 2 chiều: ");
            int[, ] array2D = ArrayHelper.InputTwoDimenstional();
            Console.WriteLine("Mảng vừa nhập:");
            ArrayHelper.PrintTwoDimensional(array2D);
        }
    }
}
