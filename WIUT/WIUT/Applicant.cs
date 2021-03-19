using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT
{
    class Applicant
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public string MaritalStatus { get; set; }
        public string PassportNo { get; set; }
        public Course Course { get; set; }

        public Applicant(string name, string surname, string address, DateTime dob, string maritalstatus, string passportNo, Course course)
        {
            Name = name;
            Surname = surname;
            Address = address;
            DoB = dob;
            MaritalStatus = maritalstatus;
            PassportNo = passportNo;
            Course = course;
        }

        public Applicant (string name, string surname, Course course)
        {
            Name = name;
            Surname = surname;
            Course = course;
        }

    }
}
