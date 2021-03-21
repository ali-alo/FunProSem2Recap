using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

        // sorting 
        public List<Applicant> Sort(ByAttribute attribute)
        {
            var applicants = GetAllApplicants();
            switch (attribute)
            {
                case ByAttribute.Name:
                    applicants.Sort(new ByNameComparer());
                    return applicants;
                case ByAttribute.Surname:
                    applicants.Sort(new BySurnameComparer());
                    return applicants;
                case ByAttribute.DoB:
                    applicants.Sort(new ByDobComparer());
                    return applicants;
                case ByAttribute.Course:
                    applicants.Sort(new ByCourseComparer());
                    return applicants;
            }

            //if we are here - something went wrong
            return null;
        }

        // Language Intergrated Query (LINQ) version

        public List<Applicant> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    // will get all the applicants all order them by pseudo variable e.Name
                    return GetAllApplicants().OrderBy(e => e.Name).ToList();
                case ByAttribute.Surname:
                    return GetAllApplicants().OrderBy(e => e.Surname).ToList();
                case ByAttribute.DoB:
                    return GetAllApplicants().OrderBy(e => e.Name).ToList();
                case ByAttribute.Course:
                    return GetAllApplicants().OrderBy(e => e.Name).ToList();
            }

            //if we are here - something went wrong
            return null;
        }

        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().Where(a => a.Name.ToLower().Contains(value.ToLower())).ToList();
                case ByAttribute.Surname:
                    return GetAllApplicants().Where(a => a.Surname.ToLower().Contains(value.ToLower())).ToList();
            }

            //if we are here - something went wrong
            return null;
        }


        private class ByNameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }

        private class BySurnameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Surname, y.Surname);
            }
        }

        private class ByDobComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return DateTime.Compare(x.DoB, y.DoB);
            }
        }

        private class ByCourseComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Course.Name, y.Course.Name);
            }
        }
    }
}
