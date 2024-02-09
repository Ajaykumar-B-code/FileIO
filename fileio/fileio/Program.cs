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
            StreamWriter write = new StreamWriter("C:\\Users\\91767\\Desktop\\workspace\\Fileio\\text.txt");
            write.WriteLine("natural numbers from 1-100");
            for(int i = 0; i < 100; i++)
            {
                write.WriteLine(i);
            }
            write.Close();  // compulsory close the file
            //while (data != null)
            //while (data != null)
            //{
            //    Console.WriteLine(data); 
            //    data = reader.ReadLine();
            //}
            Console.ReadLine();
        }
    }
}
