using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Assignment01
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter the value for Student Id");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value for Student Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Please enter the value for Student Gender");
            this.Gender = Console.ReadLine();
            Console.WriteLine("Please enter the value for Student Age");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value for Student City");
            this.City = Console.ReadLine();
     
        }

        public void PutData()
        {
            Console.WriteLine("Id = " +this.Id);
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Gender = " + this.Gender);
            Console.WriteLine("Age = " + this.Age);
            Console.WriteLine("City = " + this.City);
        }
    }
}
