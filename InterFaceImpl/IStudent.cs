using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtherProject;

namespace InterFaceImpl
{
    public interface IStudent
    {
        int GetStudentId();
        List<Student> GetStudentList();
    }
}
