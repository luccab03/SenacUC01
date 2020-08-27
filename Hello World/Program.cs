using System;
using System.Globalization;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Today;
            Console.WriteLine(CultureInfo.CurrentCulture);
        }
    }
}
