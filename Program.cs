using System;
class Program
{
    static void Main()
    {
        int age;
        string nom;
        double salaire;
        bool estEtudiant;

        Console.Write("Entrez votre nom : ");
        nom = Console.ReadLine();

        Console.Write("Entrez votre âge : ");
        age = int.Parse(Console.ReadLine());

        salaire = 50000;
        estEtudiant = false;

        Console.WriteLine($"Bonjour {nom}, vous avez {age} ans.");
        Console.WriteLine($"Salaire : {salaire} MRU");
        Console.WriteLine($"Etudiant : {estEtudiant}");
    }
}