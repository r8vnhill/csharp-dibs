using Exceptions;

try
{
    FileReader.ReadConfigFile("config.json");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}