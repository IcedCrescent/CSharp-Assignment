using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Basic___Polymorphism
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Đọc dữ liệu từ file CSV để đỡ phải nhập thủ công
            string[] content = File.ReadAllLines(@"data.csv");
            //3 List chứa 3 loại đối tượng tương ứng
            List<Scientist> scientists = new List<Scientist>();
            List<Manager> managers = new List<Manager>();
            List<LaboratoryEmployee> staffs = new List<LaboratoryEmployee>();
            try
            {
                //đọc qua từng dòng trong file, chuyển dữ liệu từ file được tách bởi dấu phẩy thành file Property tương ứng
                //0, 1, 2 ở đầu mỗi dòng tượng trưng cho từng loại đối tượng tương ứng: Nhà khoa học, quản lí và nhân viên
                foreach (var item in content)
                {
                    string[] delimited = item.Trim().Split(',');
                    switch (delimited[0])
                    {
                        case "0":
                            scientists.Add(new Scientist()
                            {
                                Name = delimited[1],
                                DOB = DateTime.Parse(delimited[2]),
                                Degree = delimited[3],
                                Role = delimited[4],
                                PublishedArticlesCount = int.Parse(delimited[5]),
                                WorkedDay = int.Parse(delimited[6]),
                                PayGrade = int.Parse(delimited[7])
                            });
                            break;
                        case "1":
                            managers.Add(new Manager()
                            {
                                Name = delimited[1],
                                DOB = DateTime.Parse(delimited[2]),
                                Degree = delimited[3],
                                Role = delimited[4],
                                WorkedDay = int.Parse(delimited[5]),
                                PayGrade = int.Parse(delimited[6])
                            });
                            break;
                        case "2":
                            staffs.Add(new LaboratoryEmployee()
                            {
                                Name = delimited[1],
                                DOB = DateTime.Parse(delimited[2]),
                                Degree = delimited[3],
                                Salary = double.Parse(delimited[4])
                            });
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
            //hiển thị dữ liệu và tính tổng lương cho từng đối tượng
            Console.WriteLine($"{scientists.Count} nhà khoa học:");
            double salary = 0;
            foreach (var item in scientists)
            {
                Console.WriteLine(item);
                salary += item.GetSalary();
            }
            Console.WriteLine("Tổng lương: " + salary);
            salary = 0;
            Console.WriteLine($"{managers.Count} nhà quản lí:");
            foreach (var item in managers)
            {
                Console.WriteLine(item);
                salary += item.GetSalary();
            }
            Console.WriteLine($"Tổng lương: {salary}");
            salary = 0;
            Console.WriteLine($"{staffs.Count} nhân viên phòng thí nghiệm: ");
            foreach (var item in staffs)
            {
                Console.WriteLine(item);
                salary += item.Salary;
            }
            Console.WriteLine($"Tổng lương: {salary}");
            Console.ReadKey();
        }
    }
}
