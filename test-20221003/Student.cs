using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
    public class Student : Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string OIB { get; set; }
        public List<Task> Tasks { get; set; }
        public Student(string name, string surname, string oib )
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            Tasks = new List<Task>();
        }
        public void DoTask()
        {
            if (Tasks.Count == 0) Console.WriteLine("Student has no tasks!");
            else
            {
                Task task = Tasks.First();
                Console.WriteLine("Student did task:" + task.Title);
                Tasks.Remove(task);
            }


        }
        public void DoAllTasks()
        {
            Tasks.Clear();
            Console.WriteLine("Student done all the tasks!");
        }
        public override string ToString()
        {
            return  Name + " " + Surname;
        }
    }
}
