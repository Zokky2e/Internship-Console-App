using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
    public class Leader : Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string OIB { get; set; }
        public Leader(string name, string surname, string oib)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
        }
        public void GiveTask(Student person, Task task)
        {
            person.Tasks.Add(task);
        }
        public override string ToString()
        {
            return "Lead Person " + Name + " " + Surname;
        }
    }
}
