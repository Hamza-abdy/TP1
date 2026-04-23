using System;
class Program
{
    static void Main()
    {
        int a,b;
        Console.Write("Entrez a : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Entrez b : ");
        b = int.Parse(Console.ReadLine());
        int somme,difference,produit,reste;
        double quotient;
        somme= a+b;
        difference= a-b;
        produit= a*b;
        quotient=a/b;
        reste=a%b;
        Console.WriteLine($"Somme = {somme}");
        Console.WriteLine($"Différence = {difference}");
        Console.WriteLine($"Produit = {produit}");
        Console.WriteLine($"Quotient = {quotient}");
        Console.WriteLine($"Reste = {reste}");
        if (a > b)
            Console.WriteLine($"{a} > {b}");
        else if (a < b)
            Console.WriteLine($"{a} < {b}");
        else
            Console.WriteLine($"{a} = {b}");
            
        bool test= (a > 0) && (b > 0);
        Console.WriteLine($"L'expression : {test}");
    }
}