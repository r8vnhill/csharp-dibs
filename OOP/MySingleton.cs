namespace OOP;

/// <summary>
///     A basic implementation of the singleton pattern in C#.
/// </summary>
/// <remarks>
///     This class ensures that only one instance of <see cref="MySingleton" /> exists throughout the application,
///     accessible via the <see cref="Instance" /> property.
/// </remarks>
/// <example>
///     Accessing and using the singleton:
///     <code>
/// var singleton = MySingleton.Instance;
/// singleton.Name = "Power";
/// Console.WriteLine(singleton.Greet()); // Output: Hello, Power
///     </code>
///     <code>
/// var other = MySingleton.Instance;
/// other.Name = "Makima";
/// Console.WriteLine(other.Greet()); // Output: Hello, Makima
/// 
/// Console.WriteLine(singleton.Greet()); // Output: Hello, Makima (same instance)
///     </code>
/// </example>
public class MySingleton
{
    // Private constructor to prevent external instantiation.
    private MySingleton()
    {
    }

    /// <summary>
    ///     Gets or sets the name used in the greeting.
    /// </summary>
    public string Name { get; set; } = "Singleton";

    /// <summary>
    ///     The single, shared instance of <see cref="MySingleton" />.
    /// </summary>
    public static MySingleton Instance { get; } = new();

    /// <summary>
    ///     Returns a greeting message using the current <see cref="Name" />.
    /// </summary>
    /// <returns>A greeting string.</returns>
    public string Greet()
    {
        return $"Hello, {Name}";
    }
}