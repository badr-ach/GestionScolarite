using IdentityModel;
using System;
using System.Collections.Generic;
using System.Reflection;
using DB;

namespace Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            Eleve etd = new Eleve();
            etd.code = "P1101";
            etd.nom = "nom e1";
            etd.prenom = "prenom e1";
            etd.code_fil = "GINF";
            etd.niveau = "1";
            etd.Save();

            Console.WriteLine("Etudiant : " + etd.nom + " " + etd.prenom + " " + etd.code_fil + etd.niveau);
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", "P1101");
            List<dynamic> etds = etd.Select(dico);
            etd = etds[0];

            etd.nom = "nom mis à jour";
            etd.prenom = " changé prenom";
            etd.Save();

            etds = etd.Select(dico);
            etd = etds[0];
            Console.WriteLine("Etudiant : " + etd.nom + " " + etd.prenom + " " + etd.code_fil + etd.niveau);

            etd.Delete();


            /*            Etudiant e = new Etudiant();

                        e.id = 1;
                        e.Delete();
                        e.nom = "Badr";
                        e.prenom = "Al Achkar";
                        e.age = 21;
                        e.specialite = "GINF";
                        e.moyenne = 1000;
                        e.Save();
                        e.nom = "A";
                        e.prenom = "B";
                        e.age = 21;
                        e.specialite = "GINF";
                        e.moyenne = 1000;
                        e.Save();
                        e.nom = "C";
                        e.prenom = "D";
                        e.age = 21;
                        e.specialite = "GINF";
                        e.moyenne = 1000;
                        e.Save();
                        e.nom = "E";
                        e.prenom = "F";
                        e.age = 21;
                        e.specialite = "GINF";
                        e.moyenne = 1000;
                        e.Save();

                        foreach (var etd in e.All())
                        {
                            Console.WriteLine(etd);
                        }*/

            /*Filiere.all<Filiere>();*/
            //Eleve etd = new Eleve();
            //Dictionary<string, object> dico = new Dictionary<string, object>();
            //dico.Add("code_fil", "fdsfsdf");
            //List<dynamic> codeExist = Eleve.select<Eleve>(dico);
            Note not = new Note("maj", "maj", 20); not.id  = 6;
            not.Save();
        }
    }
}
