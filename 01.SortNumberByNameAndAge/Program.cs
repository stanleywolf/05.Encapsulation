﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var personCount = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < personCount; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], input[1], int.Parse(input[2]));
            persons.Add(person);

        }
        persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p=>Console.WriteLine(p));
    }
}
