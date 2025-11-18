class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Sandhya";
        s1.age = 20;
        s1.department = "BIT";

        Student s2 = new Student();
        s2.name = "Subu";
        s2.age = 21;
        s2.department = "Engineering";

        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Department: " + s1.department);

        Console.WriteLine();
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Department: " + s2.department);

        Console.WriteLine();
        Console.WriteLine("College Name (Static Field): " + Student.collegeName);
    }
}