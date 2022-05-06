using System;
using ReadJsonFile;
using ReadJsonFile.Model;

namespace CopyPasteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = $"F:\\MYGit\\CS\\ARCSharp\\Projects\\CopyPasteFiles\\Data\\file_path.json";
            
            var data = TheJsonReader.Read(filePath);

            foreach (var item in data)
            {
                string _sourceFilePath = item.Source + item.FileName;
                string _destincationFilePath = item.Destination + item.FileName;
                bool _fileOverWrite = true;

                var isFileExist = FileOperation.IsFileExist(_sourceFilePath);

                if (!isFileExist) Console.WriteLine($"File {item.FileName} not found in location {item.Source}");
                else
                {
                    FileOperation.CopyFile(_sourceFilePath, _destincationFilePath, _fileOverWrite);
                    Console.WriteLine($"File {item.FileName} successfully copy to new location at {item.Destination}");
                }
            }

            Console.ReadLine();
        }
    }
}
