
using Object_Assignment01;
using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Student1 object information");
        Student student1 = new Student();
        student1.GetData();
        student1.PutData();

        Console.WriteLine("Student2 object information");
        Student student2 = new Student();
        student2.GetData();
        student2.PutData();

        Console.WriteLine("Student3 object information");
        Student student3 = new Student();
        student3.GetData();
        student3.PutData();

    }
}

