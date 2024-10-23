namespace Exceptions;

public static class FileReader
{
    public static void ReadFile(string path)
    {
        using var stream = new FileStream(path, FileMode.Open);
        using var reader = new StreamReader(stream);
        var content = reader.ReadToEnd();
        Console.WriteLine("Contenido del archivo:");
        Console.WriteLine(content);
    }
    
    public static void ReadConfigFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Configuration file not found: {filePath}");
        }
        try
        {
            Console.WriteLine("Configuration loaded successfully.");
        }
        catch (IOException ex)
        {
            throw new IOException("Error reading the configuration file.", ex);
        }
    }
}
