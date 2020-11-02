using System;
namespace  SchoolPortal
{
    public class Student{
        protected string registrationNumber;
        protected string name;
        protected string department;

        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
    }
    public class ScienceStudent : Student
    {
        int num1;
        int num2;
        int num3;
        public double CalculateAverage()
        {

            int[] scores = {num1, num2, num3};
            double average;
            int sum = 0;
            foreach (var item in scores)
            {
                sum = item + sum;
            }
            average = sum / scores.Length;
            return average;
        }
        public void DisplayDetails()
        {
            Console.Write("Enter score for Computer Network: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter score for Data Structure: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter score for C-Sharp: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Registration Number: {RegistrationNumber}\nName: {Name}\nScore for Computer Network: {num1}\nScore for Data Structure: {num2}\nScore for C-Sharp {num3}");
            Console.WriteLine($"\nAverage Score: {CalculateAverage()}");
        }   
    }
    public class CommerceStudent : Student
    {
        int num1 ;
        int num2 ;
        int num3 ;
        public double CalculateAverage()
        {
            int[] scores = {num1, num2, num3};
            double average;
            int sum = 0;
            foreach (var item in scores)
            {
                sum = item + sum;
            }
            average = sum / scores.Length;
            return average;
        }
        public void DisplayDetails()
        {
            Console.Write("Enter score for Electronic Circuits: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter score for Circuit Analysis: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter score for Analog Communication: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Registration Number: {RegistrationNumber}\nName: {Name}\nScore for ElectronicCircuit: {num1}\nScore for CircuitAnalysis: {num2}\nScore for Analog Communication: {num3}");
            Console.WriteLine($"\nAverage Score: {CalculateAverage()}");
        }
            
    }
}