namespace Product;

public record Person(string Name, int Age)
{
    public static void RecordExample()
    {
        var person = new Person("Alice", 30);
        Console.WriteLine(person.Name); // Output: Alice
        Console.WriteLine(person.Age); // Output: 30
    }

    public static void CopyWithExample()
    {
        var person = new Person("Alice", 30);
        var olderPerson = person with { Age = 31 };
        Console.WriteLine(olderPerson.Name); // Output: Alice
        Console.WriteLine(olderPerson.Age); // Output: 31
    }
}