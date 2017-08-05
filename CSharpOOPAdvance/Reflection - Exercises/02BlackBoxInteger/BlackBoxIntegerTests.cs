using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = typeof(BlackBoxInt);
            BlackBoxInt blackBox = (BlackBoxInt)Activator.CreateInstance(classType, true);

            // altenative
            //ConstructorInfo classTypeConstructor =
            //    classType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, Type.DefaultBinder,
            //        new Type[] { }, null);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBox, new object[] { value });

                string innerStateValue = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .First()
                    .GetValue(blackBox)
                    .ToString();

                Console.WriteLine(innerStateValue);
            }
        }
    }
}
