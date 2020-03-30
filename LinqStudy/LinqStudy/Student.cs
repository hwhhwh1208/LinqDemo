using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudy
{
    public class Student
    {
        public string StudentID { get; set; }

        public string StudentName { get; set; }

        public int Age { get; set; }
    }

    public class StudentCompare : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x == null || y == null)
            {
                return false;
            }
            else
            {
                return x.StudentName == y.StudentName;
            }
        }

        public int GetHashCode(Student obj)
        {
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.StudentName.GetHashCode();
            }
        }
    }
}
