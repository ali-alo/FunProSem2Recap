using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT.DAL
{
    public class Course
    {
        public int Id { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty");
                _name = value;
            }
        }

        public Course()
        {

        }

        public Course(string name)
        {
            Name = name;
        }
    }
}
