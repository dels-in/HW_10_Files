namespace HW_10;
using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

public static class FileSistemInfo
{
    internal static void OutputFileSystemInfo()
    {
        WriteLine($"Path.PathSeparator: {PathSeparator}");
        WriteLine($"Path.DirectorySeparatorChar: {DirectorySeparatorChar}");
        WriteLine($"Directory.GetCurrentDirectory(): {GetCurrentDirectory()}");
        WriteLine($"Environment.CurrentDirectory: {CurrentDirectory}");
        WriteLine($"Environment.SystemDirectory: {SystemDirectory}");
        WriteLine($"Path.GetTempPath(): {GetTempPath()}");
        WriteLine($"GetFolderPath(SpecialFolder):");
        WriteLine($" System: {GetFolderPath(SpecialFolder.System)}");
        WriteLine($" ApplicationData:{GetFolderPath(SpecialFolder.ApplicationData)}");
        WriteLine($" MyDocuments: {GetFolderPath(SpecialFolder.MyDocuments)}");
        WriteLine($" Personal: {GetFolderPath(SpecialFolder.Personal)}");
    }
}