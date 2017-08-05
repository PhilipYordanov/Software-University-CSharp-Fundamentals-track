using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01HarestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var fieldsType = typeof(HarvestingFields);
            FieldInfo[] fields = fieldsType
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            Dictionary<string, Func<FieldInfo[]>> commandsDictionary = new Dictionary<string, Func<FieldInfo[]>>()
            {
                {"private", ()=> fields.Where(f => f.IsPrivate).ToArray()},
                {"protected", ()=> fields.Where(f => f.IsFamily).ToArray()},
                {"public", ()=> fields.Where(f => f.IsPublic).ToArray()},
                {"all", ()=> fields}
            };

            string requestedCommand;
            while ((requestedCommand = Console.ReadLine()) != "HARVEST")
            {
                commandsDictionary[requestedCommand]()
                    .Select(x => $"{x.Attributes.ToString().ToLower()} {x.FieldType.Name} {x.Name}")
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Replace("family", "protected")));
            }
        }
    }
}
