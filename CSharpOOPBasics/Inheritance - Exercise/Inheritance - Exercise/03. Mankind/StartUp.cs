namespace _03.Mankind
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentTokens = Console.ReadLine()
                    .Split();

                var workerTokens = Console.ReadLine()
                    .Split();

                var student = new Student(studentTokens[0]
                    , studentTokens[1]
                    , studentTokens[2]);

                var worker = new Worker(workerTokens[0]
                    , workerTokens[1]
                    , decimal.Parse(workerTokens[2])
                    , decimal.Parse(workerTokens[3]));

                Console.Write(student.ToString());
                Console.Write(worker.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
