using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Course()
        {

        }

        public Course(string name) 
        {
            Name = name;
        }

    }
}
