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
            string data;
            StreamReader reader = new StreamReader("C:\\Users\\91767\\Desktop\\workspace\\Fileio\\text.txt");
            data = reader.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data); 
                data = reader.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
