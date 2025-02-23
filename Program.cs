using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Convertisseur de bases numériques");
        Console.WriteLine("----------------------------------");


        Console.Write("Entrez un nombre : ");
        string nombre = Console.ReadLine();


        Console.WriteLine("Choisissez la conversion :");
        Console.WriteLine("1. Décimal vers Binaire");
        Console.WriteLine("2. Binaire vers Décimal");
        Console.WriteLine("3. Décimal vers Hexadécimal");
        Console.WriteLine("4. Hexadécimal vers Décimal");
        Console.WriteLine("5. Décimal vers Base 8");
        Console.WriteLine("6. Base 8 vers Décimal");
        Console.WriteLine("7. Décimal vers DCB");
        Console.WriteLine("8. DCB vers Décimal");


        Console.Write("Votre choix : ");
        int choix = int.Parse(Console.ReadLine());


        switch (choix)
        {
            case 1:
                Console.WriteLine($"Résultat : {DecimalVersBinaire(nombre)}");
                break;
            case 2:
                Console.WriteLine($"Résultat : {BinaireVersDecimal(nombre)}");
                break;
            case 3:
                Console.WriteLine($"Résultat : {DecimalVersHexa(nombre)}");
                break;
            case 4:
                Console.WriteLine($"Résultat : {HexaVersDecimal(nombre)}");
                break;
            case 5:
                Console.WriteLine($"Résultat : {DecimalVersBase8(nombre)}");
                break;
            case 6:
                Console.WriteLine($"Résultat : {Base8VersDecimal(nombre)}");
                break;
            case 7:
                Console.WriteLine($"Résultat : {DecimalVersDCB(nombre)}");
                break;
            case 8:
                Console.WriteLine($"Résultat : {DCBVersDecimal(nombre)}");
                break;
            default:
                Console.WriteLine("Choix invalide.");
                break;
        }
    }


    static string DecimalVersBinaire(string nombre)
    {
        int dec = int.Parse(nombre);
        return Convert.ToString(dec, 2);
    }


    static int BinaireVersDecimal(string nombre)
    {
        return Convert.ToInt32(nombre, 2);
    }


    static string DecimalVersHexa(string nombre)
    {
        int dec = int.Parse(nombre);
        return Convert.ToString(dec, 16).ToUpper();
    }


    static int HexaVersDecimal(string nombre)
    {
        return Convert.ToInt32(nombre, 16);
    }


    static string DecimalVersBase8(string nombre)
    {
        int dec = int.Parse(nombre);
        return Convert.ToString(dec, 8);
    }


    static int Base8VersDecimal(string nombre)
    {
        return Convert.ToInt32(nombre, 8);
    }


    static string DecimalVersDCB(string nombre)
    {
        string dcb = "";
        foreach (char c in nombre)
        {
            int digit = int.Parse(c.ToString());
            dcb += Convert.ToString(digit, 2).PadLeft(4, '0') + " ";
        }
        return dcb.Trim();
    }


    static int DCBVersDecimal(string nombre)
    {
        string[] parties = nombre.Split(' ');
        string resultat = "";
        foreach (string partie in parties)
        {
            resultat += Convert.ToInt32(partie, 2).ToString();
        }
        return int.Parse(resultat);
    }
}