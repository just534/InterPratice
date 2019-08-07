using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaceImpl;
using OtherProject;

namespace Impl1
{
    public class StudentImpl : IStudent
    {
        public int GetStudentId()
        {
            return 100001;
        }

        public List<Student> GetStudentList()
        {
            return new List < Student >
                {
                new Student { StudentId = 100001, StudentNane = "DMZ" },
                new Student { StudentId = 100002, StudentNane = "ZZN" }
                };
        }
    }
}
