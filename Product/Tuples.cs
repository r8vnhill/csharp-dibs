namespace Product;

public static class Tuples
{
    public static void ValueTupleExample()
    {
        var tuple = (1, "hello", true);
        Console.WriteLine(tuple.Item1); // Output: 1
        Console.WriteLine(tuple.Item2); // Output: hello
        Console.WriteLine(tuple.Item3); // Output: True
    }
}