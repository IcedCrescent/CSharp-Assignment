using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic___Struct
{
    /// <summary>
    /// struct đại diện cho 1 chiếc Ô tô
    /// </summary>
    struct Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        //trường static, dùng chung giữa các struct
        public static string Brand = "Honda";

        public Car(string name, int maxSpeed)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
        }

        public override string ToString()
        {
            return $"{Name} {MaxSpeed}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Car[] cars = new Car[]
            {
                new Car("Civic", 200),
                new Car("Jazz", 300),
                new Car("City", 250),
                new Car("Accord", 320)
            };
            Console.WriteLine("Các ô tô của hãng " + Car.Brand);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Oto nhanh nhất:  {GetFastestCar(cars).Name}");
            Console.ReadKey();
            
        }

        /// <summary>
        /// Trả về oto có tốc độ cao nhất, nếu có nhiều oto có cùng tốc độ cao nhất thì trả về ô tô đầu tiên có tốc độ cao nhất
        /// </summary>
        /// <param name="cars">Mảng struct các Ô tô</param>
        /// <returns>oto có tốc độ cao nhất</returns>
        static Car GetFastestCar(Car[] cars)
        {
            if (cars.Length == 1)
                return cars[0];
            int maxSpeed = cars[0].MaxSpeed;
            Car car = cars[0];
            for (int i = 1; i < cars.Length; i++)
            {
                if (cars[i].MaxSpeed >= maxSpeed)
                    car = cars[i];
                break;
            }
            return car;
        }
    }
}

/*
 * Trả lời câu hỏi:
 * Enum và struct là value type, được lưu ở trên vùng nhớ stack 
 * Enum: là kiểu enumeration, một kiểu riêng chứa các hằng số được đặt tên, gọi là danh sách enumerator
 * Struct: gần giống như class, có thể chứa field, properties, methods, constructors,... nhưng lại được lưu trên vùng nhớ stack như kiểu nguyên thủy và không có khả năng kế thừa
 * Class: cấu trúc dữ liệu có chứa thành phần dữ liệu (constant  và fields), thành phần hàm (methods, properties, events,...) và kiểu nẹp trong. Class hỗ trợ kế thừa, được lưu trên vùng nhớ heap
 */