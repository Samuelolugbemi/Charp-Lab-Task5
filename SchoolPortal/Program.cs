using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department(Enter COM for Commercial Department and SCI for science department): ");
            string dept =Console.ReadLine();
            if(dept == "SCI"){
                ScienceStudent student1 = new ScienceStudent();
                student1.Department = dept;
                Console.Write("Enter Name: ");
                student1.Name = Console.ReadLine();
                Console.Write("Enter Registration Number: ");
                student1.RegistrationNumber = Console.ReadLine();
                student1.DisplayDetails();
            } else if(dept == "COM"){
                CommerceStudent student1 = new CommerceStudent();
                student1.Department = dept;
                Console.Write("Enter Name: ");
                student1.Name = Console.ReadLine();
                Console.Write("Enter Registration Number: ");
                student1.RegistrationNumber = Console.ReadLine();
                student1.DisplayDetails();
            }
        }
    }
}
