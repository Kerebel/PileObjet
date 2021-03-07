using System;
using System.Collections.Generic;

namespace MesOutils
{
    class Pile<T>
    {
        /// <summary>
        /// Pile contenant et pouvant contenir des entiers.
        /// On ajoute après le dernier élément ajouté
        /// On retire toujours le dernier élément ajouté
        /// </summary>
        public Pile()
        {
            this.elements = new List<T>();
        }
        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<T> elements;
        /// <summary>
        /// Obtient le nombre d'éléments actuellement présents dans la Pile
        /// </summary>
        public int Count { get => this.elements.Count; }
        /// <summary>
        /// Vérifie si la pile est vide ou non
        /// </summary>
        /// <returns>renvoie True si le nombre d'éléments de pile est à 0</returns>
        public bool PileVide()
        {
            return this.elements.Count == 0;
        }
        /// <summary>
        /// Empile le nombre entré en paramètre
        /// </summary>
        /// <param name="pNb">nombre qui va être empiler à la fin de la List</param>
        public void Empiler(T valeur)
        {
                this.elements.Add(valeur);
        }
        /// <summary>
        /// Dépile le dernier nombre empilé dans la List
        /// </summary>
        /// <returns>renvoie l'entier qui a été dépilé</returns>
        public int Depiler()
        {
            if (!PileVide())
            {
                T nb = this.elements[Count - 1];
                this.elements.RemoveAt(Count - 1); // plus sûr
                //pUnePile.tabElem.Remove(obj);
                return Convert.ToInt32(nb);
            }
            else
            {
                throw new Exception("Impossible de dépiler, pile vide");
                // Exception gérée, renvoie un message d'erreur quand la Pile est vide
                // alors que le programme essaie de depiler
            }
        }
    }
}

