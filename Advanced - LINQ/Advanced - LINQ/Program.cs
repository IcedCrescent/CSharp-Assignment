using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 9, Name = "John", Birthday = DateTime.Parse("9/8/1995") });
            employees.Add(new Employee() { ID = 10, Name = "Caroline", Birthday = DateTime.Parse("1/25/1995") });
            employees.Add(new Employee() { ID = 11, Name = "Claire", Birthday = DateTime.Parse("12/27/1992") });
            employees.Add(new Employee() { ID = 12, Name = "Tom", Birthday = DateTime.Parse("10/8/1994") });
            employees.Add(new Employee() { ID = 13, Name = "Lily", Birthday = DateTime.Parse("9/20/1998") });
            employees.Add(new Employee() { ID = 14, Name = "Catherine", Birthday = DateTime.Parse("4/3/1990") });
            employees.Add(new Employee() { ID = 15, Name = "Math", Birthday = DateTime.Parse("12/12/1989") });
            Console.WriteLine(string.Join("\n", employees));
            Console.WriteLine("Employee có ID > 10");
            var filter1 = employees.Where(e => e.ID > 10);
            Console.WriteLine(string.Join("\n", filter1));
            Console.WriteLine("Employee có ID > 10 và tên bắt đầu bằng chữ C");
            var filter2 = employees.Where(e => e.ID > 10 && e.Name.StartsWith("C"));
            Console.WriteLine(string.Join("\n", filter2));
            Console.WriteLine("Employee đầu tiên có năm sinh là 1992");
            var filter3 = employees.Where(e => e.Birthday.Year == 1992).First();
            Console.WriteLine(filter3);
            Console.ReadKey();
        }
    }
}

/*
 * trả lời câu hỏi
 * Anonymous method là một method không có tên. Anonymous method trong C# có thể được tuyên bố bằng từ khóa delegate hoặc dùng lambda
public delegate void Print(int value);

static void Main(string[] args)
{
     Print print = delegate(int val) { 
     Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
     };
     print(100);
}
 * Lamda expression là cú pháp để tạo delegate hoặc expression tree, có thể hiểu đơn giản là hàm hoặc phương thức không có tên
 * giống như là: đối số => {thân method} hoặc đối số => giá trị trả về của method
 * kí hiệu => gọi là toán tử lambda và đọc là "go to"
*/
