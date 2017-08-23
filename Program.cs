using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowPath
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ShowPath <env var>");
            }
            string envVar = Environment.GetEnvironmentVariable(args[0]);

            char[] sep = {';'};
            var varArray = envVar.Split(sep);

            Console.WriteLine("\nIn order of appearance-->");
            foreach (var s in varArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nSorted -->");
            Array.Sort(varArray);
            foreach (var s in varArray)
            {
                Console.WriteLine(s);
            }

            //comment out below to enable piping to other commands
            //Console.WriteLine("\nPress enter key to end!");
            //string enterLine = Console.ReadLine();
        }
    }
}
