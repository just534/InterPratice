using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaceImpl;

namespace Impl1
{
    public class TeacherImpl : ITeacher
    {
        public int GetClassCount()
        {
            return 1000;
        }

        public void PrintCourse()
        {
            Console.WriteLine("英语课Teacher"); ;
        }
    }
}
