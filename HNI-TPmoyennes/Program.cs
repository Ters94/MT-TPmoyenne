using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'une classe
            Classe sixiemeA = new Classe("6eme A");
            // Ajout des élèves à la classe
             sixiemeA.ajouterEleve("Jean", "RAGE");
              sixiemeA.ajouterEleve("Paul", "HAAR");
              sixiemeA.ajouterEleve("Sibylle", "BOQUET");
              sixiemeA.ajouterEleve("Annie", "CROCHE");
              sixiemeA.ajouterEleve("Alain", "PROVISTE");
              sixiemeA.ajouterEleve("Justin", "TYDERNIER");
              sixiemeA.ajouterEleve("Sacha", "TOUILLE");
              sixiemeA.ajouterEleve("Cesar", "TICHO");
              sixiemeA.ajouterEleve("Guy", "DON");
             
             // Ajout de matières étudiées par la classe
             sixiemeA.ajouterMatiere("Francais");
             sixiemeA.ajouterMatiere("Anglais");
             sixiemeA.ajouterMatiere("Physique/Chimie");
             sixiemeA.ajouterMatiere("Histoire");
             Random random = new Random();
            // Ajout de 5 notes à chaque élève et dans chaque matière
            /*
                         for (int ieleve = 0; ieleve < sixiemeA.eleves.Count(); ieleve++)
                         {
                             for (int matiere = 0; matiere < sixiemeA.matieres.Count(); matiere++)
                             {
                                 for (int i = 0; i < 5; i++)
                                 {
                                     if (sixiemeA.eleves[ieleve] is not null)
                                     {
                                         sixiemeA.eleves[ieleve].ajouterNote(new Note(matiere, (float)((6.5 + random.NextDouble() * 34)) / 2.0f));

                                     }
                                     // Note minimale = 3
                                 }
                             }
                         }
                         Console.WriteLine("");
                         Eleve eleve = sixiemeA.eleves[6];
                         // Afficher la moyenne d'un élève dans une matière
                         Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
                         eleve.Moyenne(1) + "\n");
                         // Afficher la moyenne générale du même élève
                         Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne Generale : " + eleve.Moyenne() + "\n");
                         // Afficher la moyenne de la classe dans une matière
                         Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
                         sixiemeA.Moyenne(1) + "\n");
                         // Afficher la moyenne générale de la classe
                         Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne Generale : " + sixiemeA.Moyenne() + "\n");
                         Console.Read();
                     }
               */
        }
        class Note : Eleve
        {
            public int matiere { get; private set; }
            public float note { get; private set; }
            public Note(int m, float n) : base("", "")
            {
                this.matiere = m;
                this.note = n;
            }
        }
        class Classe
        {
            internal string nomClasse { get; }
            internal string[] matieres;
            internal Eleve[] eleves;
            private string nom;
            public Classe(string nom = "")
            {
                this.nom = nom;
                this.nomClasse = nom;
                this.eleves = new Eleve[30];
                this.matieres = new string[10];
            }
            public void ajouterEleve(string prenom, string nom)
            {
                for (int i = 0; i < eleves.Length; i++)
                {
                    //verification si tab eleve est null
                    if (eleves[i] is null)
                    {
                        eleves[i] = new Eleve(prenom, nom);
                        break;
                    }
                }
              //  Console.WriteLine($"{prenom} {nom}");
            }
            public void ajouterMatiere(string matiere)
            {
                for (int i = 0; i < matieres.Length; i++)
                {
                    if (matieres[i] is null)
                    {
                        matieres[i] = matiere;
                        break;
                    }
                }
               //Console.WriteLine(matiere);
            }

        }

        class Eleve : Classe
        {
            internal Note[] notes;
            public string prenom;
            public string nom;
            //chaine caractere vide pour nom et prenom
            public Eleve(string prenom = "", string nom = "")
            {
                this.nom = nom;
                this.prenom = prenom;
                this.notes = new Note[200];
            }


        }
    }
}

    