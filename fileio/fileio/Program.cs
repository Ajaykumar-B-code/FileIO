using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string data;
            //StreamReader reader = new StreamReader("C:\\Users\\91767\\Desktop\\workspace\\Fileio\\text.txt");
            //data = reader.ReadToEnd();

            //Console.WriteLine(data);
            //reader.Close(); // to write in the same we should close the file first
            //StreamWriter write = new StreamWriter("C:\\Users\\91767\\Desktop\\workspace\\Fileio\\text.txt");
            //write.WriteLine("natural numbers from 1-100");
            //for(int i = 0; i < 100; i++)
            //{
            //    write.WriteLine(i);
            //}
            //write.Close();  
            // compulsory close the file

            //while (data != null)
            //while (data != null)
            //{
            //    Console.WriteLine(data); 
            //    data = reader.ReadLine();
            //}

            string fpath = @"C:\\Users\\91767\\Desktop\\workspace\\Fileio\\text.txt";
            //FileInfo f1 = new FileInfo(fpath);
            //Console.WriteLine(f1.FullName);
            //Console.WriteLine(f1.Name);
            //Console.WriteLine(f1.DirectoryName);
            //Console.WriteLine(f1.Extension);
            //Console.WriteLine(f1.Length.ToString());
            //Console.WriteLine(f1.CreationTime);
            File.WriteAllText(fpath, "To write in one line of the file");

            string[] lin = new string[]
            {
                "to write in multi lines",
                "we should create the array of string "
            };


            File.AppendAllLines(fpath, lin);

            //if (File.Exists(fpath))
            //{
            //    string[] s = File.ReadAllLines(fpath);
            //   foreach (var line in s)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("file doesnt exist");
            //}
            Console.ReadLine();
        }
    }
}
