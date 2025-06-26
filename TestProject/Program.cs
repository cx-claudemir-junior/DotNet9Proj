using System.IO.Abstractions;

public class Program
{
    public static void Main(string[] args) {
        var message = "Hello World";
        var fileSystem = new FileSystem();
        fileSystem.File.WriteAllTextAsync("test.log" , message);
        Console.WriteLine(message);
    }
}