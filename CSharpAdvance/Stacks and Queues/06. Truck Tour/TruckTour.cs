using System;
using System.Collections.Generic;

public class GasPump
{
    public int distanceToNext;
    public int amountOfGas;
    public int indexOfPump;

    public GasPump(int distanceToNext, int amountOfGas, int indexOfPump)
    {
        this.distanceToNext = distanceToNext;
        this.amountOfGas = amountOfGas;
        this.indexOfPump = indexOfPump;
    }
}

public class TruckTour
{
    public static void Main()
    {
        var petrolPumps = int.Parse(Console.ReadLine());
        Queue<GasPump> pumps = new Queue<GasPump>();

        for (int i = 0; i < petrolPumps; i++)
        {
            var pumpInfo = Console.ReadLine().Split();

            int distanceToNext = int.Parse(pumpInfo[1]);
            int amountOfGas = int.Parse(pumpInfo[0]);

            GasPump pump = new GasPump(distanceToNext, amountOfGas, i);
            pumps.Enqueue(pump);
        }

        GasPump starterPump = null;
        bool completeJourney = false;

        while (pumps.Count > 0)
        {
            GasPump currentPump = pumps.Dequeue();
            pumps.Enqueue(currentPump);

            starterPump = currentPump;
            int gasInTank = currentPump.amountOfGas;

            while (gasInTank >= currentPump.distanceToNext)
            {
                gasInTank -= currentPump.distanceToNext;

                currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                if (currentPump == starterPump)
                {
                    completeJourney = true;
                    break;
                }

                gasInTank += currentPump.amountOfGas;
            }
            if (completeJourney)
            {
                Console.WriteLine(starterPump.indexOfPump);
                break;
            }
        }
    }
}
