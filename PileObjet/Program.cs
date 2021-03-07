using PileObjet.Tests;
using System;

namespace PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPile.TestePileVide();
            TestPile.TesteEmpiler();
            TestPile.TesteEmpilerDepiler();
            // appels des méthodes de tests conversion
            TestPile.TesteConversion();
            TestPile.TesteConversion(154, 2);
            TestPile.TesteConversion(11, 16);
            TestPile.TesteConversion(2986, 16);
            TestPile.TesteConversion(9999, 16);

            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }
    }
}
