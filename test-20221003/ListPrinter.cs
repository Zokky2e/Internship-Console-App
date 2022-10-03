using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
     static class ListPrinter
    {
        static public int PrintList(List<Student> students, string message)
        {
            int counter = 0;
            foreach (Student student in students)
            {
                counter++;
                Console.WriteLine(counter + "." + " " +student.ToString());
            }
            Console.Write(message);
            int index = int.Parse(Console.ReadLine());
            return index;
        }
    }
}
