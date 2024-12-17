using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func(ref n);
            Console.ReadLine();
        }
        //static void Func(ref int n)

        //{
        //    int x = 1;
        //    while (x <= n)
        //    {
        //        Console.WriteLine(x)
        //            x++;
        //    }
        //}

        //static void Func(ref int n)
        //{
        //    int x = 1;
        //    do
        //    {
        //        Console.WriteLine(x);
        //        x++;

        //    } while (x <= n);
        //}

        //static void Func(ref int n)
        //{
        //    for (int x = 1; x <=n; x++)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}

    }
}
