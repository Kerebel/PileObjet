using MesOutils;
using System;
using Utilitaires;

namespace PileObjet.Tests
{
    internal abstract class TestPile
    {
        /// <summary>
        /// Test des méthode PileVide et PilePleine
        /// </summary>
        /// <param name="nbElements">nombre d'éléments maximum de la pile</param>
        public static void TestePileVide()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                if (unePile.PileVide())
                {
                    Console.WriteLine("La pile est vide");
                }
                else
                {
                    Console.WriteLine("La pile n'est pas vide");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Teste la méthode empiler
        /// </summary>
        /// <param name="nbElements">nombre d'éléments maximum de la pile</param>
        public static void TesteEmpiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(5);
                unePile.Empiler(2);
                unePile.Empiler(11);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Teste les méthodes Empiler et Dépiler
        /// </summary>
        /// <param name="nbElements">nombre d'éléments maximum de la pile</param>
        public static void TesteEmpilerDepiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(5);
                unePile.Empiler(3);
                unePile.Empiler(22);
                int valeurDepilee = unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        ///  conversion d'un nombre en base 10 dans une nouvelle base entre 2 et 16
        /// Cette méthode demandera la saisie du nombre à convertir et de la nouvelle base
        /// </summary>
        public static void TesteConversion()
        {
                Console.WriteLine("Saisie du nombre à convertir.");
                int nbAConvertir = UtilitaireConsole.SaisirNb(0);
                Console.WriteLine("Saisie de la nouvelle base");
                int newBase = UtilitaireConsole.SaisirNb(2, 16);
                TesteConversion(nbAConvertir, newBase);    
        }
        public static void TesteConversion(int nbAConvertir , int newBase)
        {
            try
            {
                String valeurConvertie = UtilitaireConsole.Conversion(nbAConvertir, newBase);
                Console.WriteLine("valeurConvertie convertie : " + valeurConvertie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
