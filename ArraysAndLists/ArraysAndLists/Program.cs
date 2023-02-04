using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // One-dimensional Array of strings
        string[] stringArray = { "apple", "banana", "cherry", "dates" };
        Console.WriteLine("Select an index from the following Array of strings:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine($"{i}: {stringArray[i]}");
        }
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if selected index exists in the Array
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine($"The string at index {stringIndex} is: {stringArray[stringIndex]}");
        }
        else
        {
            Console.WriteLine("Index does not exist in the Array.");
        }

        // One-dimensional Array of integers
        int[] intArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("\nSelect an index from the following Array of integers:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine($"{i}: {intArray[i]}");
        }
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if selected index exists in the Array
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine($"The integer at index {intIndex} is: {intArray[intIndex]}");
        }
        else
        {
            Console.WriteLine("Index does not exist in the Array.");
        }

        // List of strings
        List<string> stringList = new List<string> { "apple", "banana", "cherry", "dates" };
        Console.WriteLine("\nSelect an index from the following List of strings:");
        for (int i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine($"{i}: {stringList[i]}");
        }
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if selected index exists in the List
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine($"The string at index {listIndex} is: {stringList[listIndex]}");
        }
        else
        {
            Console.WriteLine("Index does not exist in the List.");
        }
                
        Console.ReadLine();
    }
}

