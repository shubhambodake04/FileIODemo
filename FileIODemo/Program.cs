using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        const string filepath = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\Example.txt";
        const string copypath = @"C:\Users\Shubham\source\FileIODemo\FileIODemo\ExampleNew.txt";
        static void Main(string[] args)
        {
           
           FileExists();
            //ReadAllLines();
            //ReadAllText();
            FileCopy();
            //DeleteFile();
           // ReadFromStreamReader();
            //WriteUsingStreamWriter();
            Console.ReadLine();
        }

        public static void FileExists()
        {
          
                if (File.Exists(filepath))
                    Console.WriteLine("File exixts");
                else
                    Console.WriteLine("File doesn't exists");
         
        }
        public static void ReadAllLines()
        {
            
            String[] lines;

            lines = File.ReadAllLines(filepath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            
            string lines;

            lines = File.ReadAllText(filepath);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            File.Copy(filepath, copypath);
        }
        public static void DeleteFile()
        {
            File.Delete(filepath);
        }
    
        public static void ReadFromStreamReader()
        {
            try
            {
                using (StreamReader sr = File.OpenText(copypath))
                {
                    String s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
        }

        public static void WriteUsingStreamWriter()
        {
            
            using (StreamWriter sr = File.AppendText(copypath))
            {
                sr.WriteLine("Hello world - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(copypath));
            }
        }
    }
}