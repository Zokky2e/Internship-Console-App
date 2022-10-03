using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_20221003
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string title, string description, string dueDate)
        {
            Title = title;
            Description = description;
            DueDate = DateTime.Parse(dueDate);
        }
    }
}
