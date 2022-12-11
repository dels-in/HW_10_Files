namespace HW_10;

using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

public static class Files
{
    internal static void CreateFile(string dirName, string fileName)
    {
        string userFolder = GetFolderPath(SpecialFolder.Personal);
        var testDir = new string[] { userFolder, "Otus", $"{dirName}" };
        string dir = Combine(testDir);

        // определение путей к файлам
        string textFile = Combine(dir, $"{fileName}.txt");

        // создание текстового файла и запись текстовой строки
        StreamWriter textWriter = File.CreateText(textFile);
        textWriter.WriteLine($"{fileName}");

        // закрытие файла и высвобождение ресурсов
        textWriter.Close();
        string addition = DateTime.Now.ToString();
        var chars = addition.ToCharArray();
        using var writer = new StreamWriter(textFile, true);
        writer.WriteLine(chars);

        using var reader = new StreamReader(textFile);
        while (!reader.EndOfStream)
        {
            var text = reader.ReadLine();
            WriteLine($"{fileName}: {text} + {addition}");
        }
    }
}