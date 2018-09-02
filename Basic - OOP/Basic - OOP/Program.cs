using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Số sinh viên nhập vào: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("ID sinh viên: ");
                int sid = int.Parse(Console.ReadLine());
                Console.Write("Tên sinh viên: ");
                string name = Console.ReadLine();
                Console.Write("Khoa: ");
                string department = Console.ReadLine();
                Console.Write("Điểm trung bình: ");
                double gpa = double.Parse(Console.ReadLine());
                students[i] = new Student()
                {
                    SID = sid,
                    Name = name,
                    Department = department,
                    GPA = gpa
                };
            }
            Console.WriteLine("Các sinh viên đã nhập:");
            Console.WriteLine($"{"SID", -5} {"Tên", -15} {"Khoa", -10} Điểm trung bình ");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Bấm phím bất kì để thoát.");
            Console.ReadKey();
        }
    }
}

/*
 * Trả lời câu hỏi:
 * Các access modifiers:
 * public: các kiểu hoặc thành phần member có thể được truy cập bởi bất kì code nào nằm trong assembly hoặc ngoài assembly tham chiếu tới nó
 * private: kiểu hoặc thành phần chỉ có thể được truy cập bởi code trong cùng 1 class hoặc struct
 * protected: kiểu hoặc thành phần có thể được truy cập chỉ bởi hoặc trong cùng class, hoặc trong class kế thừa từ lớp chứa nó
 * internal: kiểu hoặc thành phần có thể được truy cập bởi bất kì code nào trong cùng assembly, nhưng thể từ assembly khác
 * protected internal: kiểu hoặc thành phần có thể được truy cập bởi bất kì code nào trong trong assembly mà nó được tuyên bố, hoặc trong lớp kế thừa ở 1 assembly khác
 * 
 * Khi không gán access modifier thì default đối với
 * class: internal
 * struct: internal
 * method: private
 * field và property: private
 * field và property (của enum hoặc interface): public
*/
