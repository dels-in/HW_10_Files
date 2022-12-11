namespace HW_10;

using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

public static class DirectoryInfo
{
    internal static void WorkWithDirectories()
    {
        // определение собственного пути к папке
        string userFolder = GetFolderPath(SpecialFolder.Personal);
        var testDir1 = new string[] { userFolder, "Otus", "TestDir1" };
        var testDir2 = new string[] { userFolder, "Otus", "TestDir2" };
        string dir1 = Combine(testDir1);
        string dir2 = Combine(testDir2);

        // проверка существования папки
        WriteLine($"Does dir1 exist? {Exists(dir1)}");
        WriteLine($"Does dir2 exist? {Exists(dir2)}");

        // создание каталога
        WriteLine("Creating it...");
        CreateDirectory(dir1);
        CreateDirectory(dir2);

        WriteLine($"Does dir1 exist? {Exists(dir1)}");
        WriteLine($"Does dir2 exist? {Exists(dir2)}");
    }
}