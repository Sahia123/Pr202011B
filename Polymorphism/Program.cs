using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        // Method Overloading
        class Student
        {
            public virtual void payfees()
            {
                Console.WriteLine("Students pay fees");
            }
            public void payfees(string a)
            {
                Console.WriteLine("Student " +a+ " pay fees");
            }
            public void payfees(string c , float b)
            {
                Console.WriteLine("Student " + c +  " pay fees Rs:" + b);
Console.WriteLine("I have added some lines");
            }

        }
        // overriding
        class Exam : Student
        {
            public override void payfees()
            {
                Console.WriteLine("Only those who pay fees will give exam");
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.payfees();
            s.payfees("Sahia");
            s.payfees("Saeed" , 6500.5F);
            Exam E = new Exam();
            E.payfees();
            
        }
    }
}
//overloading depends upon type of parameters and no. of parameters