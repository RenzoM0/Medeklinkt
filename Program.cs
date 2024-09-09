using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        const string path = "textfiles//Dieren.txt";

        try
        {
            string tekst = File.ReadAllText(path);
            string cTekst = Regex.Replace(tekst, "[^a-zA-Z0-9 ]+", " "); // Verwijder alle speciale karakters

            string[] woordenArray = cTekst.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); // Split de tekst in woorden
            List<Woord> woorden = new List<Woord>();
            foreach (string woord in woordenArray)
            {
                woorden.Add(new Woord(woord));
            }
            foreach (Woord item in woorden) // Toon woorden met aantal klinkers & medeklinkers
            {
                Console.WriteLine($"Woord: {item.ToString()}");
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Er is een fout opgetreden: " + ex.Message);
        }
    }
}