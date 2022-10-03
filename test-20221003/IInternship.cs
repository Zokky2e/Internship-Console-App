using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
    public interface IInternship
    {
        string Name { get; set; }

        Leader Leader { get; set; }
        List<Student> Students { get; set; }
        void AddStudent(Student student);
        void RemoveStudent(Student student);
    }
}
