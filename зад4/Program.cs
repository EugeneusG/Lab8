using System;

namespace зад4
{
    class Program
    {
        static void Main()
        {
            string a = "Разбиение строки на несколько частей";
            string[] b = a.Split();
            Array.Sort(b);
            a = String.Join(' ', b);
            Console.WriteLine(a);
        }
    }
}
