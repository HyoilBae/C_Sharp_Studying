using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class MyObject : IComparable
    {
        public int Id { get; set; }

        public int CompareTo(object obj)
        {
            MyObject inObj = obj as MyObject;
            return this.Id.CompareTo(inObj.Id);
        }
    }
}
