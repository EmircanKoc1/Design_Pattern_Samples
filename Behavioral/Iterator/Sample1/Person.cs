﻿namespace Behavioral.Iterator.Sample1
{
    public class Person
    {
        public Person(string? name, string? surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string? Name { get; }
        public string? Surname { get; }
        public int Age { get; }

        public override string ToString()
        {
            return $"""
                I am a human , my full name is {Name ?? "undefined"} {Surname ?? "undefined"}, and i am {Age} years old.
                """;
        }
    }
}
