using System;

namespace FinalTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2];

            Adult adult = new Adult("Adult_first_name", "Adult_last_name ");
            Child child = new Child("Child_first_name", "Child_last_name ");
            persons[0] = adult;
            persons[1] = child;
            foreach (Person person in persons)
            {
                Console.WriteLine(person.toString());
            }

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string toString()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Adult : Person
    {
        public Adult(string firstName, string lastName) : base(firstName, lastName)
        {

        }
    }

    public class Child : Person
    {
        public Child(string firstName, string lastName) : base(firstName, lastName)
        {

        }
    }


}
