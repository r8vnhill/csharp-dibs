namespace Exceptions;

public static class EdSheeran
{
    public static void ValidateAge(int age) {
        if (age >= 70) {
            throw new StopLovingException(
                "And, darling, I will be loving you 'til we're 70");
        }
    }
}

public class StopLovingException(string message) : Exception(message);
