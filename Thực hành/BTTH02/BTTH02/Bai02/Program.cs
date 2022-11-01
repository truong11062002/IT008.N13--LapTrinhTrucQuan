using System;
using System.Collections.Generic;
using System.IO;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path: ");
            string path = Console.ReadLine();
            List<Item> listItems = GetAllFilesAndFolders(path);
            DisplayAllFilesAndFolder(listItems);
        }

        private static void DisplayAllFilesAndFolder(List<Item> listItems)
        {
            foreach (Item i in listItems)
                i.Display();
        }

        private static List<Item> GetAllFilesAndFolders(string path)
        {
            List<Item> Result = new List<Item>();
            if (Directory.Exists(path))
            {
                string[] listFiles = Directory.GetFiles(path);
                foreach (string filePath in listFiles)
                {
                    FileInfo info = new FileInfo(filePath);
                    File tmp = new File(info.Name, info.LastWriteTime, info.Length);
                    Result.Add(tmp);
                }
                string[] listFolders = Directory.GetDirectories(path);
                foreach (string folderPath in listFolders)
                {
                    DirectoryInfo info = new DirectoryInfo(folderPath);
                    Folder tmp = new Folder(info.Name, info.LastWriteTime);
                    Result.Add(tmp);
                }
            }
            return Result;
        }
    }
}
