using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
     static class ListPrinter
    {
        static public void PrintList(List<Student> students)
        {
            int counter = 0;
            foreach (Student student in students)
            {
                counter++;
                Console.WriteLine(counter + "." + " " +student.ToString());
            }
        }
    }
}
