using System.IO;

namespace FileTesttwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            //var files = Directory.GetFiles(@"C:\Users\Work Purpose\source\Csharp", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //  Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\Work Purpose\source\Csharp", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
