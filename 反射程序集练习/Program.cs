using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaceImpl;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent istuobj = ObjectFactory.ObjFac.CreateObject<IStudent>("StudentImpl");
            int result = istuobj.GetStudentId();
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
