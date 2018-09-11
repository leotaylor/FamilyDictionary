using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add(" twin sister", new Dictionary<string, string>()
            {
                {"name", "Michelle"},
                {"age", "33"}
            });

            myFamily.Add("brother", new Dictionary<string, string>()
            {
                {"name", "Mark"},
                {"age", "55"}
            });

            myFamily.Add("oldest sister", new Dictionary<string, string>()
            {
                {"name", "Heather"},
                {"age", "50"}
            });

            myFamily.Add("father", new Dictionary<string, string>()
            {
                {"name", "George"},
                {"age", "81"}
            });

            myFamily.Add("mother", new Dictionary<string, string>()
            {
                {"name", "Janette"},
                {"age", "61"}
            });

            foreach(var member in myFamily)
            {
                var relation = member.Key;
                var person = member.Value;

                string memberName = "";
                string memberAge = "";

                foreach ( var individual in person)
                {
                    if(individual.Key == "name")
                    {
                        memberName = individual.Value;
                    }

                    if(individual.Key == "age")
                    {
                        memberAge = individual.Value;
                    }
                }

                Console.WriteLine($"{memberName} is my {relation} and is {memberAge} years old.");
            }
            Console.ReadLine();
        }
    }
}
