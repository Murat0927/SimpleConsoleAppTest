using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Human()
        {

        }
        public Human(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Surname, Age);
        }
        public static List<Human> createPeople(int num)
        {
            List<Human> people = new List<Human>();
            for (int i = 0; i < num; i++)
            {
                people.Add(new Human("testname", "testsurname", i + 10));
            }
            return people;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Faculty testFaculty = new Faculty();

            testFaculty.initSubjects();
            for(int i = 0; i < 100; i++)
            {
                testFaculty.addNewStudent(new Human()
                {
                    Name = "testname" + i,
                    Surname = "testSurname" + i,
                    Age = i + 10
                }); 
            }

            foreach(Human i in testFaculty.students)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("----------------------");
            foreach(var subject in testFaculty.subjects)
            {
                Console.WriteLine(subject);
            }
            Console.ReadKey();
        }
    }
}
