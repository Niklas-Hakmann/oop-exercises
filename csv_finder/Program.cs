using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast stien til mappen, du vil gennemsøge:");
        string folderPath = Console.ReadLine();

        // Find alle CSV-filer
        List<string> csvFiles = FindCsvFiles(folderPath);

        // Print stierne til CSV-filerne
        Console.WriteLine("Fundne CSV-filer:");
        foreach (var file in csvFiles)
        {
            Console.WriteLine(file);
        }

        // Gem stierne til CSV-filerne i output.txt
        File.WriteAllLines("output.txt", csvFiles);
        Console.WriteLine("Stierne er gemt i output.txt");
    }

    static List<string> FindCsvFiles(string folderPath)
    {
        List<string> csvFiles = new List<string>();

        try
        {
            // Gennemgår alle CSV-filer i mappen og dens undermapper
            foreach (var file in Directory.GetFiles(folderPath, "*.csv", SearchOption.AllDirectories))
            {
                csvFiles.Add(file);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Der opstod en fejl: {ex.Message}");
        }

        return csvFiles;
    }
}