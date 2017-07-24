using System;

public class StartUp
{
    public static void Main()
    {
        var phones = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();

        var smartphone = new Smartphone();

        foreach (var phone in phones)
        {
            try
            {
                Console.WriteLine(smartphone.CallPhones(phone));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var site in sites)
        {
            try
            {
                Console.WriteLine(smartphone.BrowseSites(site));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}