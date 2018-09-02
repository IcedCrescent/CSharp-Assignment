using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___OOPInheritance
{
    class Tester
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student()
            {
                SID = 1,
                Name = "John",
                Department = "Engineering",
                GPA = 6.5
            });
            studentList.Add(new Student()
            {
                SID = 2,
                Name = "Kate",
                Department = "Business",
                GPA = 9
            });
            studentList.Add(new Student()
            {
                SID = 3,
                Name = "John",
                Department = "Designer",
                GPA = 8.45
            });
            studentList.Add(new Student()
            {
                SID = 4,
                Name = "John",
                Department = "Linguistic",
                GPA = 7
            });
            Console.WriteLine("Các đối tượng Student lưu trữ bằng List<Student>");
            foreach (var item in studentList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Các đối tượng Student lưu trữ bằng ArrayList");
            ArrayList studentArrayList = new ArrayList(studentList); //chuyển List sang ArrayList qua hàm khởi tạo của ArrayList
            foreach (var item in studentArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Nhấn bất kì phím gì để kết thúc");
            Console.ReadKey();
        }
    }
}

/*
 * ArrayList được dùng vào lúc mà C# chưa có generics. Nó đã bị
 * khuyến cáo không nên dùng mà thay vào đó bởi List<T>. Không 
 * nên dùng ArrayList trong code mới nhắm đến .NET >= 2.0 trừ khi 
 * có interface với API cũ còn dùng nó
*/ 
