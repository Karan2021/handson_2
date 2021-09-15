using System;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream read = new FileStream(@"C:\Training\CSharp\handson_2\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamread = new StreamReader(read);
            FileStream write = new FileStream(@"C:\Training\CSharp\handson_2\hands_on_2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamwrite = new StreamWriter(write);
            Console.WriteLine("Source       Destination     Date     Call");
            string line = streamread.ReadLine();
            while (streamread.Peek() > 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (line.Contains(":"))
                    {
                        string[] s1 = line.Split(':');
                        Console.Write(s1[1] + "   ");
                        line = streamread.ReadLine();
                    }
                    else
                    {
                        line = streamread.ReadLine();
                        break;
                    }
                }
                Console.WriteLine();
            }
            read.Close();
            write.Close();
            streamread.Close();
        }
    }
}
