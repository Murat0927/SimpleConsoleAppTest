using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public class Human
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public Human(string Name,string Surname,int Age)
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

        
        static void Main(string[] args)
        {
            List<Human> people = Human.createPeople(10);
            foreach(Human human in people)
            {
                Console.WriteLine(human.ToString());
            }
            Console.ReadKey();
        }
    }
}
