using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    [DataContract]
    public class Employee : Person, IStudent
    {
        [DataMember]
        public string DepartmentName { get; set; }

        [DataMember]
        public int GPA { get; set; }

        [DataMember]
        public List<string> Courses { get; set; }

        public Employee()
        {

        }

        public Employee(string firstname, string lastname, string department) : base(firstname, lastname)
        {
            if (String.IsNullOrEmpty(department))
            {
                throw new ArgumentOutOfRangeException(department, "Department cannot be null or empty");
            }

            DepartmentName = department;
        }

        public void PrintGrades()
        {
            throw new NotImplementedException();
        }
    }
}
