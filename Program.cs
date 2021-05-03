using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> people = new HashSet<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                var person = new Person(line[0], int.Parse(line[1]));
                people.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(people.Count);
        }
    }
}
