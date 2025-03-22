// See https://aka.ms/new-console-template for more information

using OOP;

var singleton = MySingleton.Instance;
singleton.Name = "Power";
Console.WriteLine(singleton.Greet()); // Output: Hello, Power

var other = MySingleton.Instance;
other.Name = "Makima";
Console.WriteLine(other.Greet()); // Output: Hello, Makima

Console.WriteLine(singleton.Greet()); // Output: Hello, Makima (same instance)