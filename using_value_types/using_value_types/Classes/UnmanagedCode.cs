using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace using_value_types.Classes
{
    public partial class UnmanagedCode
    {
        public UnmanagedCode()
        {

        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint GetShortPathName(string lpszLongPath, char[] lpszShortPath, int cchBuffer);
    }
}
