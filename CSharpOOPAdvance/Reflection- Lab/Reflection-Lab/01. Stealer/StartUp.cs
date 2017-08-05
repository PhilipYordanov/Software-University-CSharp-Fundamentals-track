using System;

public class StartUp
{
    public static void Main()
    {
        Spy spy = new Spy();
        string result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
        var collection = new string[4] {"asd", "asd", "asd", "asd"};

    }
}