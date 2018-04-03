using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var personCount = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < personCount; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
            persons.Add(person);

        }
        var percentage = decimal.Parse(Console.ReadLine());

        persons.ForEach(p=>p.IncreaceSalary(percentage));
        persons.ForEach(p=>Console.WriteLine(p));
    }
}