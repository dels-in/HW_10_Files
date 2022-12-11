using HW_10;
using DirectoryInfo = HW_10.DirectoryInfo;


//FileSistemInfo.OutputFileSystemInfo();
DirectoryInfo.WorkWithDirectories();
for (int i = 1; i <= 2; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Files.CreateFile($"TestDir{i}", $"File{j}");
    }
}