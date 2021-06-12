using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace ConsoleApp
{
    public class Faculty
    {
        public List<Human> students{ get; set; }
        public List<string> subjects { get; set; }

        public Faculty()
        {
            this.students = new List<Human>();
            this.subjects = new List<string>();
        }

        public void initSubjects()
        {
            subjects.Add("Computer Networks");
            subjects.Add("Introduction Computer Science");
            subjects.Add("Computer Graphics");
            subjects.Add("Object Oriented Programming");
        }

        public void addNewStudent(Human newStudent)
        {
            if (newStudent != null)
            {
                this.students.Add(newStudent);
            }
        }
    }
}
