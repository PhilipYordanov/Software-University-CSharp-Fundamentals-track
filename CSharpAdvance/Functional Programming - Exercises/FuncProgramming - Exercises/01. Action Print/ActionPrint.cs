using System;

public class ActionPrint
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\r\n", Console.ReadLine().Split()));
    }
}