using System;
using System.IO;

class DirectoryRecursion
{
    public static void TraverseWithRecursion(string currentDirectory)
    {
        try
        {
            Console.WriteLine($"Directory: {currentDirectory}");
            foreach (var file in Directory.GetFiles(currentDirectory))
            {
                Console.WriteLine($"File: {file}");
            }

            foreach (var directory in Directory.GetDirectories(currentDirectory))
            {
                TraverseWithRecursion(directory);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error accessing {currentDirectory}: {ex.Message}");
        }
    }
}
