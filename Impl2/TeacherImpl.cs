using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaceImpl;

namespace Impl2
{
    class TeacherImpl : ITeacher
    {
        public int GetClassCount()
        {
           return 200000;
        }

        public void PrintCourse()
        {
            Console.WriteLine("语文课Teacher") ;
        }
    }
}
