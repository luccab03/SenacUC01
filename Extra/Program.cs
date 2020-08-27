using System;
using System.Globalization;

namespace Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", true);
            Console.Write("Data de nascimento: DD/MM/AAAA");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            DateTime hoje = DateTime.Today;
            int years = (hoje.Year - nascimento.Year) - 1;
            int daysLived = years * 365;
            int meses = (hoje.Month - nascimento.Month) * 30;
            daysLived = daysLived + meses;
            int days = (hoje.Day - nascimento.Day);
            daysLived = daysLived + days;
            Console.WriteLine(daysLived);
        }
    }
}
