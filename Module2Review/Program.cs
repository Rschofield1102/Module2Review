namespace Module2Review;


internal class Program
{
    static void Main(string[] args)
    {
        // List<Student> students = new List<Student>() { student1, stud };

        Student student1 = new Student() { ID = 1, Name = "Anna Marie", };
        Student student2 = new Student() { ID = 2, Name = "Annie May", };
        Student student3 = new Student() { ID = 3, Name = "Josh Rimes", };
        Student student4 = new Student() { ID = 4, Name = "Alexandra May", };

        List<Student> students = new List<Student>() { student1, student2, student3, student4 };

        student1.AddGrade(99.3);
        student1.AddGrade(90.1, 78.9, 95.4);

        student2.AddGrade(85.5);
        student2.AddGrade(90.0, 77.9, 77.4);

        student3.AddGrade(70.3);
        student3.AddGrade(91.2, 38.9, 85.4);

        student4.AddGrade(94.9);
        student4.AddGrade(70.0, 68.9, 81.4);

        foreach (var item in students)
        {
            Console.WriteLine($"Student Name: {item.Name}");
            Console.WriteLine($"Student ID: {item.ID}");
           
            foreach (var grade in item.Grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine($" Average Grade: {item.CalculateAverageGrade()}");
            Console.WriteLine();
        }
    }
}