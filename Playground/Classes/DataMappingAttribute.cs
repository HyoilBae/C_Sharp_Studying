using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DataMappingAttribute : System.Attribute
    {
        public string ColumnName { get; set; }
        public string PropertyName { get; set; }

        public DataMappingAttribute(string col, string prop)
        {
            ColumnName = col;
            PropertyName = prop;
        }
    }
}
