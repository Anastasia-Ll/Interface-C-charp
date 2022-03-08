using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{


    class Human
    {
        public string name;
    }
    class Animal
    {
        public string name;
    }
    class Enrolle : Human, IAllowed { }
    class Student : Human, IAllowed { }
    class Teacher : Human, IAllowed { }
    class Employer : Human { }
    class Dog : Animal, IAllowed { }
    class Squirrel : Animal { }
    public interface IAllowed { }
    public class OXPAXA
    {
        public List<IAllowed> allowed = new List<IAllowed>();
        public void SkipEssence(Object o)
        {
            if (o is IAllowed)
            {
                allowed.Add((IAllowed)o);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OXPAXA sec = new OXPAXA();
            Enrolle enrolle = new Enrolle();
            enrolle.name = "Harry";
            Student student = new Student();
            student.name = "Gohn";
            Teacher teacher = new Teacher();
            teacher.name = "Mr.Green";
            Employer employer = new Employer();
            employer.name = "Robert";
            Dog dog = new Dog();
            dog.name = "Bart";
            Squirrel squirrel = new Squirrel();
            squirrel.name = "Squirrel";

            List<Object> oxp = new List<Object>();
            oxp.Add(enrolle); oxp.Add(student); oxp.Add(teacher); oxp.Add(employer); oxp.Add(squirrel); oxp.Add(dog);

            foreach (var t in oxp)
            {
                sec.SkipEssence(t);
            }

            foreach (var x in sec.allowed)
            Console.WriteLine(x);
            Console.ReadKey();
        }
    } 
}