using System;
using System.Collections.Generic;
using System.Linq;

public class BalancedParenthesis
{
    public static void Main()
    {
        // TODO: 87/100 => 100/100
        char[] input = Console.ReadLine().Trim().ToCharArray();

        if (input.Length % 2 == 0)
        {
            if (input.Length <= 1000)
            {
                if (input.Length > 1)
                {
                    IEnumerable<char> firsthalf = input.Take(input.Length / 2).Reverse();
                    IEnumerable<char> secondHalf = input.Skip(input.Length / 2);

                    Stack<char> firstSeq = new Stack<char>(firsthalf);
                    Stack<char> secondSeq = new Stack<char>(secondHalf);

                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        char firstSymbol = firstSeq.Pop();
                        char secondSymbol = secondSeq.Pop();

                        if (!((firstSymbol - secondSymbol) <= 2 && (firstSymbol - secondSymbol) != 0))
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    if ((firstSeq.Count == 0) && (secondSeq.Count == 0))
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}