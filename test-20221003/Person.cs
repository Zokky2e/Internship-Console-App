using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
    public abstract class Person
    {
        string Name { get; set; }
        string Surname { get; set; }
        string OIB { get; set; }

        public override string ToString()
        {
            return (Name + " " + Surname);
        }
    }
}
