namespace DictionariesOne
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key: Employee ID (string), Value: Employee object
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            employees["E001"] = new Employee("Alice", 30, 60000);
            employees["E002"] = new Employee("Bob", 25, 50000);
            employees["E003"] = new Employee("Charlie", 28, 55000);
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value.Name}, Age: {emp.Value.Age}, Salary: {emp.Value.Salary}");
            }
        }
    }
}
