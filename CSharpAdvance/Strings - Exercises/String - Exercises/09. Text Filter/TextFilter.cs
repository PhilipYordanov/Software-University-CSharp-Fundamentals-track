using System;

public class TextFilter
{
    public static void Main()
    {
        var bannedWords = Console.ReadLine()
            .Split(new[] {',',' ' },StringSplitOptions.RemoveEmptyEntries);

        var text = Console.ReadLine();

        for (int i = 0; i < bannedWords.Length; i++)
        {
            while (text.IndexOf(bannedWords[i]) != -1)
            {
                var replecedWord = new string('*', bannedWords[i].Length);
                text = text.Replace(bannedWords[i],replecedWord);
            }
        }
        Console.WriteLine(text);
    }
}