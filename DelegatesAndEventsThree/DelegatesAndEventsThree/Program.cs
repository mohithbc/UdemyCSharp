namespace DelegatesAndEventsThree
{
    public delegate int Comparison<T>(T x, T y);
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    // Compare people[i] and people[j] using the provided comparison delegate
                    if (comparison(people[i], people[j]) > 0)
                    {
                        // Swap people[i] and people[j] if they are in the wrong order
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;

                        // people[0] Alice
                        // people[1] Bob
                        // people[2] Charlie

                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Denis", Age= 36},
            new Person { Name = "Charlie", Age = 35 }
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            sorter.Sort(people, CompareByName);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.ReadKey();
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }

    }
}
