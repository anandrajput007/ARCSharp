using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteFiles
{
    public static class FileOperation
    {
        public static bool IsFileExist(string _sourcePath)
        {
            return File.Exists(_sourcePath);
        }

        public static void CopyFile(string _sourcePath, string _destinationPath, bool overWrite = true)
        {
            try
            {
                File.Copy(_sourcePath, _destinationPath, overWrite);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }

        public static void RemoveFile(string _filePath)
        {

        }
    }
}
