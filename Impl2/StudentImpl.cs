using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaceImpl;
using OtherProject;

namespace Impl2
{
    public class StudentImpl : IStudent
    {
        public int GetStudentId()
        {
            return 100005;
        }

        public List<Student> GetStudentList()
        {
            return new List<Student>
                {
                new Student { StudentId =200001, StudentNane = "邓缙柯" },
                new Student { StudentId = 200002, StudentNane = "邓云乔" }
            };
        }
    }
}
