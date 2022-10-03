using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
    public class Internship : IInternship
    {
        public string Name { get; set; }
        
        public Leader Leader { get; set; }
        public List<Student> Students { get; set; }
      
        public Internship(string name, Leader leader)
        {
            Name = name;
            Leader = leader;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
