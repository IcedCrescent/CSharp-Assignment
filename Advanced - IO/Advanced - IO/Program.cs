using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Advanced___IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(@"File đầu ra nằm ở folder bin\Debug trong project");
            Console.WriteLine("Ghi file text data.txt");
            Console.Write("Nội dung: ");
            string content = Console.ReadLine();
            string textFile = "data.txt";
            //Lớp FileInfo chứa các property và instance method để tạo, xóa, copy, di chuyển và đọc file, đồng thường cung cấp FileStream
            FileInfo fi = new FileInfo(textFile);
            //Lớp phụ trách ghi nội dung text ra 1 stream
            StreamWriter sw = fi.CreateText();
            try
            {
                sw.WriteLine(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                Console.WriteLine("Ghi file thành công");
            }
            Console.WriteLine("Đọc nội dung của data.txt");
            StreamReader sr = new StreamReader(textFile);
            try
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }


            Console.WriteLine("Ghi file nhị phân data.bin");
            string binFile = "data.bin";
            //Lớp BinaryWriter hỗ trợ ghi kiểu nguyên thủy thành nhị phân, và ghi string theo một encoding bất kì
            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream(binFile, FileMode.Create));
                Console.WriteLine("Ghi ngày giờ hệ thống");
                //Ghi kiểu int
                bw.Write(DateTime.Now.Hour);
                bw.Write(DateTime.Now.Minute);
                //Ghi kiểu string
                bw.Write(DateTime.Now.ToShortDateString());
                bw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Đọc nội dung của data.bin");
            try
            {
                BinaryReader br = new BinaryReader(File.Open(binFile, FileMode.Open));
                //Đọc int (cái gì ghi trước thì sẽ được đọc trước)
                Console.WriteLine(br.ReadInt32() + ":" + br.ReadInt32());
                //Đọc string
                Console.WriteLine(br.ReadString());
                br.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
