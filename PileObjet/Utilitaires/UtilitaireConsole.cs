using MesOutils;
using System;
using System.Linq;

namespace Utilitaires
{
    /// <summary>
    ///  La classe UtilitaireConsole doit uniquement servir de classe de base pour d’autres classes,
    ///  et ne pas être instanciée toute seule.
    /// </summary>
    public abstract class UtilitaireConsole
    {
        /// <summary>
        /// Demande la saisie au clavier d'un nombre entier,
        /// retourne ce nombre entier quel qu'il soit.
        /// </summary>
        /// <returns> Renvoie un entier</returns>
        public static int SaisirNb()
        {
            int nb;
            Console.Write("Veuillez saisir un nombre entier : ");
            string resultat = Console.ReadLine();
            while (!Int32.TryParse(resultat, out nb)) // Convertit le string resultat en int nb, retourne un true si la conversion est réussie
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier : ");
                    resultat = Console.ReadLine();
                }
                catch (Exception)
                {
                }
            }
            return nb;

        }
        /// <summary>
        /// Demande la saisie au clavier d'un nombre entier ayant pour valeur minimale pMin
        /// </summary>
        /// <param name="pMin">Valeur minimale du nombre entier à saisir</param>
        /// <returns>Retourne un entier supérieur ou égal à Pmin</returns>
        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier supérieur à " + pMin + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin);
            return nb;
        }
        /// <summary>
        /// Demande la saisie au clavier d'un nombre entier compris 
        /// entre 2 bornes (pMin et pMax)
        /// </summary>
        /// <param name="pMin">Valeur minimale du nombre entier à saisir</param>
        /// <param name="pMax">Valeur maximale du nombre entier à saisir</param>
        /// <returns>Retourne un entier compris entre pMin et pMax </returns>
        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier supérieur à " + pMin + " et inférieur à " + pMax + ": ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin || nb > pMax);
            return nb;
        }
        /// <summary>
        /// Permet de convertir un entier en base 10 en un nombre dans une autre base de 2 à 16
        /// </summary>
        /// <param name="nbAConvertir">Entier de base 10 à convertir</param>
        /// <param name="newBase">Base dans laquelle le nombre sera converti</param>
        /// <returns>Le nombre converti dans la nouvelle base sous forme de String</returns>
        public static string Conversion(int nbAConvertir, int newBase)
        {
            if (nbAConvertir <= 0)
            {
                throw new Exception("Le nombre à convertir doit être strictement positif");
            }
            if (newBase < 2 || newBase > 16)
            {
                throw new Exception("La nouvelle base doit être comprise entre 2 et 16");
            }

            int reste;
            int resultat = nbAConvertir;
            Pile<int> unePile = new Pile<int>();
            int test;
            string valeur = "";

            while (resultat != 0)
            {
                reste = (resultat % newBase);
                resultat = (resultat / newBase);
                unePile.Empiler(reste);
            }
            while (!unePile.PileVide())
            {
                test = (int)unePile.Depiler();
                if (test < 10)
                {
                    valeur += Convert.ToString(test);
                }
                else
                {
                    valeur += Convert.ToChar(test + 55);
                }
            }
            return valeur;
        }
        public static string InversePhrase(String phrase)
        {
            string[] maListe = phrase.Split(' ');
            string maListeInversee = string.Join(" ", maListe.Reverse());
            return maListeInversee;
        }
    }
}
