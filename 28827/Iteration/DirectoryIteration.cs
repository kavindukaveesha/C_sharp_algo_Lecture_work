using System;
using System.IO;

class DirectoryIteration
{
    public static void TraverseWithIteration(string rootPath)
    {
        Stack<string> directories = new Stack<string>();
        directories.Push(rootPath);

        while (directories.Count > 0)
        {
            string currentDirectory = directories.Pop();
            Console.WriteLine($"Directory: {currentDirectory}");

            try
            {
                foreach (var file in Directory.GetFiles(currentDirectory))
                {
                    Console.WriteLine($"File: {file}");
                }

                foreach (var directory in Directory.GetDirectories(currentDirectory))
                {
                    directories.Push(directory);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accessing {currentDirectory}: {ex.Message}");
            }
        }
    }
}
