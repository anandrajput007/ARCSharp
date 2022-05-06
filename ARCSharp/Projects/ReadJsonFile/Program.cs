using System;

namespace ReadJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = $"F:\\MYGit\\CS\\ARCSharp\\Projects\\ReadJsonFile\\Data\\file_path.json";
            var data = TheJsonReader.Read(filePath);

            foreach(var item  in data)
            {
                Console.WriteLine($"Source : {item.Source}{item.FileName}\t\t\t Destination: {item.Destination}{item.FileName}");
            }

            Console.ReadLine();
        }
    }
}
