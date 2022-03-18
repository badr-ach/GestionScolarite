using IdentityModel;
using System;
using System.Collections.Generic;
using System.Reflection;
using DB;

namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant e = new Etudiant();

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
            }


        }
    }
}
