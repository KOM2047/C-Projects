using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // List to store user inputs.
        List<object> userInputs = new List<object>();

        Console.WriteLine("Enter your inputs one at a time. Type 'exit' to finish:");

        // Use while loop to accept input.
        string input;
        while ((input = Console.ReadLine()) != null)
        {
            // Use "exit" to break the loop.
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            // Automatically detect and convert the input.
            object parsedInput = ParseInput(input);
            userInputs.Add(parsedInput);
        }

        // Count and print the occurrences of each item.
        CountOccurrences(userInputs);
    }

    // Try to parse the string input into a more specific type.
    public static object ParseInput(string input)
    {
        // Try parsing to an integer first.
        if (int.TryParse(input, out int intResult))
            return intResult;

        // Try parsing to a double.
        if (double.TryParse(input, out double doubleResult))
            return doubleResult;

        // Try parsing to a boolean.
        if (bool.TryParse(input, out bool boolResult))
            return boolResult;

        // Try parsing to a DateTime.
        if (DateTime.TryParse(input, out DateTime dateResult))
            return dateResult;

        // Default to the original string if no conversion applies.
        return input;
    }

    // Generic method to count occurrence of items and display them.
    public static void CountOccurrences<T>(List<T> items)
    {
        Dictionary<T, int> counts = new Dictionary<T, int>();

        foreach (T item in items)
        {
            if (counts.ContainsKey(item))
                counts[item]++;
            else
                counts[item] = 1;
        }

        foreach (KeyValuePair<T, int> pair in counts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} time(s)");
        }
    }
}

