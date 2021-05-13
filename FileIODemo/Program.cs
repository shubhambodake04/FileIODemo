using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileExists();
            //ReadAllLines();
            //ReadAllText();
            //FileCopy();
            //DeleteFile();
            //ReadFromStreamReader();
            WriteUsingStreamWriter();
            Console.ReadLine();
        }

        public static void FileExists()
        {
            String path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exixts");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
            String[] lines;

            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            String path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
            String copypath = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\ExampleNew.txt";

            File.Copy(path, copypath);
        }
        public static void DeleteFile()
        {
            String path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\ExampleNew.txt";


            File.Delete(path);

        }
        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
            using (StreamReader sr=File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) !=null)
                {
                    Console.WriteLine(s);
                }
            }
        
        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}