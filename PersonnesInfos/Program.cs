using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnesInfos
{
    class Program
    {
        //Début de l'instanciation de la classe.
        static Personne perso1 = new Personne("M. ", "Wayne ", "Bruce ", "1939", "célibataire");
        static Personne perso2 = new Personne("Mme. ", "Romanov ", "Natasha ", "1928", "mariée");
        static Personne perso3 = new Personne("M. ", "Stark ", "Tony ", "1970 ", "divorcé");
        //Fin de l'instanciation de la classe.

        public static void Main(string[] args)
        {
            Console.WriteLine("Descriptions des personnes :");
            Console.WriteLine();
            //Début affichage de la description des personnes (Sexe - Nom - Prénom - Année de naissance - État civil : Marié(e), Célibataire, Divorcé(e).
            Console.WriteLine(perso1.RetourneInfos(perso1.Sexe, perso1.Nom, perso1.Prenom, perso1.AnneeNaissance, perso1.EtatCivil));
            Console.WriteLine();
            Console.WriteLine(perso2.RetourneInfos(perso2.Sexe, perso2.Nom, perso2.Prenom, perso2.AnneeNaissance, perso2.EtatCivil));
            Console.WriteLine();
            Console.WriteLine(perso3.RetourneInfos(perso3.Sexe, perso3.Nom, perso3.Prenom, perso3.AnneeNaissance, perso3.EtatCivil));
            //Fin de l'affichage de la description des personnes.
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("L'âge des personnes est le suivant :");
            Console.WriteLine();
            //Début de l'affichage des âges des personnes (calcul annéeActuelle - annéeDeNaissance).
            Console.WriteLine(perso1.RetourneAge(perso1.Sexe, perso1.Nom, perso1.Prenom, perso1.AnneeNaissance));
            Console.WriteLine();
            Console.WriteLine(perso2.RetourneAge(perso2.Sexe, perso2.Nom, perso2.Prenom, perso2.AnneeNaissance));
            Console.WriteLine();
            Console.WriteLine(perso3.RetourneAge(perso3.Sexe, perso3.Nom, perso3.Prenom, perso3.AnneeNaissance));
            //Fin de l'affichage des âges.
            Console.ReadLine();
        }
    }
}
