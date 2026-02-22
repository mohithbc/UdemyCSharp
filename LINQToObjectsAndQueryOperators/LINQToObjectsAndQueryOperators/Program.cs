namespace LINQToObjectsAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromUniversityB();
            um.StudentAndUniversityNameCollection();

            // different ways of sorting
            int[] numbers = { 5, 2, 8, 1, 3 };
            IEnumerable<int> sortedNum = from num in numbers orderby num select num;
            IEnumerable<int> reversedNum = sortedNum.Reverse();

            foreach (int num in sortedNum)
            {
                Console.WriteLine(num);
            }
            // or we can do it in one line
            IEnumerable<int> reversedSortedInts = from num in numbers orderby num descending select num;
            foreach (int num in reversedSortedInts)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Please enter the university Id to fetch the data");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong value");
            }
            
            Console.ReadKey();
        }
    }
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;
        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Adding some universities
            universities.Add(new University { Id = 1, Name = "University A" });
            universities.Add(new University { Id = 2, Name = "University B" });
            // Adding some students
            students.Add(new Student { Id = 1, Name = "Alice", Gender = "male", Age = 20, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Bob", Gender = "Trans-gender", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Charlie", Gender = "female", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Diana", Gender = "female", Age = 23, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Rama", Gender = "male", Age = 24, UniversityId = 1 });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - students");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - students");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by age:");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromUniversityB()
        {
            IEnumerable<Student> ubStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Name == "University B"
                                              select student;
            Console.WriteLine("Students from University B");
            foreach (Student student in ubStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == Id
                                              select student;
            Console.WriteLine("Students from that uni {0}", Id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                            join university in universities on student.UniversityId equals university.Id
                            orderby student.Name
                            select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New collection:");
            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from university {1}", col.StudentName, col.UniversityName);
            }
        }
    }
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("University {0} with id {1}",Name, Id);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        //Foreign key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with id {1} , geneder {2}" +
                " and age {3} from university with Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
