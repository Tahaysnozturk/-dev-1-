using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cinsiyeti girin (K/Kadın veya E/Erkek): ");
        char cinsiyet = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine("\n\nBoy (cm) girin: ");
        double boyCm = double.Parse(Console.ReadLine());

        Console.WriteLine("\n\nKilo (kg) girin: ");
        double kilo = double.Parse(Console.ReadLine());

        double idealKilo = HesaplaIdealKilo(cinsiyet, boyCm);

        Console.WriteLine($"\n\nİdeal kilo: {idealKilo} kg");

        if (kilo < idealKilo)
        {
            Console.WriteLine("Şu anda ideal kilonuzun altındasınız.");
        }
        else if (kilo > idealKilo)
        {
            Console.WriteLine("Şu anda ideal kilonuzun üstündesiniz.");
        }
        else
        {
            Console.WriteLine("Şu anda ideal kilodasınız.");
        }

        Console.ReadKey();
    }

    static double HesaplaIdealKilo(char cinsiyet, double boyCm)
    {
        double idealKilo = 0;

        if (cinsiyet == 'K')
        {
            idealKilo = 45.5 + 2.3 * ((boyCm / 2.54) - 60);
        }
        else if (cinsiyet == 'E')
        {
            idealKilo = 50 + 2.3 * ((boyCm / 2.54) - 60);
        }

        return idealKilo;
    }
}
