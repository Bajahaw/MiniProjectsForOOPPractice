using System;
using System.IO;

class DirectoryOperation
{
    private static void copyAll(DirectoryInfo source, DirectoryInfo target)
    {
        if (source.FullName.ToLower() == target.FullName.ToLower())
        {
            return;
        }
        if (Directory.Exists(target.FullName) == false)
        {
            Directory.CreateDirectory(target.FullName);
        }
        foreach (FileInfo fi in source.GetFiles())
        {
            Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
            fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
        }
        foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
        {
            DirectoryInfo nextTargetSubDir =
                target.CreateSubdirectory(diSourceSubDir.Name);
            copyAll(diSourceSubDir, nextTargetSubDir);
        }
    }

    public static void CopyTo(string source, string target)
    {
        copyAll(new DirectoryInfo(source), new DirectoryInfo(target));
    }

    public static void delete(DirectoryInfo directory)
    {
        try
        {
            if (directory.Exists)
            {
                directory.Delete(true);
                Console.WriteLine($"Deleted folder: {directory.FullName}");
            }
            else
            {
                Console.WriteLine($"Folder '{directory.FullName}' does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during folder deletion: {ex.Message}");
        }
    }

    public static void getFiles(string directory)
    {
        try
        {
            if (Directory.Exists(directory))
            {
                Console.WriteLine($"Files in folder '{directory}':");
                foreach (var file in Directory.GetFiles(directory))
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine($"Folder '{directory}' does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error listing files: {ex.Message}");
        }
    }

    public static void renameTo(string source, string destination)
    {
        try
        {
            if (Directory.Exists(source))
            {
                Directory.Move(source, destination);
                Console.WriteLine($"Renamed folder: {source} -> {destination}");
            }
            else
            {
                Console.WriteLine($"Folder '{source}' does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during folder renaming: {ex.Message}");
        }
    }

}