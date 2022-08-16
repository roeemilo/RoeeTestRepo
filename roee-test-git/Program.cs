using System;

public class roeeClass
{
    public static void printMyName(string name)
    {
        Console.WriteLine($"my name is {name}");
    }

    public static void Main (string[] args)
    {
        string name = Console.ReadLine();
        printMyName(name);
    }
}