using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnesInfos
{
    class Personne
    {
        public string Sexe, Nom, Prenom, AnneeNaissance, EtatCivil, Conjoint;

        public Personne(string Gender, string Name, string FirstName, string YearBirth, string StatusCivil) //Initialisation des propriétés Personne.
        {
            Sexe = Gender;
            Prenom = FirstName;
            Nom = Name;
            AnneeNaissance = YearBirth;
            EtatCivil = StatusCivil;
        }

        public string RetourneInfos(string Sex, string Nam, string FirstNam, string YearB, string StatCivil) //Méthode afin de retourner une phrase de description pour chaque personne.
        {
            string affichage;
            string changementGenre; //Sert à changer l'orthographe selon si c'est un homme ou une femme.

            if (Sex == "M. ")
            {
                changementGenre = ", il est ";
            }
            else
            {
                changementGenre = ", elle est ";
            }

            affichage = Sex + Nam + FirstNam + "est né en " + YearB + changementGenre + StatCivil; //Affichage de la phrase de description.

            return affichage;
        }

        public string RetourneAge(string S, string N, string FN, string Age) //Méthode qui servira à calculer et à retourner l'âge de chaques personnes, en fonction de l'année actuelle (2016 - annéeNaissance)
        {
            int annee = 2016;
            string affichage;

            annee = annee - Convert.ToInt32(AnneeNaissance);

            affichage = S + N + FN + "a " + annee + " ans";

            return affichage;
        }
    }
}
