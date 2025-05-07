using System.Collections;

namespace ClassesAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("pippo", "de pippis", "male", 1980);
            Student student2 = new Student("paperoga", "de paperoni", 1985);
            Student student3 = new("paperino", "de paperis", 1985);
            var student4 = new Student("paperina", "de paperis", 1985);
            Teacher teacher1 = new Teacher{
                Name = "mario",
                Surname = "rossi",
                Subject = "mathematics"
            };
            Teacher teacher2 = new Teacher
            {
                Name = "giovanni",
            };

            Student[] students = new Student[3];

            students[0] = student1;
            students.Append(student2);
            students[2] = student3;
            students.Append(student4);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(student1);
            arrayList.Add(student2);
            arrayList.Add(student3);
            arrayList.Add(student4);
            arrayList.Add(teacher1);
            arrayList.Add(teacher2);
            arrayList.Add("hello");
            arrayList.Add(1);
            arrayList.Add(1.5);
            arrayList.Add(true);
            arrayList.Add(new DateTime(2023, 10, 1));

            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            //studentList.Add(teacher1); // This will not compile because teacher1 is not a Student
            //studentList.Add("hello"); // This will not compile because "hello" is not a Student

            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
            studentDictionary.Add("student1", student1);
            //studentDictionary.Add(3, student2); // This will not compile because 3 is not a string
            //studentDictionary.Add("teacher1", teacher1); // This will not compile because teacher1 is not a Student

            SuperList<Student> superList = new SuperList<Student>();
            superList.Push(student1);
            superList.Push(student2);
            Student student = superList.Get(0);
            Student poppedStudent = superList.Pop();

            Console.WriteLine($"Popped student: {poppedStudent.Name} {poppedStudent.Surname}");
            Console.WriteLine($"Student: {student.Name} {student.Surname}");
        }
    }
}
