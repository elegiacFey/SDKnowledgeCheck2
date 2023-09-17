using System;

namespace SDKnowledgeCheck2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many albums do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<AlbumInfo>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            var info = new VinylRecord();

            Console.WriteLine("Enter the name of the album: ");
            info.name = Console.ReadLine();

            Console.WriteLine("Enter the artist(s): ");
            info.artist = Console.ReadLine();

            Console.WriteLine("Enter the genre(s): ");
            info.genre = Console.ReadLine();

            Console.WriteLine("Enter the release year: ");
            info.year = Console.ReadLine();

            Console.WriteLine("LP, EP, or single: ");
            info.length = Console.ReadLine();

            Console.WriteLine("Enter the vinyl color: ");
            info.color = Console.ReadLine();

            Console.WriteLine("Enter the rpm the record is played at: ");
            info.rpm = Console.ReadLine();

            Console.WriteLine("Enter what condition the record is in: ");
            info.condition = Console.ReadLine();

            Console.WriteLine("Album added!");
            recordList.Add(info);
        }

        Console.WriteLine("All albums added: ");
        foreach (var info in recordList)
        {
            Console.WriteLine(info.name + " - " + info.artist);
        }
    }
}

