using System;

class Untitled
{
    static void Main(string[] args)
    {
        // Tallennetaan funktion paluu muuttujaan
        var info = AskInformation();
        double bmi = CalculateBMI(info.height, info.weight);

        PrintResult(info.name, info.height, info.weight, bmi);

    } // Main

    // Tämä funktio kysyy käyttäjältä tiedot ja laskee BMI:n sen perusteella
    public static (string name, double height, double weight) AskInformation()
    {
        Console.Write("Anna nimesi: ");
        string name = Console.ReadLine();

        Console.Write("Anna pituutesi muodossa metri, sentti (esim. 1,75): ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Anna painosi kilon tarkkuudella: ");
        double weight = double.Parse(Console.ReadLine());

        // Palautetaan tuple
        return (name, height, weight);
    }
    // Lasketaan bmi 
    public static double CalculateBMI(double height, double weight)
    {
        double bmi = Math.Round(weight / (height * height), 2);
        return bmi;
    }

    public static void PrintResult(string name, double height, double weight, double bmi)
    {
        string tulos = $"{name}, pituutesi on {height} m ja painosi on {weight}. Painoindeksi {bmi}.";
        Console.WriteLine(tulos);


        if (bmi <= 14.9)
        {
            Console.WriteLine("Sairaalloinen alipaino");
        }
        else if (bmi <= 17.9)
        {
            Console.WriteLine("Merkittävä alipaino");
        }
        else if (bmi <= 18.9)
        {
            Console.WriteLine("Lievä alipaino");
        }
        else if (bmi <= 24.9)
        {
            Console.WriteLine("Normaali paino");
        }
        else if (bmi <= 29.9)
        {
            Console.WriteLine("Lievä ylipaino");
        }
        else if (bmi <= 34.9)
        {
            Console.WriteLine("Merkittävä ylipaino");
        }
        else if (bmi <= 39.9)
        {
            Console.WriteLine("Vaikea ylipaino");
        }
        else
        {
            Console.WriteLine("Sairaalloinen ylipaino");
        }
    }

} // Class