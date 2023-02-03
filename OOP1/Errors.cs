namespace OOP1;

internal class Errors
{
    public static void CheckForRangeError<T>(
        T value,
        string valueName,
        Func<T, bool> rangePredicate,
        string acceptedRangeDisplay = ""
    )
    {
        bool inAcceptedRange = rangePredicate(value);

        if (!inAcceptedRange)
            throw new ArgumentOutOfRangeException(valueName,
              $"Value for {valueName} ({value}) is not in accepted range: {acceptedRangeDisplay}"
            );
    }
}
