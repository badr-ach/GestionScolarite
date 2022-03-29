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


        }
    }
}
