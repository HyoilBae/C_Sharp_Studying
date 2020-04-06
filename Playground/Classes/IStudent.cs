using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    interface IStudent
    {
        int GPA { get; set; }

        List<string> Courses { get; set; }

        void PrintGrades();
    }
}
