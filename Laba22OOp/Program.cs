public class StringWorker
{
    public void ProcessCapitalLetters(string originalString)
    {
        Console.WriteLine("Original string: " + originalString);
        Console.WriteLine("Length: " + originalString.Length);

        string processedString = new string(originalString.ToUpper().OrderBy(c => c).ToArray());
        Console.WriteLine("Sorted and capitalized: " + processedString);
        Console.WriteLine();
    }

    public void ProcessSmallLetters(string originalString)
    {
        Console.WriteLine("Original string: " + originalString);
        Console.WriteLine("Length: " + originalString.Length);

        string processedString = new string(originalString.ToLower().OrderByDescending(c => c).ToArray());
        Console.WriteLine("Sorted and lowercased: " + processedString);
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        StringWorker worker = new StringWorker();

        worker.ProcessCapitalLetters("Salam Popolam");

        worker.ProcessSmallLetters("Popolam Salam");
    }
}