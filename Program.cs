using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Davin", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Ocha", 11, 18098, "Seterah");
            teacher.GetNameAndAge();

            Student student = new Student("Julio", 21, 14356, "Jarwo@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}